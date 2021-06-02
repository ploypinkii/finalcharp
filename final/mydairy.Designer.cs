
namespace final
{
    partial class mydairy
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
            this.label1 = new System.Windows.Forms.Label();
            this.preview = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.editbtn = new Guna.UI2.WinForms.Guna2Button();
            this.mydairy2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "My dairy";
            // 
            // preview
            // 
            this.preview.Animated = true;
            this.preview.AutoRoundedCorners = true;
            this.preview.BorderRadius = 20;
            this.preview.CheckedState.Parent = this.preview;
            this.preview.CustomImages.Parent = this.preview;
            this.preview.FillColor = System.Drawing.Color.LightSteelBlue;
            this.preview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.preview.ForeColor = System.Drawing.Color.White;
            this.preview.HoverState.Parent = this.preview;
            this.preview.Location = new System.Drawing.Point(29, 395);
            this.preview.Name = "preview";
            this.preview.ShadowDecoration.Parent = this.preview;
            this.preview.Size = new System.Drawing.Size(123, 43);
            this.preview.TabIndex = 4;
            this.preview.Text = "all preview";
            this.preview.Click += new System.EventHandler(this.preview_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Plum;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(517, 395);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(123, 43);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.Text = "Delete dairy";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // editbtn
            // 
            this.editbtn.Animated = true;
            this.editbtn.AutoRoundedCorners = true;
            this.editbtn.BorderRadius = 20;
            this.editbtn.CheckedState.Parent = this.editbtn;
            this.editbtn.CustomImages.Parent = this.editbtn;
            this.editbtn.FillColor = System.Drawing.Color.MediumAquamarine;
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editbtn.ForeColor = System.Drawing.Color.White;
            this.editbtn.HoverState.Parent = this.editbtn;
            this.editbtn.Location = new System.Drawing.Point(377, 395);
            this.editbtn.Name = "editbtn";
            this.editbtn.ShadowDecoration.Parent = this.editbtn;
            this.editbtn.Size = new System.Drawing.Size(123, 43);
            this.editbtn.TabIndex = 7;
            this.editbtn.Text = "Edit dairy";
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // mydairy2
            // 
            this.mydairy2.Location = new System.Drawing.Point(29, 45);
            this.mydairy2.Name = "mydairy2";
            this.mydairy2.Size = new System.Drawing.Size(611, 319);
            this.mydairy2.TabIndex = 30;
            // 
            // mydairy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.mydairy2);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.label1);
            this.Name = "mydairy";
            this.Size = new System.Drawing.Size(669, 463);
            this.Load += new System.EventHandler(this.mydairy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button preview;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button editbtn;
        private System.Windows.Forms.Panel mydairy2;
    }
}
