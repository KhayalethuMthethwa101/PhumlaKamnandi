using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi
{
   public class Person
    {
     
        #region data members
        private string id, personId, name, phone, email;
        #endregion

        #region Properties
        public String ID
            {
                get { return id; }
                set { id = value; }
            }
        public string Name
            {
                get { return name; }
                set { name = value; }
            }
        public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }
        public string Email
        {
            get { return email; }
            set { email = value; }
         
        }
        public string PersonalId
        {
            get { return personId; }
            set { personId = value; }
        }



        public Role role;
      
            #endregion

        #region Construtor
        public Person()
        {
                id = "";
                name = "";
                Phone = "";
        }

        public Person(Role.RoleType roleValue)
        {

            switch (roleValue)
            {
                case Role.RoleType.NoRole:
                    role = new Role();
                    break;
                case Role.RoleType.Guest:
                    role = new Guest();
                    break;
                case Role.RoleType.Clerk:
                    role = new Clerk();
                    break;
            }
        }   
            #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + Phone;
        }
        #endregion
    }
}


