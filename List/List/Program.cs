using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqhw
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>() {
                new Person {Id = 1, Name="Иван", Age = 31, Sex = "male", Balance=400 },
                new Person {Id = 2, Name="Женя", Age = 24, Sex = "male", Balance=2100 },
                new Person {Id = 3, Name="Даша", Age = 22, Sex = "female", Balance=570 },
                new Person {Id = 4, Name="Леша", Age = 25, Sex = "male", Balance=14758 },
                new Person {Id = 5, Name="Соня", Age = 27, Sex = "female", Balance=4792 },
            };

            int old = persons.Max(x => x.Age);      //поиск самого старшего
            var oldestPerson = persons.Where(x => x.Age == old).Select(x=>x);
            foreach (Person p in oldestPerson)
            {

                Console.WriteLine($" самый старший - {p.Name} - {p.Age} лет");
                Console.ReadKey();
            }

            int reach = persons.Max(x => x.Balance);        //поиск самого богатого
            var reachestPerson = persons.Where(x => x.Balance == reach).Select(x => x);
            foreach (Person p in reachestPerson)
            {
                        Console.WriteLine($"самый богатый - {p.Name} - баланс {p.Balance}");
                        Console.ReadKey();

            }

            Console.WriteLine("самый взрослый и самый богатый");
            var oldandreach = persons.Where(x => x.Balance == reach || x.Age == old).Select(x => x);        //поиск самого старшего и самого богатого
            foreach (Person p in oldandreach)
            {
                Console.WriteLine($"{p.Name} - баланс {p.Balance}, возраст {p.Age}");
                

            }
            Console.ReadKey();

            Console.WriteLine("баланс больше 4 тысяч");
            var morethan4th = persons.Where(x => x.Balance > 4000).Select(x => x);      //поиск людей с доходом выше 4 тысяч
            foreach (Person p in morethan4th)
            {
                Console.WriteLine($"{p.Name} - баланс {p.Balance}");

            }
           Console.ReadKey();

            Console.WriteLine("сортировка по возрасту");
            var youngtoold = persons.OrderBy(x => x.Age).Select(x => x);
            foreach (Person p in youngtoold)
            {
                Console.WriteLine($"{p.Name} - возраст {p.Age}");

            }
            Console.ReadKey();

            Console.WriteLine("сортировка по полу");
            var sex = persons.OrderBy(x => x.Sex).Select(x => x);
            foreach (Person p in sex)
            {
                Console.WriteLine($"{p.Name} - пол {p.Sex}");

            }
            Console.ReadKey();
            Console.WriteLine("сортировка по балансу");
            var balance = persons.OrderByDescending(x => x.Balance).Select(x => x);
            foreach (Person p in balance)
            {
                Console.WriteLine($"{p.Name} - баланс {p.Balance}");

            }
            Console.ReadKey();

        }
    }
}
