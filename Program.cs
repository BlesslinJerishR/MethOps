using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanarysOps
{
    class Program
    {

        // Static Operations
        public class StaticOperations
        {
            public void Add()
            {
                int a = 10;
                int b = 20;
                int sum = a + b;
                Console.WriteLine($"The sum of two numbers are : {sum}");
            }

            public void Sub()
            {
                int a = 10;
                int b = 20;
                int sum = a - b;
                Console.WriteLine($"The Sub of two numbers are : {sum}");
            }

            public void Multi()
            {
                int a = 10;
                int b = 20;
                int sum = a * b;
                Console.WriteLine($"The Multiple of two numbers are : {sum}");
            }

            public void Div()
            {
                int a = 10;
                int b = 20;
                int sum = a / b;
                Console.WriteLine($"The Quotient of two numbers are : {sum}");
            }
        }


        // Dynamic Operations
        public class DynamicOperations
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Sub(int a, int b)
            {
                return a - b;
            }

            public int Multi(int a, int b)
            {
                return a * b;
            }

            public int Div(int a, int b)
            {
                return a / b;
            }
        }

        public int Rectangle()
        {
            int l = 10;
            int b = 20;
            Console.WriteLine($"Area of the Rectangle is : {l * b}");
            return l * b;
        }

        public int Triangle()
        {
            int b = 10;
            int h = 20;
            int area = (b * h) / 2;
            Console.WriteLine($"Area of the Triangle is : {area}");
            return area;
        }

        public float Circle()
        {
            float pi = 3.14f;
            int r = 20;
            float area = pi * r * r;
            Console.WriteLine($"Area of the Rectangle is : {area}");
            return area;
        }


        public class Areas
        {
            public int DRectangle(int a, int b)
            {
                Console.WriteLine($"Area of the Rectangle is : {a * b}");
                return a * b;
            }

            public int DTriangle(int a, int b)
            {
                int area = (b * a) / 2;
                Console.WriteLine($"Area of the Triangle is : {area}");
                return area;
            }

            public float DCircle(int a, int b)
            {
                float pi = 3.14f;
                float area = pi * a * a;
                Console.WriteLine($"Area of the Rectangle is : {area}");
                return area;
            }
        }
        




        static void Main(string[] args)
        {
            Console.WriteLine(@"
      ___           ___           ___           ___           ___                       ___     
     /\__\         /\  \         /\  \         /\  \         /\  \                     /\__\    
    /:/  /        /::\  \        \:\  \       /::\  \       /::\  \         ___       /:/ _/_   
   /:/  /        /:/\:\  \        \:\  \     /:/\:\  \     /:/\:\__\       /|  |     /:/ /\  \  
  /:/  /  ___   /:/ /::\  \   _____\:\  \   /:/ /::\  \   /:/ /:/  /      |:|  |    /:/ /::\  \ 
 /:/__/  /\__\ /:/_/:/\:\__\ /::::::::\__\ /:/_/:/\:\__\ /:/_/:/__/___    |:|  |   /:/_/:/\:\__\
 \:\  \ /:/  / \:\/:/  \/__/ \:\~~\~~\/__/ \:\/:/  \/__/ \:\/:::::/  /  __|:|__|   \:\/:/ /:/  /
  \:\  /:/  /   \::/__/       \:\  \        \::/__/       \::/~~/~~~~  /::::\  \    \::/ /:/  / 
   \:\/:/  /     \:\  \        \:\  \        \:\  \        \:\~~\      ~~~~\:\  \    \/_/:/  /  
    \::/  /       \:\__\        \:\__\        \:\__\        \:\__\          \:\__\     /:/  /   
     \/__/         \/__/         \/__/         \/__/         \/__/           \/__/     \/__/    
                                                
                                [ Developer : Blesslin Jerish R ]
                                     [ Stack : c# & .net ]
                              ");

            // Time Module

            // Buy Time
            DateTime now = DateTime.Now;
            Console.WriteLine("Bonjour Canarys");
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine("");

            Console.WriteLine("First Number : ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number : ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            DynamicOperations dops = new DynamicOperations();
            
            int add = dops.Add(n1, n2);
            Console.WriteLine($"The Addition of two numbers are {add}");

            int sub = dops.Sub(n1, n2);
            Console.WriteLine($"The Subtraction of two numbers are {sub}");

            int multi = dops.Multi(n1, n2);
            Console.WriteLine($"The Mutiplication of two numbers are {multi}");

            int div = dops.Div(n1, n2);
            Console.WriteLine($"The Division of two numbers are {div}");

            Console.WriteLine("");
            Console.WriteLine("Areas");
            Areas aops = new Areas();
            aops.DRectangle(n1,n2);
            aops.DTriangle(n1, n2);
            aops.DCircle(n1, n2);
            
            // Don't delete this
            Console.ReadLine();
        }
    }
}



 