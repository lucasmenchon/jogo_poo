using RPGExemplo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGExemplo
{
    internal class Ninja : Hero
    {

        //Construtor
        public Ninja(string Nome, int Level, string Classe)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.Classe = Classe;
        }

        //Polimorf Construtor
        public Ninja()
        {

        }
        
        public override string Attack() 
        {
            return this.Nome + " Ataca com Shurikens";
        }

        //ataque polimorf
        public override string Attack(string Critico)
        {
            return this.Nome + $" Ataca com Shurikens *Acerto {Critico}* ";
        }

    }
}
