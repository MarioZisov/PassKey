﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKey.Exceptions
{
    public class InvalidPasswordLenghtException : PassKeyException
    {
        public InvalidPasswordLenghtException(string message)
            : base(message)
        {
        }
    }
}
