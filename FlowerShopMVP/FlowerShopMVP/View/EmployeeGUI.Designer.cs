namespace FlowerShopMVP.View
{
    partial class EmployeeGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeGUI));
            labelFlower = new Label();
            panel1 = new Panel();
            numericUpDownFloristID = new NumericUpDown();
            labelFloristID = new Label();
            comboBoxAvailable = new ComboBox();
            textBoxStock = new TextBox();
            textBoxPrice = new TextBox();
            textBoxColor = new TextBox();
            textBoxType = new TextBox();
            numericUpDownFlowerID = new NumericUpDown();
            labelAvailable = new Label();
            labelStock = new Label();
            labelPrice = new Label();
            labelFlowerColor = new Label();
            labelFlowerType = new Label();
            labelFlowerID = new Label();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            labelFilterBy = new Label();
            comboBoxFilterBy = new ComboBox();
            dataGridView1 = new DataGridView();
            flowerID = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            color = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            isAvailable = new DataGridViewTextBoxColumn();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonViewAll = new Button();
            buttonLogout = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloristID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFlowerID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelFlower
            // 
            labelFlower.AutoSize = true;
            labelFlower.BackColor = Color.Transparent;
            labelFlower.Font = new Font("Segoe Script", 16.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelFlower.ForeColor = Color.MistyRose;
            labelFlower.Location = new Point(542, -3);
            labelFlower.Name = "labelFlower";
            labelFlower.Size = new Size(348, 71);
            labelFlower.TabIndex = 0;
            labelFlower.Text = "About flowers";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(numericUpDownFloristID);
            panel1.Controls.Add(labelFloristID);
            panel1.Controls.Add(comboBoxAvailable);
            panel1.Controls.Add(textBoxStock);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(textBoxColor);
            panel1.Controls.Add(textBoxType);
            panel1.Controls.Add(numericUpDownFlowerID);
            panel1.Controls.Add(labelAvailable);
            panel1.Controls.Add(labelStock);
            panel1.Controls.Add(labelPrice);
            panel1.Controls.Add(labelFlowerColor);
            panel1.Controls.Add(labelFlowerType);
            panel1.Controls.Add(labelFlowerID);
            panel1.Location = new Point(404, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 412);
            panel1.TabIndex = 1;
            // 
            // numericUpDownFloristID
            // 
            numericUpDownFloristID.BackColor = Color.MistyRose;
            numericUpDownFloristID.Location = new Point(233, 72);
            numericUpDownFloristID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownFloristID.Name = "numericUpDownFloristID";
            numericUpDownFloristID.Size = new Size(240, 39);
            numericUpDownFloristID.TabIndex = 13;
            // 
            // labelFloristID
            // 
            labelFloristID.AutoSize = true;
            labelFloristID.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFloristID.ForeColor = Color.SeaShell;
            labelFloristID.Location = new Point(41, 79);
            labelFloristID.Name = "labelFloristID";
            labelFloristID.Size = new Size(139, 40);
            labelFloristID.TabIndex = 12;
            labelFloristID.Text = "Florist ID";
            // 
            // comboBoxAvailable
            // 
            comboBoxAvailable.BackColor = Color.MistyRose;
            comboBoxAvailable.FormattingEnabled = true;
            comboBoxAvailable.Items.AddRange(new object[] { "", "yes", "no" });
            comboBoxAvailable.Location = new Point(232, 343);
            comboBoxAvailable.Name = "comboBoxAvailable";
            comboBoxAvailable.Size = new Size(240, 40);
            comboBoxAvailable.TabIndex = 11;
            // 
            // textBoxStock
            // 
            textBoxStock.BackColor = Color.MistyRose;
            textBoxStock.Location = new Point(232, 285);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(240, 39);
            textBoxStock.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.MistyRose;
            textBoxPrice.Location = new Point(232, 234);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(240, 39);
            textBoxPrice.TabIndex = 9;
            // 
            // textBoxColor
            // 
            textBoxColor.BackColor = Color.MistyRose;
            textBoxColor.Location = new Point(232, 181);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(240, 39);
            textBoxColor.TabIndex = 8;
            // 
            // textBoxType
            // 
            textBoxType.BackColor = Color.MistyRose;
            textBoxType.Location = new Point(232, 130);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(240, 39);
            textBoxType.TabIndex = 7;
            // 
            // numericUpDownFlowerID
            // 
            numericUpDownFlowerID.BackColor = Color.MistyRose;
            numericUpDownFlowerID.Location = new Point(232, 16);
            numericUpDownFlowerID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownFlowerID.Name = "numericUpDownFlowerID";
            numericUpDownFlowerID.Size = new Size(240, 39);
            numericUpDownFlowerID.TabIndex = 6;
            // 
            // labelAvailable
            // 
            labelAvailable.AutoSize = true;
            labelAvailable.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAvailable.ForeColor = Color.BlueViolet;
            labelAvailable.Location = new Point(40, 344);
            labelAvailable.Name = "labelAvailable";
            labelAvailable.Size = new Size(136, 40);
            labelAvailable.TabIndex = 5;
            labelAvailable.Text = "Available";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStock.ForeColor = Color.PaleVioletRed;
            labelStock.Location = new Point(41, 288);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(84, 40);
            labelStock.TabIndex = 4;
            labelStock.Text = "Stock";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.SeaShell;
            labelPrice.Location = new Point(40, 237);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(85, 40);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price";
            // 
            // labelFlowerColor
            // 
            labelFlowerColor.AutoSize = true;
            labelFlowerColor.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFlowerColor.ForeColor = Color.SeaShell;
            labelFlowerColor.Location = new Point(40, 181);
            labelFlowerColor.Name = "labelFlowerColor";
            labelFlowerColor.Size = new Size(182, 40);
            labelFlowerColor.TabIndex = 2;
            labelFlowerColor.Text = "Flower Color";
            // 
            // labelFlowerType
            // 
            labelFlowerType.AutoSize = true;
            labelFlowerType.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFlowerType.ForeColor = Color.SeaShell;
            labelFlowerType.Location = new Point(40, 130);
            labelFlowerType.Name = "labelFlowerType";
            labelFlowerType.Size = new Size(174, 40);
            labelFlowerType.TabIndex = 1;
            labelFlowerType.Text = "Flower Type";
            // 
            // labelFlowerID
            // 
            labelFlowerID.AutoSize = true;
            labelFlowerID.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFlowerID.ForeColor = Color.SeaShell;
            labelFlowerID.Location = new Point(40, 23);
            labelFlowerID.Name = "labelFlowerID";
            labelFlowerID.Size = new Size(141, 40);
            labelFlowerID.TabIndex = 0;
            labelFlowerID.Text = "Flower ID";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MistyRose;
            buttonAdd.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(978, 113);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 46);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.MistyRose;
            buttonUpdate.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(978, 256);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(150, 46);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.MistyRose;
            buttonDelete.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(978, 383);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 46);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelFilterBy
            // 
            labelFilterBy.AutoSize = true;
            labelFilterBy.BackColor = Color.Transparent;
            labelFilterBy.Font = new Font("Segoe Script", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilterBy.ForeColor = Color.MistyRose;
            labelFilterBy.Location = new Point(53, 497);
            labelFilterBy.Name = "labelFilterBy";
            labelFilterBy.Size = new Size(168, 48);
            labelFilterBy.TabIndex = 5;
            labelFilterBy.Text = "Filter By:";
            // 
            // comboBoxFilterBy
            // 
            comboBoxFilterBy.BackColor = Color.MistyRose;
            comboBoxFilterBy.FormattingEnabled = true;
            comboBoxFilterBy.Items.AddRange(new object[] { "", "None", "Availability", "Price", "Color", "Stock" });
            comboBoxFilterBy.Location = new Point(53, 546);
            comboBoxFilterBy.Name = "comboBoxFilterBy";
            comboBoxFilterBy.Size = new Size(242, 40);
            comboBoxFilterBy.TabIndex = 6;
            comboBoxFilterBy.SelectedIndexChanged += comboBoxFilterBy_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.MistyRose;
            dataGridViewCellStyle4.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = Color.MistyRose;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { flowerID, type, color, price, stock, isAvailable });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.MistyRose;
            dataGridViewCellStyle5.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(53, 620);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.MistyRose;
            dataGridViewCellStyle6.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1274, 300);
            dataGridView1.TabIndex = 7;
            dataGridView1.RowStateChanged += dgvFlowerTable_RowStateChanged;
            // 
            // flowerID
            // 
            flowerID.HeaderText = "FlowerID";
            flowerID.MinimumWidth = 10;
            flowerID.Name = "flowerID";
            // 
            // type
            // 
            type.HeaderText = "Type";
            type.MinimumWidth = 10;
            type.Name = "type";
            // 
            // color
            // 
            color.HeaderText = "Color";
            color.MinimumWidth = 10;
            color.Name = "color";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 10;
            price.Name = "price";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.MinimumWidth = 10;
            stock.Name = "stock";
            // 
            // isAvailable
            // 
            isAvailable.HeaderText = "Availability";
            isAvailable.MinimumWidth = 10;
            isAvailable.Name = "isAvailable";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.MistyRose;
            textBoxSearch.Location = new Point(328, 547);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(472, 39);
            textBoxSearch.TabIndex = 8;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.MistyRose;
            buttonSearch.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(843, 544);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(210, 46);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(886, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 50);
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(110, 75);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(288, 65);
            pictureBox3.TabIndex = 54;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.portrait_2_transformed;
            pictureBox2.Location = new Point(50, 146);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 189);
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // buttonViewAll
            // 
            buttonViewAll.BackColor = Color.MistyRose;
            buttonViewAll.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewAll.Location = new Point(1117, 544);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(210, 46);
            buttonViewAll.TabIndex = 55;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = false;
            buttonViewAll.Click += buttonViewAll_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.MistyRose;
            buttonLogout.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(65, 383);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(150, 46);
            buttonLogout.TabIndex = 56;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // EmployeeGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1374, 1029);
            Controls.Add(buttonLogout);
            Controls.Add(buttonViewAll);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxFilterBy);
            Controls.Add(labelFilterBy);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(panel1);
            Controls.Add(labelFlower);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeGUI";
            Text = "EmployeeGUI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloristID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFlowerID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFlower;
        private Panel panel1;
        private TextBox textBoxColor;
        private TextBox textBoxType;
        private NumericUpDown numericUpDownFlowerID;
        private Label labelAvailable;
        private Label labelStock;
        private Label labelPrice;
        private Label labelFlowerColor;
        private Label labelFlowerType;
        private Label labelFlowerID;
        private ComboBox comboBoxAvailable;
        private TextBox textBoxStock;
        private TextBox textBoxPrice;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label labelFilterBy;
        private ComboBox comboBoxFilterBy;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private DataGridViewTextBoxColumn flowerID;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn isAvailable;
        private NumericUpDown numericUpDownFloristID;
        private Label labelFloristID;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button buttonViewAll;
        private Button buttonLogout;
    }
}