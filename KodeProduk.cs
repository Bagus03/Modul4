using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022300025
{
    internal class KodeProduk
    {
        private Dictionary<string, string> tableKodeProduk = new Dictionary<string, string>()
        {
            { "laptop", "E100" },
            { "smartphonr" , "E101" },
            { "tablet", "E102" },
            { "headset", "E103" },
            { "keyboard", "E104" },
            { "mouse", "E105" },
            { "printer", "E106" },
            { "monitor", "E107" },
            { "smartwatch", "E108" },
            { "kamera", "E109" },
        };

        public string? GetKodeProduk(string Produk)
        {
            if (tableKodeProduk.ContainsKey(Produk))
            {
                return tableKodeProduk[Produk];
            }
            else
            {
                return null;
            }
        }
    }
}
