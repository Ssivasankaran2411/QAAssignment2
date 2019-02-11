using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAAssignment2
{

    class Program
    {
        public int i,j=0, choice,len1=0,len2=0,len3=0;
        public String choice1,result=null;
        public String length1, length2, length3;

        public void menu()
        {
            i = 0;

            do
            {

                if (i > 0)
                {
                    Console.WriteLine("OOPS.....You should enter a number from the menu......");
                }
                Console.WriteLine("Select an Option from the menu shown below");
                Console.WriteLine(" 1.ENTER THE TRIANGLE DIMENSIONS\n 2.Exit");
                do
                {
                    choice1 = Console.ReadLine();

                } while (!int.TryParse(choice1, out choice));

                i++;
            } while (choice < 1 || choice > 7);

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
        }
        public void Go()
        {
            //TriangleSolver t = new TriangleSolver();
            menu();
            do
            {
                
                switch (choice)
                {
                    case 1:
                        i = 0;
                        do
                        {
                            if (i > 0)
                            {
                                Console.WriteLine("OOPS.....You should enter a number greater than 0......");
                            }
                            j = 0;
                            do
                            {
                                
                                if (j > 0)
                                {
                                    Console.WriteLine("OOPS.....You should enter a number......");
                                }
                                Console.WriteLine("ENTER THE LENGTHS OF THE TRIANGLE");
                                length1 = Console.ReadLine();
                                
                                length2 = Console.ReadLine();
                                
                                length3 = Console.ReadLine();
                                
                               
                               
                                j++;
                            } while ((!int.TryParse(length1, out len1)) || (!int.TryParse(length2, out len2)) || (!int.TryParse(length3, out len3)));

                            len1 = int.Parse(length1);
                            len2 = int.Parse(length2);
                            len3 = int.Parse(length3);
                           
                            i++;

                        } while ((len1 < 1) || (len2 < 1) || (len3 < 1));
                        result = TriangleSolver.analyze(len1, len2, len3);
                        Console.WriteLine("The entered value resembles a {0} triangle", result);
                        break;
                    case 2:
                        Console.WriteLine("Select an Option from the menu  below");
                        break;

                }

                menu();
            } while (choice != 2);
        }
    }
}