using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Business
{
    class CreditCardController
    {
        #region Data Members

        CreditCardDB creditCardDB;
        Collection<CreditCard> cards;

        #endregion

        #region Properties

        public Collection<CreditCard> Allcards
        {
            get
            {
                return cards;
            }
        }
        #endregion

        #region Constructor
        public CreditCardController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            creditCardDB = new CreditCardDB();
            cards = creditCardDB.AllCards;
        }

        #endregion

        #region Database Communication

        public void DataMaintenance(CreditCard aCard, DB.DBOperation operation)
        {
            int index = 0;
            creditCardDB.DataSetChange(aCard, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    cards.Add(aCard);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(aCard);
                    cards[index] = aCard;
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(aCard);
                    cards.RemoveAt(index);
                    break;

            }
        }

        public bool FinalizeChanges(DB.DBOperation operation)
        {
            return creditCardDB.UpdateDataSource(operation);
        }
        #endregion

        #region Searching and Collection

        public CreditCard Find(string CreditCardNum)
        {
            int index = 0;
            bool found = (cards[index].CreditCardNum.Equals(CreditCardNum));
            int count = cards.Count;
            while (!(found) && (index < cards.Count - 1))
            {
                index = index + 1;
                found = (cards[index].CreditCardNum.Equals(CreditCardNum));
            }
            return cards[index];
        }

        public int FindIndex(CreditCard acard)
        {
            int counter = 0;
            bool found = false;
            found = (acard.CreditCardNum.Equals(cards[counter].CreditCardNum));   //using a Boolean Expression to initialise found
            while (!(found) & counter < cards.Count - 1)
            {
                counter += 1;
                found = (acard.CreditCardNum.Equals(cards[counter].CreditCardNum));
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }

        }

        #endregion
    }
}
