using PhumlaKamnandi.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    class CreditCardCompanyController
    {
        #region
        CreditCardCompanyDB creditCardCompanyDB;
        Collection<CreditCardCompany> companies;
        #endregion

        #region Properties
        public Collection<CreditCardCompany> AllCompanies
        {
            get
            {return companies;}
        }
        #endregion

        #region Constructor
        public CreditCardCompanyController()
        {
            creditCardCompanyDB = new CreditCardCompanyDB();
            companies = creditCardCompanyDB.AllCompanies;
        }
        #endregion

        #region Searching and Collection
        public CreditCardCompany Find(int cccId)
        {
            int index = 0;
            bool found = (companies[index].CCCID == cccId);
            int count = companies.Count;
            while (!(found) && (index < companies.Count - 1))
            {
                index = index + 1;
                found = (companies[index].CCCID == cccId);
            }

            return companies[index];
        }
        #endregion
    }
}
