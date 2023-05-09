namespace swe331_seminar_b20fa1709_dorjnyambuu.src
{
    partial class Home
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Хэрэглэгчийн бүртгэл");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Хэрэглэгч", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Бүтээгдэхүүний бүртгэл");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Бүтээгдэхүүн", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Ангилалын бүртгэл");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ангилал", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Ажилтны бүртгэл");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Ажилтан", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Үйлчлүүлэгчийн бүртгэл");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Үйлчлүүлэгч", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Нийлүүлэгчдын бүртгэл");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Нийлүүлэгчид", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Захиалгын бүртгэл");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Захиалга", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.main = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, -2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "userRegister";
            treeNode1.Text = "Хэрэглэгчийн бүртгэл";
            treeNode2.Name = "user";
            treeNode2.Text = "Хэрэглэгч";
            treeNode3.Name = "productRegister";
            treeNode3.Text = "Бүтээгдэхүүний бүртгэл";
            treeNode4.Name = "product";
            treeNode4.Text = "Бүтээгдэхүүн";
            treeNode5.Name = "categoryRegister";
            treeNode5.Text = "Ангилалын бүртгэл";
            treeNode6.Name = "category";
            treeNode6.Text = "Ангилал";
            treeNode7.Name = "employeeRegister";
            treeNode7.Text = "Ажилтны бүртгэл";
            treeNode8.Name = "employee";
            treeNode8.Text = "Ажилтан";
            treeNode9.Name = "customerRegister";
            treeNode9.Text = "Үйлчлүүлэгчийн бүртгэл";
            treeNode10.Name = "customer";
            treeNode10.Text = "Үйлчлүүлэгч";
            treeNode11.Name = "suppliersRegister";
            treeNode11.Text = "Нийлүүлэгчдын бүртгэл";
            treeNode12.Name = "suppliers";
            treeNode12.Text = "Нийлүүлэгчид";
            treeNode13.Name = "orderRegister";
            treeNode13.Text = "Захиалгын бүртгэл";
            treeNode14.Name = "order";
            treeNode14.Text = "Захиалга";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8,
            treeNode10,
            treeNode12,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(203, 456);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(209, -2);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(590, 456);
            this.main.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main);
            this.Controls.Add(this.treeView1);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel main;
    }
}