using System;

namespace B1L4One_List_to_list_em_all
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beheind the scene's
            string[] pc = {
                "World of Warcraft", 
                "Heroes of the Storm", 
                "Hearthstone", "Overwatch"
                };

            string[] Switch = {
                "Super smash bros ultimate"
                };

            string[] WiiU = {
                "Xenoblade chronicles X"
            };

            string[] Dds = {
                "Pokemon X"
            };

            string[] Ds = {
                "Pokemon White"
            };

            string[] Wii = {
                "The Legend of Zelda: Skyward sword"
            };

            string[] Gamecube = {
                "Mario party 5"
            };

            //Console log part 1
            Console.Clear();
            Console.WriteLine("All the video games I own ATM");
            Console.WriteLine("Select a number of the console");
            Console.WriteLine("1. PC");
            Console.WriteLine("2. Switch");
            Console.WriteLine("3. Wii U");
            Console.WriteLine("4. 3DS");
            Console.WriteLine("5. DS");
            Console.WriteLine("6. Wii");
            Console.WriteLine("7. Gamecube");
            Console.WriteLine("8. Everything");
            Console.WriteLine("9. Quit");

            Console.WriteLine("");
            String GameConsoles = Console.ReadLine();

            //Console log part 2
            //PC
            if (GameConsoles == "1") {
                Console.WriteLine("");
                foreach(string item in pc) {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            } 
            
            //Switch
            else if (GameConsoles == "2"){
                Console.WriteLine("");
                foreach(string item in Switch) {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            }
            
            //Wii U
            else if (GameConsoles == "3"){
                Console.WriteLine("");
                foreach(string item in WiiU) {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            }

            //3Ds
            else if (GameConsoles == "4"){
                Console.WriteLine("");
                foreach(string item in Dds) {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            }
            
            //Ds
            else if (GameConsoles == "5"){
                Console.WriteLine("");
                foreach(string item in Ds) {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            }
            
            //Wii
            else if (GameConsoles == "6"){
                Console.WriteLine("");
                foreach(string item in Wii) {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            }
            
            //Gamecube
            else if (GameConsoles == "7"){
                Console.WriteLine("");
                foreach(string item in Gamecube) {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            } 
            
            //All my games
            else if (GameConsoles == "8"){
                Console.WriteLine("");
                Console.WriteLine("----------PC----------");
                foreach(string item in pc) {
                    Console.WriteLine(item);
                }

                Console.WriteLine("");
                Console.WriteLine("----------Switch----------");
                foreach(string item in Switch) {
                    Console.WriteLine(item);
                }

                Console.WriteLine("");
                Console.WriteLine("----------Wii U----------");
                foreach(string item in WiiU) {
                    Console.WriteLine(item);
                }

                Console.WriteLine("");
                Console.WriteLine("----------3DS----------");
                foreach(string item in Dds) {
                    Console.WriteLine(item);
                }

                Console.WriteLine("");
                Console.WriteLine("----------DS----------");
                foreach(string item in Ds) {
                    Console.WriteLine(item);
                }

                Console.WriteLine("");
                Console.WriteLine("----------Wii----------");
                foreach(string item in Wii) {
                    Console.WriteLine(item);
                }

                Console.WriteLine("");
                Console.WriteLine("----------Gamecube----------");
                foreach(string item in Gamecube) {
                    Console.WriteLine(item);
                }
                Console.WriteLine("");
            } 
            
            else {
                Console.WriteLine("Please enter a number that is availeble");
            }
        }
    }
}
