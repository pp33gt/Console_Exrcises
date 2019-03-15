using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numericonly field. This fired an error!";
        }
    }

    class NumericInputError: UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    class DateTimeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an invalid date input in a DateTime only field. This fired an error!";
        }
    }

    class BooleanInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an invalid boolean input in a boolean only field. This fired an error!";
        }
    }

    class TooLongInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to write too many characters into a text field. This fired an error!";
        }
    }
}
