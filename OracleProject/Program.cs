using OracleProject.Models;
using OracleProject.Packages;

namespace OracleProject
{
    internal class Program
    {
        static void Main()
        {

            char operation = 'a';

            Console.WriteLine("choose opperation");

            Console.WriteLine("A => ADD");
            Console.WriteLine("D => DELETE");
            Console.WriteLine("U => UPDATE");
            Console.WriteLine("I => GET BY ID");
            Console.WriteLine("G => GET ALL EMPLOYEES");



            operation = char.Parse(Console.ReadLine().ToLower());



            while (operation == 'a' || operation == 'd' || operation == 'u' || operation == 'i' || operation == 'g')

            {

                Employee employee = new Employee();
                PKG_EMPT pkg = new PKG_EMPT();

                if (operation == 'a')
                {


                    Console.WriteLine("Add Employee");
                    Console.Write("Enter First Name : ");
                    employee.FirstName = Console.ReadLine();
                    Console.Write("Enter Last Name : ");
                    employee.FirstName = Console.ReadLine();
                    Console.Write("Enter Position : ");
                    employee.FirstName = Console.ReadLine();

                    pkg.add_employee(employee);

                    Console.WriteLine($"Employee {employee.FirstName} was succesfuly added");

                }


                else if (operation == 'd')
                {


                    Console.WriteLine("Write Employee Id you want to Delete : ");

                    employee.Id = int.Parse(Console.ReadLine());

                    pkg.delete_employee(employee);

                    Console.WriteLine($"Employee with ID {employee.Id} was deleted");


                }



                else if (operation == 'u')
                {


                    Console.WriteLine("Choose employee by Id and update : ");
                    Console.WriteLine("Enter Id : ");

                    employee.Id = int.Parse(Console.ReadLine());
                    employee.FirstName = Console.ReadLine();
                    employee.LastName = Console.ReadLine();
                    employee.Position = Console.ReadLine();

                    pkg.update_employee(employee);


                    Console.WriteLine($"Employee with ID {employee.Id} was updated");


                }



                else if (operation == 'i')
                {


                    Console.WriteLine("Enter employee Id which you want to display : ");

                    employee.Id = int.Parse(Console.ReadLine());

                    pkg.get_employee_by_id(employee);

                    Console.WriteLine($"First Name => {employee.FirstName}");
                    Console.WriteLine($"Last Name => {employee.LastName}");
                    Console.WriteLine($"Positione => {employee.Position}");



                }


                else if (operation == 'i')
                {


                    Console.WriteLine("All employes : ");


                    List<Employee> employees = new List<Employee>();
                    employees = pkg.get_employees();

                    foreach (Employee emp in employees)
                    {
                        Console.WriteLine($"First Name => {emp.FirstName}");
                        Console.WriteLine($"Last Name => {emp.LastName}");
                        Console.WriteLine($"Positione => {emp.Position}");
                    }





                }
                else { break; }


            }
        }
    }
}
