namespace FInal_Project
{
    partial class frmOfferDetails
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
            this.lblTotalLeaves = new System.Windows.Forms.Label();
            this.lblOTHours = new System.Windows.Forms.Label();
            this.lblpresentation = new System.Windows.Forms.Label();
            this.txtTotalLeaves = new System.Windows.Forms.TextBox();
            this.txtOThours = new System.Windows.Forms.TextBox();
            this.txtPresentation = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalLeaves
            // 
            this.lblTotalLeaves.AutoSize = true;
            this.lblTotalLeaves.Location = new System.Drawing.Point(28, 50);
            this.lblTotalLeaves.Name = "lblTotalLeaves";
            this.lblTotalLeaves.Size = new System.Drawing.Size(74, 15);
            this.lblTotalLeaves.TabIndex = 0;
            this.lblTotalLeaves.Text = "Total Leaves";
            // 
            // lblOTHours
            // 
            this.lblOTHours.AutoSize = true;
            this.lblOTHours.Location = new System.Drawing.Point(28, 114);
            this.lblOTHours.Name = "lblOTHours";
            this.lblOTHours.Size = new System.Drawing.Size(62, 15);
            this.lblOTHours.TabIndex = 1;
            this.lblOTHours.Text = "OT Hours";
            // 
            // lblpresentation
            // 
            this.lblpresentation.AutoSize = true;
            this.lblpresentation.Location = new System.Drawing.Point(28, 177);
            this.lblpresentation.Name = "lblpresentation";
            this.lblpresentation.Size = new System.Drawing.Size(77, 15);
            this.lblpresentation.TabIndex = 2;
            this.lblpresentation.Text = "Presentation";
            // 
            // txtTotalLeaves
            // 
            this.txtTotalLeaves.Location = new System.Drawing.Point(156, 50);
            this.txtTotalLeaves.Name = "txtTotalLeaves";
            this.txtTotalLeaves.Size = new System.Drawing.Size(214, 22);
            this.txtTotalLeaves.TabIndex = 3;
            // 
            // txtOThours
            // 
            this.txtOThours.Location = new System.Drawing.Point(156, 111);
            this.txtOThours.Name = "txtOThours";
            this.txtOThours.Size = new System.Drawing.Size(214, 22);
            this.txtOThours.TabIndex = 4;
            // 
            // txtPresentation
            // 
            this.txtPresentation.Location = new System.Drawing.Point(156, 170);
            this.txtPresentation.Name = "txtPresentation";
            this.txtPresentation.Size = new System.Drawing.Size(214, 22);
            this.txtPresentation.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(85, 264);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 27);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(293, 264);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 27);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // frmOfferDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FInal_Project.Properties.Resources.images__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 342);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPresentation);
            this.Controls.Add(this.txtOThours);
            this.Controls.Add(this.txtTotalLeaves);
            this.Controls.Add(this.lblpresentation);
            this.Controls.Add(this.lblOTHours);
            this.Controls.Add(this.lblTotalLeaves);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmOfferDetails";
            this.Text = "Offer Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalLeaves;
        private System.Windows.Forms.Label lblOTHours;
        private System.Windows.Forms.Label lblpresentation;
        private System.Windows.Forms.TextBox txtTotalLeaves;
        private System.Windows.Forms.TextBox txtOThours;
        private System.Windows.Forms.TextBox txtPresentation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}