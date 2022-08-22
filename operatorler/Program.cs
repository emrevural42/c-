using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Atama ve İşlemli Atama*****");
           //atama ve işlemli atama
           int x = 3;
           int y = 2;
            Console.WriteLine(y);
             y=y+3;
             Console.WriteLine(y);
             y+=2;
             Console.WriteLine(y);
             y/=1;
             Console.WriteLine(y);
             x*=2;
             Console.WriteLine(x);
             Console.WriteLine("*****Mantıksal Operatörler*****");
             //Mantıkısal operatörler 
             // && ,|| ,!
             bool isSuccess = true;
             bool isCompleted = false;
             if(isSuccess && isCompleted)
            Console.WriteLine("Perfect");
            if(isSuccess || isCompleted)
            Console.WriteLine("Great");
             if(isSuccess && ! isCompleted)
             Console.WriteLine("Fine");

             Console.WriteLine("*****İlişkisel Operatörler*****");
             //Iliskisel Operatorler
             // < ,>, <=,>=,==,!=
             int a=3;
             int b=4;
             bool sonuc=a<b;

             Console.WriteLine(sonuc);
             sonuc= a>b;
             Console.WriteLine(sonuc);
             sonuc= a>=b;
             Console.WriteLine(sonuc);
             sonuc= a<=b;
             Console.WriteLine(sonuc);
             sonuc= a==b;
             Console.WriteLine(sonuc);
             sonuc= a!=b;
             Console.WriteLine(sonuc);

             Console.WriteLine("*****Aritmetik Operatörler*****");
            // / , * , + , -
            int sayi1 =10;
            int sayi2 =5;
            int sonuc2 = sayi1 / sayi2;
            Console.WriteLine(sonuc2);
           
            sonuc2 = sayi1 *sayi2;
            Console.WriteLine(sonuc2);
            sonuc2 = sayi1 +sayi2;
            Console.WriteLine(sonuc2);
            sonuc2 = sayi1 - sayi2;
            Console.WriteLine(sonuc2);
            // % MOD almak için kullanılır.
            int sonuc3 = 20%3;
            Console.WriteLine(sonuc3);


           
        
        }
    }
}
