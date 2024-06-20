using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Business;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PhumlaKamnandi.Presentation_Layer
{
    public partial class Hotels_Services : Form
    {
        private Reserve reserve;
     
        public Hotels_Services(Reserve reserve)
        {
            /*   InitializeComponent();
             this.reserve = reserve;
             setupOccupancyLevelsListview();
             this.Load += OccupancyLevelReport_Load;
             this.FormClosed += OccupancyLevelReport_FormClosed;
             this.Activated += OccupancyLevelReport_Activated;

         }

       private void setupOccupancyLevelsListview()
         {


             listView.Clear();
             listView.Columns.Insert(0, "Guest Name", 120, HorizontalAlignment.Left);
             listView.Columns.Insert(1, "Checkin", 120, HorizontalAlignment.Left);
             listView.Columns.Insert(2, "Checkout", 120, HorizontalAlignment.Left);
             listView.Columns.Insert(3, "Avg Rate", 120, HorizontalAlignment.Left);
             listView.Columns.Insert(4, "Total", 120, HorizontalAlignment.Left);

             listView.Refresh();
             listView.GridLines = true;
         }


         private void OccupancyLevelReport_Load(object sender, EventArgs e)
         {
             DoughnutChart();
             LineGraph();

             listView.View = View.Details;
         }

         #region Graph set up
         public void DoughnutChart()
         {
             // assigning x and y values for the Doughnut chart
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Jan", 800);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Feb", 750);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Mar", 670);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Apr", 700);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("May", 600);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Jun", 500);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Jul", 450);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Aug", 300);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Sep", 550);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Oct", 600);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Nov", 700);
             chartYearlyOccupanyDoughnut.Series["yearlyOccupancyLevels"].Points.AddXY("Dec", 1000);
         }

         public void LineGraph()
         {
             //assigning x and y values for the LineGraph
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Jan", 800);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Feb", 750);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Mar", 670);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Apr", 700);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("May", 600);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Jun", 500);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Jul", 450);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Aug", 300);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Sep", 550);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Oct", 600);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Nov", 700);
             chartLineYearlyLevels.Series["lineYearlyLevels"].Points.AddXY("Dec", 1000);

         }

         #endregion

         private void buttonConfirm_Click(object sender, EventArgs e)
         {
             DateTime date = occupancyDateSelector.Value;
             Collection<Booking> occupancies = reserve.Occupancy(date);
             Debug.WriteLine(occupancies.Count());
             RoomFee roomFee = new RoomFee();
             decimal rate = roomFee.TotalFee(date);
             int total4month = reserve.OccupancyByMonth(date);



             foreach (Booking booking in occupancies)
             {
                 ListViewItem occupancydetails;
                 occupancydetails = new ListViewItem();

                 occupancydetails.Text = reserve.FindGuest(booking.GuestId.ToString()).Name;
                 occupancydetails.SubItems.Add(booking.Checkin.ToString());
                 occupancydetails.SubItems.Add(booking.CheckOut.ToString());
                 occupancydetails.SubItems.Add(rate.ToString());
                 occupancydetails.SubItems.Add(booking.TOTALFee.ToString());

                 listView.Items.Add(occupancydetails);
             }

             listView.Refresh();
             listView.GridLines = true;

             txtTotalBookings.Text = occupancies.Count.ToString();
             txtBookings4Month.Text = total4month.ToString();
             txtAvailability.Text = reserve.RoomsAvailable(date).Count + "";
         }

         private void OccupancyLevelReport_Activated(object sender, EventArgs e)
         {
             listView.View = View.Details;
             setupOccupancyLevelsListview();

         }

            private void OccupancyLevelReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            //listformclosed = true;
            this.Hide();
          
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
*/
        }
    }
}
