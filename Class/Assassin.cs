using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGExemplo.Class
{
    internal class Assassin : Hero
    {
        //Construtor
        public Assassin(string Nome, int Level, string Classe)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.Classe = Classe;
        }

        //Polimorf
        public Assassin()
        {

        }

        public override string Attack()
        {
            return this.Nome + " Ataca com Foice";
        }


    }
}
