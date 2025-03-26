using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagerWinform
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        public int GetStudentID()
        {
            if (int.TryParse(textBox1.Text, out int studentID))
            {
                return studentID;
            }
            else
            {
                throw new FormatException("Invalid student ID format.");
            }

        }

        public string GetStudentName()
        {
            return textBox2.Text;
        }

        public int GetStudentAge()
        {
            if (int.TryParse(textBox3.Text, out int studentAge))
            {
                return studentAge;
            }
            else
            {
                throw new FormatException("Invalid student Age format.");
            }

        }

        public string GetStudentGrade()
        {
            return textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
