using ProtoBuf.Grpc.Configuration;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Stellar.gRPC
{
    
    public interface IStellar
    {
       
        Task<PublicKey> GetKey();
    }

    [ServiceContract(Name ="SearchService")]
    public class Stellar 
    {
        [Operation()]
        public Task<PublicKey> GetKey()
        {
            throw new System.NotImplementedException();
        }
    }

}
