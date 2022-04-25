using System.Collections;

namespace WorkoutArraylistGenericlist
{
    public class CollGenric
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList();//Collections
            al.Add("hello");
            al.Add(true);
            al.Add(3.14f);
            Console.WriteLine("al " + al[0]);

            // foreach (object i in al) { Console.WriteLine(i); }
            // foreach (var i in al) { Console.WriteLine(i); }

            List<int> integerList = new List<int>();//Generics
            integerList.Add(20);
            integerList.Add(30);
            integerList.Add(40);
            //  Console.WriteLine("integerList" + integerList[0]);

            //  foreach(object i in integerList) { Console.WriteLine(i); }

            // foreach (int i in integerList) { Console.WriteLine(i); }

            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000
            };

            List<Employee> listEmployees = new List<Employee>();//complex type generics

            listEmployees.Add(emp1);
            listEmployees.Add(emp2);

            foreach (Employee i in listEmployees) { Console.WriteLine(i); }

            listEmployees.ForEach(delegate (Employee empl) {
                Console.WriteLine(empl);
            });

            Employee emp = listEmployees[0];
            Console.WriteLine("Retrive the First employee by index");
            //Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",
            // emp.ID, emp.Name, emp.Gender, emp.Salary);
            // Console.WriteLine(emp);
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return "ID: " + ID +
                " Name: " + Name +
                " Gender: " + Gender +
                " Salary: " + Salary;
        }
    }
}