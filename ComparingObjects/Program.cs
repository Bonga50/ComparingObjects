namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Employee> employees = new List<Employee>
             {
            new Employee("John", "Doe", 50000),
            new Employee("Jane", "Smith", 60000),
            new Employee("Bob", "Johnson", 55000),
            new Employee("Alice", "Williams", 52000),
            new Employee("Chris", "Brown", 53000),
            new Employee("Sarah", "Davis", 48000),
            new Employee("Michael", "Smith", 61000),
            new Employee("Emily", "Wilson", 56000),
            new Employee("David", "Johnson", 54000),
            new Employee("Laura", "Anderson", 59000)
            };
            Console.WriteLine("Unsorted list");
            DispalayElements(employees);
            Console.WriteLine(  "Sorted list");
            BubbleSort(employees);
            DispalayElements(employees);
            Console.ReadLine(  );
        }

        public static void DispalayElements(List<Employee> list) {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public static void Bubble(List<Employee> employees) {
            for (int i = 0; i < employees.Count-1; i++)
            {
                for (int j = (i+1); j < employees.Count; j++)
                {

                    if (String.Compare(employees[j].LastName, employees[i].LastName)<0)
                    {
                        Employee temp = employees[j];
                        employees[j] = employees[i];
                        employees[i] = temp;
                    }
                    if (String.Compare(employees[j].LastName, employees[i].LastName) == 0)
                    {
                        if (String.Compare(employees[j].FirstName, employees[i].FirstName) > 0)
                        {
                            Employee temp = employees[j];
                            employees[j] = employees[i];
                            employees[i] = temp;
                        }

                    }

                    
                }
            }
        }

        public static void BubbleSort(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count - 1; i++)
            {
                for (int j = (i + 1); j < employees.Count; j++)
                {

                    if (employees[j].CompareTo(employees[i]) < 0)
                    {
                        Employee temp = employees[j];
                        employees[j] = employees[i];
                        employees[i] = temp;
                    }
                   


                }
            }
        }
    }
}