using FlowerShopMVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShopMVP.View
{
    public partial class AdminGUI : Form, IAdminGUI
    {
        private AdminPresenter adminPresenter;

        public AdminGUI()
        {
            InitializeComponent();
            this.adminPresenter = new AdminPresenter(this);
        }

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void SetUserID(uint id)
        {
            this.numericUpDownUserID.Value = id;
        }

        public uint GetUserID()
        {
            return (uint)this.numericUpDownUserID.Value;
        }

        public void SetUsername(string username)
        {
            this.textBoxUsername.Text = username;
        }

        public string GetUsername()
        {
            return this.textBoxUsername.Text;
        }

        public void SetPassword(string password)
        {
            this.textBoxPassword.Text = password;
        }

        public string GetPassword()
        {
            return this.textBoxPassword.Text;
        }

        public void SetRole(string role)
        {
            this.textBoxRole.Text = role;
        }

        public string GetRole()
        {
            return this.textBoxRole.Text;
        }

        public void SetFloristID(uint floristID)
        {
            this.numericUpDownFloristID.Value = floristID;
        }

        public uint GetFloristID()
        {
            return (uint)this.numericUpDownFloristID.Value;
        }

        public int GetSelectedUser()
        {
            return this.dataGridViewUserTable.SelectedRows.Count;
        }

        public string GetSelectedUserID()
        {
            return (string)this.dataGridViewUserTable.SelectedRows[0].Cells[0].Value;
        }

        public void AddRowDgvUserTable(DataGridViewRow row)
        {
            this.dataGridViewUserTable.Rows.Add(row);
        }

        public DataGridViewRow GetFirstSelectedRow()
        {
            return this.dataGridViewUserTable.SelectedRows[0];
        }

        public int GetSelectedRowsNumber()
        {
            return this.dataGridViewUserTable.SelectedRows.Count;
        }

        public void ResetDgvUserTable()
        {
            this.dataGridViewUserTable.Rows.Clear();
        }

        public DataGridViewRowCollection GetDgvUserRows()
        {
            return this.dataGridViewUserTable.Rows;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.adminPresenter.AddUser();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.adminPresenter.UpdateUser();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.adminPresenter.DeleteUser();
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            this.adminPresenter.LoadUserTable();
        }

        private void dgvUserTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            this.adminPresenter.SetUserControls();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.adminPresenter.Logout();
        }
    }
}
