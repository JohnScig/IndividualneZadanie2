using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class Race
    {
        public static Dictionary<int, Runner> Runners { get; set; } = new Dictionary<int, Runner>();
        //{ new Runner[ID] { ID = 12, Name = "John Doe", Age = 25, Gender = "Male", Country = "SK" }
        public static int NumOfLaps { get; set; } = 3;
        public static int LapsElapsed { get; set; } = 0;

        public static double LengthOfLap { get; set; }
        public static int PointsPositions { get; set; }
        public static DateTime StartOfRace { get; set; }
        public static DateTime EndOfRace { get; set; }


        public static bool CheckID(int id)
        {
            if ((Runners.ContainsKey(id)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int GetSomeID()
        {
            Random rand = new Random();
            int someID = rand.Next(1,999);
            while (!CheckID(someID))
            {
                //MessageBox.Show("ID already in use, checking next number");
                Race.CheckID(++someID);
            }
            return someID;
        }

        public static int GetRandomID()
        {
            Random rand = new Random();
            int someID = rand.Next(1, 999);
            while (!CheckID(someID))
            {
                //MessageBox.Show("ID already in use, checking next number");
                someID = rand.Next(1, 999);
            }
            return someID;
        }

    }
}
