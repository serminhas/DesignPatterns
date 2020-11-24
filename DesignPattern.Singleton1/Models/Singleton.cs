using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton1.Models
{
    public sealed class Singleton
    {
        private Singleton()
        {
            this.StatusMessage = "Instance created succesfully";

        }
        public string StatusMessage { get; set; }
        private static readonly Singleton instance = new Singleton();
        public static Singleton Instance => instance;
    }

    
}
