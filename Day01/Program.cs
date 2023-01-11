using Microsoft.VisualBasic;
using System;

namespace Day01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nomor12();
        }
        static void Nomor1()
        {
            int i = 0;
            int sum = 0;
            int number = 0;

            Console.Write("Enter number integer : ");
            String temp = Console.ReadLine();

            for (i = 0; i < temp.Length; i++)
            {
                number = (int)temp[i] - '0';
                sum += number;
            }
            Console.WriteLine("Total Sum : " + sum);
        }
        static void Nomor2()
        {
            int i = 0;
            int sum = 0;

            Console.Write("Enter number integer : ");
            String temp = Console.ReadLine();

            foreach (var item in temp)
            {
                sum++;
            }
            Console.WriteLine("Count : " + sum);
        }
        static void Nomor3()
        {
            String hasil = "";

            Console.Write("Enter number integer : ");
            String temp = Console.ReadLine();

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                hasil += " " + temp[i];
            }
            Console.WriteLine(hasil);
        }
        static void Nomor4()
        {
            int input = 0;

            int biggest = 0;
            do
            {
                Console.Write("Enter integer [ Type 0 for exit ] : ");
                input = Int32.Parse(Console.ReadLine());
                if (input > biggest)
                {
                    biggest = input;
                }
            } while (input != 0);
            Console.WriteLine($"angka terbesar : {biggest}");
        }   
        static void Nomor5()
        {
            int input;
            String hasil = "";
            Console.Write("Enter numbers : ");
            input = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < input; i++)
            {
                if(input%i == 0)
                {
                    hasil += i + " ";
                }
            }
            Console.WriteLine(hasil);
        }
        static void Nomor6()
        {
            int input;
            bool isPrime = true;
            String hasil = "";
            Console.Write("Enter limit number : ");
            input = Int32.Parse(Console.ReadLine());
            for (int i = 2; i < input; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    { 
                        isPrime= false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    hasil += i + " ";
                }
                isPrime = true;
            }
            Console.WriteLine(hasil);
        }
        static void Nomor7()
        {
            String input;
            bool isSpace = false;
            String hasil = "";
            Console.Write("Enter strings : ");
            input = Console.ReadLine();

            hasil += input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (isSpace)
                {
                    hasil += input[i];
                    isSpace= false;
                }
                else
                {
                    if (input[i].Equals(' '))
                    {
                        isSpace = true;
                        hasil = hasil.Remove(i-1, 1);
                        hasil += input[i - 1] + " ";
                    }
                    else
                    {
                        hasil += "*";
                    }
                }
            }
            hasil = hasil.Remove(input.Length - 1, 1);
            hasil += input[input.Length - 1];
            Console.WriteLine(hasil);
        }
        static void Nomor8()
        {
            int i = 0;
            while (!DateTime.Now.AddDays(i).ToString("dddd").Equals("Saturday"))
            {
                i++;
            }
            Console.Write("Hari Sabtu : ");
            Console.WriteLine(DateTime.Now.AddDays(i).ToString("d"));
            Console.WriteLine($"{i} hari lagi");
        }
        static void Nomor9()
        {
            String input, find;
            bool goal = true;
            int hitung = 0;
            Console.Write("Enter strings : ");
            input = Console.ReadLine();
            Console.Write("Find strings : ");
            find = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("blink");
                if (input[i].Equals(find[0]))
                {
                    for (int j = 0; j < find.Length; j++)
                    {
                        Console.WriteLine("blink1");
                        if (i+find.Length > input.Length + 1)
                        {
                            Console.WriteLine(1);
                            goal = false;
                            break;
                        }
                        if (!input[i].Equals(find[j]))
                        {
                            if (!input[i].Equals(find[0]))
                            {
                                Console.WriteLine(2);
                                goal = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Check");
                                goal = false;
                                i--;
                                break;
                            }
                        }
                        i ++;
                    }
                    if (goal)
                    {
                        Console.WriteLine(3);
                        hitung ++;
                    }
                    goal = true;
                }
            }
            Console.WriteLine($"Total kata yang muncul : {hitung} dari text : {input}");
        }
        static void Nomor10()
        {
            int first = 0, second = 0, input = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Enter {i}. number: ");
                input = Int32.Parse(Console.ReadLine());
                if(input > first)
                {
                    second = first;
                    first= input;
                }
                else
                {
                    if (input > second)
                    {
                        second = input;
                    }
                }
            }
            Console.WriteLine($"Second Greatest : {second}");
        }
        static bool Nomor11()
        {
            bool result;
            int open = 0, close = 0;
            String input;
            Console.Write("Masukkan strings : ");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals('{'))
                {
                    open++;
                }
                if (input[i].Equals('}'))
                {
                    close++;
                }
            }
            if (open == close)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            Console.WriteLine(result);
            return result;
        }
        static void Nomor12()
        {
            int temp = 6;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 10; j >= temp; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
                temp++;
            }
            Console.WriteLine("=====================================================");
            temp = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = temp; j <= temp + i - 1; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
                temp++;
            }
            Console.WriteLine("=====================================================");
            temp = 1;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 1; j <= temp; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();

                if (i >= 3)
                {
                    temp--;
                }
                else
                {
                    temp++;
                }
            }
            Console.WriteLine("=====================================================");
            temp = 4;
            int number, temp1 = 0;
            for (int i = 1; i <= 5; i++)
            {
                number = i;
                for (int j = 1; j <= 9; j++)
                {
                    if ((j <= temp) || (j > 9 - temp))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(number + " ");
                        if (j >= 5)
                        {
                            number--;
                        }
                        else 
                        {
                            number++;
                        }
                    }
                }
                temp--;
                Console.WriteLine();
            }
        }
    }
}