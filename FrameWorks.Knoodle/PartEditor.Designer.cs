namespace Weaselware.Knoodle
{
    partial class PartEditor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionalNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculatedCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partThickDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSubAssemblyName = new System.Windows.Forms.TextBox();
            this.tbMakeFileName = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbHieght = new System.Windows.Forms.TextBox();
            this.tbDepth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNameDataGridViewTextBoxColumn,
            this.functionalNameDataGridViewTextBoxColumn,
            this.uOMDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.calculatedCostDataGridViewTextBoxColumn,
            this.qntyDataGridViewTextBoxColumn,
            this.partWidthDataGridViewTextBoxColumn,
            this.partLengthDataGridViewTextBoxColumn,
            this.partThickDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // partNameDataGridViewTextBoxColumn
            // 
            this.partNameDataGridViewTextBoxColumn.DataPropertyName = "PartName";
            this.partNameDataGridViewTextBoxColumn.HeaderText = "PartName";
            this.partNameDataGridViewTextBoxColumn.Name = "partNameDataGridViewTextBoxColumn";
            // 
            // functionalNameDataGridViewTextBoxColumn
            // 
            this.functionalNameDataGridViewTextBoxColumn.DataPropertyName = "FunctionalName";
            this.functionalNameDataGridViewTextBoxColumn.HeaderText = "FunctionalName";
            this.functionalNameDataGridViewTextBoxColumn.Name = "functionalNameDataGridViewTextBoxColumn";
            // 
            // uOMDataGridViewTextBoxColumn
            // 
            this.uOMDataGridViewTextBoxColumn.DataPropertyName = "UOM";
            this.uOMDataGridViewTextBoxColumn.HeaderText = "UOM";
            this.uOMDataGridViewTextBoxColumn.Name = "uOMDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // calculatedCostDataGridViewTextBoxColumn
            // 
            this.calculatedCostDataGridViewTextBoxColumn.DataPropertyName = "CalculatedCost";
            this.calculatedCostDataGridViewTextBoxColumn.HeaderText = "CalculatedCost";
            this.calculatedCostDataGridViewTextBoxColumn.Name = "calculatedCostDataGridViewTextBoxColumn";
            this.calculatedCostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qntyDataGridViewTextBoxColumn
            // 
            this.qntyDataGridViewTextBoxColumn.DataPropertyName = "Qnty";
            this.qntyDataGridViewTextBoxColumn.HeaderText = "Qnty";
            this.qntyDataGridViewTextBoxColumn.Name = "qntyDataGridViewTextBoxColumn";
            // 
            // partWidthDataGridViewTextBoxColumn
            // 
            this.partWidthDataGridViewTextBoxColumn.DataPropertyName = "PartWidth";
            this.partWidthDataGridViewTextBoxColumn.HeaderText = "PartWidth";
            this.partWidthDataGridViewTextBoxColumn.Name = "partWidthDataGridViewTextBoxColumn";
            // 
            // partLengthDataGridViewTextBoxColumn
            // 
            this.partLengthDataGridViewTextBoxColumn.DataPropertyName = "PartLength";
            this.partLengthDataGridViewTextBoxColumn.HeaderText = "PartLength";
            this.partLengthDataGridViewTextBoxColumn.Name = "partLengthDataGridViewTextBoxColumn";
            // 
            // partThickDataGridViewTextBoxColumn
            // 
            this.partThickDataGridViewTextBoxColumn.DataPropertyName = "PartThick";
            this.partThickDataGridViewTextBoxColumn.HeaderText = "PartThick";
            this.partThickDataGridViewTextBoxColumn.Name = "partThickDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(FrameWorks.Component);
            // 
            // tbSubAssemblyName
            // 
            this.tbSubAssemblyName.Location = new System.Drawing.Point(16, 31);
            this.tbSubAssemblyName.Name = "tbSubAssemblyName";
            this.tbSubAssemblyName.Size = new System.Drawing.Size(224, 20);
            this.tbSubAssemblyName.TabIndex = 1;
            // 
            // tbMakeFileName
            // 
            this.tbMakeFileName.Location = new System.Drawing.Point(16, 74);
            this.tbMakeFileName.Name = "tbMakeFileName";
            this.tbMakeFileName.Size = new System.Drawing.Size(497, 20);
            this.tbMakeFileName.TabIndex = 2;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(440, 31);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(73, 20);
            this.tbArea.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SubAssembly Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Make File Name";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(246, 31);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(60, 20);
            this.tbWidth.TabIndex = 6;
            // 
            // tbHieght
            // 
            this.tbHieght.Location = new System.Drawing.Point(313, 30);
            this.tbHieght.Name = "tbHieght";
            this.tbHieght.Size = new System.Drawing.Size(64, 20);
            this.tbHieght.TabIndex = 7;
            // 
            // tbDepth
            // 
            this.tbDepth.Location = new System.Drawing.Point(383, 30);
            this.tbDepth.Name = "tbDepth";
            this.tbDepth.Size = new System.Drawing.Size(51, 20);
            this.tbDepth.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hieght";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Depth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Area (sqft)";
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(12, 426);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 10;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(433, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PartEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 456);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDepth);
            this.Controls.Add(this.tbHieght);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.tbMakeFileName);
            this.Controls.Add(this.tbSubAssemblyName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PartEditor";
            this.Text = "PartEditor";
            this.Load += new System.EventHandler(this.PartEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSubAssemblyName;
        private System.Windows.Forms.TextBox tbMakeFileName;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHieght;
        private System.Windows.Forms.TextBox tbDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionalNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculatedCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partThickDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnSave;
    }
}