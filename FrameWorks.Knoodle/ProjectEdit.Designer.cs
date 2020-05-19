namespace Weaselware.Knoodle
{
    partial class ProjectEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectEdit));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtJobNumber = new System.Windows.Forms.TextBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.Location = new System.Drawing.Point(247, 62);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 32);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(177, 62);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtJobNumber
            // 
            this.txtJobNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "JobNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtJobNumber.Location = new System.Drawing.Point(12, 22);
            this.txtJobNumber.Name = "txtJobNumber";
            this.txtJobNumber.Size = new System.Drawing.Size(76, 20);
            this.txtJobNumber.TabIndex = 2;
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(BusinessObjects.Project);
            // 
            // txtJobName
            // 
            this.txtJobName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectBindingSource, "JobName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtJobName.Location = new System.Drawing.Point(103, 22);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(215, 20);
            this.txtJobName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Job Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Job Name";
            // 
            // ProjectEdit
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(327, 107);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.txtJobNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.KeyPreview = true;
            this.Name = "ProjectEdit";
            this.Text = "Project Editor";
            this.Load += new System.EventHandler(this.ProjectEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtJobNumber;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource projectBindingSource;
    }
}