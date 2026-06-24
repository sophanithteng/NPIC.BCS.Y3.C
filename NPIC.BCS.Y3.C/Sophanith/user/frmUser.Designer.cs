namespace NPIC.BCS.Y3.C.Sophanith.user
{
    partial class frmUser
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nicknameLabel;
            System.Windows.Forms.Label gender_idLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label created_byLabel;
            System.Windows.Forms.Label created_atLabel;
            System.Windows.Forms.Label pictureLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnadduser = new System.Windows.Forms.Button();
            this.btnaddinformation = new System.Windows.Forms.Button();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nPIC_BCS_Y3_CDataSet = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSet();
            this.tblUsersTableAdapter = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.tbl_UsersTableAdapter();
            this.tableAdapterManager = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager();
            this.tbl_UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.gender_idComboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.created_byTextBox = new System.Windows.Forms.TextBox();
            this.created_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            idLabel = new System.Windows.Forms.Label();
            nicknameLabel = new System.Windows.Forms.Label();
            gender_idLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            created_byLabel = new System.Windows.Forms.Label();
            created_atLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_BCS_Y3_CDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(314, 47);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(36, 36);
            idLabel.TabIndex = 27;
            idLabel.Text = "id:";
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nicknameLabel.Location = new System.Drawing.Point(245, 98);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new System.Drawing.Size(105, 36);
            nicknameLabel.TabIndex = 29;
            nicknameLabel.Text = "nickname:";
            // 
            // gender_idLabel
            // 
            gender_idLabel.AutoSize = true;
            gender_idLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gender_idLabel.Location = new System.Drawing.Point(241, 199);
            gender_idLabel.Name = "gender_idLabel";
            gender_idLabel.Size = new System.Drawing.Size(104, 36);
            gender_idLabel.TabIndex = 31;
            gender_idLabel.Text = "gender id:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(241, 149);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(109, 36);
            usernameLabel.TabIndex = 33;
            usernameLabel.Text = "username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(239, 250);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(106, 36);
            passwordLabel.TabIndex = 35;
            passwordLabel.Text = "password:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(269, 301);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(76, 36);
            phoneLabel.TabIndex = 37;
            phoneLabel.Text = "phone:";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roleLabel.Location = new System.Drawing.Point(291, 351);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(54, 36);
            roleLabel.TabIndex = 39;
            roleLabel.Text = "role:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(266, 496);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(75, 36);
            statusLabel.TabIndex = 41;
            statusLabel.Text = "status:";
            // 
            // created_byLabel
            // 
            created_byLabel.AutoSize = true;
            created_byLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            created_byLabel.Location = new System.Drawing.Point(230, 402);
            created_byLabel.Name = "created_byLabel";
            created_byLabel.Size = new System.Drawing.Size(115, 36);
            created_byLabel.TabIndex = 43;
            created_byLabel.Text = "created by:";
            // 
            // created_atLabel
            // 
            created_atLabel.AutoSize = true;
            created_atLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            created_atLabel.Location = new System.Drawing.Point(230, 453);
            created_atLabel.Name = "created_atLabel";
            created_atLabel.Size = new System.Drawing.Size(111, 36);
            created_atLabel.TabIndex = 45;
            created_atLabel.Text = "created at:";
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pictureLabel.Location = new System.Drawing.Point(902, 425);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(197, 36);
            pictureLabel.TabIndex = 47;
            pictureLabel.Text = "បញ្ចូលរូបភាពនៅទីនេះ";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.MediumBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Location = new System.Drawing.Point(1456, 480);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(162, 52);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "រក្សាទុក្ខទិន្នន័យ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.Location = new System.Drawing.Point(1269, 480);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(162, 52);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "លុបទិន្នន័យ";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncancel.Location = new System.Drawing.Point(1079, 480);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(162, 52);
            this.btncancel.TabIndex = 22;
            this.btncancel.Text = "បោះបង់ទិន្នន័យ";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 52);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow.png");
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadduser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadduser.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadduser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadduser.Location = new System.Drawing.Point(1350, 135);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(268, 52);
            this.btnadduser.TabIndex = 25;
            this.btnadduser.Text = "បន្ថែមអ្នកប្រើប្រាស់";
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            // 
            // btnaddinformation
            // 
            this.btnaddinformation.BackColor = System.Drawing.Color.DarkCyan;
            this.btnaddinformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddinformation.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddinformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaddinformation.Location = new System.Drawing.Point(1350, 65);
            this.btnaddinformation.Name = "btnaddinformation";
            this.btnaddinformation.Size = new System.Drawing.Size(268, 52);
            this.btnaddinformation.TabIndex = 27;
            this.btnaddinformation.Text = "បន្ថែមព័ត៌មានអ្នកប្រើប្រាស់";
            this.btnaddinformation.UseVisualStyleBackColor = false;
            this.btnaddinformation.Click += new System.EventHandler(this.btnaddinformation_Click);
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tbl_Users";
            this.tblUsersBindingSource.DataSource = this.nPIC_BCS_Y3_CDataSet;
            // 
            // nPIC_BCS_Y3_CDataSet
            // 
            this.nPIC_BCS_Y3_CDataSet.DataSetName = "NPIC_BCS_Y3_CDataSet";
            this.nPIC_BCS_Y3_CDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_CategoriesTableAdapter = null;
            this.tableAdapterManager.tbl_GendersTableAdapter = null;
            this.tableAdapterManager.tbl_ProductsTableAdapter = null;
            this.tableAdapterManager.tbl_SaleDetailsTableAdapter = null;
            this.tableAdapterManager.tbl_SalesTableAdapter = null;
            this.tableAdapterManager.tbl_StocksTableAdapter = null;
            this.tableAdapterManager.tbl_SuppliersTableAdapter = null;
            this.tableAdapterManager.tbl_UsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_UsersDataGridView
            // 
            this.tbl_UsersDataGridView.AutoGenerateColumns = false;
            this.tbl_UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewImageColumn2});
            this.tbl_UsersDataGridView.DataSource = this.tblUsersBindingSource;
            this.tbl_UsersDataGridView.Location = new System.Drawing.Point(95, 553);
            this.tbl_UsersDataGridView.Name = "tbl_UsersDataGridView";
            this.tbl_UsersDataGridView.RowHeadersWidth = 51;
            this.tbl_UsersDataGridView.RowTemplate.Height = 24;
            this.tbl_UsersDataGridView.Size = new System.Drawing.Size(1523, 307);
            this.tbl_UsersDataGridView.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn8.HeaderText = "id";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nickname";
            this.dataGridViewTextBoxColumn9.HeaderText = "nickname";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "gender_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "gender_id";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn11.HeaderText = "username";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn12.HeaderText = "password";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn13.HeaderText = "phone";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "role";
            this.dataGridViewTextBoxColumn14.HeaderText = "role";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "status";
            this.dataGridViewCheckBoxColumn2.HeaderText = "status";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "created_by";
            this.dataGridViewTextBoxColumn15.HeaderText = "created_by";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "created_at";
            this.dataGridViewTextBoxColumn16.HeaderText = "created_at";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "picture";
            this.dataGridViewImageColumn2.HeaderText = "picture";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(383, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(319, 45);
            this.idTextBox.TabIndex = 28;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "nickname", true));
            this.nicknameTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameTextBox.Location = new System.Drawing.Point(383, 89);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(319, 45);
            this.nicknameTextBox.TabIndex = 30;
            this.nicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gender_idComboBox
            // 
            this.gender_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "gender_id", true));
            this.gender_idComboBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_idComboBox.FormattingEnabled = true;
            this.gender_idComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.gender_idComboBox.Location = new System.Drawing.Point(383, 191);
            this.gender_idComboBox.Name = "gender_idComboBox";
            this.gender_idComboBox.Size = new System.Drawing.Size(319, 44);
            this.gender_idComboBox.TabIndex = 32;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(383, 140);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(319, 45);
            this.usernameTextBox.TabIndex = 34;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(383, 241);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(319, 45);
            this.passwordTextBox.TabIndex = 36;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(383, 292);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(319, 45);
            this.phoneTextBox.TabIndex = 38;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "role", true));
            this.roleComboBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.roleComboBox.Location = new System.Drawing.Point(383, 343);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(319, 44);
            this.roleComboBox.TabIndex = 40;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblUsersBindingSource, "status", true));
            this.statusCheckBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCheckBox.Location = new System.Drawing.Point(383, 496);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(169, 44);
            this.statusCheckBox.TabIndex = 42;
            this.statusCheckBox.Text = "checkBox";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // created_byTextBox
            // 
            this.created_byTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.created_byTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblUsersBindingSource, "created_by", true));
            this.created_byTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_byTextBox.Location = new System.Drawing.Point(383, 393);
            this.created_byTextBox.Name = "created_byTextBox";
            this.created_byTextBox.Size = new System.Drawing.Size(319, 45);
            this.created_byTextBox.TabIndex = 44;
            this.created_byTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // created_atDateTimePicker
            // 
            this.created_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblUsersBindingSource, "created_at", true));
            this.created_atDateTimePicker.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_atDateTimePicker.Location = new System.Drawing.Point(383, 444);
            this.created_atDateTimePicker.Name = "created_atDateTimePicker";
            this.created_atDateTimePicker.Size = new System.Drawing.Size(319, 45);
            this.created_atDateTimePicker.TabIndex = 46;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblUsersBindingSource, "picture", true));
            this.picturePictureBox.Image = global::NPIC.BCS.Y3.C.Properties.Resources.working;
            this.picturePictureBox.Location = new System.Drawing.Point(835, 38);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(330, 384);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 48;
            this.picturePictureBox.TabStop = false;
            this.picturePictureBox.Click += new System.EventHandler(this.picturePictureBox_Click_1);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1653, 881);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nicknameLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(gender_idLabel);
            this.Controls.Add(this.gender_idComboBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(created_byLabel);
            this.Controls.Add(this.created_byTextBox);
            this.Controls.Add(created_atLabel);
            this.Controls.Add(this.created_atDateTimePicker);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(this.tbl_UsersDataGridView);
            this.Controls.Add(this.btnaddinformation);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_BCS_Y3_CDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NPIC_BCS_Y3_CDataSet nPIC_BCS_Y3_CDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private NPIC_BCS_Y3_CDataSetTableAdapters.tbl_UsersTableAdapter tblUsersTableAdapter;
        private NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Button btnaddinformation;
        private System.Windows.Forms.DataGridView tbl_UsersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.ComboBox gender_idComboBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.TextBox created_byTextBox;
        private System.Windows.Forms.DateTimePicker created_atDateTimePicker;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.ImageList imageList1;
    }
}