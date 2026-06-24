namespace NPIC.BCS.Y3.C.Sophanith.pages
{
    partial class FrmCategories
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
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label statusLabel;
            this.nPIC_BCS_Y3_CDataSet = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSet();
            this.tbl_CategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CategoriesTableAdapter = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.tbl_CategoriesTableAdapter();
            this.tableAdapterManager = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            idLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_BCS_Y3_CDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(151, 103);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(36, 36);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(151, 154);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(52, 36);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(151, 205);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(120, 36);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(151, 299);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(75, 36);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "status:";
            // 
            // nPIC_BCS_Y3_CDataSet
            // 
            this.nPIC_BCS_Y3_CDataSet.DataSetName = "NPIC_BCS_Y3_CDataSet";
            this.nPIC_BCS_Y3_CDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_CategoriesBindingSource
            // 
            this.tbl_CategoriesBindingSource.DataMember = "tbl_Categories";
            this.tbl_CategoriesBindingSource.DataSource = this.nPIC_BCS_Y3_CDataSet;
            // 
            // tbl_CategoriesTableAdapter
            // 
            this.tbl_CategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_CategoriesTableAdapter = this.tbl_CategoriesTableAdapter;
            this.tableAdapterManager.tbl_GendersTableAdapter = null;
            this.tableAdapterManager.tbl_ProductsTableAdapter = null;
            this.tableAdapterManager.tbl_SaleDetailsTableAdapter = null;
            this.tableAdapterManager.tbl_SalesTableAdapter = null;
            this.tableAdapterManager.tbl_StocksTableAdapter = null;
            this.tableAdapterManager.tbl_SuppliersTableAdapter = null;
            this.tableAdapterManager.tbl_UsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_CategoriesBindingSource, "id", true));
            this.idTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(314, 103);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(266, 45);
            this.idTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_CategoriesBindingSource, "title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(314, 154);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(266, 45);
            this.titleTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_CategoriesBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(314, 205);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(266, 45);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_CategoriesBindingSource, "status", true));
            this.statusCheckBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCheckBox.Location = new System.Drawing.Point(314, 299);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(104, 41);
            this.statusCheckBox.TabIndex = 8;
            this.statusCheckBox.Text = "checkBox1";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusCheckBox);
            this.Name = "FrmCategories";
            this.Text = "FrmCategories";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_BCS_Y3_CDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NPIC_BCS_Y3_CDataSet nPIC_BCS_Y3_CDataSet;
        private System.Windows.Forms.BindingSource tbl_CategoriesBindingSource;
        private NPIC_BCS_Y3_CDataSetTableAdapters.tbl_CategoriesTableAdapter tbl_CategoriesTableAdapter;
        private NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
    }
}