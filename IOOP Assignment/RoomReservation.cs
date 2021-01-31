using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    public partial class RoomReserve : Form
    {
        SqlConnection conn = new SqlConnection();

        public RoomReserve()
        {
            InitializeComponent();
        }

        private void RoomReserve_Load(object sender, EventArgs e)
        {
            panelHome.BringToFront();
            lblWelcome.Text = "Welcome xxx !!!";
            setDateTime();
            setTimeCombo();
            addItemToCbo();
        }

        private void amberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAReserve.BringToFront();
        }

        private void blackThornToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelBReserve.BringToFront();
        }

        private void cedarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCReserve.BringToFront();
        }

        private void daphneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDReserve.BringToFront();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void panelChangeRequest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeRoomRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelChangeRequest.BringToFront();
        }

        private void btnMakeChange_Click(object sender, EventArgs e)
        {
            panelRequestForm.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelHome.BringToFront();
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            panelChangeRequest.BringToFront();
        }

        private void setDateTime()
        {
            //set time pick start from today
            timePicker.MinDate = DateTime.Now;
            timePicker.MaxDate = DateTime.Now.AddDays(14);
        }

        private void setTimeCombo()
        {
            //set current date to dt
            DateTime dt = DateTime.Now;

            for (int i = 1; i < 30; i += 5)
            {
                dt = dt.AddMinutes(i);
                cboTime.Items.Add(dt.ToShortTimeString());
            }
        }

        private void addItemToCbo()
        {
            string alpha = null;
            cboRType.Items.Add("Amber");
            cboRType.Items.Add("BlackThorn");
            cboRType.Items.Add("Cedar");
            cboRType.Items.Add("Daphne");
            for (int i = 1; i<5; i++)
            {
               if (i == 1) 
                {
                    alpha = "A";
                    for (int id = 1; id < 6; id++)
                    {
                        cboRiD.Items.Add(alpha + id);
                    }
                }
               if (i == 2)
                {
                    alpha = "B";
                    for (int id = 1; id < 5; id++)
                    {
                        cboRiD.Items.Add(alpha + id);
                    }
                }
               if (i == 3) 
                {
                    alpha = "C";
                    for (int id = 1; id < 7; id++)
                    {
                        cboRiD.Items.Add(alpha + id);
                    }
                }
               if (i == 4) 
                {
                    alpha = "D";
                    for (int id = 1; id < 6; id++)
                    {
                        cboRiD.Items.Add(alpha + id);
                    }
                }
               
            }
        }
    }
}
