using System;
using System.Collections.Generic;

namespace Partie4_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of the list
            List <string> langage = new List <string>();
            langage.Add("HTML");
            langage.Add("CSS");
            langage.Add("Javacript");
            langage.Add("jQuery");
            langage.Add("PHP");
            langage.Add("Bootstrap");
            langage.Add("Java");

            langage.ForEach(Console.WriteLine);

            Console.WriteLine($"le contenu du 4ème élément est {langage[3]}");
            Console.WriteLine($"le contenu de l'index 4 de la liste est {langage[4]}");
            langage.Remove("Bootstrap");//suppression de la commande

            langage.ForEach(Console.WriteLine);
            Console.WriteLine($"la commande a été supprimé");
            int index = langage.IndexOf("Javacript");//correction du mot
            langage[index] = "Javascript";

            //ajout de nouvelle variable
            langage.Add("c");
            langage.ForEach(Console.WriteLine);
        }
}
}
