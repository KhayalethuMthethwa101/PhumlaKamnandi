using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Business
{
    class Room
    {
        #region Data members
        private int room_Number;
        private bool roomStatus = false;

        #endregion

        #region Property Methods
        public int RoommNu
        {
            get { return room_Number; }
            set { room_Number = value; }
        }

        public bool Status
        {
            set { roomStatus = value; }
            get { return roomStatus; }
        }

        #endregion

        #region Constructor

        public Room(int room_number)
        {
            this.room_Number = room_number;
        }

        #endregion

        #region Utility Methods
        public void ReserveRoom()
        {
            roomStatus = true;
        }

        public void checkout()
        {
            roomStatus = false;
        }

        #endregion



    }
}