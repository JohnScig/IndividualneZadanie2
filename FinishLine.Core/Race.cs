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


            //foreach (Runner runner in Runners)
            //{
            //    if (runner.ID == id)
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }

    }
}
