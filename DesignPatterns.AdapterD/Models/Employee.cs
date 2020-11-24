namespace DesignPatterns.AdapterDP.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal? Salary { get; set; }
        public string Designation { get; set; }



        public Employee(int id, string firstName, string lastName, decimal? salary, string designation)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Designation = designation;
        }
    }
}
