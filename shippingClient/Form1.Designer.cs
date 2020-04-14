namespace shippingClient
{
    partial class Form1
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
            this.lbOrderedProduct = new System.Windows.Forms.ListBox();
            this.lbTimeOrdered = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbOrderedProduct
            // 
            this.lbOrderedProduct.FormattingEnabled = true;
            this.lbOrderedProduct.ItemHeight = 20;
            this.lbOrderedProduct.Location = new System.Drawing.Point(106, 88);
            this.lbOrderedProduct.Name = "lbOrderedProduct";
            this.lbOrderedProduct.Size = new System.Drawing.Size(278, 224);
            this.lbOrderedProduct.TabIndex = 0;
            // 
            // lbTimeOrdered
            // 
            this.lbTimeOrdered.FormattingEnabled = true;
            this.lbTimeOrdered.ItemHeight = 20;
            this.lbTimeOrdered.Location = new System.Drawing.Point(390, 88);
            this.lbTimeOrdered.Name = "lbTimeOrdered";
            this.lbTimeOrdered.Size = new System.Drawing.Size(271, 224);
            this.lbTimeOrdered.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(106, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 34);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Ordered product:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(390, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 34);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time Ordered";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTimeOrdered);
            this.Controls.Add(this.lbOrderedProduct);
            this.Name = "Form1";
            this.Text = "Shipping Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbOrderedProduct;
        private System.Windows.Forms.ListBox lbTimeOrdered;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

