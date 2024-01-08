using System;
class Principal
{
    static void Main()
    {
        Console.WriteLine("Aula de IF, ELSE IF e ELSE");
        Console.WriteLine("Digite Um numero de 0 a 10");
        int n1 = Convert.ToInt32(Console.ReadLine());
        if (n1 > 0 && n1 < 11)
        {
            Console.WriteLine("Este número é par (S/N)");
            string res = Console.ReadLine();
            if (res == "s" || res == "S")
            {
                Console.WriteLine("É maior que 6? (S/N)");
                string res2 = Console.ReadLine();
                if (res2 == "S" || res2 == "s")
                {
                    Console.WriteLine("Dividindo este número por quatro dá dois? (S/N)");
                    string res1 = Console.ReadLine();
                    if (res1 == "S" || res1 == "s")
                    {
                        Console.WriteLine("Este Número é o 8!");
                    }
                    else
                    {
                        Console.WriteLine("Este Número é o 10! ");
                    }
                }
                else
                {
                    Console.WriteLine("Este número é divisível por 3? (S/N)");
                    string res3 = Console.ReadLine();
                    if (res3 == "S" || res3 == "s")
                    {
                        Console.WriteLine("Este número é o 6!");
                    }
                    else if (res3 == "n" || res3 == "N")
                    {
                        Console.WriteLine("Este número dividido por 2 dá 2? (S/N)");
                        string res4 = Console.ReadLine();
                        if (res4 == "s" || res4 == "S")
                        {
                            Console.WriteLine("Este número é o 4!");
                        }
                        else
                        {
                            Console.WriteLine("Este número é o 2!");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Este número é maior que 5? (S/N)");
                string res5 = Console.ReadLine();
                if (res5 == "s" || res5 == "S")
                {
                    Console.WriteLine("Este número dividido por 3 dá 3? (S/N)");
                    string res7 = Console.ReadLine();
                    if (res7 == "S" || res7 == "s")
                    {
                        Console.WriteLine("O número digitado é o 9!");
                    }
                    else
                    {
                        Console.WriteLine("O número digitado é o 7!");
                    }
                }
                else
                {
                    Console.WriteLine("Este número é divisível por 5? (S/N)");
                    string res8 = Console.ReadLine();
                    if (res8 == "s" || res8 == "S")
                    {
                        Console.WriteLine("O número digitado é o 5! ");
                    }
                    else
                    {
                        Console.WriteLine("Este número dividido por 3 dá 1? (S/N)");
                        string res6 = Console.ReadLine();
                        if (res6 == "S" || res6 == "s")
                        {
                            Console.WriteLine("O número digitado é 3!");
                        }
                        else
                        {
                            Console.WriteLine("O númmero digitado é o 1!");
                        }                
                    }
                }
            }
        }
    }
}