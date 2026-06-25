namespace NPIC.BCS.Y3.C.Sophanith.pages
{
    partial class FrmProduct
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
            System.Windows.Forms.Label barcodeLabel;
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label qtyLabel;
            System.Windows.Forms.Label cate_idLabel;
            System.Windows.Forms.Label price_inLabel;
            System.Windows.Forms.Label price_outLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label created_atLabel;
            System.Windows.Forms.Label user_idLabel;
            this.nPIC_BCS_Y3_CDataSet = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSet();
            this.tbl_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProductsTableAdapter = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.tbl_ProductsTableAdapter();
            this.tableAdapterManager = new NPIC.BCS.Y3.C.NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.cate_idTextBox = new System.Windows.Forms.TextBox();
            this.price_inTextBox = new System.Windows.Forms.TextBox();
            this.price_outTextBox = new System.Windows.Forms.TextBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.created_atDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.user_idTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            barcodeLabel = new System.Windows.Forms.Label();
            product_nameLabel = new System.Windows.Forms.Label();
            qtyLabel = new System.Windows.Forms.Label();
            cate_idLabel = new System.Windows.Forms.Label();
            price_inLabel = new System.Windows.Forms.Label();
            price_outLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            created_atLabel = new System.Windows.Forms.Label();
            user_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_BCS_Y3_CDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(175, 136);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(36, 36);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // barcodeLabel
            // 
            barcodeLabel.AutoSize = true;
            barcodeLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            barcodeLabel.Location = new System.Drawing.Point(175, 206);
            barcodeLabel.Name = "barcodeLabel";
            barcodeLabel.Size = new System.Drawing.Size(93, 36);
            barcodeLabel.TabIndex = 3;
            barcodeLabel.Text = "barcode:";
            // 
            // product_nameLabel
            // 
            product_nameLabel.AutoSize = true;
            product_nameLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_nameLabel.Location = new System.Drawing.Point(175, 275);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(143, 36);
            product_nameLabel.TabIndex = 5;
            product_nameLabel.Text = "product name:";
            // 
            // qtyLabel
            // 
            qtyLabel.AutoSize = true;
            qtyLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            qtyLabel.Location = new System.Drawing.Point(175, 339);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(48, 36);
            qtyLabel.TabIndex = 7;
            qtyLabel.Text = "qty:";
            // 
            // cate_idLabel
            // 
            cate_idLabel.AutoSize = true;
            cate_idLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cate_idLabel.Location = new System.Drawing.Point(175, 402);
            cate_idLabel.Name = "cate_idLabel";
            cate_idLabel.Size = new System.Drawing.Size(80, 36);
            cate_idLabel.TabIndex = 9;
            cate_idLabel.Text = "cate id:";
            // 
            // price_inLabel
            // 
            price_inLabel.AutoSize = true;
            price_inLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            price_inLabel.Location = new System.Drawing.Point(175, 464);
            price_inLabel.Name = "price_inLabel";
            price_inLabel.Size = new System.Drawing.Size(85, 36);
            price_inLabel.TabIndex = 11;
            price_inLabel.Text = "price in:";
            // 
            // price_outLabel
            // 
            price_outLabel.AutoSize = true;
            price_outLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            price_outLabel.Location = new System.Drawing.Point(175, 526);
            price_outLabel.Name = "price_outLabel";
            price_outLabel.Size = new System.Drawing.Size(98, 36);
            price_outLabel.TabIndex = 13;
            price_outLabel.Text = "price out:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(175, 641);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(75, 36);
            statusLabel.TabIndex = 15;
            statusLabel.Text = "status:";
            // 
            // created_atLabel
            // 
            created_atLabel.AutoSize = true;
            created_atLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            created_atLabel.Location = new System.Drawing.Point(175, 585);
            created_atLabel.Name = "created_atLabel";
            created_atLabel.Size = new System.Drawing.Size(111, 36);
            created_atLabel.TabIndex = 17;
            created_atLabel.Text = "created at:";
            // 
            // user_idLabel
            // 
            user_idLabel.AutoSize = true;
            user_idLabel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            user_idLabel.Location = new System.Drawing.Point(179, 78);
            user_idLabel.Name = "user_idLabel";
            user_idLabel.Size = new System.Drawing.Size(81, 36);
            user_idLabel.TabIndex = 19;
            user_idLabel.Text = "user id:";
            // 
            // nPIC_BCS_Y3_CDataSet
            // 
            this.nPIC_BCS_Y3_CDataSet.DataSetName = "NPIC_BCS_Y3_CDataSet";
            this.nPIC_BCS_Y3_CDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ProductsBindingSource
            // 
            this.tbl_ProductsBindingSource.DataMember = "tbl_Products";
            this.tbl_ProductsBindingSource.DataSource = this.nPIC_BCS_Y3_CDataSet;
            // 
            // tbl_ProductsTableAdapter
            // 
            this.tbl_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_CategoriesTableAdapter = null;
            this.tableAdapterManager.tbl_GendersTableAdapter = null;
            this.tableAdapterManager.tbl_ProductsTableAdapter = this.tbl_ProductsTableAdapter;
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
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "id", true));
            this.idTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(365, 136);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(392, 45);
            this.idTextBox.TabIndex = 2;
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "barcode", true));
            this.barcodeTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeTextBox.Location = new System.Drawing.Point(365, 204);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(392, 45);
            this.barcodeTextBox.TabIndex = 4;
            // 
            // product_nameTextBox
            // 
            this.product_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "product_name", true));
            this.product_nameTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_nameTextBox.Location = new System.Drawing.Point(365, 266);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(392, 45);
            this.product_nameTextBox.TabIndex = 6;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "qty", true));
            this.qtyTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyTextBox.Location = new System.Drawing.Point(365, 330);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(392, 45);
            this.qtyTextBox.TabIndex = 8;
            // 
            // cate_idTextBox
            // 
            this.cate_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cate_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "cate_id", true));
            this.cate_idTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cate_idTextBox.Location = new System.Drawing.Point(365, 393);
            this.cate_idTextBox.Name = "cate_idTextBox";
            this.cate_idTextBox.Size = new System.Drawing.Size(392, 45);
            this.cate_idTextBox.TabIndex = 10;
            // 
            // price_inTextBox
            // 
            this.price_inTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_inTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "price_in", true));
            this.price_inTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_inTextBox.Location = new System.Drawing.Point(365, 455);
            this.price_inTextBox.Name = "price_inTextBox";
            this.price_inTextBox.Size = new System.Drawing.Size(392, 45);
            this.price_inTextBox.TabIndex = 12;
            // 
            // price_outTextBox
            // 
            this.price_outTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_outTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "price_out", true));
            this.price_outTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_outTextBox.Location = new System.Drawing.Point(365, 517);
            this.price_outTextBox.Name = "price_outTextBox";
            this.price_outTextBox.Size = new System.Drawing.Size(392, 45);
            this.price_outTextBox.TabIndex = 14;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tbl_ProductsBindingSource, "status", true));
            this.statusCheckBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCheckBox.Location = new System.Drawing.Point(365, 636);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(200, 41);
            this.statusCheckBox.TabIndex = 16;
            this.statusCheckBox.Text = "checkBox1";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // created_atDateTimePicker
            // 
            this.created_atDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbl_ProductsBindingSource, "created_at", true));
            this.created_atDateTimePicker.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.created_atDateTimePicker.Location = new System.Drawing.Point(365, 579);
            this.created_atDateTimePicker.Name = "created_atDateTimePicker";
            this.created_atDateTimePicker.Size = new System.Drawing.Size(239, 45);
            this.created_atDateTimePicker.TabIndex = 18;
            // 
            // user_idTextBox
            // 
            this.user_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "user_id", true));
            this.user_idTextBox.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_idTextBox.Location = new System.Drawing.Point(365, 69);
            this.user_idTextBox.Name = "user_idTextBox";
            this.user_idTextBox.Size = new System.Drawing.Size(392, 45);
            this.user_idTextBox.TabIndex = 20;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 753);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(barcodeLabel);
            this.Controls.Add(this.barcodeTextBox);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(qtyLabel);
            this.Controls.Add(this.qtyTextBox);
            this.Controls.Add(cate_idLabel);
            this.Controls.Add(this.cate_idTextBox);
            this.Controls.Add(price_inLabel);
            this.Controls.Add(this.price_inTextBox);
            this.Controls.Add(price_outLabel);
            this.Controls.Add(this.price_outTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(created_atLabel);
            this.Controls.Add(this.created_atDateTimePicker);
            this.Controls.Add(user_idLabel);
            this.Controls.Add(this.user_idTextBox);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nPIC_BCS_Y3_CDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NPIC_BCS_Y3_CDataSet nPIC_BCS_Y3_CDataSet;
        private System.Windows.Forms.BindingSource tbl_ProductsBindingSource;
        private NPIC_BCS_Y3_CDataSetTableAdapters.tbl_ProductsTableAdapter tbl_ProductsTableAdapter;
        private NPIC_BCS_Y3_CDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox cate_idTextBox;
        private System.Windows.Forms.TextBox price_inTextBox;
        private System.Windows.Forms.TextBox price_outTextBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.DateTimePicker created_atDateTimePicker;
        private System.Windows.Forms.TextBox user_idTextBox;
    }
}