using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AllInfo
{
    // StudentLinqDataContext db = new StudentLinqDataContext();
    public partial class Form2Student : Form
    {
        private string temp1;
        public Form2Student()
        {
            InitializeComponent();
        }
        

        
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
              
                StudentLinqDataContext dbc = new StudentLinqDataContext();
                studentinfo st = new studentinfo();
                
                    //MessageBox.Show("Name is required");
                TextBox[] newTextBox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7,
                                       textBox8,textBox11,textBox10};
                for (int inti = 0; inti < newTextBox.Length; inti++)
                {
                    if (newTextBox[inti].Text == string.Empty)
                    {
                        MessageBox.Show("Please fill the text boxs");
                        newTextBox[inti].Focus();
                        return;
                    }
                    else
                    {


                        st.StudentName = textBox1.Text;


                        //MessageBox.Show("Father Name is required");


                        st.FatherName = textBox2.Text;


                        st.Email = textBox3.Text;
                        st.Mobile = textBox4.Text;
                        st.Age = textBox5.Text;
                        st.Sex = textBox6.Text;
                        st.Religion = textBox7.Text;
                        st.AdmissionYear = textBox8.Text;
                        st.CreatePassword = textBox10.Text;
                        st.Department = textBox11.Text;
                        dbc.studentinfos.InsertOnSubmit(st);
                        dbc.SubmitChanges();
                        File.Copy(temp1, @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\AllInfo\studentpropic\" + textBox1.Text + ".jpg");

                        MessageBox.Show("Data Inserted");
                    }
                }
                
              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something wrong !!!");
            }



        }

        private void Form2Student_Load(object sender, EventArgs e)
        {

        }

 
        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Jpg files|*.jpg";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                textBox9.Text = openFileDialog1.FileName;
                temp1 = openFileDialog1.FileName;
                // textBox11.Text = temp1;
                // bookName=openFileDialog1.SafeFileName;
                // MessageBox.Show(openFileDialog1.SafeFileName);




            }
        }

        private void Form2Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
