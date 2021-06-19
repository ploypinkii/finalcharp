
namespace final
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.exitbtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.showcheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernamebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.CheckedState.Parent = this.exitbtn;
            this.exitbtn.CustomImages.Parent = this.exitbtn;
            this.exitbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.HoverState.Parent = this.exitbtn;
            this.exitbtn.Location = new System.Drawing.Point(511, 12);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitbtn.ShadowDecoration.Parent = this.exitbtn;
            this.exitbtn.Size = new System.Drawing.Size(25, 25);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.linkLabel2);
            this.guna2Panel1.Controls.Add(this.showcheck);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.passwordbox);
            this.guna2Panel1.Controls.Add(this.usernamebox);
            this.guna2Panel1.Location = new System.Drawing.Point(99, 294);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(359, 199);
            this.guna2Panel1.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Purple;
            this.linkLabel2.Location = new System.Drawing.Point(229, 167);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(126, 17);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Password ?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // showcheck
            // 
            this.showcheck.AutoSize = true;
            this.showcheck.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showcheck.Location = new System.Drawing.Point(8, 167);
            this.showcheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showcheck.Name = "showcheck";
            this.showcheck.Size = new System.Drawing.Size(128, 23);
            this.showcheck.TabIndex = 4;
            this.showcheck.Text = "Show password";
            this.showcheck.UseVisualStyleBackColor = true;
            this.showcheck.CheckedChanged += new System.EventHandler(this.showcheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "USERNAME";
            // 
            // passwordbox
            // 
            this.passwordbox.AutoRoundedCorners = true;
            this.passwordbox.BorderRadius = 22;
            this.passwordbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordbox.DefaultText = "";
            this.passwordbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordbox.DisabledState.Parent = this.passwordbox;
            this.passwordbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordbox.FocusedState.Parent = this.passwordbox;
            this.passwordbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordbox.HoverState.Parent = this.passwordbox;
            this.passwordbox.Location = new System.Drawing.Point(3, 114);
            this.passwordbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordbox.MaxLength = 12;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '♥';
            this.passwordbox.PlaceholderText = "";
            this.passwordbox.SelectedText = "";
            this.passwordbox.ShadowDecoration.Parent = this.passwordbox;
            this.passwordbox.Size = new System.Drawing.Size(352, 46);
            this.passwordbox.TabIndex = 1;
            this.passwordbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordbox_KeyDown);
            this.passwordbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordbox_KeyPress);
            // 
            // usernamebox
            // 
            this.usernamebox.AutoRoundedCorners = true;
            this.usernamebox.BorderRadius = 22;
            this.usernamebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernamebox.DefaultText = "";
            this.usernamebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernamebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernamebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernamebox.DisabledState.Parent = this.usernamebox;
            this.usernamebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernamebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernamebox.FocusedState.Parent = this.usernamebox;
            this.usernamebox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernamebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernamebox.HoverState.Parent = this.usernamebox;
            this.usernamebox.Location = new System.Drawing.Point(4, 32);
            this.usernamebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernamebox.MaxLength = 20;
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.PasswordChar = '\0';
            this.usernamebox.PlaceholderText = "";
            this.usernamebox.SelectedText = "";
            this.usernamebox.ShadowDecoration.Parent = this.usernamebox;
            this.usernamebox.Size = new System.Drawing.Size(352, 46);
            this.usernamebox.TabIndex = 0;
            this.usernamebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernamebox_KeyPress);
            // 
            // loginbtn
            // 
            this.loginbtn.Animated = true;
            this.loginbtn.AutoRoundedCorners = true;
            this.loginbtn.BorderRadius = 22;
            this.loginbtn.CheckedState.Parent = this.loginbtn;
            this.loginbtn.CustomImages.Parent = this.loginbtn;
            this.loginbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(125)))), ((int)(((byte)(173)))));
            this.loginbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.HoverState.Parent = this.loginbtn;
            this.loginbtn.Location = new System.Drawing.Point(187, 527);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.ShadowDecoration.Parent = this.loginbtn;
            this.loginbtn.Size = new System.Drawing.Size(180, 46);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Haven\'t account ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Purple;
            this.linkLabel1.Location = new System.Drawing.Point(295, 585);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign up";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Location = new System.Drawing.Point(135, 43);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(284, 245);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DragEndTransparencyValue = 0.5D;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(548, 690);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton exitbtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox usernamebox;
        private Guna.UI2.WinForms.Guna2TextBox passwordbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showcheck;
        private Guna.UI2.WinForms.Guna2Button loginbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

