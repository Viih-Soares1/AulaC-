using System;
class program{
    static void Main(){
        int n1, n2 = 0;
        Console.WriteLine("Digite dois números inteiros distintos");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        if(n1 > n2){
            Console.WriteLine(string.Format("Números que estão entre {0} e {1}", n2, n1));
            for(; n2 <= n1; n2++){
                Console.WriteLine(n2);
            }
        }
        else{
            Console.WriteLine(string.Format("Números que estão entre {0} e {1}", n1, n2));
            while(n1 != n2){                
                Console.WriteLine(n1);
                n1++;
            }
        }
    }
}