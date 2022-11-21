using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;
namespace BuissnessLogicLayer
{
    public class ShiftManager
    {
        private ShiftDB shiftDB;
        private DBCheck checkDB;
        public ShiftManager()
        {
            shiftDB= new ShiftDB();
            checkDB= new DBCheck(); 
        }
        public List<Shift> getAllShifts()
        {
            return shiftDB.GetAllShift();
        }

        public bool SetShift(int employee_id, ShiftType shiftType, string dayShift)
        {
            if (checkDB.checkForRepShift(employee_id, dayShift))
            {
                shiftDB.SetShift(employee_id, shiftType, dayShift);
                return true;
            }
            return false;
            
        }

        public bool RemoveShift(int user_id, string dateTime)
        {
            shiftDB.DeleteShift(user_id, dateTime);
            return true;
        }
    }
}
