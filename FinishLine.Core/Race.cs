using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class Race
    {
        #region Dictionaries and lists of racers

        public static Dictionary<int, Runner> Runners { get; set; } = new Dictionary<int, Runner>();
        public static Dictionary<int, List<DateTime>> RunnerLaps { get; set; } = new Dictionary<int, List<DateTime>>();
        public static List<int> WinningRunners { get; set; } = new List<int>();

        #endregion

        #region Parameters of the race
        public static int NumOfLaps { get; set; } = 3;
        public static int LapsElapsed { get; set; } = 1;
        public static double LengthOfLap { get; set; }
        public static int PointsPositions { get; set; }
        public static DateTime StartOfRace { get; set; }
        public static DateTime EndOfRace { get; set; }
        public static Runner Leader { get; set; }
        #endregion

        /// <summary>
        /// Method checks if given ID is unique in the Dictionary of runners.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Method gets the next higher unique ID
        /// </summary>
        /// <returns></returns>
        public static int GetSomeID()
        {
            int someID = 1;
            while (!Race.CheckID(someID))
            {
                Race.CheckID(++someID);
            }
            return someID;
        }

        /// <summary>
        /// Method gets the next unique random ID
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Method checks how many entries are in the racer's RunnerLaps dictionary. Based on that, the number of laps he has finished is returned.
        /// Returns a "W" if given racer has already finished the race.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static object GetCurrentLap(int id)
        {
            if (Race.CheckFinishedRace(Race.Runners[id]))
            {
                return "W";
            }

            if (RunnerLaps.ContainsKey(id))
            {
                return RunnerLaps[id].Count;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Method checks whether a racer is the race leader. If so, his delta is 0. If not, his delta time to the leader in the given lap is calculated.
        /// In case the runner is not on the same lap, the method indicates how many laps down they are.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
                    //TimeSpan delta = RunnerLaps[id].Last() - RunnerLaps[id][RunnerLaps.Values.Count-1];
                    TimeSpan delta = RunnerLaps[id].Last() - RunnerLaps[Leader.ID].Last();
                    return delta;
                }
                else
                {
                    return ("Down " + (RunnerLaps[Leader.ID].Count - RunnerLaps[id].Count) + " lap(s)");
                }
            }
            else
            {
                return TimeSpan.Zero;
            }

        }

        /// <summary>
        /// Method gets the runner's overall time as a difference of when he crossed the last lap line and when the race started.
        /// If they are on the first lap, it is zero.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Method calculates a special hidden value based on which the leaderboards are ordered.
        /// The value is 100*number of laps the runner is currently on minus overall time in years.
        /// This way, the leaderboards will only show bad numbers if the runners stay still for 100 years per lap, which is quite impossible.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static double GetOverallHiddenTime(int id)
        {

            if (Race.RunnerLaps[id].Count == 1)
            {
                return 0;
            }
            else
            {
                TimeSpan overallHiddenTime = RunnerLaps[id].Last() - Race.StartOfRace;
                return (Race.RunnerLaps[id].Count) * 100 - overallHiddenTime.TotalHours;

                //return ((Race.RunnerLaps[id].Count)*(-1)).ToString() + "," + (RunnerLaps[id].Last() - Race.StartOfRace).ToString();
                //TimeSpan overallHiddenTime = DateTime.Now - Race.StartOfRace;
                //return overallHiddenTime;
            }
        }

        /// <summary>
        /// Starts the race. The RunnerLaps Dictionary is populated with new values based on the Racers dictionary.
        /// </summary>
        public static void StartRace()
        {
            RunnerLaps.Clear();
            DateTime currentTime = DateTime.Now;

            foreach (int id in Runners.Keys)
            {
                RunnerLaps.Add(key: id, value: new List<DateTime>() { currentTime });
            }
        }

        /// <summary>
        /// Method checks if the runner sent as parameter is the leader of the race (based on if he has finished more laps than anybody else)
        /// If so, the LapsElapsed property of the race is increased, as the leader is always the first to start a new lap.
        /// </summary>
        /// <param name="runner"></param>
        public static void CheckRaceLeader(Runner runner)
        {
            if (RunnerLaps[runner.ID].Count > LapsElapsed)
            {
                LapsElapsed++;
                Leader = runner;
            }
        }

        /// <summary>
        /// Checks whether the runner has already finished the race by checking if he's in the list of winning racers.
        /// </summary>
        /// <param name="runner"></param>
        /// <returns></returns>
        public static bool CheckFinishedRace(Runner runner)
        {
            if (WinningRunners.Contains(runner.ID))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Method checks if the entire race is finished by checking how many runners have finished and whether that number is sufficient.
        /// </summary>
        /// <returns></returns>
        public static bool CheckEndOfRace()
        {
            if (WinningRunners.Count >= PointsPositions)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method checks if the runner finished the race. It checks the count of his RunnerLaps values and compares it to the number of necessary laps to end race.
        /// </summary>
        /// <param name="runner"></param>
        /// <returns></returns>
        public static bool CheckIsDone(Runner runner)
        {
            if (RunnerLaps[runner.ID].Count == NumOfLaps + 1)
            {
                WinningRunners.Add(runner.ID);
                return true;
            }

            return false;

        }

    }
}
