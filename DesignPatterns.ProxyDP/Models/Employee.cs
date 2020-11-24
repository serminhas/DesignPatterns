namespace DesignPatterns.ProxyDP.Models
{
    public class Employee
    {
        public string UserName { get; internal set; }
        public string Password { get; internal set; }
        public string Role { get; internal set; }

        public Employee(string username, string password, string role)
        {
            this.UserName = username;
            this.Password = password;
            this.Role = role;
        }
    }
}
