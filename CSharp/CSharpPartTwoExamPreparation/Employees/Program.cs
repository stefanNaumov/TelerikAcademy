using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Employee
{
    public string firstName { get; set; }

    public string secondName { get; set; }

    public string JobPosition { get; set; }

    public int Rank { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        Dictionary<string, int> positions = new Dictionary<string, int>();
        int numberOfPositions = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPositions; i++)
        {
            string[] currentPosition = Console.ReadLine().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            if(!(positions.ContainsKey(currentPosition[0])))
            {
                positions.Add(currentPosition[0], int.Parse(currentPosition[1]));
            }
        }
        int numberOfEmployees = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfEmployees; i++)
        {
            Employee currEmployee = new Employee();
            string[] currentEmployee = Console.ReadLine().Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

            string[] currentEmployeeName = currentEmployee[0].Split(new char[] { ' ' });

            string currentEmployeePosition = currentEmployee[1];

            currEmployee.firstName = currentEmployeeName[0];
            currEmployee.secondName = currentEmployeeName[1];
            currEmployee.JobPosition = currentEmployeePosition;
            currEmployee.Rank = positions[currEmployee.JobPosition];

            employees.Add(currEmployee);
        }

        var ratings = employees.OrderByDescending(em => em.Rank).ThenBy(em => em.secondName).ThenBy(em => em.firstName);

        foreach (var el in ratings)
        {
            Console.WriteLine("{0} {1}",el.firstName,el.secondName);
        }
    }
}

