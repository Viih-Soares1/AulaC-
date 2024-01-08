using System;

class Program{
    static void Main(){
        // Formatação de strings
        // ToUpper()  // letras maiusculas
        // ToLower() // letras minusculas
        //  Console.WriteLine(variavel.ToUpper());
        // Console.WriteLine(variavel.ToLower()); 
        //REPLACE // Primeiro parametro é o que vai retirar("OLÁ"), o segundo é o que vai colocar no lugar("Oi")
        string txt = "Olá Mundo";
        Console.WriteLine("Digite se nome");
        string nome = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Digite sua idade");
        int idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Format("Olá {0}, sua idade é {1} ", nome.ToUpper() , idade));
        Console.WriteLine(txt.Replace("Olá", "Oi"));
              
    }
}