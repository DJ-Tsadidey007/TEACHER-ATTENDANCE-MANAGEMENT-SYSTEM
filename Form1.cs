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
using System.Media;
using System.IO;
using System.Speech;
using System.Speech.Synthesis;
namespace NPBIOMETRIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            STAFFMEM.Show();
            ADLOT.Show();
            ADLIN.Show();
            STUD.Show();

            STAFFMEM.Enabled = true;
                ADLOT.Enabled = true;
                ADLIN.Enabled = true;
                STUD.Enabled = true;
                admintb.Text = null;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (admintb.Text =="admin101")
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak("ADMINISTRATOR LOG IN");
                admintb.Clear();
                adminstatus.Text = "Successful!";
                tabControl1.Visible = true;

                // TODO: This line of code loads data into the 'attendanceDataSet.Table1' table. You can move, or remove it, as needed.
                this.table1TableAdapter2.Fill(this.attendanceRecDataSet.Table1);
                // TODO: This line of code loads data into the 'enlistDataSet.Table1' table. You can move, or remove it, as needed.
                this.table1TableAdapter.Fill(this.enlistDataSet.Table1);

                this.reportViewer1.RefreshReport();
            }
            else
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Speak("ADMINISTRATOR CANNOT LOG IN");
                adminstatus.Text = "Unsuccessful!";
            }
        }

        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.enlistDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceRecDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter2.Fill(this.attendanceRecDataSet.Table1);
            // TODO: This line of code loads data into the 'attendanceDataSet.Table1' table. You can move, or remove it, as needed.
           // this.table1TableAdapter1.Fill(this.attendanceDataSet.Table1);
            // TODO: This line of code loads data into the 'enlistDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.enlistDataSet.Table1);



            this.reportViewer1.RefreshReport();
        }
        string strfilepath = "";
        string getpath = "";
        Image defaultimage, defaultvid;
        Byte[] ImageByteArray;
        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg) | *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strfilepath = ofd.FileName;
                pictureBox1.Image = new Bitmap(strfilepath);
                defaultimage = pictureBox1.Image;
              //  imagePictureBox.Image = pictureBox1.Image;

                imageTextBox.Text = strfilepath;
               
            }
        }
        string mile = "";
        private void button7_Click(object sender, EventArgs e)
        {
            mile = staffName.Text;

            StreamWriter pry;
            pry = File.CreateText("cry.txt");
            pry.WriteLine(mile);
            pry.Close();

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("GETTING BIO DATA PLEASE WAIT");

            Process.Start("C:/Users/user/Desktop/Selasi Project2/PMS BIOMETRIC ATTENDANCE SYSTEM/bin/Debug/UareUSampleCSharp");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            
                fP_ScanTextBox.Text = mile;

                mile = staffName.Text;

                StreamWriter pry;
                pry = File.CreateText("cry.txt");
                pry.WriteLine(mile);
                pry.Close();
            //This is to handle the situation whereby any of the fields is empty
                if (staffID.Text == "") { MessageBox.Show("Staff ID must be empty!"); }
                if (staffName.Text == "") { MessageBox.Show("Staff Name must be empty!"); }
                if (regNum.Text == "") { MessageBox.Show("Registered Number must be empty!"); }
                if (acadQual.Text == "") { MessageBox.Show("Academic Qualification must be empty!"); }
                if (profQual.Text == "") { MessageBox.Show("Professional Qualification must be empty!"); }
            //This line of code declares that the adminitrator has registered the staff member
                this.Validate();
                this.table1BindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.enlistDataSet);
                MessageBox.Show("STAFF REGISTERED SUCCESSFULLY");
            
            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("STAFF SIGNING IN");
            Form att = new Attendance();
            att.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                verifiedTextBox1.Text = "ATTENDANCE VERIFIED";
                verifiedTextBox.Text = "ATTENDANCE VERIFIED";
                this.Validate();
                this.table1BindingSource2.EndEdit();
                this.tableAdapterManager2.UpdateAll(this.attendanceRecDataSet);

            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                verifiedTextBox1.Text = "ATTENDANCE DISCREDITED";
                verifiedTextBox.Text = "ATTENDANCE DISCREDITED";
                this.Validate();
                this.table1BindingSource2.EndEdit();
                this.tableAdapterManager2.UpdateAll(this.attendanceRecDataSet);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            remarksTextBox1.Text = remarksTextBox.Text;
            this.Validate();
            this.table1BindingSource2.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.attendanceRecDataSet);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            verifiedTextBox1.Text = "ATTENDANCE VERIFIED";
            this.Validate();
            this.table1BindingSource2.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.attendanceRecDataSet);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            adminstatus.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SpeechSynthesizer selassie = new SpeechSynthesizer();
            selassie.Speak("Student Log In!");
            SMS student = new SMS();
            student.Show();
        }

        private void essghana_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://https://www.facebook.com");
        }

        private void IDSUBMIT_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* if (radioButton2.Checked)
            {
                verifiedTextBox1.Text = "ATTENDANCE DISCREDITED";
                verifiedTextBox.Text = "ATTENDANCE DISCREDITED";
                this.Validate();
                this.table1BindingSource2.EndEdit();
                this.tableAdapterManager2.UpdateAll(this.attendanceRecDataSet);*/

            if (adminrdb.Checked)
            {
                STAFFMEM.Hide();
                STUD.Hide();
            }
            else if (staffrdb.Checked)
            {
                admintb.Hide();
                STAFFMEM.Enabled = true;
                STAFFMEM.Show();
                ADLOT.Hide();
                ADLIN.Hide();
                STUD.Hide();
            } 
            else if (studentrdb.Checked)
            {
                admintb.Hide();
                STUD.Enabled = true;
                STUD.Show();
                ADLOT.Hide();
                ADLIN.Hide();
                STAFFMEM.Hide();
            }
        }
    }
}
