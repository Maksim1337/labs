////Задание 1 Слова в обратом порядке
//using System;


//namespace Лаба_1
//{
//    class Program
//    {
//        static int Main(string[] args)
//        {
//        input_point:
//            Console.WriteLine("Введите строку");
//            string s = Console.ReadLine();
//            char[] buf = s.ToCharArray();
//            int sizebuf = s.Length;
//            char[] str = new char[sizebuf + 2];
//            str[0] = ' ';
//            for (int i = 0; i < sizebuf; i++)
//            {
//                str[i + 1] = buf[i];
//            }
//            int size = str.Length;
//            int finich = size;
//            for (int i = size - 1; i >= 0; i--)
//            {
//                if (str[i] == ' ')
//                {
//                    for (int j = i + 1; j < finich; j++)
//                    {
//                        Console.Write(str[j]);
//                    }
//                    Console.Write(" ");
//                    finich = i;
//                }
//            }
//            Console.WriteLine("\n Если хотите повторить , нажмите y");
//            string a=Console.ReadLine();
//            if (a[0] == 'y')
//                goto input_point;
//            else
//                return 0;



//        }
//    }
//}

//// Задание 2 Все буквы z после гласных менять на a
//using System;

//namespace Лаба_1
//{
//    class Program
//    {
//        static int Main(string[] args)
//        {
//            input_point:
//            Console.WriteLine("Введите строку");
//            string s = Console.ReadLine();
//            char[] str = s.ToCharArray();
//            int size = str.Length;
//            char[] bufarray = new char[] { 'a', 'e', 'y', 'u', 'i', 'O' };
//            for (int i = 0; i < size; i++)
//            {
//                if (str[i] == 'z')
//                {
//                    for (int j = 0; j < 5; j++)
//                    {
//                        if (str[i - 1] == bufarray[j])
//                        {
//                            str[i] = 'a';
//                        }
//                    }
//                }
//            }
//            Console.Write(str);
//            Console.WriteLine("\n Если хотите повторить , нажмите y");
//            string a = Console.ReadLine();
//            if (a[0] == 'y')
//                goto input_point;
//            else
//                return 0;
//        }
//    }
//}


////Задание 3 Вывести на экран рандомные 30 символов строки состоящей из 256 символов 
//using System;

//namespace Лаба_1
//{
//    class Program
//    {
//        static int getrandomnumber()
//        {
//            Random rnd = new Random();
//            int number = rnd.Next(0, 9);
//            return number;
//        }
//        static char getrandomletter()
//        {
//            Random rnd = new Random();
//            int number = rnd.Next(0, 26);
//            char latter = (char)('a' + number);
//            return latter;
//        }
//        static void Main(string[] args)
//        {
//            char[] str = new char[256];
//            for (int i = 0; i < 256; i++)
//            {
//                str[i] = getrandomletter();
//            }
//            for (int i = 0; i < 30; i++)
//            {
//                Console.Write(str[getrandomnumber()]);
//                Console.Write(" ");
//            }

//        }
//    }
//}

