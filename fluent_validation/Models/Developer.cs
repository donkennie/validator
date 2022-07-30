using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fluent_validation.Models
{
    public class Developer
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [StringLength(60)]
        [DataType(DataType.MultilineText)]
        public string Note
        {
            get => note;
            set => note = new HtmlSanitizer().Sanitize(value);
        }



        public string Email { get; set; }

        public decimal Experience { get; set; }
    }
}
