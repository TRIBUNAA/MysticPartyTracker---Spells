using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    class Character
    {
        public Character(string name, int lvl, string classe, string raca)
        {
            this.Name = name;
            this.Level = lvl;
            this.Classe = classe;
            this.Raca = raca;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string Classe { get; set;}
        public string Raca { get; set; }
    }
}
