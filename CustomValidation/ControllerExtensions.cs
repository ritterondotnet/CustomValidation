using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using CustomValidation.Enums;
using CustomValidation.Models;

namespace CustomValidation
{
    public static class ControllerExtensions
    {
        public static ValidationMessage AddValidationMessage(this Controller controller, string title, string message, ValidationType validationtType = ValidationType.Info)
        {
            Validator validator = controller.TempData["Validator"] as Validator;
            validator = validator ?? new Validator();

            var validationMessage = validator.AddValidationMessage(title, message, validationtType);
            controller.TempData["Validator"] = validator;
            return validationMessage;
        }
    }
}
