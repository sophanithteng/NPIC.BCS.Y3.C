namespace NPIC.BCS.Y3.C.Sophanith.user
{
    partial class frmUpdate
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
            this.btnclean = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnkhmer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbvillage = new System.Windows.Forms.ComboBox();
            this.administrativeBoundariesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new NPIC.BCS.Y3.C.masterDataSet();
            this.cmbcommune = new System.Windows.Forms.ComboBox();
            this.administrativeBoundariesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbdistrict = new System.Windows.Forms.ComboBox();
            this.administrativeBoundariesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbprovince = new System.Windows.Forms.ComboBox();
            this.administrativeBoundariesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.administrativeBoundariesTableAdapter = new NPIC.BCS.Y3.C.masterDataSetTableAdapters.AdministrativeBoundariesTableAdapter();
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclean
            // 
            this.btnclean.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclean.Location = new System.Drawing.Point(640, 266);
            this.btnclean.Margin = new System.Windows.Forms.Padding(4);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(168, 53);
            this.btnclean.TabIndex = 78;
            this.btnclean.Text = "ជម្រះទិន្នន័យ";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(816, 266);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 53);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "បង្ហាញទិន្នន័យ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEnglish
            // 
            this.btnEnglish.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnglish.Location = new System.Drawing.Point(865, 17);
            this.btnEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(107, 41);
            this.btnEnglish.TabIndex = 76;
            this.btnEnglish.Text = "អង់គ្លេស";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click_1);
            // 
            // btnkhmer
            // 
            this.btnkhmer.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhmer.Location = new System.Drawing.Point(740, 17);
            this.btnkhmer.Margin = new System.Windows.Forms.Padding(4);
            this.btnkhmer.Name = "btnkhmer";
            this.btnkhmer.Size = new System.Drawing.Size(107, 41);
            this.btnkhmer.TabIndex = 75;
            this.btnkhmer.Text = "ភាសាខ្មែរ";
            this.btnkhmer.UseVisualStyleBackColor = true;
            this.btnkhmer.Click += new System.EventHandler(this.btnkhmer_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(22, 327);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(962, 212);
            this.textBox1.TabIndex = 74;
            // 
            // cmbvillage
            // 
            this.cmbvillage.DataSource = this.administrativeBoundariesBindingSource3;
            this.cmbvillage.DisplayMember = "TitleKH";
            this.cmbvillage.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbvillage.FormattingEnabled = true;
            this.cmbvillage.Location = new System.Drawing.Point(242, 244);
            this.cmbvillage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbvillage.Name = "cmbvillage";
            this.cmbvillage.Size = new System.Drawing.Size(327, 44);
            this.cmbvillage.TabIndex = 73;
            this.cmbvillage.ValueMember = "ID";
            // 
            // administrativeBoundariesBindingSource3
            // 
            this.administrativeBoundariesBindingSource3.DataMember = "AdministrativeBoundaries";
            this.administrativeBoundariesBindingSource3.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbcommune
            // 
            this.cmbcommune.DataSource = this.administrativeBoundariesBindingSource2;
            this.cmbcommune.DisplayMember = "TitleKH";
            this.cmbcommune.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcommune.FormattingEnabled = true;
            this.cmbcommune.Location = new System.Drawing.Point(242, 183);
            this.cmbcommune.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcommune.Name = "cmbcommune";
            this.cmbcommune.Size = new System.Drawing.Size(327, 44);
            this.cmbcommune.TabIndex = 72;
            this.cmbcommune.ValueMember = "ID";
            this.cmbcommune.SelectedIndexChanged += new System.EventHandler(this.cmbcommune_SelectedIndexChanged_1);
            // 
            // administrativeBoundariesBindingSource2
            // 
            this.administrativeBoundariesBindingSource2.DataMember = "AdministrativeBoundaries";
            this.administrativeBoundariesBindingSource2.DataSource = this.masterDataSet;
            // 
            // cmbdistrict
            // 
            this.cmbdistrict.DataSource = this.administrativeBoundariesBindingSource1;
            this.cmbdistrict.DisplayMember = "TitleKH";
            this.cmbdistrict.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdistrict.FormattingEnabled = true;
            this.cmbdistrict.Location = new System.Drawing.Point(242, 123);
            this.cmbdistrict.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbdistrict.Name = "cmbdistrict";
            this.cmbdistrict.Size = new System.Drawing.Size(327, 44);
            this.cmbdistrict.TabIndex = 71;
            this.cmbdistrict.ValueMember = "ID";
            this.cmbdistrict.SelectedIndexChanged += new System.EventHandler(this.cmbdistrict_SelectedIndexChanged_1);
            // 
            // administrativeBoundariesBindingSource1
            // 
            this.administrativeBoundariesBindingSource1.DataMember = "AdministrativeBoundaries";
            this.administrativeBoundariesBindingSource1.DataSource = this.masterDataSet;
            // 
            // cmbprovince
            // 
            this.cmbprovince.DataSource = this.administrativeBoundariesBindingSource;
            this.cmbprovince.DisplayMember = "TitleKH";
            this.cmbprovince.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbprovince.FormattingEnabled = true;
            this.cmbprovince.Location = new System.Drawing.Point(242, 64);
            this.cmbprovince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbprovince.Name = "cmbprovince";
            this.cmbprovince.Size = new System.Drawing.Size(327, 44);
            this.cmbprovince.TabIndex = 70;
            this.cmbprovince.ValueMember = "ID";
            this.cmbprovince.SelectedIndexChanged += new System.EventHandler(this.cmbprovince_SelectedIndexChanged_1);
            // 
            // administrativeBoundariesBindingSource
            // 
            this.administrativeBoundariesBindingSource.DataMember = "AdministrativeBoundaries";
            this.administrativeBoundariesBindingSource.DataSource = this.masterDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 41);
            this.label5.TabIndex = 69;
            this.label5.Text = "ភូមិ ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 41);
            this.label4.TabIndex = 68;
            this.label4.Text = "ឃុំ/សង្កាត់ ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 41);
            this.label3.TabIndex = 67;
            this.label3.Text = "ស្រុក/ខណ្ឌ ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 41);
            this.label2.TabIndex = 66;
            this.label2.Text = "ខេត្ត​ ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // administrativeBoundariesTableAdapter
            // 
            this.administrativeBoundariesTableAdapter.ClearBeforeFill = true;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // masterDataSetBindingSource1
            // 
            this.masterDataSetBindingSource1.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource1.Position = 0;
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 565);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEnglish);
            this.Controls.Add(this.btnkhmer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbvillage);
            this.Controls.Add(this.cmbcommune);
            this.Controls.Add(this.cmbdistrict);
            this.Controls.Add(this.cmbprovince);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdate";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrativeBoundariesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnkhmer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbvillage;
        private System.Windows.Forms.ComboBox cmbcommune;
        private System.Windows.Forms.ComboBox cmbdistrict;
        private System.Windows.Forms.ComboBox cmbprovince;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource administrativeBoundariesBindingSource;
        private masterDataSetTableAdapters.AdministrativeBoundariesTableAdapter administrativeBoundariesTableAdapter;
        private System.Windows.Forms.BindingSource administrativeBoundariesBindingSource3;
        private System.Windows.Forms.BindingSource administrativeBoundariesBindingSource2;
        private System.Windows.Forms.BindingSource administrativeBoundariesBindingSource1;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource1;
    }
}