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
    class CreditCardDB: DB
    {
        #region  Data members        
        private string table = "Credit_Card";
        private string sqlLocal = "SELECT * FROM Credit_Card";
        private Collection<CreditCard> cards;
        #endregion

        #region Property Method: Collection
        public Collection<CreditCard> AllCards
        {
            get
            {
                return cards;
            }
        }
        #endregion

        #region Constructor
        public CreditCardDB() : base()
        {
            cards = new Collection<CreditCard>();
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
            CreditCard aCard;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Booking object
                    String ccNum = Convert.ToString(myRow["CC_Number"]).TrimEnd();
                    int cccId = Convert.ToInt32(myRow["CCC_ID"]);
                    int expirationMonth = Convert.ToInt32(myRow["Expiration_Month"]);
                    int expirationYear = Convert.ToInt32(myRow["Expiration_Year"]);
                    aCard = new CreditCard(ccNum, cccId, expirationMonth, expirationYear);

                    cards.Add(aCard);
                }
            }
        }

        private void FillRow(DataRow aRow, CreditCard aCard, DB.DBOperation operation)
        {
            if (operation.Equals(DB.DBOperation.Add))
            {
                aRow["CC_Number"] = aCard.CreditCardNum;
            }

            aRow["CCC_ID"] = aCard.CCCId;
            aRow["Expiration_Month"] = aCard.ExperationM;
            aRow["Expiration_Year"] = aCard.ExperationY;
        }

        private int FindRow(CreditCard aCard, string table)
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
                    if (aCard.CreditCardNum.Equals(Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["CC_Number"])))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }

        #region Database Operations CRUD
        public void DataSetChange(CreditCard aCard, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, aCard, DBOperation.Add);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aCard, table)];
                    FillRow(aRow, aCard, DBOperation.Edit);
                    break;
                case DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(aCard, table)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@CC_Number", SqlDbType.NChar, 16, "CC_Number");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CCC_ID", SqlDbType.Int);
            param.SourceColumn = "CCC_ID";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Expiration_Month", SqlDbType.Int);
            param.SourceColumn = "Expiration_Month";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Expiration_Year", SqlDbType.Int);
            param.SourceColumn = "Expiration_Year";
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@CC_Number", SqlDbType.NChar, 16, "CC_Number");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CCC_ID", SqlDbType.Int);
            param.SourceColumn = "CCC_ID";
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Expiration_Month", SqlDbType.Int);
            param.SourceColumn = "Expiration_Month";
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Expiration_Year", SqlDbType.Int);
            param.SourceColumn = "Expiration_Year";
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_CC_Number", SqlDbType.NChar, 16, "CC_Number");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command()
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Credit_Card (CC_Number, CCC_ID, Expiration_Month, Expiration_Year) VALUES (@CC_Number, @CCC_ID, @Expiration_Month, @Expiration_Year)", cnMain);
            Build_INSERT_Parameters();
        }

        private void Create_UPDATE_Command()
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Credit_Card SET CC_Number=@CC_Number, CCC_ID=@CCC_ID, Expiration_Month=@Expiration_Month, Expiration_Year=@Expiration_Year, WHERE CC_Number=@Original_CC_Number", cnMain);
            Build_UPDATE_Parameters();
        }

        private void Create_DELETE_Command()
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Credit_Card WHERE CC_Number=@CC_Number", cnMain);
            Build_DELETE_Parameters();
        }

        private void Build_DELETE_Parameters()
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@CC_Number", SqlDbType.NChar, 16, "CC_Number");
            param.SourceVersion = DataRowVersion.Current;
            daMain.DeleteCommand.Parameters.Add(param);
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
