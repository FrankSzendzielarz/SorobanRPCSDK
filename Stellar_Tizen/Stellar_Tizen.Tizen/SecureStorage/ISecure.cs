using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stellar_Tizen.Tizen.TV.SecureStorage
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface contains methods that are responsible for connecting with Managers.
    /// <para>  DataManager
    /// </para>
    /// </summary>
    /// <typeparam name="T">Item type (Key, Certificate, Data {byte[]}).</typeparam>
    public interface ISecure<T>
    {
        ////TODO: (For developers) change deafult parameter values in interface implementation.
        ////Specially in Keys Class.

        /// <summary>
        /// Checks if item exists in Manager.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        /// <param name="password">The password used to decrypt an item. If password is provided when adding an item to Manager, the same password should be passed here.</param>
        /// <returns>true if exists, false if not or if occurred any errors.</returns>
        bool Exists(string alias, string password = null);

        /// <summary>
        /// Gets item from Manager.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        /// <param name="password">The password used to decrypt an item. If password is provided when adding an item to Manager, the same password should be passed here.</param>
        /// <returns>Item if exists, else null.</returns>
        T Get(string alias, string password);

        /// <summary>
        /// Gets all available aliases from Manager.
        /// </summary>
        /// <returns>Aliases List or null if aliases do not exist.</returns>
        IEnumerable<string> GetAliases();

        /// <summary>
        /// Gets short version of all available aliases from Manager.
        /// </summary>
        /// <returns>Aliases List if exists, else null.</returns>
        IEnumerable<string> GetAliasesShort();

        /// <summary>
        /// Gets first chars of item content no more than charCount.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        /// <param name="password">The password used to decrypt an item. If password is provided when adding an item to Manager, the same password should be passed here.</param>
        /// <param name="charCount">Maximum chars count that will be returned.</param>
        /// <returns>Item content prefix if exist, else null.</returns>
        string GetContentPrefix(string alias, string password, int charCount = 40);

        /// <summary>
        /// Gets item type.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        /// <param name="password">The password used to decrypt an item. If password is provided when adding an item to Manager, the same password should be passed here.</param>
        /// <returns>Item type if item exists, else null.</returns>
        string GetType(string alias, string password);

        /// <summary>
        /// Removes item stored inside Manager under specified alias.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        void Remove(string alias);

        /// <summary>
        /// Removes all items from Manager.
        /// </summary>
        void RemoveAll();
    }
}
