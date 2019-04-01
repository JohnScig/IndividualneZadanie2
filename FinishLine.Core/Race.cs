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
        public static Dictionary<int, List<DateTime>> RunnerLaps { get; set; } = new Dictionary<int, List<DateTime>>();

        //{ new Runner[ID] { ID = 12, Name = "John Doe", Age = 25, Gender = "Male", Country = "SK" }
        public static int NumOfLaps { get; set; } = 3;
        public static int LapsElapsed { get; set; } = 1;

        public static double LengthOfLap { get; set; }
        public static int PointsPositions { get; set; }
        public static DateTime StartOfRace { get; set; }
        public static DateTime EndOfRace { get; set; }

        public static Runner Leader { get; set; }

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
            int someID = rand.Next(1, 999);
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

        public static int GetCurrentLap(int id)
        {
            return RunnerLaps[id].Count;
        }

        public static object GetLapDeltaToLeader(int id)
        {
            if (Leader != null)
            {
                if (Leader.ID == id)
                {
                    return TimeSpan.Zero;
                }

                if (RunnerLaps[Leader.ID].Count == RunnerLaps[id].Count)
                {
                    TimeSpan delta = RunnerLaps[id].Last() - RunnerLaps[Leader.ID].Last();
                    return delta;
                }
                else
                {
                    return ("Down " + (RunnerLaps[Leader.ID].Count - RunnerLaps[id].Count) + " laps");
                }
            }
            else
            {
                return TimeSpan.Zero;
            }

        }

        public static TimeSpan GetOverallTime(int id)
        {

            if (Race.RunnerLaps[id].Count == 1)
            {
                return TimeSpan.Zero;
            }
            else
            {
                TimeSpan overallTime = RunnerLaps[id].Last() - Race.StartOfRace;
                return overallTime;
            }


            
        }

        public static void StartRace()
        {
            RunnerLaps.Clear();
            DateTime currentTime = DateTime.Now;

            foreach (int id in Runners.Keys)
            {
                RunnerLaps.Add(key: id, value: new List<DateTime>() { currentTime });
            }
        }

        public static void CheckRaceLeader(Runner runner)
        {
            if (RunnerLaps[runner.ID].Count > LapsElapsed)
            {
                LapsElapsed++;
                Leader = runner;
            }
        }





    }
}
