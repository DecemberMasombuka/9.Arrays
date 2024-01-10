using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OnewayAtributte way of creating an array
            int[] luckyNumbers = { 4, 6, 12, 8, 90, 5, };
            Console.WriteLine("enter the postion of the number 8");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(luckyNumbers[userGuess]);

            //Create an array and dont store anything yet
            String[] friends = new string[5];

            //Store items in the array
            friends[0] = "Jim";
            friends[1] = "Abednigo";
            friends[2] = "Chris";
            friends[3] = "Mabena";
            friends[4] = "Lucky";

            String[] songs = {"S","O","P" };
            Console.WriteLine(songs[0]);
            //print the item stored in position 4 
            Console.WriteLine(friends[4]);
            Console.Read();

        }
    }
}
