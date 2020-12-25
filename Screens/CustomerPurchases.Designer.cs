
namespace Retail_Management_System.Screens
{
    partial class CustomerPurchases
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
            this.customer_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customer_name
            // 
            this.customer_name.AutoSize = true;
            this.customer_name.BackColor = System.Drawing.Color.Transparent;
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.Location = new System.Drawing.Point(12, 78);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(248, 29);
            this.customer_name.TabIndex = 0;
            this.customer_name.Text = "Firstname Lastname";
            // 
            // CustomerPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 547);
            this.Controls.Add(this.customer_name);
            this.Name = "CustomerPurchases";
            this.Text = "Customer Purchases";
            this.Load += new System.EventHandler(this.CustomerPurchases_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customer_name;
    }
}