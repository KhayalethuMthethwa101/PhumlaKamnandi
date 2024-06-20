using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PhumlaKamnandi.Business
{
    public class Reserve
    {
        #region Data Members
        int BoookingId;
        int periodOfStay;
        decimal Total_Fee;
   
        Collection<Booking> bookings;
        Collection<Person> people;
        Collection<int> rooms;
        Collection<CreditCardCompany> companies;
        PersonController personController;
        BookingController bookingController;
        CreditCardCompanyController cccController;

        #endregion


        public Reserve()
        {
            rooms = new Collection<int>();
            personController = new PersonController();
            bookingController = new BookingController();
            cccController = new CreditCardCompanyController();
            people = personController.AllPeople;
            bookings = bookingController.AllBookings;
            companies = cccController.AllCompanies;
            UpdateRooms();
        }

        #region Utility Method

        public void UpdateRooms()
        {
            rooms.Add(1);
            rooms.Add(2);
            rooms.Add(3);
            rooms.Add(4);
            rooms.Add(5);
        }

        public Collection<Booking> AllBookings
        {
            get { return bookingController.AllBookings; }
        }
        public Collection<int> makeBooking(DateTime checkIn, DateTime checkout)
        {
            Collection<int> AvailableRooms = new Collection<int>() ;
            foreach(Booking book in bookings)
            {
                if((checkIn >= DateTime.Parse(book.Checkin)) && (checkIn < DateTime.Parse(book.CheckOut)))
                {
                    rooms.Remove(book.RoomId);
                }
            }
            
            foreach(int i in rooms)
            {
                AvailableRooms.Add(i);
            }
            UpdateRooms();
            return AvailableRooms;
        }

        public Collection<int> RoomsAvailable(DateTime checkIn)
        {
            Collection<int> AvailableRooms = new Collection<int>();
            foreach (Booking book in bookings)
            {
                if (checkIn.Day == DateTime.Parse(book.Checkin).Day)
                {
                    rooms.Remove(book.RoomId);
                }
            }

            foreach (int i in rooms)
            {
                AvailableRooms.Add(i);
            }
            UpdateRooms();
            return AvailableRooms;
        }

      

        public int AddBooking (int guestId, int roomId, String checkIn, String checkout, decimal Total_Fee)
       {
            Booking booking = new Booking(guestId, roomId, checkIn, checkout, Total_Fee);
            bookingController.DataMaintenance(booking, Data.DB.DBOperation.Add);
            bookingController.FinalizeChanges(Data.DB.DBOperation.Add);
            //bookingController.AllBookings.Add(booking);
            bookings = bookingController.AllBookings;
            return booking.BookingID;
       }


        public void DeleteBooking(String bookingId)
        {
            bookingController.DataMaintenance(FindBooking(bookingId), Data.DB.DBOperation.Delete);
            bookingController.FinalizeChanges(Data.DB.DBOperation.Delete);
            bookings = bookingController.AllBookings;
        }



        public Person FindGuest(string id)
        {
            Person guest=null;//=new Person();
            foreach (Person person in people)
            {
                if (person.role.getRoleValue == Role.RoleType.Guest)
                {
                    if (person.ID.Equals(id))
                    {
                        guest = person;
                    }
                }
            }

            return guest;
        }

        public bool LogIn(string username, string password)
        {
            bool LogIn = false;
            foreach (Person person in people)
            {
                if (person.role.getRoleValue == Role.RoleType.Clerk)
                {
                    Clerk clerk = (Clerk)person.role;
                    if (clerk.Username.Equals(username))
                    {
                        if (clerk.Password.Equals(password))
                        {
                            LogIn = true;
                        }
                    }
                }
            }

            return LogIn;
        }



        public Booking FindBooking(String id)
        {
            return bookingController.Find(id);
        }


        public void AddGuest(Person person)
        {
            Debug.WriteLine("Inside AddGuest");
            personController.DataMaintenance(person, Data.DB.DBOperation.Add);
            personController.FinalizeChanges(person, Data.DB.DBOperation.Add);
        }


        public String GetId(Person person)
        {
            String id = "";
            foreach(Person person1 in people)
            {
                    if (person.PersonalId.Equals(person1.PersonalId))
                    {
                        id = id + person1.ID;
                    }
            }

            return id;
        }

        public Collection<CreditCardCompany> AllCreditCardCompanies()
        {
            return companies;
        }
        #endregion

    }
}
