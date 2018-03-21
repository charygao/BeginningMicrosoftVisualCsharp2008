using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serialize
{
    /// <summary>
    /// Define the Person class
    /// </summary>
    [Serializable]
    public class Person
    {
        public Person()
        {
        }

        public int Age { get; set; }
        public int WeightInPounds { get; set; }
    }
}
