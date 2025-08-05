using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public struct Point
    {
        #region Attribute

        public int x;
        public int y;



        #endregion


        #region Constructor


        public Point() // Default Constructore
        {
            x = default;
            y = default;

        }
         public Point(int X, int Y)
        {

            this.x = X;
            this.y = Y;


        }
        public Point(int Y)
        {


            this.y = Y;


        }





        #endregion

        #region Functions

        public override string ToString()
        {
            return $"Point X {x} Point Y {y}";
        }


        #endregion




    }
}
