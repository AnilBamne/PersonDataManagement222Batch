using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement222Batch
{
    /// <summary>
    /// Creating a Person class
    /// encapsulating the person details
    /// overriding the toString method
    /// </summary>
    public class Person
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"SerialNo:{SSN} Name:{Name} Age:{Age} Address:{Address}";
        }
    }
}
