using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Data
{
    class CreditCardCompanyDB: DB
    {
        #region Data Members
        private string table = "Credit_Card_Company";
        private string sqlLocal = "SELECT * FROM Credit_Card_Company";
        private Collection<CreditCardCompany> companies;
        #endregion

        #region Property Method: Collection
        public Collection<CreditCardCompany> AllCompanies
        {
            get { return companies;}
        }
        #endregion

        #region Constructor
        public CreditCardCompanyDB() : base()
        {
            companies = new Collection<CreditCardCompany>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            CreditCardCompany aCompany;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Booking object
                    int cccId = Convert.ToInt32(myRow["CCC_ID"]);
                    String cccName = Convert.ToString(myRow["CCC_Name"]).TrimEnd();
                    aCompany = new CreditCardCompany(cccId, cccName);

                    companies.Add(aCompany);
                }
            }
        }
    }
}
