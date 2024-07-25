using System;

namespace doPatika
{
    class Program
    {
        static void Main(string[] args)

        {

            /*Aşağıdaki örnekte hem while hem de do-while koşullarını inceleyeceğiz. 
             While döngüsü koşul olduğu sürece gerçekleşir, do-while ise 1 kere de olsa gerçekleşir */

            // Hedef sayı için değişken tanımlama

            //While durumu

            int limit = 0;
            int counter = 0;

            //Kullanıcıdan veri girişi alma
            Console.WriteLine("Döngünün tekrar etmesini istediğiniz sayıyı giriniz.");
            limit = Convert.ToInt32(Console.ReadLine());

            //Girilen sayının negatif olup olmadığının kontrolü

            if (limit >=0 )
            {
                //pozitif ise
                while(counter <=limit)
                {
                    Console.WriteLine("Ben bir Patikalıyım!");
                    counter++;
                }
            }

            else
            {
                //negatif ise
                while (counter >= limit) ;
                {
                    Console.WriteLine("Ben bir Patikalıyım!");
                    counter--;
                }

            }

            //Do-While durumu

            //Hedef sayı ve sayaç için değişken tanımlama

            int limite = 0;
            int countere = 0;

            if (limite >= 0 ) 
            {

                //pozitif ise
                do
                {
                    Console.WriteLine("Ben bir Patikalıyım!");
                    countere++;
                } while (countere <= limit);

            }
            else 
            { 
            
                //negatif ise
                do
                {
                    Console.WriteLine("Ben bir Patikalıyım!");
                    countere--;
                } while (countere >= limit);
            }


        }

    }
}