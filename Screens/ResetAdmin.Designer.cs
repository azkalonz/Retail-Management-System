
namespace Retail_Management_System.Screens
{
    partial class ResetAdmin
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
            this.continue_btn = new Guna.UI2.WinForms.Guna2Button();
            this.verification_code = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.email_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.send_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // continue_btn
            // 
            this.continue_btn.CheckedState.Parent = this.continue_btn;
            this.continue_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continue_btn.CustomImages.Parent = this.continue_btn;
            this.continue_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.continue_btn.ForeColor = System.Drawing.Color.White;
            this.continue_btn.HoverState.Parent = this.continue_btn;
            this.continue_btn.Location = new System.Drawing.Point(77, 283);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.ShadowDecoration.Parent = this.continue_btn;
            this.continue_btn.Size = new System.Drawing.Size(180, 45);
            this.continue_btn.TabIndex = 0;
            this.continue_btn.Text = "Continue";
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // verification_code
            // 
            this.verification_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.verification_code.DefaultText = "";
            this.verification_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.verification_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.verification_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verification_code.DisabledState.Parent = this.verification_code;
            this.verification_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.verification_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verification_code.FocusedState.Parent = this.verification_code;
            this.verification_code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.verification_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.verification_code.HoverState.Parent = this.verification_code;
            this.verification_code.Location = new System.Drawing.Point(51, 220);
            this.verification_code.Name = "verification_code";
            this.verification_code.PasswordChar = '\0';
            this.verification_code.PlaceholderText = "Verification Code";
            this.verification_code.SelectedText = "";
            this.verification_code.ShadowDecoration.Parent = this.verification_code;
            this.verification_code.Size = new System.Drawing.Size(239, 36);
            this.verification_code.TabIndex = 1;
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(77, 334);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Cancel";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter your email address for verification.";
            // 
            // email_txt
            // 
            this.email_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_txt.DefaultText = "";
            this.email_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_txt.DisabledState.Parent = this.email_txt;
            this.email_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_txt.FocusedState.Parent = this.email_txt;
            this.email_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_txt.HoverState.Parent = this.email_txt;
            this.email_txt.Location = new System.Drawing.Point(51, 82);
            this.email_txt.Name = "email_txt";
            this.email_txt.PasswordChar = '\0';
            this.email_txt.PlaceholderText = "Email Address";
            this.email_txt.SelectedText = "";
            this.email_txt.ShadowDecoration.Parent = this.email_txt;
            this.email_txt.Size = new System.Drawing.Size(239, 36);
            this.email_txt.TabIndex = 4;
            // 
            // send_btn
            // 
            this.send_btn.CheckedState.Parent = this.send_btn;
            this.send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_btn.CustomImages.Parent = this.send_btn;
            this.send_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.send_btn.ForeColor = System.Drawing.Color.White;
            this.send_btn.HoverState.Parent = this.send_btn;
            this.send_btn.Location = new System.Drawing.Point(77, 140);
            this.send_btn.Name = "send_btn";
            this.send_btn.ShadowDecoration.Parent = this.send_btn;
            this.send_btn.Size = new System.Drawing.Size(180, 45);
            this.send_btn.TabIndex = 5;
            this.send_btn.Text = "Send";
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // ResetAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 423);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.verification_code);
            this.Controls.Add(this.continue_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetAdmin";
            this.Load += new System.EventHandler(this.ResetAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button continue_btn;
        private Guna.UI2.WinForms.Guna2TextBox verification_code;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox email_txt;
        private Guna.UI2.WinForms.Guna2Button send_btn;
    }
}