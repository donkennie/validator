using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluent_validation.Models
{
    public class ResponseModel
    {
        public ResponseModel()
        {
            IsValid = true;
            ValidationMessages = new List<string>();
        }
        public bool IsValid { get; set; }
        public List<string> ValidationMessages { get; set; }
    }
}
