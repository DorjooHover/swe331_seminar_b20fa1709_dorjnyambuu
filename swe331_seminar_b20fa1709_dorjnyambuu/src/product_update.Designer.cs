namespace swe331_seminar_b20fa1709_dorjnyambuu.src
{
    partial class product_update
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
            this.label1 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.perUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unitprice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.ComboBox();
            this.supplierName = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product name:";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(127, 31);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(121, 20);
            this.productName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Supplier:";
            // 
            // perUnit
            // 
            this.perUnit.Location = new System.Drawing.Point(128, 146);
            this.perUnit.Name = "perUnit";
            this.perUnit.Size = new System.Drawing.Size(121, 20);
            this.perUnit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity per unit :";
            // 
            // unitprice
            // 
            this.unitprice.Location = new System.Drawing.Point(128, 185);
            this.unitprice.Name = "unitprice";
            this.unitprice.Size = new System.Drawing.Size(121, 20);
            this.unitprice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit price:";
            // 
            // categoryName
            // 
            this.categoryName.FormattingEnabled = true;
            this.categoryName.Location = new System.Drawing.Point(127, 70);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(121, 21);
            this.categoryName.TabIndex = 10;
            // 
            // supplierName
            // 
            this.supplierName.FormattingEnabled = true;
            this.supplierName.Location = new System.Drawing.Point(128, 106);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(121, 21);
            this.supplierName.TabIndex = 11;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(207, 232);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 33);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "Цуцлах";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(126, 232);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 33);
            this.save.TabIndex = 13;
            this.save.Text = "Хадгалах";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // product_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 267);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.supplierName);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.unitprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.perUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label1);
            this.Name = "product_update";
            this.Text = "product_update";
            this.Load += new System.EventHandler(this.product_update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox perUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unitprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoryName;
        private System.Windows.Forms.ComboBox supplierName;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
    }
}