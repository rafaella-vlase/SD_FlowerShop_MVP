namespace FlowerShopMVP.View
{
    partial class ManagerGUI
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerGUI));
            labelFlower = new Label();
            textBoxPrice = new TextBox();
            textBoxColor = new TextBox();
            textBoxType = new TextBox();
            numericUpDownFloristID = new NumericUpDown();
            labelFloristID = new Label();
            labelRole = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            labelUserID = new Label();
            textBoxStock = new TextBox();
            label1 = new Label();
            comboBoxAvailable = new ComboBox();
            comboBoxFilterBy = new ComboBox();
            labelFilterBy = new Label();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            dataGridView1 = new DataGridView();
            floristID = new DataGridViewTextBoxColumn();
            flowerID = new DataGridViewTextBoxColumn();
            flowerName = new DataGridViewTextBoxColumn();
            color = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            available = new DataGridViewTextBoxColumn();
            label2 = new Label();
            comboBoxViewFlowerList = new ComboBox();
            numericUpDownFlowerID = new NumericUpDown();
            label3 = new Label();
            buttonViewAll = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloristID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFlowerID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // labelFlower
            // 
            labelFlower.AutoSize = true;
            labelFlower.BackColor = Color.Transparent;
            labelFlower.Font = new Font("Segoe Script", 16.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelFlower.ForeColor = Color.MistyRose;
            labelFlower.Location = new Point(461, -9);
            labelFlower.Margin = new Padding(4, 0, 4, 0);
            labelFlower.Name = "labelFlower";
            labelFlower.Size = new Size(456, 71);
            labelFlower.TabIndex = 23;
            labelFlower.Text = "About flowershops";
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.MistyRose;
            textBoxPrice.Location = new Point(673, 294);
            textBoxPrice.Margin = new Padding(4, 2, 4, 2);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(240, 39);
            textBoxPrice.TabIndex = 32;
            // 
            // textBoxColor
            // 
            textBoxColor.BackColor = Color.MistyRose;
            textBoxColor.Location = new Point(673, 240);
            textBoxColor.Margin = new Padding(4, 2, 4, 2);
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(240, 39);
            textBoxColor.TabIndex = 31;
            // 
            // textBoxType
            // 
            textBoxType.BackColor = Color.MistyRose;
            textBoxType.Location = new Point(673, 187);
            textBoxType.Margin = new Padding(4, 2, 4, 2);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(240, 39);
            textBoxType.TabIndex = 30;
            // 
            // numericUpDownFloristID
            // 
            numericUpDownFloristID.BackColor = Color.MistyRose;
            numericUpDownFloristID.Location = new Point(673, 80);
            numericUpDownFloristID.Margin = new Padding(4, 2, 4, 2);
            numericUpDownFloristID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownFloristID.Name = "numericUpDownFloristID";
            numericUpDownFloristID.Size = new Size(240, 39);
            numericUpDownFloristID.TabIndex = 29;
            // 
            // labelFloristID
            // 
            labelFloristID.AutoSize = true;
            labelFloristID.BackColor = Color.Transparent;
            labelFloristID.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFloristID.ForeColor = Color.PaleVioletRed;
            labelFloristID.Location = new Point(461, 348);
            labelFloristID.Margin = new Padding(4, 0, 4, 0);
            labelFloristID.Name = "labelFloristID";
            labelFloristID.Size = new Size(84, 40);
            labelFloristID.TabIndex = 28;
            labelFloristID.Text = "Stock";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.Transparent;
            labelRole.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRole.ForeColor = Color.SeaShell;
            labelRole.Location = new Point(461, 295);
            labelRole.Margin = new Padding(4, 0, 4, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(85, 40);
            labelRole.TabIndex = 27;
            labelRole.Text = "Price";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.SeaShell;
            labelPassword.Location = new Point(461, 239);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(182, 40);
            labelPassword.TabIndex = 26;
            labelPassword.Text = "Flower Color";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Transparent;
            labelUsername.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.SeaShell;
            labelUsername.Location = new Point(461, 188);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(174, 40);
            labelUsername.TabIndex = 25;
            labelUsername.Text = "Flower Type";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.BackColor = Color.Transparent;
            labelUserID.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserID.ForeColor = Color.SeaShell;
            labelUserID.Location = new Point(461, 80);
            labelUserID.Margin = new Padding(4, 0, 4, 0);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(204, 40);
            labelUserID.TabIndex = 24;
            labelUserID.Text = "FlowerShop ID";
            // 
            // textBoxStock
            // 
            textBoxStock.BackColor = Color.MistyRose;
            textBoxStock.Location = new Point(673, 348);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(240, 39);
            textBoxStock.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(461, 412);
            label1.Name = "label1";
            label1.Size = new Size(136, 40);
            label1.TabIndex = 34;
            label1.Text = "Available";
            // 
            // comboBoxAvailable
            // 
            comboBoxAvailable.BackColor = Color.MistyRose;
            comboBoxAvailable.FormattingEnabled = true;
            comboBoxAvailable.Items.AddRange(new object[] { "", "yes", "no" });
            comboBoxAvailable.Location = new Point(671, 411);
            comboBoxAvailable.Name = "comboBoxAvailable";
            comboBoxAvailable.Size = new Size(242, 40);
            comboBoxAvailable.TabIndex = 35;
            // 
            // comboBoxFilterBy
            // 
            comboBoxFilterBy.BackColor = Color.MistyRose;
            comboBoxFilterBy.FormattingEnabled = true;
            comboBoxFilterBy.Items.AddRange(new object[] { "", "None", "Availability", "Price", "Color", "Stock" });
            comboBoxFilterBy.Location = new Point(126, 501);
            comboBoxFilterBy.Name = "comboBoxFilterBy";
            comboBoxFilterBy.Size = new Size(242, 40);
            comboBoxFilterBy.TabIndex = 37;
            comboBoxFilterBy.SelectedIndexChanged += comboBoxFilterBy_SelectedIndexChanged;
            // 
            // labelFilterBy
            // 
            labelFilterBy.AutoSize = true;
            labelFilterBy.BackColor = Color.Transparent;
            labelFilterBy.Font = new Font("Segoe Script", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFilterBy.ForeColor = Color.MistyRose;
            labelFilterBy.Location = new Point(126, 432);
            labelFilterBy.Name = "labelFilterBy";
            labelFilterBy.Size = new Size(168, 48);
            labelFilterBy.TabIndex = 36;
            labelFilterBy.Text = "Filter By:";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.MistyRose;
            buttonSearch.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(1029, 494);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(210, 46);
            buttonSearch.TabIndex = 39;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = Color.MistyRose;
            textBoxSearch.Location = new Point(520, 501);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(472, 39);
            textBoxSearch.TabIndex = 38;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MistyRose;
            dataGridViewCellStyle1.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { floristID, flowerID, flowerName, color, price, stock, available });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MistyRose;
            dataGridViewCellStyle2.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(57, 571);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1250, 412);
            dataGridView1.TabIndex = 40;
            dataGridView1.RowStateChanged += dgvFlowerTable_RowStateChanged;
            // 
            // floristID
            // 
            floristID.HeaderText = "Shop ID";
            floristID.MinimumWidth = 10;
            floristID.Name = "floristID";
            // 
            // flowerID
            // 
            flowerID.HeaderText = "FlowerID";
            flowerID.MinimumWidth = 10;
            flowerID.Name = "flowerID";
            // 
            // flowerName
            // 
            flowerName.HeaderText = "Type";
            flowerName.MinimumWidth = 10;
            flowerName.Name = "flowerName";
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
            // available
            // 
            available.HeaderText = "Available";
            available.MinimumWidth = 10;
            available.Name = "available";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MistyRose;
            label2.Location = new Point(1013, 79);
            label2.Name = "label2";
            label2.Size = new Size(226, 40);
            label2.TabIndex = 41;
            label2.Text = "View flower list:";
            // 
            // comboBoxViewFlowerList
            // 
            comboBoxViewFlowerList.BackColor = Color.MistyRose;
            comboBoxViewFlowerList.FormattingEnabled = true;
            comboBoxViewFlowerList.Items.AddRange(new object[] { "", "All", "Filter by Color and Price" });
            comboBoxViewFlowerList.Location = new Point(1013, 129);
            comboBoxViewFlowerList.Name = "comboBoxViewFlowerList";
            comboBoxViewFlowerList.Size = new Size(242, 40);
            comboBoxViewFlowerList.TabIndex = 42;
            comboBoxViewFlowerList.SelectedIndexChanged += comboBoxViewFlowerList_SelectedIndexChanged;
            // 
            // numericUpDownFlowerID
            // 
            numericUpDownFlowerID.BackColor = Color.MistyRose;
            numericUpDownFlowerID.Location = new Point(673, 130);
            numericUpDownFlowerID.Margin = new Padding(4, 2, 4, 2);
            numericUpDownFlowerID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownFlowerID.Name = "numericUpDownFlowerID";
            numericUpDownFlowerID.Size = new Size(240, 39);
            numericUpDownFlowerID.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SeaShell;
            label3.Location = new Point(461, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 40);
            label3.TabIndex = 43;
            label3.Text = "Flower ID";
            // 
            // buttonViewAll
            // 
            buttonViewAll.BackColor = Color.MistyRose;
            buttonViewAll.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewAll.Location = new Point(1013, 256);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(242, 46);
            buttonViewAll.TabIndex = 45;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = false;
            buttonViewAll.Click += buttonViewAll_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(904, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 50);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.portrait_2_transformed;
            pictureBox2.Location = new Point(38, 108);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 189);
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.pixel_speech_bubble__1___1_;
            pictureBox3.Location = new Point(126, 39);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(288, 65);
            pictureBox3.TabIndex = 49;
            pictureBox3.TabStop = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.MistyRose;
            buttonLogout.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(47, 331);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(210, 46);
            buttonLogout.TabIndex = 50;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // ManagerGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1374, 1028);
            Controls.Add(buttonLogout);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonViewAll);
            Controls.Add(numericUpDownFlowerID);
            Controls.Add(label3);
            Controls.Add(comboBoxViewFlowerList);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(comboBoxFilterBy);
            Controls.Add(labelFilterBy);
            Controls.Add(comboBoxAvailable);
            Controls.Add(label1);
            Controls.Add(textBoxStock);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxColor);
            Controls.Add(textBoxType);
            Controls.Add(numericUpDownFloristID);
            Controls.Add(labelFloristID);
            Controls.Add(labelRole);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelUserID);
            Controls.Add(labelFlower);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManagerGUI";
            Text = "ManagerGUI";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloristID).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFlowerID).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelFlower;
        private TextBox textBoxPrice;
        private TextBox textBoxColor;
        private TextBox textBoxType;
        private NumericUpDown numericUpDownFloristID;
        private Label labelFloristID;
        private Label labelRole;
        private Label labelPassword;
        private Label labelUsername;
        private Label labelUserID;
        private TextBox textBoxStock;
        private Label label1;
        private ComboBox comboBoxAvailable;
        private ComboBox comboBoxFilterBy;
        private Label labelFilterBy;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBoxViewFlowerList;
        private NumericUpDown numericUpDownFlowerID;
        private Label label3;
        private DataGridViewTextBoxColumn floristID;
        private DataGridViewTextBoxColumn flowerID;
        private DataGridViewTextBoxColumn flowerName;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn available;
        private Button buttonViewAll;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonLogout;
    }
}