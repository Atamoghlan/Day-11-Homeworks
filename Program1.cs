using System;

namespace Day_11_Задание_1
{
    class Student
    {
        public string Lastname { get; set; }

        public int Course { get; set; }
        public int CreditBookNumber { get; set; }
        public Student() { }
        public Student(string lastname, int course, int creditbooknumber)
        {
            Lastname = lastname; Course = course; CreditBookNumber = creditbooknumber;

        }
        public virtual void Print()
        { Console.WriteLine($"Студент {Lastname}учится на {Course}-ом(ем) курсе. Номер зачетной книги: {CreditBookNumber}"); }

    }
    class Aspirant : Student
    {
        public int Dissertation { get; set; }
        public Aspirant() { }
        public Aspirant(string lastname, int course, int creditbooknumber, int dissertation)
        : base(lastname, course, creditbooknumber)
        {
            Dissertation = dissertation;
        }
        public new void Print()
        { Console.WriteLine($"Студент {Lastname} учится на {Course}-ом(ем) курсе. Номер зачетной книги: {CreditBookNumber}. Номер диссертации: {Dissertation}"); }

    }
    class Program
    {
        public static void Main()
        {
            Student Atamoghlan = new Student();
            Aspirant Araz = new Aspirant();
            string answer = "";
            while (answer != "S" || answer != "A")
            {
                Console.WriteLine("Студент (Введите S) или Аспирант (Введите A)?");
                answer = Console.ReadLine();
                if (answer == "S")
                {
                    while (Atamoghlan.Lastname == null || Atamoghlan.Lastname.Length < 2 || Atamoghlan.Lastname.Length > 30)
                    {
                        Console.WriteLine("Введите фамилию студента");
                        Atamoghlan.Lastname = Console.ReadLine();
                        if (Atamoghlan.Lastname != null && Atamoghlan.Lastname.Length > 2 && Atamoghlan.Lastname.Length < 30)
                        { continue; }
                        else
                        {
                            Console.WriteLine("Ошибка! Фамилия должна состоять из английских букв и быть не длиннее 30-ти символов");
                        }
                    }
                    while (Atamoghlan.Course < 1 || Atamoghlan.Course > 5)
                    {
                        Console.WriteLine("Введите курс студента");
                        Atamoghlan.Course = Convert.ToInt32(Console.ReadLine());
                        if (Atamoghlan.Course > 1 && Atamoghlan.Course < 6)
                        { continue; }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    while (Atamoghlan.Course < 1 || Atamoghlan.Course > 5)
                    {
                        Console.WriteLine("Введите номер зачетной книги");
                    Atamoghlan.CreditBookNumber = Convert.ToInt32(Console.ReadLine());
                        if (Atamoghlan.Course > 1 && Atamoghlan.Course < 10000)
                        { continue; }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    Atamoghlan.Print();

                }

                else if (answer == "A")
                {
                    while (Atamoghlan.Lastname == null || Atamoghlan.Lastname.Length < 2 || Atamoghlan.Lastname.Length > 30)
                    {
                    Console.WriteLine("Введите фамилию аспиранта");
                    Araz.Lastname = Console.ReadLine();
                        if (Araz.Lastname != null && Araz.Lastname.Length > 2 && Araz.Lastname.Length < 30)
                        { continue; }
                        else
                        {
                         Console.WriteLine("Ошибка! Фамилия должна состоять из английских букв и быть не длиннее 30-ти символов");
                        }
                    }
                    while (Atamoghlan.Course < 1 || Atamoghlan.Course > 5)
                    {
                        Console.WriteLine("Введите курс аспиранта");
                    Araz.Course = Convert.ToInt32(Console.ReadLine());
                        if (Atamoghlan.Course > 1 && Atamoghlan.Course < 6)
                        { continue; }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    while (Araz.CreditBookNumber < 1 || Araz.CreditBookNumber > 10000)
                    {
                        Console.WriteLine("Введите номер зачетной книги");
                        Araz.CreditBookNumber = Convert.ToInt32(Console.ReadLine());
                        if (Araz.CreditBookNumber > 1 && Araz.CreditBookNumber < 10000)
                        { continue; }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    while (Araz.Dissertation < 1 || Araz.Dissertation > 10000)
                    {
                    Console.WriteLine("Введите номер диссертации");
                    Araz.Dissertation = Convert.ToInt32(Console.ReadLine());
                        if (Araz.Dissertation > 1 && Araz.Dissertation < 10000)
                        { continue; }
                        else { Console.WriteLine("Ошибка!"); }
                    }
                    Araz.Print();
                }
                else
                {
                    Console.WriteLine("Введите Студент или Аспирант");
                }
            }
        }
    }
}

