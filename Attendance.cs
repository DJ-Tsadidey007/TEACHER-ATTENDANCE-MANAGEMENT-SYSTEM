using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Speech;
using System.Speech.Synthesis;
using System.Media;
namespace NPBIOMETRIC
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource2.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.attendanceRecDataSet);

        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceRecDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter2.Fill(this.attendanceRecDataSet.Table1);
            // TODO: This line of code loads data into the 'enlistDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter1.Fill(this.enlistDataSet.Table1);
            // TODO: This line of code loads data into the 'attendanceDataSet.Table1' table. You can move, or remove it, as needed.
           // this.table1TableAdapter.Fill(this.attendanceDataSet.Table1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("FINGER PRINT SCANNING BEGIN");


            Process.Start("C:/Users/user/Desktop/Selasi Project2/PMS BIOMETRIC ATTENDANCE SYSTEM/bin/Debug/UareUSampleCSharp");
        }
        string jill;
        string tile;
        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader milk;
            milk = File.OpenText("cry.txt");
           jill = milk.ReadLine();
            milk.Close();

          BindingSource bs = new BindingSource();
          bs.DataSource = table1DataGridView.DataSource;
          bs.Filter = string.Format("CONVERT(" + table1DataGridView.Columns[1].DataPropertyName + ",System.String) like '%" + jill.Replace("'", "''") + "%'");
          table1DataGridView.Refresh();

          tile = imageTextBox.Text;

          pictureBox1.Image = new Bitmap(tile);

          staff_IDTextBox.Text = staff_IDTextBox1.Text;
          staff_NameTextBox.Text = staff_NameTextBox1.Text;
          time_ArrivedDateTimePicker.Text = time_ArrivedDateTimePicker2.Text;

        //  staff_IDTextBox2.Text = staff_IDTextBox.Text;
         // staff_NameTextBox2.Text = staff_NameTextBox.Text;


          MessageBox.Show("STAFF IDENTIFIED!");

          this.Validate();
          this.table1BindingSource2.EndEdit();
          this.tableAdapterManager2.UpdateAll(this.attendanceRecDataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
