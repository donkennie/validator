using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fluent_validation.Error
{
    public static class DeveloperError
    {

        public static string IdErrorMessage { get; set; } = "Id field cannot be null or empty.";
        
        public static string NameErrorMessage { get; set; } = "Name field cannot be null or empty.";
        public static string ObjectErrorMessage { get; set; } = "Seller field cannot be null or empty.";
       
        public static string QuantityErrorMessage { get; set; } = "Quantity field must be greater than 0.";
    }
}
