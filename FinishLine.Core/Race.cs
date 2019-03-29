using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public static class Race
    {
        public static List<Runner> Runners { get; set; } = new List<Runner>() { new Runner() { ID = 12, Name = "John Doe", Age = 25, Gender = "Male", Country = "SK" } };

        public static bool CheckID(int id)
        {
            foreach (Runner runner in Runners)
            {
                if (runner.ID == id)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
