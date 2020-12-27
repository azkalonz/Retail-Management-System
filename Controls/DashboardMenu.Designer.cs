
namespace Retail_Management_System.Controls
{
    partial class DashboardMenu
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
            this.components = new System.ComponentModel.Container();
            this.user_dropdown = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.name = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.reportsbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.users = new Guna.UI2.WinForms.Guna2Button();
            this.user_dropdown.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_dropdown
            // 
            this.user_dropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.user_dropdown.BackColor = System.Drawing.Color.Gainsboro;
            this.user_dropdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_dropdown.Controls.Add(this.logout_button);
            this.user_dropdown.Location = new System.Drawing.Point(404, 66);
            this.user_dropdown.Name = "user_dropdown";
            this.user_dropdown.Size = new System.Drawing.Size(217, 45);
            this.user_dropdown.TabIndex = 3;
            // 
            // logout_button
            // 
            this.logout_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_button.Location = new System.Drawing.Point(14, 10);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(187, 23);
            this.logout_button.TabIndex = 0;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(439, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(165, 55);
            this.name.TabIndex = 0;
            this.name.Text = "First Name Last Name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(4, 14);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(116, 23);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "LOGOUT";
            this.guna2Button1.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.name);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel1);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel2);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 55);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Location = new System.Drawing.Point(302, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(131, 52);
            this.guna2Panel1.TabIndex = 5;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.reportsbtn);
            this.guna2Panel2.Location = new System.Drawing.Point(165, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(131, 52);
            this.guna2Panel2.TabIndex = 6;
            // 
            // reportsbtn
            // 
            this.reportsbtn.BorderRadius = 10;
            this.reportsbtn.CheckedState.Parent = this.reportsbtn;
            this.reportsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsbtn.CustomImages.Parent = this.reportsbtn;
            this.reportsbtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.reportsbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportsbtn.ForeColor = System.Drawing.Color.White;
            this.reportsbtn.HoverState.Parent = this.reportsbtn;
            this.reportsbtn.Location = new System.Drawing.Point(4, 14);
            this.reportsbtn.Name = "reportsbtn";
            this.reportsbtn.ShadowDecoration.Parent = this.reportsbtn;
            this.reportsbtn.Size = new System.Drawing.Size(116, 23);
            this.reportsbtn.TabIndex = 4;
            this.reportsbtn.Text = "REPORTS";
            this.reportsbtn.Click += new System.EventHandler(this.reportsbtn_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.users);
            this.guna2Panel3.Location = new System.Drawing.Point(28, 3);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(131, 52);
            this.guna2Panel3.TabIndex = 7;
            // 
            // users
            // 
            this.users.BorderRadius = 10;
            this.users.CheckedState.Parent = this.users;
            this.users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users.CustomImages.Parent = this.users;
            this.users.FillColor = System.Drawing.Color.DodgerBlue;
            this.users.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.users.ForeColor = System.Drawing.Color.White;
            this.users.HoverState.Parent = this.users;
            this.users.Location = new System.Drawing.Point(4, 14);
            this.users.Name = "users";
            this.users.ShadowDecoration.Parent = this.users;
            this.users.Size = new System.Drawing.Size(116, 23);
            this.users.TabIndex = 4;
            this.users.Text = "USERS";
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // DashboardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.user_dropdown);
            this.Name = "DashboardMenu";
            this.Size = new System.Drawing.Size(621, 61);
            this.Load += new System.EventHandler(this.DashboardMenu_Load_1);
            this.user_dropdown.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel user_dropdown;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label name;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button reportsbtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button users;
    }
}
