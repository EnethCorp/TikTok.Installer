﻿using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CricBlast_GUI.Database;

namespace CricBlast_GUI.Forms.Admin_Controls
{
    public partial class ManageUser : UserControl
    {
        public ManageUser()
        {
            InitializeComponent();

            using (var sqlConnection = new SqlConnection(ConnectionString.CrikBlastDB))
            {
                sqlConnection.Open();
                var sqlDataAdapter = new SqlDataAdapter("SELECT Username, Email, Password, PhoneNumber, Image FROM Users", sqlConnection);
                var dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                UserDataGridView.Columns[0].DataPropertyName = "Image";
                UserDataGridView.Columns[1].DataPropertyName = "Username";
                UserDataGridView.Columns[2].DataPropertyName = "Email";
                UserDataGridView.Columns[3].DataPropertyName = "Password";
                UserDataGridView.Columns[4].DataPropertyName = "PhoneNumber";
                UserDataGridView.DataSource = dataTable;
            }
        }
    }
}