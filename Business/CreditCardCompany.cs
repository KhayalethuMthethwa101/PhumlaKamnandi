using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class CreditCardCompany
    {
        private int cccId;
        private String cccName;

        #region
        public int CCCID
        {
            get { return cccId; }
            set { cccId = value; }
        }

        public String CCCName
        {
            get { return cccName; }
            set { cccName = value; }
        
        }
        #endregion

        #region Constructor
        public CreditCardCompany(int cccId, String cccName)
        {
            this.CCCID = cccId;
            this.CCCName = cccName;
        }
        #endregion
    }
}
