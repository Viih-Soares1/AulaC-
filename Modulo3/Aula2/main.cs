using System;
class program{
    static void Main(){
        int[] vetor = new int[3]{10,20,30};    

        int pos = Array.BinarySearch(vetor,20);
        Console.WriteLine(pos);
        int value = Convert.ToInt32(vetor.GetValue(1));
        Console.WriteLine(value);

        // MATRIZ BIDIMENSIONAL 
        //int[,] matrizb = new int[3,3];
        //matrizb[0,0] = 10; matrizb[0,1] = 20; matrizb[0,2] = 30;
       // matrizb[1,0] = 50; matrizb[1,1] = 60; matrizb[1,2] = 70;
       // matrizb[2,0] = 80; matrizb[2,1] = 90; matrizb[2,2] = 100;
       // Console.WriteLine(matrizb[2,2]);

        
    }
}