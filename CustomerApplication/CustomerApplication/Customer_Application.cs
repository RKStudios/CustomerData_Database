﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


//++++++application gives looping error when there are no entries

namespace CustomerApplication
{
    public partial class Customer_Application : Form
    {
        public Customer_Application()
        {
            InitializeComponent();

            /*
            //create connection object SqlConnection
            SqlConnection sConnect = new SqlConnection();

            //specify connection string for object 
            //string: database location;database name;authentication type
            sConnect.ConnectionString = "data source = RK-PC\\SQLEXPRESS;database = CustomerData;integrated security = SSPI";

            //SQL command to retrieve all data using sql connection
            SqlCommand command = new SqlCommand("select * from Customer", sConnect);

            //open connection to server
            sConnect.Open();

            //read all data
            SqlDataReader sdr = command.ExecuteReader();

            //store sql data source
            BindingSource source = new BindingSource();
            source.DataSource = sdr;

            //fill grid with retrieved data from db
            dataGridView1.DataSource = source;

            //close server connection
            sConnect.Close();
            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
