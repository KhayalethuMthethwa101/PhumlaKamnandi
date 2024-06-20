using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Business
{
   public class BookingController
    {
        #region Data Members

        BookingDB bookingDB;
        Collection<Booking> bookings;

        #endregion

        #region Properties

        public Collection<Booking> AllBookings
        {
            get
            { return bookings; }
        }
        #endregion

        #region Constructor
        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;
        }

        #endregion

        #region Database Communication

        public void DataMaintenance(Booking aBook, DB.DBOperation operation)
        {
            int index = 0;
            bookingDB.DataSetChange(aBook, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    bookings.Add(aBook);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(aBook);
                    bookings[index] = aBook;
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(aBook);
                    bookings.RemoveAt(index);
                    break;

            }
        }

        public bool FinalizeChanges(DB.DBOperation operation)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return bookingDB.UpdateDataSource(operation);
        }
        #endregion

        #region Searching through a collection
        public Booking Find(string ID)
        {
            int index = 0;
            bool found = (bookings[index].BookingID == Convert.ToInt32(ID));
            int count = bookings.Count;
            while (!(found) && (index < bookings.Count - 1))
            {
                index = index + 1;
                found = (bookings[index].BookingID == Convert.ToInt32(ID));
            }

            return bookings[index];
        }

        public int FindIndex(Booking abook)
        {
            int counter = 0;
            bool found = false;
            found = (abook.BookingID == bookings[counter].BookingID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < bookings.Count - 1)
            {
                counter += 1;
                found = (abook.BookingID == bookings[counter].BookingID);
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
