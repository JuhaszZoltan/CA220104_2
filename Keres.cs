using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA220104_2
{
    internal class Keres
    {
        public string Cim { get; set; }
        public string DatumIdo { get; set; }
        public string Get { get; set; }
        public string HttpKod { get; set; }
        private string MeretString { get; set; }
        public int ByteMeret => 
            MeretString == "-" 
            ? 0 
            : int.Parse(MeretString);
        public bool Domain => 
            !int.TryParse(Cim[Cim.Length - 1].ToString(), out _);

        public Keres(string sor)
        {
            var v = sor.Split('*');
            Cim = v[0];
            DatumIdo = v[1];
            Get = v[2];
            var w = v[3].Split(' ');
            HttpKod = w[0];
            MeretString = w[1];
        }
    }
}
