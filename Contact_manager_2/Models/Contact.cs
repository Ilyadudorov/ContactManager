using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [RegularExpression(@"^[a-яA-Я\s]*$",ErrorMessage = "Имя должно состоять только из букв")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Имя должно состоять только из букв")]  на английском
        [Required(ErrorMessage = "Необходимо ввести имя")]
        [StringLength(10, ErrorMessage = "Имя должно содержать больше символов", MinimumLength = 2)]
        public string First_Name { get; set; }

        [RegularExpression(@"^[a-яA-Я\s]*$", ErrorMessage = "Фамилия должно состоять только из букв")]
        [Required(ErrorMessage = "Необходимо ввести фамилию")]
        [StringLength(15, ErrorMessage = "Фамилия должна содержать больше символов", MinimumLength = 2)]
        public string Last_Name { get; set; }

        [RegularExpression(@"^[a-яA-Я\s]*$", ErrorMessage = "Отчество должно состоять только из букв")]
        public string Middle_Name { get; set; }

        [Required(ErrorMessage = "Необходимо ввести день рождения")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [RegularExpression(@"^[a-яA-Я\s]*$", ErrorMessage = "Должность должна состоять только из букв")]
        [Required(ErrorMessage = "Необходимо ввести должность")]
        [StringLength(20, ErrorMessage = "Должность должна содержать больше символов", MinimumLength = 2)]
        [DisplayName("Должность")]
        public string Position { get; set; }
    }
}
