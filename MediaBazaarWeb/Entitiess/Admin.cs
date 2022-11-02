using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace Entities
{
    public class Admin: User
    {
        public Admin():base()
        {
            this.accType = AccountType.Admin;
        }
    }
}
