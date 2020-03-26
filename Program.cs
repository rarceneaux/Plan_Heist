using System;
using System.Collections.Generic;
using System.Linq;

namespace Plan_Heist
{
    class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Plan you Robbery Big Pat");

                List<Robber> robbers = new List<Robber>();

                var bankDifficulty = new Bank();

                while (true)
                {
                    Console.WriteLine("Please enter Robber Name");
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

                var numOfMember = robbers.Count();
                Console.WriteLine($"there are {numOfMember} members");

            //foreach (var robber in robbers)
            // {
            //    Console.WriteLine($"{robber.Name} has robbing skills of: {robber.SkillLevel} and courage factor of {robber.CourageFactor}");
            // }

            var sumOfMemberSkill = 0;

            foreach(var robber in robbers)
            {
                sumOfMemberSkill += robber.SkillLevel;
            }

            if(sumOfMemberSkill >=  bankDifficulty.BankDifficulty)
            {
                Console.WriteLine($"Randy is a bum");
            }
            else
            {
                Console.WriteLine($"Ray is going to jail for child support");
            }
            }
        }
    }

