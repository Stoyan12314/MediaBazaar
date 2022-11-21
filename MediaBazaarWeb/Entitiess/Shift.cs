using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Entities
{
    public class Shift
    {
        public ShiftType shiftType { private set;  get; }
        public DateTime dayShift { private set; get; }
        public int employeeId { private set; get; }
        public Shift(int employee_id, ShiftType shiftType, DateTime dayShift)
        {
            this.shiftType = shiftType;
            this.dayShift = dayShift;
            this.employeeId= employee_id;
        }
    }
}
