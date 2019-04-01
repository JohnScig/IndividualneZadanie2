using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Runner
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int ID { get; set; }

        /// <summary>
        /// Basic modification function.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="country"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="id"></param>
        public void ModifyRunner (string name, string country, int age, string gender, int id)
        {
            Name = name;
            Country = country;
            Age = age;
            Gender = gender;
            ID = id;
        }

        /// <summary>
        /// To string function formated for easy reading from a text file.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return (ID + "\t" + Name + "\t" + Country + "\t" + Age + "\t" + Gender);
        }

    }
}
