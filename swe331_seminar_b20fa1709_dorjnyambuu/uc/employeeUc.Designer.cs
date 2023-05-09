namespace swe331_seminar_b20fa1709_dorjnyambuu.uc
{
    partial class employeeUc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employee)).BeginInit();
            this.SuspendLayout();
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(431, 423);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 32);
            this.edit.TabIndex = 10;
            this.edit.Text = "Засах";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(512, 423);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 32);
            this.add.TabIndex = 9;
            this.add.Text = "Нэмэх";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // employee
            // 
            this.employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee.Location = new System.Drawing.Point(0, 2);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(590, 415);
            this.employee.TabIndex = 7;
            // 
            // employeeUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.employee);
            this.Name = "employeeUc";
            this.Size = new System.Drawing.Size(590, 456);
            this.Load += new System.EventHandler(this.employeeUc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView employee;
    }
}
