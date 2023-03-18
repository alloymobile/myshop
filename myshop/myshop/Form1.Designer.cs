namespace myshop
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Shop";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(263, 44);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Iphone 14 pro";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(9, 121);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(110, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "CAD 1400";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(12, 163);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(62, 61);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(186, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 61);
            this.button2.TabIndex = 5;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(80, 181);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 31);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.Text = "0";
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.lblName);
            this.grpProduct.Controls.Add(this.txtQuantity);
            this.grpProduct.Controls.Add(this.button2);
            this.grpProduct.Controls.Add(this.lblPrice);
            this.grpProduct.Controls.Add(this.btnRemove);
            this.grpProduct.Location = new System.Drawing.Point(37, 129);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(297, 224);
            this.grpProduct.TabIndex = 7;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(412, 81);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.Button button1;
    }
}

