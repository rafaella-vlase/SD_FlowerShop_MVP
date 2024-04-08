namespace FlowerShopMVP.View
{
    partial class AdminGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGUI));
            dataGridViewUserTable = new DataGridView();
            userID = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            floristID = new DataGridViewTextBoxColumn();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            panel1 = new Panel();
            numericUpDownFloristID = new NumericUpDown();
            textBoxRole = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            numericUpDownUserID = new NumericUpDown();
            labelFloristID = new Label();
            labelRole = new Label();
            labelPassword = new Label();
            labelUsername = new Label();
            labelUserID = new Label();
            labelFlower = new Label();
            buttonViewAll = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserTable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloristID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUserTable
            // 
            dataGridViewUserTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUserTable.BackgroundColor = Color.MistyRose;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MistyRose;
            dataGridViewCellStyle1.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.MistyRose;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUserTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUserTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserTable.Columns.AddRange(new DataGridViewColumn[] { userID, username, password, role, floristID });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MistyRose;
            dataGridViewCellStyle2.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewUserTable.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUserTable.Location = new Point(50, 444);
            dataGridViewUserTable.Margin = new Padding(4, 2, 4, 2);
            dataGridViewUserTable.Name = "dataGridViewUserTable";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.MistyRose;
            dataGridViewCellStyle3.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewUserTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewUserTable.RowHeadersWidth = 82;
            dataGridViewUserTable.Size = new Size(1274, 563);
            dataGridViewUserTable.TabIndex = 17;
            dataGridViewUserTable.RowStateChanged += dgvUserTable_RowStateChanged;
            // 
            // userID
            // 
            userID.HeaderText = "User ID";
            userID.MinimumWidth = 10;
            userID.Name = "userID";
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.MinimumWidth = 10;
            username.Name = "username";
            // 
            // password
            // 
            password.HeaderText = "Password";
            password.MinimumWidth = 10;
            password.Name = "password";
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.MinimumWidth = 10;
            role.Name = "role";
            // 
            // floristID
            // 
            floristID.HeaderText = "Florist ID";
            floristID.MinimumWidth = 10;
            floristID.Name = "floristID";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.MistyRose;
            buttonDelete.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(1007, 243);
            buttonDelete.Margin = new Padding(4, 2, 4, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 47);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.MistyRose;
            buttonUpdate.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(1007, 173);
            buttonUpdate.Margin = new Padding(4, 2, 4, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(150, 47);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MistyRose;
            buttonAdd.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(1007, 100);
            buttonAdd.Margin = new Padding(4, 2, 4, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 47);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "ADD";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(numericUpDownFloristID);
            panel1.Controls.Add(textBoxRole);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(numericUpDownUserID);
            panel1.Controls.Add(labelFloristID);
            panel1.Controls.Add(labelRole);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(labelUserID);
            panel1.Location = new Point(420, 101);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 339);
            panel1.TabIndex = 11;
            // 
            // numericUpDownFloristID
            // 
            numericUpDownFloristID.BackColor = Color.MistyRose;
            numericUpDownFloristID.Location = new Point(191, 211);
            numericUpDownFloristID.Margin = new Padding(6);
            numericUpDownFloristID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownFloristID.Name = "numericUpDownFloristID";
            numericUpDownFloristID.Size = new Size(243, 39);
            numericUpDownFloristID.TabIndex = 10;
            // 
            // textBoxRole
            // 
            textBoxRole.BackColor = Color.MistyRose;
            textBoxRole.Location = new Point(191, 154);
            textBoxRole.Margin = new Padding(4, 2, 4, 2);
            textBoxRole.Name = "textBoxRole";
            textBoxRole.Size = new Size(240, 39);
            textBoxRole.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.MistyRose;
            textBoxPassword.Location = new Point(191, 100);
            textBoxPassword.Margin = new Padding(4, 2, 4, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(240, 39);
            textBoxPassword.TabIndex = 8;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.MistyRose;
            textBoxUsername.Location = new Point(191, 49);
            textBoxUsername.Margin = new Padding(4, 2, 4, 2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(240, 39);
            textBoxUsername.TabIndex = 7;
            // 
            // numericUpDownUserID
            // 
            numericUpDownUserID.BackColor = Color.MistyRose;
            numericUpDownUserID.Location = new Point(191, -6);
            numericUpDownUserID.Margin = new Padding(4, 2, 4, 2);
            numericUpDownUserID.Maximum = new decimal(new int[] { 4000000, 0, 0, 0 });
            numericUpDownUserID.Name = "numericUpDownUserID";
            numericUpDownUserID.Size = new Size(240, 39);
            numericUpDownUserID.TabIndex = 6;
            // 
            // labelFloristID
            // 
            labelFloristID.AutoSize = true;
            labelFloristID.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFloristID.ForeColor = Color.PaleVioletRed;
            labelFloristID.Location = new Point(0, 207);
            labelFloristID.Margin = new Padding(4, 0, 4, 0);
            labelFloristID.Name = "labelFloristID";
            labelFloristID.Size = new Size(139, 40);
            labelFloristID.TabIndex = 4;
            labelFloristID.Text = "Florist ID";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRole.ForeColor = Color.SeaShell;
            labelRole.Location = new Point(0, 156);
            labelRole.Margin = new Padding(4, 0, 4, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(73, 40);
            labelRole.TabIndex = 3;
            labelRole.Text = "Role";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.SeaShell;
            labelPassword.Location = new Point(0, 100);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(137, 40);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.SeaShell;
            labelUsername.Location = new Point(0, 49);
            labelUsername.Margin = new Padding(4, 0, 4, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(143, 40);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // labelUserID
            // 
            labelUserID.AutoSize = true;
            labelUserID.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserID.ForeColor = Color.SeaShell;
            labelUserID.Location = new Point(0, 0);
            labelUserID.Margin = new Padding(4, 0, 4, 0);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(110, 40);
            labelUserID.TabIndex = 0;
            labelUserID.Text = "User ID";
            // 
            // labelFlower
            // 
            labelFlower.AutoSize = true;
            labelFlower.BackColor = Color.Transparent;
            labelFlower.Font = new Font("Segoe Script", 16.125F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelFlower.ForeColor = Color.MistyRose;
            labelFlower.Location = new Point(563, -2);
            labelFlower.Margin = new Padding(4, 0, 4, 0);
            labelFlower.Name = "labelFlower";
            labelFlower.Size = new Size(301, 71);
            labelFlower.TabIndex = 10;
            labelFlower.Text = "About users";
            // 
            // buttonViewAll
            // 
            buttonViewAll.BackColor = Color.MistyRose;
            buttonViewAll.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewAll.Location = new Point(1007, 314);
            buttonViewAll.Margin = new Padding(4, 2, 4, 2);
            buttonViewAll.Name = "buttonViewAll";
            buttonViewAll.Size = new Size(150, 47);
            buttonViewAll.TabIndex = 18;
            buttonViewAll.Text = "VIEW ALL";
            buttonViewAll.UseVisualStyleBackColor = false;
            buttonViewAll.Click += buttonViewAll_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(858, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 50);
            pictureBox2.TabIndex = 48;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.portrait_2_transformed;
            pictureBox1.Location = new Point(41, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 189);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(101, 53);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(288, 65);
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.MistyRose;
            buttonLogout.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.Location = new Point(50, 329);
            buttonLogout.Margin = new Padding(4, 2, 4, 2);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(150, 47);
            buttonLogout.TabIndex = 53;
            buttonLogout.Text = "LOGOUT";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // AdminGUI
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cottage__1_;
            ClientSize = new Size(1374, 1028);
            Controls.Add(buttonLogout);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(buttonViewAll);
            Controls.Add(dataGridViewUserTable);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(panel1);
            Controls.Add(labelFlower);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "AdminGUI";
            Text = "AdminGUI";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloristID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownUserID).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewUserTable;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private Panel panel1;
        private TextBox textBoxRole;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private NumericUpDown numericUpDownUserID;
        private Label labelFloristID;
        private Label labelRole;
        private Label labelPassword;
        private Label labelUsername;
        private Label labelUserID;
        private Label labelFlower;
        private NumericUpDown numericUpDownFloristID;
        private Button buttonViewAll;
        private DataGridViewTextBoxColumn userID;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn floristID;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button buttonLogout;
    }
}