using System;

namespace Лаба3
{
    class Human
    {
        private string name;
        private int age, height,iq;
        private double weight;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Human(int bufage , int bufheight, float bufweight,int bufiq)
        {
            age = bufage;
            height = bufheight;
            weight = bufweight;
            iq = bufiq;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name:{name}\nAge:{age}\nHeight:{height}\nWeight:{weight}\nIQ:{iq}\n");
        }

        public  int dailyCcal;

        public int DailyCcal
        {
            get
            {
                return  dailyCcal=(int)weight * 10 + height * 6 - age * 5;
            }
        }

        public int dailyread;
        
        public int Dailyread
        {
            get
            {
                return dailyread = age * 5;
            }
        }
        public int Runningnow(int runningnow,int run)
        {
            return runningnow + run;
        }
        public int Readnow(int readnow,int morningread)
        {
            return readnow + morningread;
        }
        public int Readnow(int readnow, int morningread,int eveningread)
        {
            return readnow + morningread + eveningread;
        }
        public int Readnow(int readnow, int morningread,int eveningread,int nightread)
        {
            return readnow + morningread + eveningread + nightread;
        }
        public int Run(int runningnow)
        {
            while(runningnow<dailyCcal)
            {
                Console.WriteLine($"\n1-Slowrunning(1hour) ,ccal 317");
                Console.WriteLine($"2-Middlerunning(1hour) ,ccal 765");
                Console.WriteLine($"3-Fastrunning(1hour) ,ccal 1511");
                Console.Write("Please,write the number: ");
                string number = Console.ReadLine();
                switch(number)
                {
                    case "1":
                        runningnow = Runningnow(runningnow, 337);
                        Console.WriteLine($"\nCcal now: {runningnow}");
                        break;
                    case "2":
                        runningnow = Runningnow(runningnow, 765);
                        Console.WriteLine($"Ccal now: {runningnow}");
                        break;
                    case "3":
                        runningnow = Runningnow(runningnow, 1511);
                        Console.WriteLine($"Ccal now: {runningnow}\n");
                        break;
                    default:
                        Console.WriteLine("\nArror,Please,write true.\n");
                        break;
                }    
            }
            return runningnow;
        }
        public int Read(int readnow,int morningread,int nightread,int eveningread)
        {
            while (readnow < dailyread)
            {
                Console.WriteLine($"\n1-Read Morning(10)");
                Console.WriteLine($"2-Read Morning(10),Evening(15)");
                Console.WriteLine($"3-Read Morning(10),Evening(15),Night(20)");
                Console.Write("Please,write the number: ");
                string number = Console.ReadLine();
                switch (number)
                {
                    case "1":
                        readnow = Readnow(readnow,morningread);
                        Console.WriteLine($"\nRead Now: {readnow}");
                        break;
                    case "2":
                        readnow = Readnow(readnow,morningread,eveningread);
                        Console.WriteLine($"Read Now): {readnow}");
                        break;
                    case "3":
                        readnow = Readnow(readnow,morningread,eveningread,nightread);
                        Console.WriteLine($"Read Now: {readnow}\n");
                        break;
                    default:
                        Console.WriteLine("\nArror,Please,write true.\n");
                        break;
                }
            }
            return readnow;
        }
        public double ProgressWeight(int runningnow)
         {
            int bufCcal = runningnow - dailyCcal;
            double  newweight = (double)bufCcal / 4000;
            weight -= newweight;
            return weight;
         }
        public int ProgressIq(int readnow)
        {
            int bufreadnow = readnow - dailyread;
            int newiq = (int)bufreadnow/5;
            iq+=newiq;
            return iq;
        }
        public void GetInfo(double newweight,int newiq)
        {
            Console.WriteLine($"Name:{name}\nAge:{age}\nHeight:{height}\nWeight:{newweight}\nIQ:{newiq}\n");
        }

    }
    class People
    {
        Human[] data;
        public People()
        {
            data = new Human[2];
        }
        public Human this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people[0] = new Human(18, 186, 82,130) { Name = "Maksim" };
            Human Maksim = people[0];
            Maksim.GetInfo();
            Console.WriteLine($"\nCalorie,ccal:{Maksim.DailyCcal}\nRead Pages: {Maksim.Dailyread}\n");
            int Maksimccalnow = 0;
            int Maksimreadnow = 0;
            int morningread = 10;
            int nightread = 20;
            int eveningread = 15;
            Maksimccalnow = Maksim.Run(Maksimccalnow);
            Maksimreadnow = Maksim.Read(Maksimreadnow,morningread,eveningread,nightread);
            double newweightMaksim=Maksim.ProgressWeight(Maksimccalnow);
            int newiqMaksim = Maksim.ProgressIq(Maksimreadnow);
            Console.WriteLine($"\nNew info:");
            Maksim.GetInfo(newweightMaksim,newiqMaksim);
            Console.ReadKey();

            Console.WriteLine($"\n\n---------New Human----------\n\n");

            people[1] = new Human(18, 194, 75,125) { Name = "Slava" };
            Human Slava = people[1];
            Slava.GetInfo();
            Console.WriteLine($"\nCalorie,ccal:{Slava.DailyCcal}\nRead Pages:{Slava.Dailyread}\n");
            int Slavaccalnow = 0;
            int Slavareadmow = 0;
            Slavaccalnow = Slava.Run(Slavaccalnow);
            Slavareadmow = Slava.Read(Slavareadmow, morningread, eveningread, nightread);
            double newweightSlava = Slava.ProgressWeight(Slavaccalnow);
            int newiqSlava = Slava.ProgressIq(Slavareadmow);
            Slava.GetInfo(newweightSlava,newiqSlava);
            Console.ReadKey();
        }
    }
}

