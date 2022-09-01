using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Corpo
       
    {
        public Corpo() { this.armaD = new Arma(); this.armaE = new Arma(); }
        public string cabeca { get; set; }
        public string peito { get; set; }
        public string mao { get; set; }
        public string perna { get; set; }
        public string pé { get; set; }
        public Arma armaD { get; set; }
        public Arma armaE { get; set; }


    }
}
