using System;

namespace DesignPatterns.Singleton1
{
    using Models;
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            singleton1.StatusMessage = "İlk instance oluşturuldu";
            Console.WriteLine(singleton1.StatusMessage);
            Console.WriteLine(singleton1.GetHashCode());

            Singleton singleton2 = Singleton.Instance;
            singleton2.StatusMessage = "İkinci instance oluşturuldu";
            Console.WriteLine(singleton2.StatusMessage);
            Console.WriteLine(singleton2.GetHashCode());
        }
    }
}
