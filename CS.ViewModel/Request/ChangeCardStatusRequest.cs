﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CS.VM.Request
{
    public class ChangeCardStatusRequest
    {
        public int CardNumber { get; set; }
        public int Status { get; set; }
    }
}
