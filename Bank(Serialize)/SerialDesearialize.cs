using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank;
using Newtonsoft.Json;

namespace Bank_Serialize_
{
    internal class SerialDesearialize
    {
 
        public static void SerializeData(List<Account> accounts)
        {
            File.WriteAllText("AccountData.json", JsonConvert.SerializeObject(accounts));
        }
        public static Account[] DeserializeData()
        {

            string filename = "AccountData.json";
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                return JsonConvert.DeserializeObject<Account[]>(json);
            }
            return new Account[0];
        }
    }
}
