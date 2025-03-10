

using System;
using Xamarin.Forms;

namespace Stellar_Tizen.Models
{
    /// <summary>
    /// Responsible for managing the logic of the player.
    /// </summary>
    public class AppModel
    {
        #region fields




        /// <summary>
        /// Instance of apicharge service
        /// </summary>
        private IStellarService _stellarService;


        public event EventHandler CurrentAddressChanged;

        public event EventHandler CurrentQRAddressChanged;

        #endregion


        #region methods

        /// <summary>
        /// Initializes class instance.
        /// </summary>
        public AppModel()
        {


            _stellarService = DependencyService.Get<IStellarService>();









        }




        #endregion
    }
}
