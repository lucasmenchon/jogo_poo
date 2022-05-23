using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGExemplo.Class
{
    internal class Hero
    {
        public Hero(string Nome, int Level, string Classe)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.Classe = Classe;
        }

        //Polimorf
        public Hero()
        {

        }

        public string Nome { get; set; }

        public int Level { get; set; }

        public string Classe { get; set; }

        //override
        public override string ToString()
        {
            return @$"
            Nome: {this.Nome} 
            Level: {this.Level}
            Classe: {this.Classe} ";
        }

        public virtual string Attack()
        {
            return this.Nome + " Ataca com ?";
        }

        //ataque polimorf
        public virtual string Attack(string Critico)
        {
            return this.Nome + $" Ataca com ? Acerto *{Critico}* ";
        }
    }
}
