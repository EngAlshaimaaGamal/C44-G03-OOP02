using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public struct Person
    {
        #region Property

        public string[]? Name { get; set; }

        public int[]? Age { get; set; }




        #endregion

        #region Constructor

        public Person(string[]? name, int[]? age)
        {
            Name = name;
            Age = age;
        }


        #endregion

        #region indexer

        public string this[int index]
        {
            get
            {
                return $"{Name?[index]} is {Age?[index]} years old";    


            }
        
        }


        #endregion



    }
}
