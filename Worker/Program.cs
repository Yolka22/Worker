using System;

namespace Worker
{
    internal class Program
    {
        private class Worker
        {
            protected string name;
            protected DateTime start;

            public Worker(string name, DateTime start)
            {
                this.name = name;
                this.start = start;
            }

            public virtual void Print()
            {
                Console.WriteLine("имя " + name);
                Console.WriteLine("имя " + start);
            }
        }

        private class President : Worker
        {
            private string job_title;

            public President(string name, DateTime start, string job_title) : base(name, start)
            {
                this.job_title = job_title;
            }

            public override void Print()
            {
                base.Print();
                Console.WriteLine("Должность " + job_title);
                Console.WriteLine();
            }

            private class Security : Worker
            {
                private string place_of_work;

                public Security(string name, DateTime start, string place_of_work) : base(name, start)
                {
                    this.place_of_work = place_of_work;
                }

                public override void Print()
                {
                    base.Print();
                    Console.WriteLine("Место работы " + place_of_work);
                    Console.WriteLine();
                }
            }

            private class Manager : Worker
            {
                private string group;

                public Manager(string name, DateTime start, string group) : base(name, start)
                {
                    this.group = group;
                }

                public override void Print()
                {
                    base.Print();
                    Console.WriteLine("Группа " + group);
                    Console.WriteLine();
                }
            }

            private class Engineer : Worker
            {
                private string work_expirience;

                public Engineer(string name, DateTime start, string work_expirience) : base(name, start)
                {
                    this.work_expirience = work_expirience;
                }

                public override void Print()
                {
                    base.Print();
                    Console.WriteLine("Стаж работы " + work_expirience);
                    Console.WriteLine();
                }
            }

            private static void Main(string[] args)
            {
                DateTime dateTime = DateTime.Now;

                President president = new President("Tom", dateTime, "President");
                Security security = new Security("John", dateTime, "office");
                Manager manager = new Manager("Ron", dateTime, "1");
                Engineer engineer = new Engineer("Fox", dateTime, "7");
                Worker[] workers = new Worker[] { president, security, manager, engineer };

                for (int i = 0; i < workers.Length; i++)
                {
                    workers[i].Print();
                }

                Console.ReadLine();
            }
        }
    }
}