namespace masterpol.AppForms
{
    partial class HistoryForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleLabelAttentionFont = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.masterpolDataSet = new masterpol.masterpolDataSet();
            this.partnerProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerProductTableAdapter = new masterpol.masterpolDataSetTableAdapters.PartnerProductTableAdapter();
            this.tableAdapterManager = new masterpol.masterpolDataSetTableAdapters.TableAdapterManager();
            this.partnerProductDataGridView = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new masterpol.masterpolDataSetTableAdapters.ProductTableAdapter();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterpolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.titleLabelAttentionFont);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.partnerProductDataGridView);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 2;
            // 
            // titleLabelAttentionFont
            // 
            this.titleLabelAttentionFont.AutoSize = true;
            this.titleLabelAttentionFont.Location = new System.Drawing.Point(85, 20);
            this.titleLabelAttentionFont.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabelAttentionFont.Name = "titleLabelAttentionFont";
            this.titleLabelAttentionFont.Size = new System.Drawing.Size(113, 13);
            this.titleLabelAttentionFont.TabIndex = 1;
            this.titleLabelAttentionFont.Text = "ИСТОРИЯ ПРОДАЖ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::masterpol.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // masterpolDataSet
            // 
            this.masterpolDataSet.DataSetName = "masterpolDataSet";
            this.masterpolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnerProductBindingSource
            // 
            this.partnerProductBindingSource.DataMember = "PartnerProduct";
            this.partnerProductBindingSource.DataSource = this.masterpolDataSet;
            // 
            // partnerProductTableAdapter
            // 
            this.partnerProductTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialTypeTableAdapter = null;
            this.tableAdapterManager.PartnerProductTableAdapter = this.partnerProductTableAdapter;
            this.tableAdapterManager.PartnerTableAdapter = null;
            this.tableAdapterManager.PartnerTypeTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = masterpol.masterpolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partnerProductDataGridView
            // 
            this.partnerProductDataGridView.AllowUserToAddRows = false;
            this.partnerProductDataGridView.AllowUserToDeleteRows = false;
            this.partnerProductDataGridView.AutoGenerateColumns = false;
            this.partnerProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partnerProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partnerProductDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.ProductId,
            this.Amount});
            this.partnerProductDataGridView.DataSource = this.partnerProductBindingSource;
            this.partnerProductDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partnerProductDataGridView.Location = new System.Drawing.Point(20, 0);
            this.partnerProductDataGridView.Name = "partnerProductDataGridView";
            this.partnerProductDataGridView.ReadOnly = true;
            this.partnerProductDataGridView.Size = new System.Drawing.Size(760, 336);
            this.partnerProductDataGridView.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.masterpolDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.masterpolDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.DataSource = this.productBindingSource1;
            this.ProductId.DisplayMember = "ProductName";
            this.ProductId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ProductId.HeaderText = "Продукция";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductId.ValueMember = "IdProduct";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Количество";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterpolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label titleLabelAttentionFont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private masterpolDataSet masterpolDataSet;
        private System.Windows.Forms.BindingSource partnerProductBindingSource;
        private masterpolDataSetTableAdapters.PartnerProductTableAdapter partnerProductTableAdapter;
        private masterpolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView partnerProductDataGridView;
        private masterpolDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}