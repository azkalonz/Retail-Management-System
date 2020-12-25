
namespace Retail_Management_System.Controls
{
    partial class CurrentCustomer
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
            this.user_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerComboBox1 = new Retail_Management_System.Controls.CustomerComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(81, 99);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(225, 25);
            this.user_name.TabIndex = 1;
            this.user_name.Text = "Firstname Lastname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer #";
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_id.Location = new System.Drawing.Point(167, 128);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(93, 16);
            this.user_id.TabIndex = 3;
            this.user_id.Text = "Customer #1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Retail_Management_System.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(3, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // customerComboBox1
            // 
            this.customerComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.customerComboBox1.Location = new System.Drawing.Point(0, 0);
            this.customerComboBox1.Name = "customerComboBox1";
            this.customerComboBox1.Size = new System.Drawing.Size(331, 66);
            this.customerComboBox1.TabIndex = 0;
            this.customerComboBox1.CustomerChanged += new System.EventHandler(this.customerComboBox1_CustomerChanged);
            // 
            // CurrentCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.customerComboBox1);
            this.Name = "CurrentCustomer";
            this.Size = new System.Drawing.Size(346, 161);
            this.Load += new System.EventHandler(this.CurrentCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerComboBox customerComboBox1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
