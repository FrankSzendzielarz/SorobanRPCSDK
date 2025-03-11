using Stellar_CrossPlatform.Services;

namespace Stellar_CrossPlatform
{
    public partial class MainPage : ContentPage
    {
        StellarService _stellarService;
      

        public MainPage()
        {
            InitializeComponent();
            _stellarService = new StellarService();
            
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await UpdateAccountInfo();
        }

        private async Task UpdateAccountInfo()
        {
            try
            {
                var account = await _stellarService.GetAccount();
                Console.WriteLine(account.AccountId);
                var balance = await _stellarService.GetBalance(account);


                AccountLabel.Text = $"Account: {account.AccountId}";
                BalanceLabel.Text = $"Balance: {balance.ToString()}";
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to load account: {ex.Message}", "OK");
            }
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var muxedAccount = await _stellarService.GetAccount();
            await UpdateAccountInfo();
            SemanticScreenReader.Announce(AccountLabel.Text);
            SemanticScreenReader.Announce(BalanceLabel.Text);
        }

        private async void AccountBtn_Clicked(object sender, EventArgs e)
        {
            await _stellarService.ResetAccount();
            await UpdateAccountInfo();
        }
    }

}
