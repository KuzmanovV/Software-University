namespace BakeryOpenning
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Initialize the repository
            Bakery bakery = new Bakery("Barny", 10);
            //Initialize entity
            Employee employee = new Employee("Stephen", 40, "Bulgaria");
            //Print Employee
            Console.WriteLine(employee); //Employee: Stephen, 40 (Bulgaria)

        }
    }
}
