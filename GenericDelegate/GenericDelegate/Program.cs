using System;
using System.Collections.Generic;

namespace GenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Func<int , float , double ,double> obj1 = new Func<int , float , double ,double>
             (GenericDelegate.AddNumber1);
             double Result = obj1.Invoke(100 , 125f , 456.789);
             Console.WriteLine(Result);

             Action<int , float , double> obj2 = new Action<int , float , double >
             (GenericDelegate.AddNumber2);
             obj2.Invoke(50 , 255.45f , 123.456);

             Predicate<string> obj3 = new Predicate<string>
             (GenericDelegate.CheckLength);
             bool Status = obj3.Invoke("Goodness");
             Console.WriteLine(Status);

             Console.ReadKey(); */

            /* Func <int , float , double , double> func = (x, y, z) =>
            {
              return x + y  + z;
            };
           double Result = func.Invoke(100 , 1245f , 456.789);
           Console.WriteLine(Result);

           Action<int , float , double> qw = (int no1 , float no2 ,double no3) =>
            { 
                Console.WriteLine(no1 + no2 + no3);
            };
           qw.Invoke(100 , 125f , 456.789); 

           Predicate<string> pd = st => st.Length == 4;
           {
               bool result = pd.Invoke("Ade");
               Console.WriteLine(result);
           }*/

            EntitleForPromotion IsEntitledBySalary = delegate (Employee employee)
            {
                if (employee.Salary <= 30000)
                {
                    return true;
                }
                return false;
            };

            EntitleForPromotion IsEntitledByExperience = delegate (Employee employee)
            {
                if (employee.Experience >= 4)
                {
                    return true;
                }
                return false;
            };

            Predicate<Employee> IsEntitledBySalaryAnonymous = delegate (Employee employee)
            {
                if (employee.Salary <= 30000)
                {
                    return true;
                }
                return false;
            };

            Predicate<Employee> IsEntitledByExperienceAnonymous = delegate (Employee employee)
            {
                if (employee.Salary >= 4)
                {
                    return true;
                }
                return false;
            };
            
            var employees = new List<Employee>()
            {
             new Employee ()
             {
                Id = 1,
                Name = "Adeyanju",
                Experience = 4,
                Salary = 50000,
             },

             new Employee ()
             {
                Id = 2,
                Name = "serubow",
                Experience = 2,
                Salary = 250000,
             },

             new Employee ()
             {
                Id = 3,
                Name = "gabriel",
                Experience = 3,
                Salary = 30000,
             },

             new Employee ()
             {
                Id = 4,
                Name = "Bayo",
                Experience = 4,
                Salary = 550000,
             }
        };

            // Custom delegate
            EntitleForPromotion IsEntitledBySalary1 = new EntitleForPromotion(PromoBySalary);

            //Employee.PromotedEmployeesCustomDelegate(employees, IsEntitledBySalary);
            //Employee.PromotedEmployeePredicate(employees, PromoBySalary);
            //Employee.PromotedEmployeePredicate(employees, PromoByExperience);

            Employee.PromotedEmployeePredicate(employees, IsEntitledByExperienceAnonymous);
            Employee.PromotedEmployeePredicate(employees, IsEntitledBySalaryAnonymous);

            Employee.PromotedEmployeesCustomDelegate(employees, IsEntitledByExperience);
            Employee.PromotedEmployeesCustomDelegate(employees, IsEntitledBySalary);

            Console.WriteLine();
        }


        public class GenericDelegate
        {
            public static double AddNumber1(int no1, float no2, double no3)
            {
                return no1 + no2 + no3;
            }

            public static void AddNumber2(int no1, float no2, double no3)
            {
                //    Console.WriteLine( no1 + no2 + no3);
            }

            public static bool CheckLength(string name)
            {
                if (name.Length > 5)
                {
                    return true;
                }

                return false;
            }

        }
        static bool PromoBySalary(Employee emp)
        {
            if (emp.Salary <= 30000)
            {
                return true;
            }
            return false;
        }

        static bool PromoByExperience(Employee emp)
        {
            if (emp.Experience >= 4)
            {
                return true;
            }
            return false;
        }
        // declaring delegate for the method in the employee class
        public delegate bool EntitleForPromotion(Employee employee);
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Experience { get; set; }
            public decimal Salary { get; set; }


            public static void PromotedEmployeesCustomDelegate(List<Employee> employees, EntitleForPromotion employeeFilter) // callback method
            {
                Console.WriteLine("All the employee(s) are : ");

                foreach (var employee in employees)
                {
                    if (employeeFilter(employee))
                    {
                        Console.WriteLine($"{employee.Id}\t {employee.Name}");
                    }
                }
            }

            public static void PromotedEmployeePredicate(List<Employee> employees, Predicate<Employee> isEntitled)
            {
                Console.WriteLine("All promoted employee(s) are: ");

                foreach (var employee in employees)
                {
                    if (isEntitled(employee))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{employee.Id}\t{employee.Name}");
                        Console.WriteLine($"{employee.Name} now earns {employee.Salary + (employee.Salary * (10m/100m))} as salary");
                        Console.WriteLine();
                    }
                }
            }
        }

    }
}


