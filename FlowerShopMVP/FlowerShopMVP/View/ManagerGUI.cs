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
    public partial class ManagerGUI : Form, IManagerGUI
    {
        private ManagerPresenter managerPresenter;
        public ManagerGUI()
        {
            InitializeComponent();
            this.managerPresenter = new ManagerPresenter(this);
        }

        public void SetMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }

        public void HideForm()
        {
            this.Hide();
        }

        public void SetFloristID(uint floristID)
        {
            this.numericUpDownFloristID.Value = floristID;
        }

        public uint GetFloristID()
        {
            return (uint)this.numericUpDownFloristID.Value;
        }

        public void SetFlowerID(uint flowerID)
        {
            this.numericUpDownFlowerID.Value = flowerID;
        }

        public uint GetFlowerID()
        {
            return (uint)this.numericUpDownFlowerID.Value;
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
            return this.comboBoxAvailable.Text;
        }

        public void ResetSelectedCriterionFilterBy()
        {
            this.comboBoxFilterBy.SelectedIndex = 0;
        }

        public string GetSelectedCriterionFilterBy()
        {
            return this.comboBoxFilterBy.SelectedItem.ToString();
        }

        public void ResetSelectedCriterion()
        {
            this.comboBoxViewFlowerList.SelectedIndex = 0;
        }

        public string GetSelectedCriterion()
        {
            return this.comboBoxViewFlowerList.Text;
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

        // GUI Specific====================================================================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFontChanged(e);
            Environment.Exit(0);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.managerPresenter.SearchFlowerByName();
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
            this.managerPresenter.LoadFlowerTable();
        }

        private void comboBoxViewFlowerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.managerPresenter.FlowerTable();
        }

        private void comboBoxFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.managerPresenter.FlowerTableFilterBy();
        }

        private void dgvFlowerTable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            this.managerPresenter.SetFlowerControls();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.managerPresenter.Logout();
        }
    }
}
