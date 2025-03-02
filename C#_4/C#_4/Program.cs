namespace C__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            /* for (int i = 0; i < employees.Length; i++) {
                 employees[i]= new Employee();
                 Console.Write("Name: ");
                 employees[i].Name = Console.ReadLine();
                 Console.Write("Salary: ");
                 decimal.TryParse(Console.ReadLine(), out decimal salary);
                 employees[i].Salary = salary;
                 Console.Write("Gender: ");
                 employees[i].Gender_ = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine());
                 Console.Write("Security Level: ");
                 employees[i].SecurityLevel_ = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), Console.ReadLine());
                 Console.Write("Day of birth: ");
                 employees[i].HireDate_.Day = int.Parse(Console.ReadLine());
                 Console.Write("Month of birth: ");
                 employees[i].HireDate_.Month = int.Parse(Console.ReadLine());
                 Console.Write("Year of birth: ");
                 employees[i].HireDate_.Year = int.Parse(Console.ReadLine());
             }*/
            for (int i = 0; i < 3; i++)
            {
                employees[i] = new Employee();
                employees[i].HireDate_.Day = i == 0 ? 5 : i == 1 ? 4 : 1;
                employees[i].HireDate_.Month = 5;
                employees[i].HireDate_.Year = 2000;

            }
            Array.Sort(employees);
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
