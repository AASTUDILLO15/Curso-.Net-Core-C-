using Logica;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form1 : Form
    {
        private StudentsClass students;
        public Form1()
        {
            InitializeComponent();

            var ListTextBox = new List<TextBox>();//lista con los datos de textBox
            ListTextBox.Add(textBoxFirstName);
            ListTextBox.Add(textBoxLastName);
            ListTextBox.Add(textBoxIdentification);
            ListTextBox.Add(textBoxEmail);

            var ListLabel = new List<Label>();//lista con las label
            ListLabel.Add(labelFName);
            ListLabel.Add(labelLName);
            ListLabel.Add(labelID);
            ListLabel.Add(labelEmail);
            ListLabel.Add(labelPage);

            Object[] objects = { pictureBoxStudents,
                                Properties.Resources._130manwomanstudent2_100617,
                                studentGridView,
                                numericUpDown1 };

            students = new StudentsClass(ListTextBox, ListLabel, objects);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxStudents_Click(object sender, EventArgs e)
        {
            students.uploadImage.Upload(pictureBoxStudents);
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Equals(""))
            {
                labelFName.ForeColor = Color.DarkCyan;
                labelFName.Text = "First Name";
            }
            else
            {
                labelFName.ForeColor = Color.Green;
                labelFName.Text = "Great First Name!";
            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            students.textBoxEvent.textKeyPress(e);
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLastName.Text.Equals(""))
            {
                labelLName.ForeColor = Color.DarkCyan;
                labelLName.Text = "Last Name";
            }
            else
            {
                labelLName.ForeColor = Color.Green;
                labelLName.Text = "Great Last Name!";
            }
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            students.textBoxEvent.textKeyPress(e);
        }

        private void textBoxIdentification_TextChanged(object sender, EventArgs e)
        {
            if (textBoxIdentification.Text.Equals(""))
            {
                labelID.ForeColor = Color.DarkCyan;
                labelID.Text = "Identification";
            }
            else
            {
                labelID.ForeColor = Color.Green;
                labelID.Text = "Identification";
            }
        }

        private void textBoxIdentification_KeyPress(object sender, KeyPressEventArgs e)
        {
            students.numBoxEvent.numKeyPress(e);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.DarkCyan;
                labelEmail.Text = "E-mail";
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "Cool E-mail";
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            students.textBoxEvent.emailKeyPress(e);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            students.Register();
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            students.SearchStudent(textBoxFind.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            students.Pagin("first");
        }

        private void buttonPreviusPage_Click(object sender, EventArgs e)
        {
            students.Pagin("prior");
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            students.Pagin("next");
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            students.Pagin("last");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            students.Reg_Pages();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            students.Refresh();
        }

        private void studentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentGridView.Rows.Count != 0)
            {
                students.GetStudent();
            }
        }

        private void studentGridView_KeyUp(object sender, KeyEventArgs e)
        {
            if (studentGridView.Rows.Count != 0)
            {
                students.GetStudent();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            students.Delete();
        }
    }
}
