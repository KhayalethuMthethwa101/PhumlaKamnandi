using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    class CreditCard
    {

        #region Data Members

        
        private string creditCardNum;
        private int CCCID;
        private int experationM;
        private int experationY;
        #endregion

        #region Property Methods
        public String CreditCardNum
        {
            set { creditCardNum = value; }
            get { return creditCardNum; }
        }
        public int CCCId
        {
            set { CCCID = value; }
            get { return CCCID; }
        }
        public int ExperationM
        {
            set { experationM = value; }
            get { return experationM; }
        }
        public int ExperationY
        {
            set { experationY = value; }
            get { return experationY; }
        }

        #endregion

        #region Constructor
        public CreditCard(string creditCardNum, int CCCID, int experationM, int experationY)
        {
            this.creditCardNum = creditCardNum;
            this.CCCID = CCCID;
            this.experationM = experationM;
            this.experationY = experationY;
        }

        #endregion

    }
}
