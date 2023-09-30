namespace Darkest_Party_Randomizer
{
    internal class DD2_Party_Shuffler
    {
        static void Main()
        {
            Random rng = new();

            string[,] Heroes_Path = { { "Plague Doctor", "Surgeon", "Alchemist", "Physician" },
                                      { "Grave Robber", "Deadeye", "Venomdrop", "Nightsworn" },
                                      { "Highwayman", "Rogue", "Sharpshot", "Yellowhand" },
                                      { "Man-at-arms", "Sergeant", "Bulwark", "Vanguard" },
                                      { "Hellion", "Ravager", "Berserker", "Carcass" },
                                      { "Runaway", "Arsonist", "Survivor", "Orphan" },
                                      { "Jester", "Virtuoso", "Soloist", "Intermezzo" },
                                      { "Leper", "Tempest", "Poet", "Monarch" },
                                      { "Occultist", "Ritualist", "Warlock", "Aspirant" },
                                      { "Vestal", "Confessor", "Chaplain", "Seraph" },
                                      { "Flagellant", "Maniac", "Exanimate", "Scourge" }
                                    };

            bool IsRunning = true;
            while (IsRunning == true)
            {
                Console.WriteLine("\n-- Welcome to Darkest Party Randomizer! --");
                Console.WriteLine("");
                Console.WriteLine("Exit    Shuffle party");
                Console.WriteLine("(1)     (2)");
                Console.Write("So, what do we do? :) ");

                string? input = Console.ReadLine();

                try
                {
                    if (input != "2")
                    {
                        Console.Clear();
                        Console.WriteLine("(!) Invalid input. Try again.");
                    }

                    switch (input)
                    {
                        case "2":
                            Console.Clear();
                            PartyShuffle();
                            break;

                        case "1":
                            Console.Clear();
                            Console.WriteLine("\nGood luck with that one!");
                            IsRunning = false;
                            break;
                    }

                }
                catch
                {
                    
                }

                void PartyShuffle()
                {
                    Console.WriteLine("How about...");
                    int i = 0;
                    int r = 1;
                    int rnd_hero;
                    int rnd_path;
                    int party = 4;
                    int hpLength = Heroes_Path.GetLength(0);
                    int hpWidth = Heroes_Path.GetLength(1);
                    List<int> Used_Heroes = new();
                    while (i < party)
                    {
                        rnd_hero = rng.Next(0, hpLength - 1);
                        rnd_path = rng.Next(1, hpWidth - 1);
                        if (Used_Heroes.Contains(rnd_hero))
                        {
                            continue;
                        }
                        else
                        {
                            Used_Heroes.Add(rnd_hero);
                            Console.WriteLine("Rank " + r + " - " + Heroes_Path[rnd_hero, 0] + " " + "(" + Heroes_Path[rnd_hero, rnd_path] + ")");
                            i++; r++;
                        }
                    }
                }              
            }
        }
    }
}