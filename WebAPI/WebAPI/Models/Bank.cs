using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Bank
    {
        public Bank()
        {
            BankAccounts = new HashSet<BankAccount>();
        }
     
        [Key]
        public int BankID { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        public string BankName { get; set; }

        public virtual ICollection<BankAccount> BankAccounts { get; set; } 
    }
}