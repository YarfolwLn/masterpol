namespace masterpol.AppForms
{
    partial class CreateUpdatePartnerForm
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
            System.Windows.Forms.Label partnerNameLabel;
            System.Windows.Forms.Label partnerTypeIdLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label ceoLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleLabelAttentionFont = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.masterpolDataSet = new masterpol.masterpolDataSet();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerTableAdapter = new masterpol.masterpolDataSetTableAdapters.PartnerTableAdapter();
            this.tableAdapterManager = new masterpol.masterpolDataSetTableAdapters.TableAdapterManager();
            this.partnerNameTextBox = new System.Windows.Forms.TextBox();
            this.partnerTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ceoTextBox = new System.Windows.Forms.TextBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.saveAttentionBackground = new System.Windows.Forms.Button();
            this.ratingHintAttentionFont = new System.Windows.Forms.Label();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeTableAdapter = new masterpol.masterpolDataSetTableAdapters.ProductTypeTableAdapter();
            this.partnerTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerTypeTableAdapter = new masterpol.masterpolDataSetTableAdapters.PartnerTypeTableAdapter();
            partnerNameLabel = new System.Windows.Forms.Label();
            partnerTypeIdLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ceoLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterpolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerTypeBindingSource)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.ratingHintAttentionFont);
            this.splitContainer1.Panel2.Controls.Add(this.saveAttentionBackground);
            this.splitContainer1.Panel2.Controls.Add(partnerNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.partnerNameTextBox);
            this.splitContainer1.Panel2.Controls.Add(partnerTypeIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.partnerTypeIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(ratingLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ratingTextBox);
            this.splitContainer1.Panel2.Controls.Add(addressLabel);
            this.splitContainer1.Panel2.Controls.Add(this.addressTextBox);
            this.splitContainer1.Panel2.Controls.Add(ceoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ceoTextBox);
            this.splitContainer1.Panel2.Controls.Add(phoneLabel);
            this.splitContainer1.Panel2.Controls.Add(this.phoneMaskedTextBox);
            this.splitContainer1.Panel2.Controls.Add(emailLabel);
            this.splitContainer1.Panel2.Controls.Add(this.emailTextBox);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.splitContainer1.Size = new System.Drawing.Size(368, 450);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 3;
            // 
            // titleLabelAttentionFont
            // 
            this.titleLabelAttentionFont.AutoSize = true;
            this.titleLabelAttentionFont.Location = new System.Drawing.Point(85, 20);
            this.titleLabelAttentionFont.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabelAttentionFont.Name = "titleLabelAttentionFont";
            this.titleLabelAttentionFont.Size = new System.Drawing.Size(102, 13);
            this.titleLabelAttentionFont.TabIndex = 1;
            this.titleLabelAttentionFont.Text = "НОВЫЙ ПАРТНЕР";
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
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataMember = "Partner";
            this.partnerBindingSource.DataSource = this.masterpolDataSet;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialTypeTableAdapter = null;
            this.tableAdapterManager.PartnerProductTableAdapter = null;
            this.tableAdapterManager.PartnerTableAdapter = this.partnerTableAdapter;
            this.tableAdapterManager.PartnerTypeTableAdapter = this.partnerTypeTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = this.productTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = masterpol.masterpolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // partnerNameLabel
            // 
            partnerNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            partnerNameLabel.AutoSize = true;
            partnerNameLabel.Location = new System.Drawing.Point(20, 51);
            partnerNameLabel.Name = "partnerNameLabel";
            partnerNameLabel.Size = new System.Drawing.Size(83, 13);
            partnerNameLabel.TabIndex = 0;
            partnerNameLabel.Text = "Наименование";
            // 
            // partnerNameTextBox
            // 
            this.partnerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partnerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "PartnerName", true));
            this.partnerNameTextBox.Location = new System.Drawing.Point(109, 48);
            this.partnerNameTextBox.Name = "partnerNameTextBox";
            this.partnerNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.partnerNameTextBox.TabIndex = 1;
            // 
            // partnerTypeIdLabel
            // 
            partnerTypeIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            partnerTypeIdLabel.AutoSize = true;
            partnerTypeIdLabel.Location = new System.Drawing.Point(20, 77);
            partnerTypeIdLabel.Name = "partnerTypeIdLabel";
            partnerTypeIdLabel.Size = new System.Drawing.Size(26, 13);
            partnerTypeIdLabel.TabIndex = 2;
            partnerTypeIdLabel.Text = "Тип";
            // 
            // partnerTypeIdComboBox
            // 
            this.partnerTypeIdComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partnerTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partnerBindingSource, "PartnerTypeId", true));
            this.partnerTypeIdComboBox.DataSource = this.partnerTypeBindingSource;
            this.partnerTypeIdComboBox.DisplayMember = "PartnerTypeName";
            this.partnerTypeIdComboBox.FormattingEnabled = true;
            this.partnerTypeIdComboBox.Location = new System.Drawing.Point(109, 74);
            this.partnerTypeIdComboBox.Name = "partnerTypeIdComboBox";
            this.partnerTypeIdComboBox.Size = new System.Drawing.Size(242, 21);
            this.partnerTypeIdComboBox.TabIndex = 3;
            this.partnerTypeIdComboBox.ValueMember = "IdPartnerType";
            // 
            // ratingLabel
            // 
            ratingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(20, 104);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(48, 13);
            ratingLabel.TabIndex = 4;
            ratingLabel.Text = "Рейтинг";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(109, 101);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(242, 20);
            this.ratingTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(20, 145);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(38, 13);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Адрес";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(109, 142);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(242, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // ceoLabel
            // 
            ceoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            ceoLabel.AutoSize = true;
            ceoLabel.Location = new System.Drawing.Point(20, 171);
            ceoLabel.Name = "ceoLabel";
            ceoLabel.Size = new System.Drawing.Size(57, 13);
            ceoLabel.TabIndex = 8;
            ceoLabel.Text = "Директор";
            // 
            // ceoTextBox
            // 
            this.ceoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ceoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Ceo", true));
            this.ceoTextBox.Location = new System.Drawing.Point(109, 168);
            this.ceoTextBox.Name = "ceoTextBox";
            this.ceoTextBox.Size = new System.Drawing.Size(242, 20);
            this.ceoTextBox.TabIndex = 9;
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(20, 197);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(52, 13);
            phoneLabel.TabIndex = 10;
            phoneLabel.Text = "Телефон";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(109, 194);
            this.phoneMaskedTextBox.Mask = "+0 000 000 00 00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(242, 20);
            this.phoneMaskedTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(20, 223);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(109, 220);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(242, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // saveAttentionBackground
            // 
            this.saveAttentionBackground.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveAttentionBackground.Location = new System.Drawing.Point(23, 246);
            this.saveAttentionBackground.Name = "saveAttentionBackground";
            this.saveAttentionBackground.Size = new System.Drawing.Size(328, 44);
            this.saveAttentionBackground.TabIndex = 14;
            this.saveAttentionBackground.Text = "Сохранить";
            this.saveAttentionBackground.UseVisualStyleBackColor = true;
            this.saveAttentionBackground.Click += new System.EventHandler(this.saveAttentionBackground_Click);
            // 
            // ratingHintAttentionFont
            // 
            this.ratingHintAttentionFont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingHintAttentionFont.AutoSize = true;
            this.ratingHintAttentionFont.Location = new System.Drawing.Point(192, 121);
            this.ratingHintAttentionFont.Margin = new System.Windows.Forms.Padding(0);
            this.ratingHintAttentionFont.Name = "ratingHintAttentionFont";
            this.ratingHintAttentionFont.Size = new System.Drawing.Size(162, 13);
            this.ratingHintAttentionFont.TabIndex = 15;
            this.ratingHintAttentionFont.Text = "Целое неотрицательное число";
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this.masterpolDataSet;
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // partnerTypeBindingSource
            // 
            this.partnerTypeBindingSource.DataMember = "PartnerType";
            this.partnerTypeBindingSource.DataSource = this.masterpolDataSet;
            // 
            // partnerTypeTableAdapter
            // 
            this.partnerTypeTableAdapter.ClearBeforeFill = true;
            // 
            // CreateUpdatePartnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreateUpdatePartnerForm";
            this.Text = "CreateUpdatePartnerForm";
            this.Load += new System.EventHandler(this.CreateUpdatePartnerForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterpolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label titleLabelAttentionFont;
        private System.Windows.Forms.PictureBox pictureBox1;
        private masterpolDataSet masterpolDataSet;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private masterpolDataSetTableAdapters.PartnerTableAdapter partnerTableAdapter;
        private masterpolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox partnerNameTextBox;
        private System.Windows.Forms.ComboBox partnerTypeIdComboBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox ceoTextBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label ratingHintAttentionFont;
        private System.Windows.Forms.Button saveAttentionBackground;
        private masterpolDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private masterpolDataSetTableAdapters.PartnerTypeTableAdapter partnerTypeTableAdapter;
        private System.Windows.Forms.BindingSource partnerTypeBindingSource;
    }
}