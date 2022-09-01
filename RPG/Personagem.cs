using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Personagem 
    {
        public Personagem() { this.status = new Status(); this.mochila = new Mochila(); this.corpo = new Corpo(); }
        public int nivel { get; set; }
        public string nome { get; set; }
        public string raca { get; set; }
        public string classe { get; set; }
        public Corpo corpo { get; set; }
        public Status status { get; set; }
        public string historia { get; set; }
        public string objetivo { get; set; }
        public string habilidade1 { get; set; }
        public string habilidade2 { get; set; }
        public string habilidade3 { get; set; }
        public Mochila mochila { get; set; }

    }
}
