using System;
namespace Лаба_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите выражение: ");
                string str = Console.ReadLine();
                int  size = str.Length, sizen = str.Length / 2 + 1, sizes = str.Length / 2 + 1, j = 0, z = 0;
                char[] arrays = new char[sizes];
                int[] arrayn = new int[sizen];
                bool arror = true;
                int[] arraynumber = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                for(int i=0;i<size-1;i++)
                {
                    if (str[i] == '*' || str[i] == '/' || str[i] == '-' || str[i] == '+')
                    {
                        if (str[i+1] == '*' || str[i+1] == '/' || str[i+1] == '-' || str[i+1] == '+')
                        {
                            arror = false;
                        }
                    }
                }
                if (sizen > size / 2+1 && size%2==1)
                {
                   arror = false;               
                }
                if (sizen > size / 2  && size % 2 == 0)
                {
                    arror = false;
                }
                if (arror == true)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (str[i] == '*' || str[i] == '/' || str[i] == '-' || str[i] == '+')
                        {
                            arrays[j] = str[i]; j++;
                        }
                        else
                        {
                            arrayn[z] = Convert.ToInt32(str[i]) - 48; z++;
                        }
                    }
                    int buf;
                    for (int i = 0; i < sizen; i++)
                    {
                        if (arrays[i] == '^')
                        {
                            buf = Convert.ToInt32(Math.Pow(arrayn[i], arrayn[i + 1]));
                            if (i > 0 && arrays[i - 1] == '-')
                            {
                                arrayn[i] = 0; arrayn[i + 1] = buf; arrays[i] = '-';
                            }
                            else if (i > 0 && arrays[i - 1] == '+')
                            {
                                arrayn[i] = 0; arrayn[i + 1] = buf; arrays[i] = '+';
                            }
                            else if (i == 0)
                            {
                                arrayn[i] = 0; arrayn[i + 1] = buf; arrays[i] = '+';
                            }
                        }
                        else if (arrays[i] == '*')
                        {
                            buf = arrayn[i] * arrayn[i + 1];
                            if (i > 0 && arrays[i - 1] == '-')
                            {
                                arrayn[i] = 0; arrayn[i + 1] = buf; arrays[i] = '-';
                            }
                            else if (i > 0 && arrays[i - 1] == '+')
                            {
                                arrayn[i] = 0; arrayn[i + 1] = buf; arrays[i] = '+';
                            }
                            else if (i == 0)
                            {
                                arrayn[i] = 0; arrayn[i + 1] = buf; arrays[i] = '+';
                            }
                        }
                        else if (arrays[i] == '/')
                        {
                            buf = arrayn[i] / arrayn[i + 1];
                            if (i > 0 && arrays[i - 1] == '-')
                            {
                                arrayn[i] = 0; arrayn[i + 1] = buf; arrays[i] = '-';
                            }
                            else if (i > 0 && arrays[i - 1] == '+')
                            {
                                arrayn[i] = 0; arrayn[i + 1] = buf; arrays[i] = '+';
                            }
                            else if (i == 0)
                            {
                                arrayn[i] = 0; arrayn[i + 1] = buf; arrays[i] = '+';
                            }
                        }
                    }
                    int result = arrayn[0];
                    for (int i = 0; i < sizen; i++)
                    {
                        if (arrays[i] == '+')
                        {
                            result = result + arrayn[i + 1];
                        }
                        else if (arrays[i] == '-')
                        {
                            result = result - arrayn[i + 1];
                        }
                    }
                    Console.WriteLine(result);
                }
                else
                Console.WriteLine("В вашей записи есть ошибка ");
                Console.WriteLine("Если хотите повторить,нажмите'y' ");
                string repeat = Console.ReadLine();
                if (repeat[0] != 'y')
                {
                    break;
                }
            }
        }
    }
}

