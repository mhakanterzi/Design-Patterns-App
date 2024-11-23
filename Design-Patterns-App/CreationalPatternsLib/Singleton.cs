using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Pattern.CreationalPatternsLib;
using Design_Pattern.PatternApp;

namespace Design_Pattern.CreationalPatternsLib
{
    public class Singleton
    {
        // Constructor must be private to prevent instantiation from outside
        private Singleton() { }

        // A static field to store the singleton object
        private static Singleton _instance;

        // A lock object to synchronize threads on first access
        private static readonly object _lock = new object();

        // A public method to get the singleton instance
        public static Singleton GetInstance(string value)
        {
            // This check prevents unnecessary locking once the instance is created
            if (_instance == null)
            {
                // The first thread to acquire the lock initializes the instance
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }

        // A public property to hold a value associated with the singleton
        public string Value { get; set; }
    }
}