using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollection
{
    public class TextInputError : UserError
    {
        public override string UEMessage() => "You tried to use a text input in a numericonly field.This fired an error!";

                                                

    }
}
