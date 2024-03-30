using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Numerics;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d,e,f,h,count=0,price=0,m,l,q,p;
            string[] t = new string[100];
            int[] s = new int[100];
            int[] unit = new int[100];
            int[] r = new int[100];
            string[]   k = new string[100];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                                        KS Mart                                 ");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("1.Admin\n2.User");
            a=Convert.ToInt32(Console.ReadLine());
            x:
            if(a==1)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine("Welcome to Admin login page");
                Console.WriteLine("Username:admin");
                Console.Write("Password:");
                b=Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("Do you want change your password or not?");
                Console.WriteLine("1.Yes\n2.No");
                c=Convert.ToInt32(Console.ReadLine());
                if (c==1)
                {
                    Console.ForegroundColor=ConsoleColor.Gray;
                    Console.Write("Enter your password: ");
                    d=Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.ForegroundColor=ConsoleColor.Cyan;
                    Console.WriteLine("Do you want to login?");
                    Console.WriteLine("1.Yes\n2.No");
                    e=Convert.ToInt32(Console.ReadLine());
                    if (e == 1)
                    {
                        Console.ForegroundColor=ConsoleColor.DarkBlue;
                        Console.WriteLine("Please enter your password:");
                        f=Convert.ToInt32(Console.ReadLine());
                        if (d == f)
                        {
                            Console.ForegroundColor=ConsoleColor.DarkCyan;
                            Console.WriteLine("Welcome to Dashboard ");
                            int n;
                            Console.WriteLine("Enter n value: ");
                            n=Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            for (int i = 0; i < n; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write("Enter items " + t[i] + "is: ");
                                t[i]= Console.ReadLine();
                            }
                            for(int i = 0; i < n; i++)
                            {
                                Console.Write("Enter items is: ");
                                s[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine() ;
                            for(int i = 0;i<n ; i++)
                            {
                                Console.ForegroundColor= ConsoleColor.DarkMagenta;
                              Console.WriteLine("Items: " + t[i] +  " Cost: " + s[i]);
                            }
                            
                        }
                        else
                        {
                            
                            Console.ForegroundColor=ConsoleColor.DarkRed;
                            Console.WriteLine("Please enter correct password");
                        }
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("1.Admin\n2.User");
                        h = Convert.ToInt32(Console.ReadLine());
                        if (h == 1)
                        {
                            goto x;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome to User Page \n\n");
                            Console.WriteLine();
                            Console.WriteLine("Items available in the mart\n");
                            Console.WriteLine("Item           |           Cost");
                            for (int i = 0; i < 100; i++)
                            {
                                if (t[i] == null)
                                {
                                    break;
                                }
                                count++;
                                l = 15 - t[i].Length;
                                Console.Write(t[i]);
                                for (int j = 0; j < l; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write("|");
                                Console.WriteLine("           " + s[i]);
                            }
                            Console.Write("\nEnter no of items you want: ");
                            m = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < m; i++)
                            {
                                int av = 0;
                            O: Console.Write("Enter your " + (i + 1) + " item: ");
                                k[i] = Console.ReadLine();
                                for (int j = 0; j < count; j++)
                                {
                                    if (k[i] == t[j])
                                    {
                                        av = 1;
                                    }
                                }
                                if (av == 0)
                                {
                                    Console.WriteLine("Sorry! Item not available");
                                    Console.WriteLine("Please Re-enter");
                                    goto O;
                                }
                                Console.Write("No of units you want: ");
                                 unit[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            for (int i = 0; i < m; i++)
                            {
                                for (int j = 0; j < count; j++)
                                {
                                    if (t[i] == t[j])
                                    {
                                        r[i] = unit[i] * s[j];
                                        price = price + r[i];
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Please fill the below details.");
                            Console.Write("Name: ");
                            string name= Console.ReadLine();
                            Console.Write("Phone No.: ");
                            int num=Convert.ToInt32(Console.ReadLine());
                            Console.Write("Email: ");
                            string mail=Console.ReadLine();
                            Console.WriteLine("BILL PAYMENT");
                            Console.WriteLine("User id : " + (num % 10000));
                            Console.WriteLine();
                            Console.WriteLine("Items           Units            Cost");
                            for (int i = 0;i<m;i++)
                            {
                                q = 15 - t[i].Length;
                                Console.Write(t[i]);
                                for (int j = 0;j < q;j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(" " + unit[i]);
                                p = 10 - unit[i].ToString().Length;
                                for (int w = 0;w<p;w++)
                                {
                                    Console.Write(" ");
                                }
                                Console.WriteLine("|   " + r[i]);
                            }
                            Console.Write("               Total Bill  Rs.    "+price);
                        }


                    }
                    if (e == 2)
                    {
                        goto x;
                    }
                }
                if (c==2)
                {
                    Console.ForegroundColor=ConsoleColor.DarkYellow;
                    Console.WriteLine("Welcome to Dashboard");
                    int n;
                    Console.WriteLine("Enter n value: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Enter items " + t[i] + "is: ");
                        t[i] = Console.ReadLine();
                    }
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        Console.ForegroundColor=ConsoleColor.Yellow;
                        Console.Write("Enter items " + s[i] + "is: ");
                        s[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                    for (int i = 0;i < n; i++)
                    {
                        Console.ForegroundColor=ConsoleColor.Black;
                        Console.WriteLine("Items " + t[i]+  " Cost" + s[i]);
                    }

                }
            }
        }

    }
}
