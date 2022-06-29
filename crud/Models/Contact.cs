using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    //model
    public class Contact
    {
        //properties
        [Key]
        public int contactId { get; set; }

        [Required(ErrorMessage = "Contact name is required")]
        public string ContactName { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
