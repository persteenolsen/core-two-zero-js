using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTwoZeroJS.Models
{
    public class PersonTableCoreTwoJS
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public string Editable { get; set; }

        // Add this Class member to the Model to match the new Column in the MS SQL BD
        public string Profession { get; set; }
    }
}
