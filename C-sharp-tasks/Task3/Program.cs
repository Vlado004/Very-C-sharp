using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {

        enum accountType
        {
            Stednja,
            Tekuci,
            Ziro
        }

        struct BankAccount
        {
            public BankAccount(long accountNumber, double value, accountType type)
            {
                this.accountNumber = accountNumber;
                this.value = value;
                this.type = type;
            }

            public long accountNumber { get; }
            public double value { get; }
            public accountType type { get; }
        }

        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>() {
                new BankAccount(10, 150, accountType.Tekuci),
                new BankAccount(20, 1000, accountType.Stednja),
                new BankAccount(30, 0, accountType.Tekuci),
                new BankAccount(40, 37, accountType.Tekuci),
                new BankAccount(50, 25000, accountType.Ziro),
            };
            
            int choice;

            while (true)
            {
                Console.WriteLine("1. Dodaj novi racun\n2. Ispisi sve racune\n3. Izlaz");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Unesite valjani broj!");
                    Console.WriteLine("1. Dodaj novi racun\n2. Ispisi sve racune\n3. Izlaz");
                }

                switch(choice)
                {
                    case (1):
                        long newAcountNumber;
                        Console.WriteLine("Unesite broj racuna");
                        while (!long.TryParse(Console.ReadLine(), out newAcountNumber) || newAcountNumber < 1)
                        {
                            Console.WriteLine("Unesite valjani broj!");
                        }

                        int typeChoice;
                        Console.WriteLine("Odaberite vrstu racuna\n1. Stednja\n2. Tekuci\n3. Ziro");
                        while (!int.TryParse(Console.ReadLine(), out typeChoice) || typeChoice < 1 || typeChoice > 3)
                        {
                            Console.WriteLine("Unesite valjani broj!");
                            Console.WriteLine("Odaberite vrstu racuna\n1. Stednja\n2. Tekuci\n3. Ziro");
                        } 

                        accountType newType;
                        if (typeChoice == 1)
                            newType = accountType.Stednja;
                        else if (typeChoice == 2)
                            newType = accountType.Tekuci;
                        else
                            newType = accountType.Ziro;

                        accounts.Add(new BankAccount(newAcountNumber, 0, newType));
                        break;

                    case (2):
                        foreach (BankAccount acc in accounts)
                        {
                            Console.WriteLine($"Racun br. {acc.accountNumber}, ima {acc.value:C} te je {acc.type} racun");
                        }
                        break;

                    case (3):
                        Console.WriteLine("Dovidenja");
                        return;
                }
            }
        }
    }
}