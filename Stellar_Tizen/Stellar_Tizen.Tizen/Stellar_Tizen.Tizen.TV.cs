
using System;
using System.IO;
using System.Net;
using System.Reflection;
using Xamarin.Forms;

namespace Stellar_Tizen.Tizen.TV
{
    /// <summary>
    /// Stellar Tizen demo integration
    /// </summary>
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        #region methods

        /// <summary>
        /// Handles creation phase of the forms application.
        /// Loads Xamarin application.
        /// </summary>
        protected override void OnCreate()
        {

            base.OnCreate();
#if DEBUG
            DisableCertificateValidation();
#endif

            LoadApplication(new Stellar_Tizen());
        }

        private void DisableCertificateValidation()
        {
            // USE if working with local SSL RPC
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;

           
        }


        /// <summary>
        /// Entry method of the program/application.
        /// </summary>
        /// <param name="args">Launch arguments.</param>
        static void Main(string[] args)
        {
            var app = new Program();

            // IMPORTANT!!!
            AppDomain.CurrentDomain.AssemblyResolve += (object s, ResolveEventArgs eventArgs) =>
            {
                var appDir = Path.GetDirectoryName(typeof(Program).Assembly.Location);
                var fullName = eventArgs.Name;
                var reqName = eventArgs.RequestingAssembly.FullName;
                var assemblyName = eventArgs.Name.Split(',')[0];
                var assemblyPath = Path.Combine(appDir, assemblyName + ".dll");
                bool exists = File.Exists(assemblyPath);
                if (exists) return Assembly.LoadFile(assemblyPath); else return null;
            };
            Forms.Init(app);
            app.Run(args);
        }

        #endregion
    }
}
