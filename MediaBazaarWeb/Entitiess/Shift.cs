using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Entities
{
    public class Shift
    {
        private ShiftType shiftType;
        private DateTime dayShift;

        public Shift(ShiftType shiftType, DateTime dayShift)
        {
            this.shiftType = shiftType;
            this.dayShift = dayShift;
        }
    }
}
