using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace CllasWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("imput number");
            int tt = int.Parse(Console.ReadLine());
            Console.WriteLine("start");
            Calc(tt);
            EvenNumber(tt);
            OddIndex(tt);
            Sum(tt);
            Quantity(tt);
            Ex336(tt);


        }
        static double Calc(int t)
        {
            int sum = 0;

            for (int i = 1; i <= t; i++)
            {
                sum += i;

            }
            Console.WriteLine("mijin tvabanakan = " + sum / t);
            return sum / t;
        }
        static double EvenNumber(int z)
        {
            double sum = 0;
            for (int i = 0; i < z; i++)
            {


                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("zuyg andamneri gumary" + " = " + sum);
            return sum;
        }
        static double OddIndex(int z)
        {
            double p = 1;
            for (int i = 0; i < z; i++)
            {


                if (i % 2 == 1)
                {
                    p *= i ^ 2;
                }
            }
            Console.WriteLine("kent indeqsneri qarakusineri artadryaly" + " = " + p);
            return p;
        }
        static double Sum(int z)
        {
            Console.WriteLine("nermucel mijakayqi sahmannery");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < z; i++)
            {
                if (i > a && i < b)
                {
                    sum += i;
                }
            }
            Console.WriteLine("[a,b] mijakayqi andamneri gumary = " + sum);
            return sum;
        }
        static double Quantity(int z)
        {
            int k = 0;
            for (int i = 0; i < z; i++)
            {
                if (i % 7 == 0)
                {
                    k++;
                }
            }
            Console.WriteLine("7-i bazmapatikneri qanak = " + k);
            return k;
        }

        static double Ex336(int k)
        {
            int[] arr = new int[k];
            Console.WriteLine("Nermucel zangvaci tarrery");
            for (int i = 0; i < k; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            int z = 0;
            for (int i = 0; i < k; i++)
            {
                if (arr[i] < 0)
                {
                    z++;
                }
            }
            if (z > 0)
            {
                for (int j = 0; j < k; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                    }

                }
                Console.WriteLine(max);
            }
            else
            {
                Console.WriteLine("0");

            }
            return max;
        }


    }
}