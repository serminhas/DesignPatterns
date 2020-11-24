using System;

namespace DesignPatterns.FacadeDP
{
    using Models;
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.PlaceOrder();
        }
    }
}
