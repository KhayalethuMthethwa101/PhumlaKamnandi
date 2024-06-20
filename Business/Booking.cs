using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    public class Booking
    {

        #region Data Members
        int bookingId;
        string  checkIn;
        string checkout;
        int guestId;
        int roomId;
        decimal Total_Fee;

        #endregion

        #region Property Methods
        public string Checkin
        {
            get { return checkIn; }
            set { checkIn = value; }
           
        }

        public string CheckOut
        {
            get { return checkout; }
            set { checkout = value; }
           
        }
        public int RoomId
        {
            get { return roomId; }
            set { roomId = value; }

        }

        public int GuestId
        {
            get { return guestId; }
            set { guestId = value; }

        }

        public int BookingID
        {
           
            get { return bookingId; }
            set { bookingId = value; }
        }

        public decimal TOTALFee
        {
            get { return Total_Fee; }
            set { Total_Fee = value; }
            
        }

      

        #endregion

        #region Constructor
        public Booking(int guestId, int roomId, String checkIn, String checkout, decimal Total_Fee)
        {


            this.checkIn = checkIn; //initialize the check-in date
            this.checkout = checkout; //initialize the check-out date

            this.roomId = roomId; //initialize the roomID
            this.Total_Fee = Total_Fee; //initilaize the total fee
            this.guestId = guestId; //initialize the guest ID
        }

        #endregion

        #region Methods
        public int GetBookingID()
        {
            return this.bookingId;
        }
        #endregion
    }
}
