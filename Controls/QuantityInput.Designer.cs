
namespace Retail_Management_System.Controls
{
    partial class QuantityInput
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
            this.label4 = new System.Windows.Forms.Label();
            this.product_quantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.product_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // product_quantity
            // 
            this.product_quantity.BackColor = System.Drawing.Color.Transparent;
            this.product_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.product_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.product_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.product_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.product_quantity.DisabledState.Parent = this.product_quantity;
            this.product_quantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.product_quantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.product_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.product_quantity.FocusedState.Parent = this.product_quantity;
            this.product_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.product_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.product_quantity.Location = new System.Drawing.Point(3, 3);
            this.product_quantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.ShadowDecoration.Parent = this.product_quantity;
            this.product_quantity.Size = new System.Drawing.Size(123, 56);
            this.product_quantity.TabIndex = 33;
            this.product_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.product_quantity.ValueChanged += new System.EventHandler(this.product_quantity_ValueChanged);
            this.product_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.product_quantity_ValueChanged);
            // 
            // QuantityInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.product_quantity);
            this.Controls.Add(this.label4);
            this.Name = "QuantityInput";
            this.Size = new System.Drawing.Size(126, 87);
            this.Load += new System.EventHandler(this.QuantityInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown product_quantity;
    }
}
