using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomValidation.Enums;

namespace CustomValidation.Models
{
    [Serializable]
    public class Validator
    {
        public bool ShowNewestOnTop { get; set; }
        public bool ShowCloseButton { get; set; }
        public List<ValidationMessage> ValidationMessages { get; set; }

        public Validator()
        {
            ValidationMessages = new List<ValidationMessage>();
            ShowNewestOnTop = false;
            ShowCloseButton = false;
        }

        public ValidationMessage AddValidationMessage(string title, string message, ValidationType messageType)
        {
            var validation = new ValidationMessage()
            {
                Title = title,
                Message = message,
                MessageType = messageType
            };
            ValidationMessages.Add(validation);
            return validation;
        }
    }
}
