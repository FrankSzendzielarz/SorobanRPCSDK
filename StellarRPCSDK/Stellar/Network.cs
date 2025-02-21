
using ProtoBuf;
using Stellar.Utilities;
using System;
using System.ServiceModel;
using System.Text;

namespace Stellar
{
    [ServiceContract]
    public class Network_ProtoWrapper
    {
        [ProtoContract]
        public class ByteArrayWrapper
        {
            [ProtoMember(1)]
            public byte[] Value { get; set; }
        }

        [ProtoContract]
        public class StringResult
        {
            [ProtoMember(1)]
            public string Value { get; set; }
        }

        [ProtoContract]
        public class BoolResult
        {
            [ProtoMember(1)]
            public bool Value { get; set; }
        }

        [ProtoContract]
        public class UseParam
        {
            [ProtoMember(1)]
            public Network Network { get; set; }
        }

        [ProtoContract]
        public class GetCurrentResult
        {
            [ProtoMember(1)]
            public Network Network { get; set; }
        }

        [ProtoContract]
        public class IsPublicNetworkParam
        {
            [ProtoMember(1)]
            public Network Network { get; set; }
        }

        // Instance methods
        [OperationContract]
        public StringResult GetNetworkPassphrase(Network network)
        {
            return new StringResult { Value = network.NetworkPassphrase };
        }

        [OperationContract]
        public ByteArrayWrapper GetNetworkId(Network network)
        {
            return new ByteArrayWrapper { Value = network.NetworkId };
        }

        // Static methods
        [OperationContract]
        public GetCurrentResult GetCurrent()
        {
            return new GetCurrentResult { Network = Network.Current };
        }

        [OperationContract]
        public void Use(UseParam param)
        {
            Network.Use(param.Network);
        }

        [OperationContract]
        public Network Public()
        {
            return Network.Public();
        }

        [OperationContract]
        public Network Test()
        {
            return Network.Test();
        }

        [OperationContract]
        public void UsePublicNetwork()
        {
            Network.UsePublicNetwork();
        }

        [OperationContract]
        public void UseTestNetwork()
        {
            Network.UseTestNetwork();
        }

        [OperationContract]
        public BoolResult IsPublicNetwork(IsPublicNetworkParam param)
        {
            return new BoolResult { Value = Network.IsPublicNetwork(param.Network) };
        }
    }

    /// <summary>
    /// Represents a network configuration with associated passphrase and network ID.
    /// </summary>
    public sealed class Network : IEquatable<Network>
    {
        /// <summary>
        /// The passphrase for the public global stellar network.
        /// </summary>
        public const string PublicPassphrase = "Public Global Stellar Network ; September 2015";

        /// <summary>
        /// The passphrase for the test SDF network.
        /// </summary>
        public const string TestnetPassphrase = "Test SDF Network ; September 2015";

        private static volatile Network _current;
        private static readonly object _lock = new object();
        private readonly Lazy<byte[]> _networkId;

        /// <summary>
        /// Initializes a new instance of the Network class with the specified network passphrase.
        /// </summary>
        /// <param name="networkPassphrase">The passphrase that identifies the network.</param>
        /// <exception cref="ArgumentNullException">Thrown when networkPassphrase is null.</exception>
        /// <exception cref="ArgumentException">Thrown when networkPassphrase is empty or consists only of whitespace.</exception>
        public Network(string networkPassphrase)
        {
            if (networkPassphrase == null)
            {
                throw new ArgumentNullException(nameof(networkPassphrase));
            }

            if (string.IsNullOrWhiteSpace(networkPassphrase))
            {
                throw new ArgumentException("Network passphrase cannot be empty or whitespace.", nameof(networkPassphrase));
            }

            NetworkPassphrase = networkPassphrase;
            _networkId = new Lazy<byte[]>(() => Util.Hash(Encoding.UTF8.GetBytes(NetworkPassphrase)));
        }

        /// <summary>
        /// Gets the network passphrase.
        /// </summary>
        public string NetworkPassphrase { get; }

        /// <summary>
        /// Gets the network ID derived from the network passphrase.
        /// </summary>
        public byte[] NetworkId => _networkId.Value;

        /// <summary>
        /// Gets the currently active network configuration.
        /// </summary>
        public static Network Current
        {
            get => _current;
            private set => _current = value;
        }

        /// <summary>
        /// Creates a new instance representing the public network.
        /// </summary>
        /// <returns>A Network instance configured for the public network.</returns>
        public static Network Public()
        {
            return new Network(PublicPassphrase);
        }

        /// <summary>
        /// Creates a new instance representing the test network.
        /// </summary>
        /// <returns>A Network instance configured for the test network.</returns>
        public static Network Test()
        {
            return new Network(TestnetPassphrase);
        }

        /// <summary>
        /// Sets the current network configuration.
        /// </summary>
        /// <param name="network">The network configuration to use, or null to clear the current configuration.</param>
        public static void Use(Network network)
        {
            lock (_lock)
            {
                Current = network;
            }
        }

        /// <summary>
        /// Determines whether the specified network is the public network.
        /// </summary>
        /// <param name="network">The network to check.</param>
        /// <returns>true if the network is the public network; otherwise, false.</returns>
        /// <exception cref="ArgumentNullException">Thrown when network is null.</exception>
        public static bool IsPublicNetwork(Network network)
        {
            if (network == null)
            {
                throw new ArgumentNullException(nameof(network));
            }

            return string.Equals(network.NetworkPassphrase, PublicPassphrase, StringComparison.Ordinal);
        }

        /// <summary>
        /// Sets the current network to the public network.
        /// </summary>
        public static void UsePublicNetwork()
        {
            Use(Public());
        }

        /// <summary>
        /// Sets the current network to the test network.
        /// </summary>
        public static void UseTestNetwork()
        {
            Use(Test());
        }

        /// <summary>
        /// Determines whether two Network instances are equal.
        /// </summary>
        /// <param name="other">The Network instance to compare with the current instance.</param>
        /// <returns>true if the specified Network is equal to the current Network; otherwise, false.</returns>
        public bool Equals(Network other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(NetworkPassphrase, other.NetworkPassphrase, StringComparison.Ordinal);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current Network.
        /// </summary>
        /// <param name="obj">The object to compare with the current Network.</param>
        /// <returns>true if the specified object is equal to the current Network; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as Network);
        }

        /// <summary>
        /// Returns a hash code for the current Network instance.
        /// </summary>
        /// <returns>A hash code for the current Network instance.</returns>
        public override int GetHashCode()
        {
            return NetworkPassphrase.GetHashCode();
        }

        /// <summary>
        /// Returns a string representation of the current Network instance.
        /// </summary>
        /// <returns>A string representation of the current Network instance.</returns>
        public override string ToString()
        {
            return $"Network(passphrase='{NetworkPassphrase}')";
        }
    }
}
