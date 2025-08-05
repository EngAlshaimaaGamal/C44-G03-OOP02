using Demo.Encapsulation;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Struct 

            #region Example 01
            //Point p1;
            //// declare variable (data type )
            //// clr initialize 8 Byte in stack for p1( x ,y)

            //p1 = new Point();

            //// new  => with any value type  as constructor selection  not create object

            //p1.x = 10;
            //p1.y = 20;  
            //Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}");


            //Console.WriteLine(p1); // return (namespace .Datatype).type Demo.Point  => object 
            //Console.WriteLine(p1.ToString()); // Demo.Point => ToString

            //Point P2 = new Point();

            //P2.y = 30;
            //Console.WriteLine($"Point p1: x = {P2.x}, y = {P2.y}");

            //Console.WriteLine(" Enter the X : ");
            //int x = int.Parse(Console.ReadLine() ?? "0");   
            //Console.WriteLine(" Enter the Y : ");   
            //int y = int.Parse(Console.ReadLine() ?? "0");   
            //Point P3 = new Point(x, y);
            //Console.WriteLine($"Point p3: x = {P3.x}, y = {P3.y}");





            #endregion

            #region Example 02

            //Point p1 = new Point(10, 20);

            //Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}");

            //Point P2 = new Point(30, 40); 

            //Console.WriteLine($"Point p2: x = {P2.x}, y = {P2.y}");

            //P2 = p1; // copy value of p1 to P2

            //Console.WriteLine("After Assign P2=P1");       


            //Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}");

            //Console.WriteLine($"Point p2: x = {P2.x}, y = {P2.y}"); // 10,20    


            //p1.x = 100; // change value of P2.x 
            //p1.y = 200; // change value of P2.y


            //Console.WriteLine("After Assign  change P1");


            //Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}");

            //Console.WriteLine($"Point p2: x = {P2.x}, y = {P2.y}");


            #endregion




            #endregion



            #region Encapsulation
            //Employee emp1 = new Employee();
           // emp1.name = "Ahmed";    
           //emp1.age = 30;
           // emp1.id = 1001; 
           // emp1.salary = 5000.50m;
           // Console.WriteLine(emp1);


            // there are tree Problem  before the encapsulation
            // Access direct the attribute 
            // any modify in the details will affect the outer code 
            // no validation for the data   

            // so we need to encapsulate the data   
            // Encapsulation =>  is the process of hiding the internal state and functionality of an object and only exposing a controlled interface for interaction.   


            //emp1.setName("Ahmed Gamal Dahy"); // using setter to set the name  
            //emp1.age = 30;  
            //emp1.id = 1001;
            //emp1.SetSalary(5000.50m);
            //Console.WriteLine($"Employee Name: {emp1.GetName()}, Age: {emp1.age}, ID: {emp1.id}, Salary: {emp1.GetSalary()}");  


            //emp1.Id =-1; // using property to set the id
            //Console.WriteLine($"Employee Id {emp1.Id}"); // using property to get the id    

          //emp1.Id= 1;
          //  emp1.setName("Ahmerdd");
          //  emp1.SetSalary(5000);
          //  emp1.Age = 30;
          //  Console.WriteLine(emp1.Deduction);






            #endregion












        }
    }
}
