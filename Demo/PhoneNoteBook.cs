using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal struct PhoneNoteBook
    {
        #region Attribute
         public string[]? Name;
         public int[]? PhoneNumber;
         public int size;


        #endregion
        #region Property
         public int Size
            {
                get { return size; }
        
            }




        #endregion

        #region indexer

        public int this[string name]
           {
            get{
                if (Name is not null && PhoneNumber is not null)
                
                    for (int i = 0; i < Name.Length; i++)
                        if (Name[i] == name)
                            return PhoneNumber[i];



                    return -1; // Return -1 if the name is not found



                
            }


            set
            {
                if (Name is not null && PhoneNumber is not null)
                
                    for (int i = 0; i < Name.Length; i++)
                    
                        if (Name[i] == name)
                        {
                            PhoneNumber[i] = value;
                            return; // Exit the function after updating the number

                        }



                    


                






            }
        }
            
        

        public string this[int index]
        {
            get 
            {
                return $" page  : {index} ,  name {Name[index]}  , number :: {PhoneNumber[index]} ";
            
            }
        
        }
        
            
            


        #endregion

        #region Functions

        public void AddNewPersone(int position, int number, string name)
        {


            if (Name is not null && PhoneNumber is not null) 
            {
                if (position < size && position >= 0)
                {
                    Name[position] = name;
                    PhoneNumber[position] = number;

                }
            
            
            }
            
        
        
        }

        #region Getter


        // function Search By Name
        public int GetPhoneNumber(string name)
        {
            if (Name is not null && PhoneNumber is not null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (Name[i] == name)
                    {
                        return PhoneNumber[i];

                    }



                }



            }
            return -1;



        }

        #endregion


        #region Setter

        public void SetNumber(int number, string NewName)
        {
            if (Name is not null && PhoneNumber is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name[i] == NewName)
                    {
                        PhoneNumber[i] = number;
                        return; // Exit the function after updating the number

                    }



                }


            }



        }


        #endregion





        #endregion


        #region Constructor
        public PhoneNoteBook(int size) 
        {
            this.size = size;
            Name = new string[size];
            PhoneNumber = new int[size];




        }



        #endregion


    }
}
