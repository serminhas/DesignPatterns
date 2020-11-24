namespace DesignPatterns.ProxyDP.Models
{
    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperation()
        {
            System.Console.WriteLine("Performing Read Write Operations on the shared Folder");
        }
    }
}
