﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // :base() -> parent constructor'a ne yollamak istersin?
        public SuccessResult(string message):base(true, message)
        {

        }
        
        public SuccessResult(): base(true)
        {

        }

    }
}
