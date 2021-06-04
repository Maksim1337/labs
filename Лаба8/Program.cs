using System;

namespace Лаба_3_5_6_8
{
    class University
    {
        private FacultyStudent[] data;
        public University()
        {
            data = new FacultyStudent[2];
        }
        public FacultyStudent this[int index]
        {
            set
            {
                data[index] = value;
            }

            get
            {
                return data[index];
            }
        }

        public void AllInfo()
        {
            Console.WriteLine($"");
        }
    }

    class Human
    {
        public string name;

        public Human()
        {
            Console.WriteLine("Write name:");
            name = Console.ReadLine();
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name:{name}");
        }
    }

    class Student : Human
    {
        protected int id;
        public Student() : base()
        {
            Console.WriteLine("Write id:");
            id = Convert.ToInt32(Console.ReadLine());
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Student name:{name}\nid:{id}");
        }
    }

    class FacultyStudent : Student
    {
        public string faculty;

        enum Faculty
        {
            KSiS = 1,
            FKP,
            FITY
        }

        public FacultyStudent() : base()
        {
            Console.WriteLine("Choose a faculty:\n1.KSiS\n2.FKP\n3.FITY");
            int cheack = Convert.ToInt32(Console.ReadLine());
            switch (cheack)
            {
                case 1: faculty = Faculty.KSiS.ToString(); break;
                case 2: faculty = Faculty.FKP.ToString(); break;
                case 3: faculty = Faculty.FITY.ToString(); break;
                default: faculty = "NoFaculty"; break;
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Student name:{name}\nid:{id}\nFaculty:{faculty}");
        }
    }


    public interface IStart
    {
        void Start();
    }


    struct Game
    {
        public void Start()
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("\nGame Started between students'Rock Paper Scissors'");
        }

        public void StartGame()
        {
            Console.WriteLine("Game over");
        }

        public void StartGame(string name, string name2)
        {
            Random rnd = new Random();
            int cheack = rnd.Next(0, 2);
            if (cheack == 0)
            {
                Console.WriteLine($"Студент:{name} Выиграл!");
            }
            else if (cheack == 1)
            {
                Console.WriteLine($"Студент:{name2} Выиграл!");
            }
        }
    }

    class Wastepaper
    {

        public delegate void paper(string message);
        public event paper Notify; 

        public Wastepaper(int sum)
        {
            Sum = sum;
        }

        public int Sum { get; private set; }

        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"more wastefulness: {sum}");   
        }

        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"decreased waste: {sum}");  
            }
            else
            {
                Notify?.Invoke($"Not enough paperwork, current balance: {Sum}"); ;
            }
        }

        class Program
        {
            delegate void Message();



            static void Main(string[] args)
            {
                int time;
                Message mes;
                Console.WriteLine("\nEnter the current hour of time:");
                time = Convert.ToInt32(Console.ReadLine());
                if (time < 12)
                {
                    mes = GoodMorning;
                    mes();
                }
                else if (time > 12)
                {
                    mes = GoodEvening;
                    mes();
                }

                Console.WriteLine("\n-------Human--------");
                Human human = new Human();
                human.GetInfo();

                Console.WriteLine("\n-------Student--------");
                Student student = new Student();
                student.GetInfo();

                Console.WriteLine("\n-------Faculty Student--------");
                University university = new University();
                university[0] = new FacultyStudent();
                university[0].GetInfo();
                Console.WriteLine("\n-------New Student--------");
                university[1] = new FacultyStudent();
                university[1].GetInfo();

                Wastepaper acc = new Wastepaper(100);
                acc.Notify += DisplayMessage;
                acc.Put(100);
                Console.WriteLine($"Macculature at the university: {acc.Sum}");
                acc.Take(70);   
                Console.WriteLine($"Сумма на счете: {acc.Sum}");
                acc.Take(180);  
                Console.WriteLine($"Macculature at the university: {acc.Sum}");

                int gamecheack = 0;
                Game game;
                game.Start();
                while (gamecheack == 0)
                {
                    Console.WriteLine("\n------------------------------------------");
                    Console.WriteLine("\nSelect an action\n1.Play one game\n2.Finish the game");
                    Console.WriteLine("\n------------------------------------------");
                    int cheack = Convert.ToInt32(Console.ReadLine());
                    switch (cheack)
                    {
                        case 1: game.StartGame(university[0].name, university[1].name); break;
                        case 2: game.StartGame(); gamecheack = 1; break;
                    }
                }

                Console.ReadKey();
            }

            private static void GoodMorning()
            {
                Console.WriteLine("\nGood Morning");
            }

            private static void GoodEvening()
            {
                Console.WriteLine("\nGood Evening");
            }

            private static void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }
        }

    }
}