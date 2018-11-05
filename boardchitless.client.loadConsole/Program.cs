using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardChitless.client.loadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dat = DateTime.Now;
            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            Console.Write("\nAvailable Commands:  XMLByID, RefBySearch, RunALetter, RefByID, FullLoadByID, exit");

            Program prog = new Program();

            while (true) // Loop indefinitely
            {
   
                Console.Write("\n\nCommand: ");
                string line = Console.ReadLine();
                line = line.ToLower();

                Console.Write("\nReceived: " + line );

                if (line == "xmlbyid")
                {

                    Console.Write("\nGame ID? ");
                    string GameID = Console.ReadLine().Trim();

                    var status = prog.pullRaw(Int32.Parse(GameID));
                    //prog.storeRawInDB(Int32.Parse(GameID), xml);
                    Console.Write(status);

                }
  
                else if (line == "refbysearch")
                {

                    Console.Write("\nWhat would you like to search for? ");
                    string GameName = Console.ReadLine().Trim();

                    var status = prog.pullAList(GameName);

                    

                    Console.Write(status);

                }
                else if (line == "refbysearch")
                {

                    Console.Write("\nWhat would you like to search for? ");
                    string GameName = Console.ReadLine().Trim();

                    var status = prog.pullAList(GameName);

                    

                    Console.Write(status);

                }

                else if (line == "runaletter")
                {

                    Console.Write("\nWhich letter? ");
                    string letter = Console.ReadLine().Trim();

                    Console.Write("\nStarting at " + DateTime.Now.ToString() + ":\n");
                    prog.pullALetter(letter);


                    Console.Write("\nDone at " + DateTime.Now.ToString() + ".");

                }
                else if (line == "exit")
                {
                    break;
                }
                else {
                    Console.Write("\nUnrecognized Command.");
                }

            }

            //string end = Console.ReadLine();

        }



        public string pullRaw(long GameID) {

            Console.Write("Executing");
            var LM = new BoardChitless.Manager.BoardGameGeekLoader();

            try
            {

                Console.Write(".");
                string rtn = LM.pullXMLbyIDAndSaveToDatabase(GameID.ToString());
                Console.Write(".");
         
                Console.Write(".");

                return "Done!";
            }
            catch {
                return "Error";
            }

        }

        public string pullAList(string searchGame)
        {

           // Console.Write("Executing");
            var LM = new BoardChitless.Manager.BoardGameGeekLoader();

            try
            {
                var rtn = LM.searchAndSaveAllReferences(searchGame);
                if (rtn == "TimeOut")
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("+");
                }
                return rtn;
            }
            catch
            {
                Console.Write("-");
                return "Error!";
            }

        }

        public string pullALetter(string letter)
        {

                               
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    var letterToRun = letter + c.ToString().ToLower();
                    Console.Write(letterToRun + ".");
                    var status = pullAList(letterToRun);

                    if (status == "TimeOut" && letterToRun.Length <= 2)
                    {
                        Console.Write("\n");
                        pullALetter(letterToRun);
                        Console.Write("\n");
                    }
                }

                for (int i = 0; i <= 9; i++)
                {
                    var letterToRun = letter + i.ToString().ToLower();
                    Console.Write(letterToRun + ".");
                    var status = pullAList(letterToRun);

                    if (status == "TimeOut" && letterToRun.Length <= 2)
                    {
                        Console.Write("\n");
                        pullALetter(letterToRun);
                        Console.Write("\n");
                    }

                }
                Console.Write("---Done");
                return "Done";
            
        }



    }
}