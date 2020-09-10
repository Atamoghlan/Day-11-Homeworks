using System;

namespace Day_11_Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string a = "";
            while (a != "Ф" || a != "Ф")
            {
                Console.WriteLine("Введите Ф, если вы Физическое лицо\nВведите Ю, если вы Юридическое лицо");
                a = Console.ReadLine();
                if (a == "Ф")
                {

                    Console.WriteLine("Введите количество клиентов");
                    int elements = Convert.ToInt32(Console.ReadLine());
                    Individual clientF = new Individual(elements);
                    for (int q = 0; q < elements; q++)
                    {        
                            Console.WriteLine($"{q + 1}-ый(ой) клиент\nВведите сумму депозита");
                            int b = (Convert.ToInt32(Console.ReadLine()));
                            clientF[q]= new Individual();
                            clientF[q].Sum = b;
                            clientF[q].NumOfAccount = q;
                            clientF[q].Date = "08.09.2020";
                            clientF[q].Percents();
                            clientF[q].issueofmoney();
                            clientF[q].DateOfAccountOpening();
                    }
                }
                else if (a == "Ю")
                {
                    Console.WriteLine("Введите количество клиентов");
                    int elements = Convert.ToInt32(Console.ReadLine());
                    Company clientY = new Company(elements);
                    for (int q = 0; q < elements; q++)
                    {
                            Console.WriteLine($"{q + 1}-ый(ой) клиент\nВведите сумму депозита");
                            int c = Convert.ToInt32(Console.ReadLine());
                            clientY[q] = new Company();
                            clientY[q].Sum = Convert.ToInt32(Console.ReadLine());
                            clientY[q].NumOfAccount = q;
                            clientY[q].Date = "08.09.2020";
                            clientY[q].Percents();
                            clientY[q].issueofmoney();
                            clientY[q].DateOfAccountOpening();       
                    }
                }

                else
                { Console.WriteLine("Ошибка!"); }
            }
        }
        public class Account
        {
            private int sum;
            public int Sum
            {
                get { return sum; }
                set { sum = value; }
            }
            public int NumOfAccount { get; set; }
            public string Date { get; set; }
            public Account() { }


            public Account(int sum, int accountnum, string date) { Sum = sum; accountnum = NumOfAccount; Date = date; }
            public void issueofmoney() { Console.WriteLine($"Сумма:{Sum} Номер аккаунта:{NumOfAccount}"); }
            public void DateOfAccountOpening() { Console.WriteLine($"Дата открытия счета:{Date}"); }

        }
        public class Individual : Account
        {

            public string AccountType { get; set; }
            Individual[] data;
            public Individual this[int index]
            {
                get
                {
                    return data[index];
                }
                set { data[index] = value; }

            }
            public Individual() { }
            public Individual(int index) { this.data = new Individual[index]; }
            public Individual(int sum, int accountnum, string date, string accounttype) : base(sum, accountnum, date)
            { AccountType = accounttype; base.Sum = sum; }
            public void Percents()
            {
                double percent;
                double FinalSum;
                if (Sum <= 10000)
                {
                    AccountType = "classic";
                    percent = 1.03;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам по тарифу Classic 3% годовых. По окончанию срока вы получите {FinalSum} ");
                }
                else if (Sum <= 50000)
                {
                    AccountType = "premium";
                    percent = 1.05;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам по тарифу Premium 5% годовых. По окончанию срока вы получите {FinalSum} ");
                }
                else if (Sum > 50000)
                {
                    AccountType = "gold";
                    percent = 1.08;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам по тарифу Gold 8% годовых. По окончанию срока вы получите {FinalSum} ");
                }
            }

            public void CashOut()
            {
                Console.WriteLine("Введите сумму вывода");
                int s = Convert.ToInt32(Console.ReadLine());
                base.Sum = base.Sum - s;
                Console.WriteLine($"Осталось средств: {base.Sum}");
            }

        }
        public class Company : Account
        {
            public Company() { }
            public Company this[int index]
            {
                get
                {
                    return data[index];
                }
                set { data[index] = value; }

            }
            Company[] data;

            public Company(int index) { this.data = new Company[index]; }
            public Company(int sum, int accountnum, string date, int percentmethod)
            : base(sum, accountnum, date)
            {

            }
            public void Percents()
            {
                double percent;
                double FinalSum;
                if (Sum <= 10000)
                {
                    percent = 1.03;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам 3% годовых. По окончанию срока вы получите {FinalSum} ");
                }
                else if (Sum <= 50000)
                {
                    percent = 1.05;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам 5% годовых. По окончанию срока вы получите {FinalSum} ");
                }
                else if (Sum > 50000)
                {
                    percent = 1.08;
                    FinalSum = Sum * percent;
                    Console.WriteLine($"Предлагаем Вам 8% годовых. По окончанию срока вы получите {FinalSum} ");
                }
            }
        }
    }
}

