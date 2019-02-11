using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAssignment2
{
    public static class TriangleSolver
    {
        
        public static String res;
        
        public static string analyze(int lngth1,int lngth2,int lngth3)
        {
            res = null;
            if (lngth1 > 0 && lngth2 > 0 && lngth3 > 0)
            {
                if ((lngth1 + lngth2 > lngth3) && (lngth1 + lngth3 > lngth2) && (lngth2 + lngth3 > lngth1))
                {
                    if ((lngth1.Equals(lngth2)) && (lngth2.Equals(lngth3)))
                    {
                        //Console.WriteLine("equvilateral");
                        res = ("equvilateral");

                        
                    }
                    else if ((lngth1.Equals(lngth2)) || (lngth2.Equals(lngth3)))
                    {
                        //Console.WriteLine("Isosceles");
                        res = ("Triangle is Isosceles");

                      
                    }
                    else
                    {
                        //Console.WriteLine("Scalene");
                        res = ("Triangle is Scalene");

                        
                    }
                    
                }

                else
                {
                    res = ("Invalid triangle");
                    // Console.WriteLine("Not a Valid Trianglee");
                    
                }
            }
            else
            {
                res = ("Negative triangle");
                // Console.WriteLine("Not a Valid Trianglee");
               
            }

            return res;
        }
    }
}
