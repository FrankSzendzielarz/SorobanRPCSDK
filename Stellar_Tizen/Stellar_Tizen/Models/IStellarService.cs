using Stellar;
using System.Threading.Tasks;

namespace Stellar_Tizen.Models
{
    /// <summary>
    /// Responsible for interacting with ApiCharge and its Accounts
    /// </summary>
    public interface IStellarService
    {
        // Get account for funding
        Task<MuxedAccount.KeyTypeEd25519> GetAccount();

        Task ResetAccount();

        // Get current balance 
        Task<long> GetBalance(MuxedAccount.KeyTypeEd25519 account);



    }
}
