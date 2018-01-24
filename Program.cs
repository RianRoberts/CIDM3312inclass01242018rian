using System;

namespace SonofANickNameGeneraotr
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] nicknames = new string [10,2];

            // row 1, column 1
            nicknames[0,0] = "Dude";
            // row 1, column 2
            nicknames[0,1] = "Jones";

             // row 2, column 1
            nicknames[1,0] = "Snappy";
            // row 2, column 2
            nicknames[1,1] = "Firecracker";


            Console.WriteLine("Please enter your name");
            
            string name = Console.ReadLine();

            char[] nameparts = name.ToCharArray();

            for(int i = 0; i < nameparts.Length; i++){
                
            }


        }
    }
}