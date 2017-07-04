using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace BIOM_ALYSSAR1._5
{
    public partial class ClockOut : Form
    {
        public ClockOut()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (3 * 1000); // 10 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            getAttendance();
            // timer_Tick();
            // ValidateUser();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            getAttendance();
        }

        protected void getAttendance()
        {
            //string constring = @"Server=localhost; Database=sdtestdb; UID =root; PWD=1234;";
            MySqlConnection con = new MySqlConnection(Helper.GetConnection());
            MySqlCommand com = new MySqlCommand();
            com.Connection = con;
            com.CommandText = "SELECT employeeID, concat(lastName, ', ', firstName) As FullName, division, timeIn, timeOut FROM employee " +
                                 "INNER JOIN employeeattendance ON employee.employeeID = employeeattendance.employee_employeeID WHERE DATE_FORMAT(timeIn, '%Y-%m-%d') = curdate() ORDER BY employeeattendanceID desc ";
            com.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.Columns[0].Name = "employeeID";
            dataGridView1.Columns[0].HeaderText = "Employee ID";
            dataGridView1.Columns[0].DataPropertyName = "employeeID";

            dataGridView1.Columns[1].Name = "FullName";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[1].DataPropertyName = "FullName";

            /* dataGridView1.Columns[2].Name = "lastName";
             dataGridView1.Columns[2].HeaderText = "Last Name";
             dataGridView1.Columns[2].DataPropertyName = "lastName";*/

            dataGridView1.Columns[2].Name = "division";
            dataGridView1.Columns[2].HeaderText = "Division";
            dataGridView1.Columns[2].DataPropertyName = "division";

            dataGridView1.Columns[3].Name = "timeIn";
            dataGridView1.Columns[3].HeaderText = "Time In";
            dataGridView1.Columns[3].DataPropertyName = "timeIn";

            dataGridView1.Columns[4].Name = "timeOut";
            dataGridView1.Columns[4].HeaderText = "Time Out";
            dataGridView1.Columns[4].DataPropertyName = "timeOut";

            dataGridView1.DataSource = dt;
        }
        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
