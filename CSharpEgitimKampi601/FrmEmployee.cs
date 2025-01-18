﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost; port=5432; user Id=postgres; Database=Customer; Password=Prokilit";

        void EmployeeList()
        {
            var connection= new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Employees";
            var command= new NpgsqlCommand(query, connection);
            var adapter=new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource=dataTable;
            connection.Close();
        }
        void DepartmentList()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Departments";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "DepartmentId";
            cmbDepartment.DataSource = dataTable;
            connection.Close();
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            EmployeeList();
            DepartmentList();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            string employeeName=txtEmployeeName.Text;
            string employeeSurname=txtEmployeeSurname.Text; 
            decimal employeSalary=decimal.Parse(txtEmployeeSalary.Text);
            int departmentId=int.Parse(cmbDepartment.SelectedValue.ToString());

            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Employees (EmployeeName,EmployeeSurname,EmployeSalary,DepartmentId) values (@employeeName,@employeeSurname,@employeeSalary,@departmentid)";
            var command= new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@employeeName", employeeName); 
            command.Parameters.AddWithValue("@employeeSurname", employeeSurname); 
            command.Parameters.AddWithValue("@employeeSalary", employeSalary); 
            command.Parameters.AddWithValue("@departmentid", departmentId); 
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ekleme işlemi başarılı");
            EmployeeList();

        }
    }
}
