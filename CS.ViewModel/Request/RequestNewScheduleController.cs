﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CS.VM.Request
{
    public class RequestNewScheduleController : CreateNewPatientRequest
    {
        public string PatientId { get; set; }
        public string ShiftId { get; set; }
        public bool BHYT { get; set; }
    }
}
