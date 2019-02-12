using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
  public static class TriangleSolver
  {
    public static string Analyze(int s1, int s2, int s3)
    {
            if (s1 < s2+s3 && s2 < s1+s3 && s3 < s1+s2)
            {
                if (s1 == s2 && s2 == s3 && s3 == s1)
                    return "This is an Equilateral triangle";

                if ((s1 == s2 && s2 != s3 && s3 != s1) || (s1 != s2 && s2 == s3 && s3 != s1) || (s1 != s2 && s2 != s3 && s3 == s1))
                    return "This is an Isosceles triangle";

                if (s1 != s2 && s2 != s3 && s3 != s1)
                    return "This is an Scalene triangle";

            }
            //for zero inputs
            else if (s1 == 0 && s2 == 0 && s3 == 0)
            {
                return "All sides enterred are zero, Triangle not possible";
            }
            else if ((s1 == 0 && s2 != 0 && s3 != 0) || (s1 != 0 && s2 == 0 && s3 != 0) || (s1 != 0 && s2 != 0 && s3 == 0))
            {
                return "One of the side is Zero, Triangle not Posssible";
            }
            else if ((s1 == 0 && s2 == 0 && s3 != 0) || (s1 == 0 && s2 != 0 && s3 == 0) || (s1 != 0 && s2 == 0 && s3 == 0))
            {
                return "Two of the side are Zero, Triangle not Posssible";
            }
            //for negative inputs
            else if ((s1 < 0 && s2 >= 0 && s3 >= 0) || (s1 >= 0 && s2 < 0 && s3 >= 0) || (s1 >= 0 && s2 >= 0 && s3 < 0))
            {
                return "One of the side is Negative, Triangle not Posssible";
            }
            else if ((s1 < 0 && s2 < 0 && s3 >= 0) || (s1 < 0 && s2 >= 0 && s3 < 0) || (s1 >= 0 && s2 < 0 && s3 < 0))
            {
                return "Two of the side are Negative, Triangle not Posssible";
            }
            else if (s1 < 0 && s2 < 0 && s3 < 0)
            {
                return "All sides enterred are less then zero, Triangle not possible";
            }
            else { return "Invalid inputs for creating a triangle"; }

            return "";
          
        }
  }
}
