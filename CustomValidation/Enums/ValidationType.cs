using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomValidation.Enums
{
    [Serializable]
    public enum ValidationType
    {
        Error,
        Info,
        Success,
        Warning
    }
}