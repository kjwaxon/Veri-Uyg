using System;

namespace ConsoleAppBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //a değişkenime stack içerisinde yer ayırdım ve adresine 456 sayısını yerleştirdim  
            int a = 456;
            // boxing yaparak a değişkenimi o değişkenime kopyaladım
            //burada da heap içerisinde bir nesne oluşturup oraya yine 456 yı koydum
            //yani hem stackde hem heap kısmında 456 sayısını tutmuş oldum
            object o = a;
            //a değişkenimin değerini değiştirdim
            a = 800;
            //hem heap yapısındaki hem stackdeki veriyi konsola yazdırdım
            System.Console.WriteLine("Değer tipi (value-type) değişken içeriği ={0}",a);
            System.Console.WriteLine("Obje tipi (object-type) değişken içeriği ={0}", o);
        }
    }
}
