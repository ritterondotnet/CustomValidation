using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomValidation.Enums;

namespace CustomValidation.Models
{
    [Serializable]
    public class ValidationMessage
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public ValidationType MessageType { get; set; }
        public bool IsSticky { get; set; }
    }
}
