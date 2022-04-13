using System;
using System.Collections;

namespace ConsoleAppVeriUyg
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Stack islem = new Stack();


              //ekleme işlemini yapan komutum: Push("");
              //çıkarma işlemini yapan komutum: Pop();
              //çıkacak olan elemanı gösteren komutum: Peek();
              islem.Push("Ankara");
              islem.Push("İzmir");
              islem.Push("İstanbul");
              islem.Push("Antalya");

              //stack üst üste oluştu

              Console.WriteLine(islem.Pop());
              Console.WriteLine(islem.Pop());
            */

            //enqueue ekleme işlemini yapar
            Queue dahiliye = new Queue();

            dahiliye.Enqueue("Murat KUŞ");
            dahiliye.Enqueue("Berika SERTER");
            dahiliye.Enqueue("Okan CAN");

            //dequeue çıkarma işlemini yapar

            Console.WriteLine("İşleme Alınan Kişi : "+dahiliye.Dequeue());

        }
    }
}
