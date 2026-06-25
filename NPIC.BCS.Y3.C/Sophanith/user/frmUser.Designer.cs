namespace NPIC.BCS.Y3.C.Sophanith.user
{
    partial class FrmUser
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
            this.nPIC_BCS_Y3_CDataSet = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSet();
            this.tbl_UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UsersTableAdapter = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.tbl_UsersTableAdapter();
            this.tableAdapterManager = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.gender_idComboBox = new System.Windows.Forms.ComboBox();
            this.tblGendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.created_byTextBox = new System.Windows.Forms.TextBox();
            this.created_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.user_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_viewTableAdapter = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.user_viewTableAdapter();
            this.user_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.tbl_GendersTableAdapter = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.tbl_GendersTableAdapter();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_BCS_Y3_CDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_viewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(935, 619);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            idLabel.Visible = false;
            // 
            // nicknameLabel
            // 
            nicknameLabel.AutoSize = true;
            nicknameLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nicknameLabel.Location = new System.Drawing.Point(124, 102);
            nicknameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nicknameLabel.Name = "nicknameLabel";
            nicknameLabel.Size = new System.Drawing.Size(152, 36);
            nicknameLabel.TabIndex = 3;
            nicknameLabel.Text = "ឈ្មោះហៅក្រៅ  :";
            // 
            // gender_idLabel
            // 
            gender_idLabel.AutoSize = true;
            gender_idLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gender_idLabel.Location = new System.Drawing.Point(124, 165);
            gender_idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gender_idLabel.Name = "gender_idLabel";
            gender_idLabel.Size = new System.Drawing.Size(67, 36);
            gender_idLabel.TabIndex = 5;
            gender_idLabel.Text = "ភេទ  :";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usernameLabel.Location = new System.Drawing.Point(124, 223);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(160, 36);
            usernameLabel.TabIndex = 7;
            usernameLabel.Text = "ឈ្មោះប្រើប្រាស់  :";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(124, 281);
            passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(124, 36);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "ពាក្យសម្ងាត់ :";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(124, 342);
            phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(128, 36);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "លេខទូរស័ព្ទ  :";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            roleLabel.Location = new System.Drawing.Point(124, 400);
            roleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(81, 36);
            roleLabel.TabIndex = 13;
            roleLabel.Text = "តួនាទី  :";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(124, 519);
            statusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(108, 36);
            statusLabel.TabIndex = 15;
            statusLabel.Text = "ស្ថានភាព​  :";
            // 
            // created_byLabel
            // 
            created_byLabel.AutoSize = true;
            created_byLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            created_byLabel.Location = new System.Drawing.Point(124, 465);
            created_byLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            created_byLabel.Name = "created_byLabel";
            created_byLabel.Size = new System.Drawing.Size(129, 36);
            created_byLabel.TabIndex = 17;
            created_byLabel.Text = "បង្កើតដោយ​​  :";
            // 
            // created_atLabel
            // 
            created_atLabel.AutoSize = true;
            created_atLabel.Location = new System.Drawing.Point(899, 678);
            created_atLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            created_atLabel.Name = "created_atLabel";
            created_atLabel.Size = new System.Drawing.Size(70, 16);
            created_atLabel.TabIndex = 19;
            created_atLabel.Text = "created at:";
            created_atLabel.Visible = false;
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pictureLabel.Location = new System.Drawing.Point(865, 71);
            pictureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(197, 36);
            pictureLabel.TabIndex = 21;
            pictureLabel.Text = "បញ្ចូលរូបភាពនៅទីនេះ";
            // 
            // nPIC_BCS_Y3_CDataSet
            // 
            this.nPIC_BCS_Y3_CDataSet.DataSetName = "NPIC_BCS_Y3_CDataSet";
            this.nPIC_BCS_Y3_CDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UsersBindingSource
            // 
            this.tbl_UsersBindingSource.DataMember = "tbl_Users";
            this.tbl_UsersBindingSource.DataSource = this.nPIC_BCS_Y3_CDataSet;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tbl_UsersTableAdapter = this.tbl_UsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(967, 615);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(129, 22);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.Visible = false;
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicknameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "nickname", true));
            this.nicknameTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameTextBox.Location = new System.Drawing.Point(328, 100);
            this.nicknameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(367, 45);
            this.nicknameTextBox.TabIndex = 4;
            this.nicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gender_idComboBox
            // 
            this.gender_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbl_UsersBindingSource, "gender_id", true));
            this.gender_idComboBox.DataSource = this.tblGendersBindingSource;
            this.gender_idComboBox.DisplayMember = "title_kh";
            this.gender_idComboBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_idComboBox.FormattingEnabled = true;
            this.gender_idComboBox.Location = new System.Drawing.Point(328, 155);
            this.gender_idComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.gender_idComboBox.Name = "gender_idComboBox";
            this.gender_idComboBox.Size = new System.Drawing.Size(367, 44);
            this.gender_idComboBox.TabIndex = 6;
            this.gender_idComboBox.ValueMember = "id";
            // 
            // tblGendersBindingSource
            // 
            this.tblGendersBindingSource.DataMember = "tbl_Genders";
            this.tblGendersBindingSource.DataSource = this.nPIC_BCS_Y3_CDataSet;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "username", true));
            this.usernameTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(328, 213);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(367, 45);
            this.usernameTextBox.TabIndex = 8;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(328, 271);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(367, 45);
            this.passwordTextBox.TabIndex = 10;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.Location = new System.Drawing.Point(328, 332);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(367, 45);
            this.phoneTextBox.TabIndex = 12;
            this.phoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "role", true));
            this.roleComboBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.roleComboBox.Location = new System.Drawing.Point(328, 390);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(367, 44);
            this.roleComboBox.TabIndex = 14;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_UsersBindingSource, "status", true));
            this.statusCheckBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCheckBox.Location = new System.Drawing.Point(328, 514);
            this.statusCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(267, 47);
            this.statusCheckBox.TabIndex = 16;
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // created_byTextBox
            // 
            this.created_byTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.created_byTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "created_by", true));
            this.created_byTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_byTextBox.Location = new System.Drawing.Point(328, 455);
            this.created_byTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.created_byTextBox.Name = "created_byTextBox";
            this.created_byTextBox.Size = new System.Drawing.Size(367, 45);
            this.created_byTextBox.TabIndex = 18;
            this.created_byTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // created_atDateTimePicker
            // 
            this.created_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_UsersBindingSource, "created_at", true));
            this.created_atDateTimePicker.Location = new System.Drawing.Point(987, 673);
            this.created_atDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.created_atDateTimePicker.Name = "created_atDateTimePicker";
            this.created_atDateTimePicker.Size = new System.Drawing.Size(173, 22);
            this.created_atDateTimePicker.TabIndex = 20;
            this.created_atDateTimePicker.Visible = false;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbl_UsersBindingSource, "picture", true));
            this.picturePictureBox.Image = global::NPIC.BCS.Y3.C.Properties.Resources.working;
            this.picturePictureBox.Location = new System.Drawing.Point(785, 111);
            this.picturePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(375, 400);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 22;
            this.picturePictureBox.TabStop = false;
            this.picturePictureBox.DoubleClick += new System.EventHandler(this.picturePictureBox_DoubleClick);
            // 
            // user_viewBindingSource
            // 
            this.user_viewBindingSource.DataMember = "user_view";
            this.user_viewBindingSource.DataSource = this.nPIC_BCS_Y3_CDataSet;
            // 
            // user_viewTableAdapter
            // 
            this.user_viewTableAdapter.ClearBeforeFill = true;
            // 
            // user_viewDataGridView
            // 
            this.user_viewDataGridView.AllowUserToAddRows = false;
            this.user_viewDataGridView.AllowUserToDeleteRows = false;
            this.user_viewDataGridView.AutoGenerateColumns = false;
            this.user_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1});
            this.user_viewDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.user_viewDataGridView.DataSource = this.user_viewBindingSource;
            this.user_viewDataGridView.Location = new System.Drawing.Point(92, 588);
            this.user_viewDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.user_viewDataGridView.Name = "user_viewDataGridView";
            this.user_viewDataGridView.ReadOnly = true;
            this.user_viewDataGridView.RowHeadersWidth = 51;
            this.user_viewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_viewDataGridView.Size = new System.Drawing.Size(1496, 271);
            this.user_viewDataGridView.TabIndex = 22;
            this.user_viewDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_viewDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nickname";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "NickName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "title_kh";
            this.dataGridViewTextBoxColumn3.HeaderText = "title_kh";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn5.HeaderText = "username";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn6.HeaderText = "phone";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn4.HeaderText = "password";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "role";
            this.dataGridViewTextBoxColumn7.HeaderText = "role";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "status";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Blue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1361, 519);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(227, 62);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "រក្សាទុកទិន្នន័យ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(1127, 519);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(227, 62);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "លុបទិន្នន័យ";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(1267, 100);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(321, 62);
            this.btnadd.TabIndex = 25;
            this.btnadd.Text = "បន្ថែមព័ត៌មានអ្នកប្រើប្រាស់";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1341, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 62);
            this.button1.TabIndex = 26;
            this.button1.Text = "បង្កើតអ្នកប្រើប្រាស់";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(892, 519);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 62);
            this.button2.TabIndex = 27;
            this.button2.Text = "មិនផ្លាស់ប្ដូរ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(106, 43);
            this.btnback.TabIndex = 28;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // tbl_GendersTableAdapter
            // 
            this.tbl_GendersTableAdapter.ClearBeforeFill = true;
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(368, 12);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(601, 45);
            this.txtsearch.TabIndex = 29;
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.Font = new System.Drawing.Font("Khmer OS Battambang", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(1141, 10);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(227, 62);
            this.btnsearch.TabIndex = 30;
            this.btnsearch.Text = "ស្វែងរក";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 923);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.user_viewDataGridView);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_BCS_Y3_CDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NPIC_BCS_Y3_CDataSet nPIC_BCS_Y3_CDataSet;
        private System.Windows.Forms.BindingSource tbl_UsersBindingSource;
        private NPIC_BCS_Y3_CDataSetTableAdapters.tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.BindingSource user_viewBindingSource;
        private NPIC_BCS_Y3_CDataSetTableAdapters.user_viewTableAdapter user_viewTableAdapter;
        private System.Windows.Forms.DataGridView user_viewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.BindingSource tblGendersBindingSource;
        private NPIC_BCS_Y3_CDataSetTableAdapters.tbl_GendersTableAdapter tbl_GendersTableAdapter;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
    }
}