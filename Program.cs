using System;

namespace the_nim
{
    class Program
    {
        static void Main(string[] args)
        {
            int buckrt1 = 0;
            Console.Write("Input buckrt1 = ");
            buckrt1 = int.Parse(Console.ReadLine());
            int buckrt2 = 0;
            Console.Write("Input buckrt2 = ");
            buckrt2 = int.Parse(Console.ReadLine());
            int buckrt3 = 0;
            Console.Write("Input buckrt3 = ");
            buckrt3 = int.Parse(Console.ReadLine());

            int a = 0 ;
            int b = 0 ;

            bool isend = false;
            while (isend = false)
            {
                Console.WriteLine("buckrt1 = {0},buckrt2{1},buckrt3{2}", buckrt1, buckrt2, buckrt3);
                int buckrt;
                int box;
                if (buckrt1 >= 0 || buckrt2 >= 0 || buckrt3 >= 0)
                {
                    Console.Write("Input Player =");
                    string player = Console.ReadLine();
                    switch (player)
                   
                     {     
                        case1:
                            Console.Write("input buckrt = ");
                            buckrt = int.Parse(Console.ReadLine());
                            Console.Write("input box = ");
                            box = int.Parse(Console.ReadLine());
                            if (buckrt >= 1 && buckrt <= 3)
                            {
                                if (buckrt == 1)
                                {
                                    if (box == 1)
                                    {
                                        if (buckrt1 != 0)
                                        {
                                            buckrt1 -= 1;
                                        }
                                        else
                                            Console.WriteLine("Empty box");
                                    }
                                    else if (b == 2)
                                    {
                                        if (buckrt1 != 1)
                                        {
                                            buckrt1 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Input box Again");
                                    }
                                    else if (buckrt == 2)
                                    {
                                        if (box == 1)
                                        {
                                            if (buckrt2 != 0)
                                            {
                                                buckrt2 -= 1;
                                            }
                                            else
                                                Console.WriteLine("Empty box");
                                        }
                                        else if (box == 2)
                                        {
                                            if (buckrt2 != 1)
                                            {
                                                buckrt2 -= 2;
                                            }
                                            else
                                                Console.WriteLine("Input box Again");
                                        }
                                        else
                                            Console.WriteLine("Input box Again");
                                    }
                                    else if (buckrt == 3)
                                    {
                                        if (box == 1)
                                        {
                                            if (buckrt3 != 0)
                                            {
                                                buckrt3 -= 1;
                                            }
                                            else
                                                Console.WriteLine("Empty box");
                                        }
                                        else if (box == 2)
                                        {
                                            if (buckrt3 != 1)
                                            {
                                                buckrt3 -= 2;
                                            }
                                            else
                                                Console.WriteLine("Input box Again");
                                        }
                                        else
                                            Console.WriteLine("Input box Again");
                                    }
                                    if (buckrt1 == 0 && buckrt2 == 0 && buckrt3 == 0)
                                    {
                                        a++;
                                        isend = true;

                                    }
                                }
                                else
                                    Console.WriteLine("Input box Again");
                                break;
                            case "b":
                            Console.Write("input buckrt = ");
                            buckrt = int.Parse(Console.ReadLine());
                            Console.Write("input box = ");
                            box = int.Parse(Console.ReadLine());
                            if (buckrt >= 1 && buckrt <= 3)
                            {
                                if (buckrt == 1)
                                {
                                    if (box == 1)
                                    {
                                        if (buckrt1 != 0)
                                        {
                                            buckrt1 -= 1;
                                        }
                                        else
                                            Console.WriteLine("Empty box");
                                    }
                                    else if (b == 2)
                                    {
                                        if (buckrt1 != 1)
                                        {
                                            buckrt1 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Input box Again");
                                    }
                                    else
                                        Console.WriteLine("Input box Again");
                                }
                                else if (buckrt == 2)
                                {
                                    if (box == 1)
                                    {
                                        if (buckrt2 != 0)
                                        {
                                            buckrt2 -= 1;
                                        }
                                        else
                                            Console.WriteLine("Empty box");
                                    }
                                    else if (box == 2)
                                    {
                                        if (buckrt2 != 1)
                                        {
                                            buckrt2 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Input box Again");
                                    }
                                    else
                                        Console.WriteLine("Input box Again");
                                }
                                else if (buckrt == 3)
                                {
                                    if (box == 1)
                                    {
                                        if (buckrt3 != 0)
                                        {
                                            buckrt3 -= 1;
                                        }
                                        else
                                            Console.WriteLine("Empty box");
                                    }
                                    else if (box == 2)
                                    {
                                        if (buckrt3 != 1)
                                        {
                                            buckrt3 -= 2;
                                        }
                                        else
                                            Console.WriteLine("Input box Again");
                                    }
                                    else
                                        Console.WriteLine("Input box Again");
                                }
                                if (buckrt1 == 0 && buckrt2 == 0 && buckrt3 == 0)
                                {
                                    b++;
                                    isend = true;

                                }
                            }
                            else
                                Console.WriteLine("Input box Again");
                                break;
                            default:
                            Console.WriteLine("Input box Again");
                            break;


                      }
                }
            } 
            if (a > b)
            {
                Console.WriteLine("b win");
            }
            else if (b > a) 
            {
                Console.WriteLine("a win");
            }
            
        }
    }
}
