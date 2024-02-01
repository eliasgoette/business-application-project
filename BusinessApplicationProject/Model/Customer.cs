using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplicationProject.Model
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        Address? CustomerAddress { get; set; }
        string CustomerNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string? Email { get; set; }
        string? Website { get; set; }
        string? PasswordHash { get; set; }
    }
}