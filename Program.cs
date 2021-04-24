using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> HeistMembers = new List<Member>();


            Console.WriteLine("Plan Your Heist!");
            while (true)
            {
                Console.WriteLine("What is your name?");
                string MemberName = Console.ReadLine();
                if (MemberName == "")
                {
                    break;
                }
                Console.WriteLine("Enter a skill level 1-30.");
                string MemberLevel = Console.ReadLine();
                int MemberLevelInt = Convert.ToInt32(MemberLevel);
                Console.WriteLine("Enter your courage level between 0.0 and 2.0");
                string MemberCourage = Console.ReadLine();
                double MemberCourageD = Convert.ToDouble(MemberCourage);

                HeistMembers.Add(new Member
                {
                    Name = ($"{MemberName}"),
                    Level = MemberLevelInt,
                    Courage = MemberCourageD,
                });


            }

            int BankLevel = 100;
            int LevelSum = 0;
            int TrialRuns;
            int Tries = 0;


            Console.WriteLine("How many heists do you want to attempt?");
            string Heists = Console.ReadLine();
            TrialRuns = Convert.ToInt32(Heists);
            Console.WriteLine($"{TrialRuns}");


            foreach (Member m in HeistMembers)
            {
                LevelSum += m.Level;

            }

            while (true)
            {
                if (Tries == TrialRuns)
                {
                    break;
                }
                else {
                int secretNumber = new Random().Next(-10, 10);
                BankLevel = BankLevel + secretNumber;

                if (LevelSum >= BankLevel)
                {
                    Console.WriteLine($"Team Skill Level: {LevelSum} Bank Difficulty Level: {BankLevel}");
                    Console.WriteLine("Heist Success!");
                }
                else
                {
                    Console.WriteLine($"Team Skill Level: {LevelSum} Bank Difficulty Level: {BankLevel}");
                    Console.WriteLine("Heist Fail!");
                }
                Tries++;
                Console.WriteLine();
                }
            }


        }
    }
}
