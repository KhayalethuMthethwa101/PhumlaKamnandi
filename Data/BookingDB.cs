using PhumlaKamnandi.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandi.Data
{
    public class BookingDB: DB
    {
        #region  Data members        
        private string table = "Booking";
        private string sqlLocal = "SELECT * FROM Booking";
        private Collection<Booking> bookings;
        #endregion

        #region Property Method: Collection
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
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
            Booking aBooking;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Booking object
                    int bookingID = Convert.ToInt32(myRow["BookingID"]);
                    int guestID = Convert.ToInt32(myRow["GuestID"]);
                    int roomID = Convert.ToInt32(myRow["Room_Number"]);
                    String checkin = Convert.ToString(myRow["Check_In"]).TrimEnd();
                    String checkout = Convert.ToString(myRow["Check_Out"]).TrimEnd();
                    decimal totalFee = Convert.ToDecimal(myRow["Total_Fee"]);

                    aBooking = new Booking( guestID, roomID, checkin, checkout, totalFee);
                    aBooking.BookingID = bookingID;

                    bookings.Add(aBooking);
                }
            }
        }
        private void FillRow(DataRow aRow, Booking aBooking, DB.DBOperation operation)
        {
            aRow["BookingID"] = aBooking.BookingID;
            aRow["GuestID"] = aBooking.GuestId;
            aRow["Room_Number"] = aBooking.RoomId;
            aRow["Check_In"] = aBooking.Checkin;
            aRow["Check_Out"] = aBooking.CheckOut;
            aRow["Total_Fee"] = aBooking.TOTALFee;
        }

        private int FindRow(Booking aBooking, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (aBooking.BookingID == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        #region Database Operations CRUD
        public void DataSetChange(Booking aBooking, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, aBooking, DBOperation.Add);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aBooking, table)];
                    FillRow(aRow, aBooking, DBOperation.Edit);
                    break;
                case DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(aBooking, table)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.Int);
            param.SourceColumn = "BookingID";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.Int);
            param.SourceColumn = "GuestID";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Room_Number", SqlDbType.Int);
            param.SourceColumn = "Room_Number";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Check_In", SqlDbType.Date);
            param.SourceColumn = "Check_In";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Check_Out", SqlDbType.Date);
            param.SourceColumn = "Check_Out";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Total_Fee", SqlDbType.Money);
            param.SourceColumn = "Total_Fee";
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.Int);
            param.SourceColumn = "GuestID";
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Room_Number", SqlDbType.Int);
            param.SourceColumn = "Room_Number";
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Check_In", SqlDbType.Date);
            param.SourceColumn = "Check_In";
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Check_Out", SqlDbType.Date);
            param.SourceColumn = "Check_Out";
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Total_Fee", SqlDbType.Money);
            param.SourceColumn = "Total_Fee";
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_BookingID", SqlDbType.Int);
            param.SourceColumn = "BookingID";
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command()
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Booking (BookingID,GuestID, Room_Number, Check_In, Check_Out, Total_Fee) VALUES (@BookingID, @GuestID, @Room_Number, @Check_In, @Check_Out, @Total_Fee)", cnMain);
            Build_INSERT_Parameters();
        }

        private void Create_UPDATE_Command()
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET GuestID=@GuestID, Room_Number=@Room_Number, Check_In=@Check_In, Check_Out=@Check_Out, Total_Fee=@Total_Fee WHERE BookingID=@Original_BookingID", cnMain);
            Build_UPDATE_Parameters();
        }

       

        private void Build_DELETE_Parameters()
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@BookingID", SqlDbType.Int);
            param.SourceColumn = "BookingID";
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_DELETE_Command()
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE BookingID=@BookingID", cnMain);
            Build_DELETE_Parameters();
        }

        public bool UpdateDataSource(DB.DBOperation operation)
        {
            switch (operation)
            {
                case DBOperation.Add:
                    Create_INSERT_Command();
                    break;
                case DBOperation.Edit:
                    Create_UPDATE_Command();
                    break;
                case DBOperation.Delete:
                    Create_DELETE_Command();
                    break;
            }

            return UpdateDataSource(sqlLocal, table);
        }

        #endregion
    }
}
