using System;
using System.Collections.Generic;
using System.Linq;


namespace Plan_Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Robbery Project Pat");

            var robbers = new List<Robber>();

            var bankDifficulty =  new Bank();

            while (true)
            {
                Console.WriteLine("Please enter robber Name");
                var robberName = Console.ReadLine();
                if (robberName == "") break;

                Console.WriteLine("Please enter robber's skill level between 0 to 50.");
                var robberSkillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter robber's courage factor 0.0 to 2.0");
                var robberCourageFactor = decimal.Parse(Console.ReadLine());

                var robber = new Robber
                {
                    Name = robberName,
                    SkillLevel = robberSkillLevel,
                    CourageFactor = robberCourageFactor
                };

            robbers.Add(robber);
            }

            Console.WriteLine("Please enter the # of trail runs this app should person");
            var trialRuns = int.Parse(Console.ReadLine());
           for (int i = 0; i < trialRuns; i++)
            {
                RobTheBank(bankDifficulty, robbers);
            }


            var numOfMember = robbers.Count();
                Console.WriteLine($"There are {numOfMember} members of the North Memphis Vice Lords");

            foreach (var robber in robbers)
            {
                Console.WriteLine($"{robber.Name} has robbing skills of: {robber.SkillLevel} and courage factor of {robber.CourageFactor}");
            }

            //Create a random number between - 10 and 10 for the heist's luck value.
            //Add this number to the bank's difficulty level.
            //Before displaying the success or failure message, display a report that shows.
            // The team's combined skill level
            // The bank's difficulty level


            //Run the scenario multiple times.
                //After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
                //Loop through the difficulty and skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.

                Console.WriteLine("Please enter the # of trail runs this app should person");
           
        }

        public static void RobTheBank(Bank bankDifficulty, List<Robber> robbers)
        {
            var rng = new Random();
            var heistLuck = rng.Next(-10, 10);

            var bankDifficultyWithLuck = bankDifficulty.BankDifficulty + heistLuck;

            //var sumOfMemberSkill = 0;
            //foreach(var robber in robbers)
            //{
            //    sumOfMemberSkill += robber.SkillLevel;
            //}
            var sumOfMemberSkill = robbers.Sum(robber => robber.SkillLevel);


            Console.WriteLine($"The Vice Lords have a total robbing skill set of {sumOfMemberSkill}");
            Console.WriteLine($"This robbery has a robbing difficulty of {bankDifficultyWithLuck}");

            if (sumOfMemberSkill >= bankDifficultyWithLuck)
            {
                Console.WriteLine($"Make the Hood Trap Again-Winning");
            }
            else
            {
                Console.WriteLine($"The Trap is over-Losing");
            }
        }
    }
}

