using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stellar_Tizen.Tizen.TV.SecureStorage
{
    using System.Collections.Generic;
    using System.Linq;
    using global::Tizen.Security.SecureRepository;

    /// <summary>
    /// Base class for example classes responsible for connecting with Managers.
    /// </summary>
    /// <typeparam name="T">Item type (Key,Certificate,byte[] {Data}).</typeparam>
    public abstract class Secure<T> : ISecure<T>
    {
        /// <summary>
        /// Checks if item Exists in Manager.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        /// <param name="password">The password used to decrypt an item. If password is provided when adding an item to Manager, the same password should be passed here.</param>
        /// <returns>True if Exists, false if not or if occurred any errors.</returns>
        public bool Exists(string alias, string password = null)
        {
            IEnumerable<string> aliases = this.GetAliasesShort();
            if (aliases != null)
            {
                foreach (string alias_ in aliases)
                {
                    // Checks if alias_ from Manager is the same as specyfied by first parameter.
                    if (alias_ == alias)
                    {
                        return true;
                    }
                }
            }

            return false;
            //// Alternative implementation (It should be faster but here I want to show You how to use aliases and what there are for && It`s universal method for all Managers):
            // use e.g. KeyManger.Get(alias,password) inside try{} block and return false inside catch{} for implementation example check Decrypt / Encrypt method inside Cryptography class.
        }

        /// <summary>
        /// Gets short version of all available aliases from Manager.
        /// </summary>
        /// <returns>Aliases List if exists, else null.</returns>
        public IEnumerable<string> GetAliasesShort()
        {
            IEnumerable<string> aliases;
            aliases = this.GetAliases();
            if (aliases != null)
            {
                List<string> shortAlises = new List<string>();
                foreach (string alias_ in aliases)
                {
                    shortAlises.Add(alias_.Split(null).Last()); // WE are splitting alias_ by "space".
                    // alias: "App.name ALIAS" Alias has two parts App.name and actual ALIAS,
                    // It`s done this way beacause you can share Keys,Certificates,Data with other apps so *Manager adds App.name prefix to avoid alias conflicts between diffrent Apps.
                    // You don`t have to do it. It`s done automatically.
                }

                return shortAlises;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets item from Manager.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        /// <param name="password">The password used to decrypt an item. If password is provided when adding an item to Manager, the same password should be passed here.</param>
        /// <returns>Item if exists, else null.</returns>
        public abstract T Get(string alias, string password);

        /// <summary>
        /// Gets all available aliases from Manager.
        /// </summary>
        /// <returns>Aliases List or null if aliases does not exist.</returns>
        public abstract IEnumerable<string> GetAliases();

        /// <summary>
        /// Gets first chars of item content no more than charCount.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        /// <param name="password">The password used to decrypt an item. If password is provided when adding an item to Manager, the same password should be passed here.</param>
        /// <param name="charCount">Maximum chars count that will be returned.</param>
        /// <returns>Item content prefix if exists, else null.</returns>
        public abstract string GetContentPrefix(string alias, string password, int charCount = 40);

        /// <summary>
        /// Gets item type.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        /// <param name="password">The password used to decrypt an item. If password is provided when adding an item to Manager, the same password should be passed here.</param>
        /// <returns>Item Type if item exists, else null.</returns>
        public abstract string GetType(string alias, string password);

        /// <summary>
        /// Removes item stored inside Manager under specified alias.
        /// </summary>
        /// <param name="alias">The name of an item.</param>
        public virtual void Remove(string alias)
        {
            try
            {
                Manager.RemoveAlias(alias);
            }
            catch
            {
                
            } 
        }

        /// <summary>
        /// Removes all items from Manager.
        /// </summary>
        public virtual void RemoveAll()
        {
            IEnumerable<string> aliases;
            aliases = this.GetAliases();

            if (aliases != null)
            {
                foreach (string alias in aliases)
                {
                    this.Remove(alias);
                }
            }
        }
    }
}
