using System;
using System.Threading.Tasks;
using System.Text;


namespace Lab_20
{
    class Program
    {
        delegate double MyDelegate(double a);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Lenght;
            if (myDelegate != null)
            {
                double r = myDelegate(2);
                Console.WriteLine(r);
            }
            MyDelegate myDelegate1 = Area;
            if (myDelegate1 != null)
            {
                double r = myDelegate1(2);
                Console.WriteLine(r);
            }
            MyDelegate myDelegate2 = Volume;
            if (myDelegate2 != null)
            {
                double r = myDelegate2(2);
                Console.WriteLine(r);
            }
            Console.ReadKey();

        }
        static double Lenght(double r)
        {
            Console.WriteLine("Длина");
            return 2 * r * Math.PI;
        }
        static double Area(double r)
        {
            Console.WriteLine("Площадь");
            return Math.PI * Math.Pow(r, 2);
        }
        static double Volume(double r)
        {
            Console.WriteLine("Объем");
            return (4/3)*Math.PI * Math.Pow(r, 3);
        }
    }
}
