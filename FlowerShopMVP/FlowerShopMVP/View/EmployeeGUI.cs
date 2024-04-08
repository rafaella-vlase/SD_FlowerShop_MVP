using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowerShopMVP.Presenter;

namespace FlowerShopMVP.View
{
    public partial class EmployeeGUI : Form, IEmployeeGUI
    {
        private EmployeePresenter employeePresenter;
        private uint floristID;
        public EmployeeGUI(uint floristID)
        {
            InitializeComponent();
            this.floristID = floristID;
            this.employeePresenter = new EmployeePresenter(this, floristID);
        }

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void SetFlowerID(uint flowerID)
        {
            this.numericUpDownFlowerID.Value = flowerID;
        }

        public uint GetFlowerID()
        {
            return (uint)this.numericUpDownFlowerID.Value;
        }

        public void SetFloristID(uint floristID)
        {
            this.numericUpDownFloristID.Value = floristID;
        }

        public uint GetFloristID()
        {
            return (uint)this.numericUpDownFloristID.Value;
        }

        public void SetType(string type)
        {
            this.textBoxType.Text = type;
        }

        public string GetType()
        {
            return this.textBoxType.Text;
        }

        public void SetColor(string color)
        {
            this.textBoxColor.Text = color;
        }

        public string GetColor()
        {
            return this.textBoxColor.Text;
        }

        public void SetPrice(float price)
        {
            this.textBoxPrice.Text = price.ToString();
        }

        public float GetPrice()
        {
            return (float)Convert.ToDouble(this.textBoxPrice.Text);
        }

        public void SetStock(int stock)
        {
            this.textBoxStock.Text = stock.ToString();
        }

        public int GetStock()
        {
            return Convert.ToInt32(this.textBoxStock.Text);
        }

        public void SetAvailability(string isAvailable)
        {
            this.comboBoxAvailable.SelectedItem = isAvailable;
        }

        public string GetAvailability()
        {
            return this.comboBoxAvailable.SelectedItem.ToString();
        }

        public void ResetSelectedCriterion()
        {
            this.comboBoxFilterBy.SelectedIndex = 0;
        }

        public string GetSelectedCriterion()
        {
            return this.comboBoxFilterBy.SelectedItem.ToString();
        }

        public int GetSelectedFlower()
        {
            return this.dataGridView1.SelectedRows.Count;
        }

        public string GetSelectedFlowerID()
        {
            return (string)this.dataGridView1.SelectedRows[0].Cells[0].Value;
        }

        public void AddRowDgvFlowerTable(DataGridViewRow row)
        {
            this.dataGridView1.Rows.Add(row);
        }

        public DataGridViewRow GetFirstSelectedRow()
        {
            return this.dataGridView1.SelectedRows[0];
        }

        public void ResetDgvFlowerTable()
        {
            this.dataGridView1.Rows.Clear();
        }

        public DataGridViewRowCollection GetDgvFlowerRows()
        {
            return this.dataGridView1.Rows;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.employeePresenter.AddFlower();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.employeePresenter.UpdateFlower();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.employeePresenter.DeleteFlower();
        }

        private void dgvFlowerTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            this.employeePresenter.SetFlowerControls();
        }

        // GUI Specific====================================================================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFontChanged(e);
            Environment.Exit(0);
        }

        public void SetVisibility(bool visible)
        {
            this.comboBoxFilterBy.Visible = visible;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.employeePresenter.SearchFlowerByName(floristID);
        }

        public string GetSearchedInformation()
        {
            return this.textBoxSearch.Text;
        }

        public int GetSelectedRowsNumber()
        {
            return this.dataGridView1.SelectedRows.Count;
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            this.employeePresenter.LoadFlowerTableEmployee();
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.employeePresenter.FlowerTableFilterBy();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.employeePresenter.Logout();
        }
    }
}
