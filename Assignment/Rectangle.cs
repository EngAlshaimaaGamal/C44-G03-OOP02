using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Rectangle
    {

        #region Attributes

        private double height;

        private double weigth;

        private double area;

      


        #endregion

        #region Properties

        public double Heigth
        {
            set 
            {
                if( value >0)
                { 
                  height = value;


                }
                else
                {
                   Console.WriteLine("Heigth is not set yet, please set it first.");
                }


            }


            get { return height; }
        
        }

        public double Weigth
        {
            set 
            {
                if (value >0)
                {
                    weigth = value;
                }
                else
                {
                    Console.WriteLine("Weigth is not set yet, please set it first.");
                }
            }
            get { return weigth; }
        }  
        
        public double Area 
        {
            get // read only property
            { 
                return height * weigth; 



            }
        
        
        
        }


        #endregion

        #region Function

        public override string ToString()
        {
            return $"Rectangle: Height = {height}, Weigth = {weigth}, Area = {Area}";
        }


        #endregion


        #region Constructor

        public Rectangle(double height, double weigth) 
        {
            this.height = height;
            this.weigth = weigth;
        }

        #endregion



    }
}
