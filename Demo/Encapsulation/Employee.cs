using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {

        #region Attributes


        private string? name;
        private int age;
        private int id;
       private decimal salary;

        #endregion

        //region Apply Encapsulation By using Properties (new Approch)
        // private attributes
        // using Getter / Setter  or Property 

        #region Apply Encapsulation By using Stter / Getter (old Approch)

        public string? GetName()
        {
            return name;
        }

        public void setName(string?  Name)
        {
            // validation   
            Name = Name? .Length>10 ? Name.Substring(0, 10) : Name; // if the name is more than 10 char we will take only the first 10 char
            this.name = Name;

        }




        public Decimal GetSalary()
        {
            return salary;

        }
        public void SetSalary(decimal Salary)
        {
            this.salary = Salary;

        }





        #endregion


        #region Apply Encapsulation By Using Properties

       // public int Id { set; get; } // Automatic Empemention property


        public int Age {  set; get; } // 1.1 Automatic Empemention property

        // 1.2 full property with validation    
        public int Id 
        {
            get 
            {
                return id;


            }
            set 
            {
                // validation   
                id = value > 0 ? value : 1; // if the id is less than 1 we will set it to 1  
                
            
            
            }
        
        
        
        }


        // read only property   

        public decimal Deduction 
        {
            get 
            {
                return salary * 0.1m; // 10% of the salary as deduction 

            }
        
        
        }

        // full property
        private decimal myVar;   

        public decimal MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        // Automatic Property
        //public int MyProperty { get; set; }





        #endregion


        #region Constructors

        public Employee(string? name, int age, int id, decimal salary)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.salary = salary;
        }


        #endregion


        #region Methods

        public override string ToString()
        {
            return $"Employee name {name}\n id {id}\n  age {age}\n salary {salary:c}  Deduction {Deduction}";
        }

        #endregion






    }
}
