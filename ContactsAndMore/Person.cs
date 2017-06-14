using ContactsAndMore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAndMore
{
    public class Person : IActive

    {
        public Person()
        {

        }
        public bool Active { get; set; }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonEmail { get; set; }
    }
}
