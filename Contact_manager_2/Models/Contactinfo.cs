using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class Contactinfo
    {
        [Key]
        public int Id { get; set; }
        public int NumberPhone { get; set; }
        public string Email { get; set; }
        public string Skype { get; set; }
        public string Other { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
