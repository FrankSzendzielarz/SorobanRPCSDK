

using Stellar;
using Stellar_Tizen.Models;
using Stellar_Tizen.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using Xamarin.Forms;
using ZXing;


namespace Stellar_Tizen.ViewModels
{
    /// <summary>
    /// The application's main view model class (abstraction of the view).
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        #region fields

        private const int UPDATE_INTERVAL = 1000; //ms



        public ICommand ResetAccountCommand { get; private set; }

        /// <summary>
        /// Current app model.
        /// </summary>
        private AppModel _appModel;

        #endregion

        #region properties

        MuxedAccount.KeyTypeEd25519 _currentAccount = null;
        /// <summary>
        /// Current account.
        /// </summary>
        public MuxedAccount.KeyTypeEd25519 CurrentAccount { get { return _currentAccount; } private set { _currentAccount = value; CurrentAddress = value.Address; } }

        string _currentAddress;
        public string CurrentAddress
        {
            get => _currentAddress;
            private set
            {
                _currentAddress = value;
                OnPropertyChanged(nameof(CurrentAddress));
                OnPropertyChanged(nameof(CurrentQRAddress));
            }

        }

        public ImageSource CurrentQRAddress
        {
            get
            {
                int width = 300;
                int height = 300;
                var writer = new ZXing.QrCode.QRCodeWriter();
                var matrix = writer.encode(CurrentAddress, BarcodeFormat.QR_CODE, width, height);

                return QRToImageSourceConverter.ConvertToImageSource(matrix, width, height);
            }
        }

        long _currentBalance;
        public long CurrentBalance
        {
            get => _currentBalance;
            private set
            {
                _currentBalance = value;
                OnPropertyChanged(nameof(CurrentBalance));
            }

        }




        #endregion

        #region methods

        /// <summary>
        /// Initializes class instance.
        /// </summary>
        public MainViewModel()
        {
          
         

            _appModel = new AppModel();
            CurrentAccount = DependencyService.Get<IStellarService>().GetAccount().Result;
           

            Device.StartTimer(TimeSpan.FromMilliseconds(UPDATE_INTERVAL), OnUpdateBalanceTimer);



            InitCommands();
        }

        /// <summary>
        /// Initializes commands.
        /// </summary>
        private void InitCommands()
        {
          
            ResetAccountCommand = new Command(ResetAccount);

        }

  

        private void ResetAccount()
        {
            DependencyService.Get<IStellarService>().ResetAccount();
     

            CurrentAccount = DependencyService.Get<IStellarService>().GetAccount().Result;
            
        }


       

        /// <summary>
        /// Updates the account periodically
        /// </summary>
        /// <returns>Flag indicating if timer should keep recurring.</returns>
        private bool OnUpdateBalanceTimer()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                try
                {
                    var balance = await DependencyService.Get<IStellarService>().GetBalance(CurrentAccount);
                    CurrentBalance = balance;
                }
                catch (Exception ex)
                {
                    // Log the exception
                }
            });

            return true;
        }

    


        #endregion
    }



}


public class QRToImageSourceConverter
{
    public static ImageSource ConvertToImageSource(ZXing.Common.BitMatrix matrix, int width, int height)
    {
        byte[] bitmapBytes = CreateBitmapBytes(matrix, width, height);

        // Create a MemoryStream from the bitmap bytes
        var stream = new MemoryStream(bitmapBytes);

        // Create and return an ImageSource from the stream
        return ImageSource.FromStream(() => stream);
    }

    private static byte[] CreateBitmapBytes(ZXing.Common.BitMatrix matrix, int width, int height)
    {
        // Define bitmap file header (14 bytes)
        byte[] fileHeader = new byte[14];
        int fileSize = 54 + (width * height * 3);
        fileHeader[0] = (byte)'B';
        fileHeader[1] = (byte)'M';
        BitConverter.GetBytes(fileSize).CopyTo(fileHeader, 2);
        BitConverter.GetBytes(54).CopyTo(fileHeader, 10);

        // Define bitmap info header (40 bytes)
        byte[] infoHeader = new byte[40];
        BitConverter.GetBytes(40).CopyTo(infoHeader, 0);
        BitConverter.GetBytes(width).CopyTo(infoHeader, 4);
        BitConverter.GetBytes(height).CopyTo(infoHeader, 8);
        BitConverter.GetBytes((short)1).CopyTo(infoHeader, 12);
        BitConverter.GetBytes((short)24).CopyTo(infoHeader, 14);

        // Create bitmap data
        byte[] imageData = new byte[width * height * 3];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                int index = ((height - 1 - y) * width + x) * 3;
                byte color = (byte)(matrix[x, y] ? 0 : 255);
                imageData[index] = color;     // Blue
                imageData[index + 1] = color; // Green
                imageData[index + 2] = color; // Red
            }
        }

        // Combine all parts
        using (MemoryStream ms = new MemoryStream())
        {
            ms.Write(fileHeader, 0, fileHeader.Length);
            ms.Write(infoHeader, 0, infoHeader.Length);
            ms.Write(imageData, 0, imageData.Length);
            return ms.ToArray();
        }
    }
}