
using Listas_exercicio;

namespace Program {
    class Listas {
        static void Main(string[] args) {


            Console.WriteLine("how many employees will be registered?");

            int numberOfEmployeers = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();


            for (int i = 0; i < numberOfEmployeers; i++) {
                Console.WriteLine("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Salary:");
                double salary = int.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("enter the employee id that will receive salary increase");
            int employerId = int.Parse(Console.ReadLine());

            Employee e = employees.Find(id => id.Id == employerId);

            if (e != null) {
                Console.WriteLine("enter the percentage:");
                int percentage = int.Parse(Console.ReadLine());

                e.IncreaseSalary(percentage);

                Console.WriteLine(e.Salary);

            }
            else {
                Console.WriteLine("The employee doesnot exist");
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee employee in employees) {
                Console.WriteLine(employee);

            }

        }
    }
}