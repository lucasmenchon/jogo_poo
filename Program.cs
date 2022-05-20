using RPGExemplo.Class;
using static System.Console;

namespace RPGExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sem POO
            /*string nome = "Zed";
            int level = 99;
            string classe = "Ninja";

            WriteLine(nome + @$"
            Level: {level}
            Classe: {classe}");*/

            //Com POO
            /*Zed zed = new Zed();
            zed.nome = "Zed";
            zed.classe = "Ninja";
            zed.level = 99;
            Write(zed);*/

            //Com POO/Construtor
            Ninja zed = new Ninja("Zed", 99, "Ninja");
            Assassin kayn = new Assassin("Kayn", 99, "Assassino");

            Write(zed + $@"
          " + zed.Attack("Critico") + $@"
          " + kayn.ToString() + $@"
          " + kayn.Attack() + $@"
          ");

        }
    }
}
