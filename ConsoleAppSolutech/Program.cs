using System;

namespace ConsoleAppSolutech
{
    class Program
    {
        static void Main(string[] args)
        {
            //Attend que l'on écrive l'expression
            Console.WriteLine("Ecrivez le texte que vous souhaitez calculer");
            string text = Console.ReadLine();
            //Remplace les plus et les minus
            string textTransform = text.Replace("plus", "+").Replace("minus", "-");
            //Transforme l'expression en tableau de string pour pouvoir le parcourir
            string[] split = textTransform.Split(" ");
            int result=0;
            for (int i = 0; i < split.Length; i++)
            {
                if(split[i] != "+" && split[i] != "-")
                {
                    //si i est égal à 0 alors on ajoute simplement la valeur du nombre à result
                    // si non on ajoute la valeur du nombre à résultat en ajoutant l'opérateur précédent
                    result +=  i == 0 ? int.Parse(split[i]) : int.Parse(split[i - 1] + split[i]);
                }
            }
            //Ecrit le résultat
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
