namespace FInal_Project
{
    partial class Form5
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
            this.lbltotalwithoutdiscount = new System.Windows.Forms.Label();
            this.lbltotalwithdiscount = new System.Windows.Forms.Label();
            this.lblpayby = new System.Windows.Forms.Label();
            this.txttotalwithoutdiscount = new System.Windows.Forms.TextBox();
            this.txttotalwithdiscount = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnfinish = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltotalwithoutdiscount
            // 
            this.lbltotalwithoutdiscount.AutoSize = true;
            this.lbltotalwithoutdiscount.Location = new System.Drawing.Point(37, 30);
            this.lbltotalwithoutdiscount.Name = "lbltotalwithoutdiscount";
            this.lbltotalwithoutdiscount.Size = new System.Drawing.Size(137, 15);
            this.lbltotalwithoutdiscount.TabIndex = 0;
            this.lbltotalwithoutdiscount.Text = "Total (without Discount)";
            // 
            // lbltotalwithdiscount
            // 
            this.lbltotalwithdiscount.AutoSize = true;
            this.lbltotalwithdiscount.Location = new System.Drawing.Point(37, 97);
            this.lbltotalwithdiscount.Name = "lbltotalwithdiscount";
            this.lbltotalwithdiscount.Size = new System.Drawing.Size(120, 15);
            this.lbltotalwithdiscount.TabIndex = 1;
            this.lbltotalwithdiscount.Text = "Total (with Discount)";
            // 
            // lblpayby
            // 
            this.lblpayby.AutoSize = true;
            this.lblpayby.Location = new System.Drawing.Point(37, 163);
            this.lblpayby.Name = "lblpayby";
            this.lblpayby.Size = new System.Drawing.Size(42, 15);
            this.lblpayby.TabIndex = 2;
            this.lblpayby.Text = "Pay by";
            // 
            // txttotalwithoutdiscount
            // 
            this.txttotalwithoutdiscount.Location = new System.Drawing.Point(194, 27);
            this.txttotalwithoutdiscount.Name = "txttotalwithoutdiscount";
            this.txttotalwithoutdiscount.Size = new System.Drawing.Size(140, 22);
            this.txttotalwithoutdiscount.TabIndex = 3;
            // 
            // txttotalwithdiscount
            // 
            this.txttotalwithdiscount.Location = new System.Drawing.Point(194, 97);
            this.txttotalwithdiscount.Name = "txttotalwithdiscount";
            this.txttotalwithdiscount.Size = new System.Drawing.Size(140, 22);
            this.txttotalwithdiscount.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Visa",
            "Master",
            "Debit",
            "Credit"});
            this.comboBox1.Location = new System.Drawing.Point(194, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // btnfinish
            // 
            this.btnfinish.Location = new System.Drawing.Point(50, 278);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(75, 23);
            this.btnfinish.TabIndex = 6;
            this.btnfinish.Text = "Finish";
            this.btnfinish.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FInal_Project.Properties.Resources.images__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(395, 378);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnfinish);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txttotalwithdiscount);
            this.Controls.Add(this.txttotalwithoutdiscount);
            this.Controls.Add(this.lblpayby);
            this.Controls.Add(this.lbltotalwithdiscount);
            this.Controls.Add(this.lbltotalwithoutdiscount);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form5";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotalwithoutdiscount;
        private System.Windows.Forms.Label lbltotalwithdiscount;
        private System.Windows.Forms.Label lblpayby;
        private System.Windows.Forms.TextBox txttotalwithoutdiscount;
        private System.Windows.Forms.TextBox txttotalwithdiscount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.Button btnCancel;
    }
}