﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllInfo
{
    public partial class VL : Form
    {
        private string name;
        public VL()
        {
            InitializeComponent();
        }

        private void VL_Load(object sender, EventArgs e)
        {
            this.Hide();
            //  FacultyHomepage fh = new FacultyHomepage();
            //  fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (bookdbmlDataContext data = new bookdbmlDataContext())
                {
                    bookinfo Book = data.bookinfos.Single(Bookinfo => Bookinfo.Name == textBox1.Text);
                    name = Book.Name;

                    MessageBox.Show("This Book is Available In the Library ");
                    textBox1.Text = null;

                }
            }
            catch
            {
                MessageBox.Show("This Book is not Available In the Library ");
                textBox1.Text = null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            axAcroPDF1.Show();
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = @"C:\Users\Tomal\Documents\Visual Studio 2013\Projects\AllInfo\pdf";

            if (op.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.LoadFile(op.FileName);
            }
        }
        }
    }

