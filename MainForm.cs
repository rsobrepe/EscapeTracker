using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HighScore
{
    
    public partial class MainForm : Form
    {
        int passVal = 0;
        int failVal = 0;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Times.mdf;Integrated Security=True");
        public MainForm()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
     

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(checkPass.Checked == true)
            {
                passVal = 1;
                failVal = 0;
            }
            else
            {
                failVal = 1;
                passVal = 0;
            }
            string dat = "Insert into [Time]([Room Name], [Time Slot], Pass, Fail, Duration, [Clues Used]) Values('"+comboRoom.SelectedValue+"', '"+ txtTimeSlot.Text +"', '"+ passVal +"','"+ failVal +"', '"+ txtDuration.Text +"', '"+ txtClues.Text +"')";
            SqlCommand com = new SqlCommand(dat, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Time Successfully Inputed!");
        }
    }
}
