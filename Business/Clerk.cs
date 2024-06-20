using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    class Clerk:Role
    {
        #region Data Members

        string username, password;
        #endregion

        #region Constructor
        public Clerk() : base()
        {
            getRoleValue = RoleType.Clerk;
        }

        #endregion

        #region Property Methods

        public String Username
        {
            get { return username; }
            set { username = value; }      
        }

        public String Password
        {
            get { return password; }
            set { password = value; } 
        }
        #endregion
    }
}
