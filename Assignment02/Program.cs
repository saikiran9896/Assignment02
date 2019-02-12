using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
  class Program
  {
    static void Main(string[] args)
    {
      int option, s1, s2, s3; ;

      
      
            do
            {
                Console.WriteLine("Select from the menu below: ");
                Console.WriteLine("1.Enter the sides of the Triangle : ");
                Console.WriteLine("2. EXIT");
                Console.WriteLine("Select an option from the menu :");
                option = Convert.ToInt32(Console.ReadLine());
            } while (option!=1&& option!=2);


     do {
        
        if (option == 2)
          break;
        if(option==1) {

                    do {
                        Console.WriteLine("Enter First side of the triangle: ");
                        s1 = Convert.ToInt32(Console.ReadLine());
                    } while (s1<=0);


                    do {
                        Console.WriteLine("Enter Second side of the triangle: ");
                        s2 = Convert.ToInt32(Console.ReadLine());
                    } while (s2<=0);


                    do {
                        Console.WriteLine("EnterThird side of the triangle");
                        s3 = Convert.ToInt32(Console.ReadLine());
                    } while (s3<=0); 

          
          string message = TriangleSolver.Analyze(s1, s2, s3);
          Console.WriteLine(message);
          Console.WriteLine();
          Console.WriteLine();
          Console.WriteLine("1.Enter the sides of Triangle : ");
          Console.WriteLine("2. EXIT");
          Console.WriteLine("Enter your choice :");
          option = Convert.ToInt32(Console.ReadLine());

        }
     } while (option == 1 || option == 2) ;



    }
  }
}
