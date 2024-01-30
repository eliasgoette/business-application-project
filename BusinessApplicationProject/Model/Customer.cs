using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationProject.Model
{
    public class Customer
    {
        Address? CustomerAddress { get; set; }
        string CustomerNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string? Email { get; set; }
        string? Website { get; set; }
        string? PasswordHash { get; set; }
    }
}