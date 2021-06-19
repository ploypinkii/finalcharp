
namespace final
{
    partial class read
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(read));
            this.searchdatetimepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.searchbtn = new Guna.UI2.WinForms.Guna2Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printbtn = new Guna.UI2.WinForms.Guna2Button();
            this.dairygridview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.emopic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picturebox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.clearbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dairygridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchdatetimepicker
            // 
            this.searchdatetimepicker.Animated = true;
            this.searchdatetimepicker.AutoRoundedCorners = true;
            this.searchdatetimepicker.BorderRadius = 9;
            this.searchdatetimepicker.CheckedState.Parent = this.searchdatetimepicker;
            this.searchdatetimepicker.FillColor = System.Drawing.Color.Silver;
            this.searchdatetimepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchdatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.searchdatetimepicker.HoverState.Parent = this.searchdatetimepicker;
            this.searchdatetimepicker.Location = new System.Drawing.Point(217, 18);
            this.searchdatetimepicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchdatetimepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.searchdatetimepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.searchdatetimepicker.Name = "searchdatetimepicker";
            this.searchdatetimepicker.ShadowDecoration.Parent = this.searchdatetimepicker;
            this.searchdatetimepicker.Size = new System.Drawing.Size(145, 21);
            this.searchdatetimepicker.TabIndex = 2;
            this.searchdatetimepicker.Value = new System.DateTime(2021, 6, 10, 18, 5, 11, 837);
            // 
            // searchbtn
            // 
            this.searchbtn.Animated = true;
            this.searchbtn.AutoRoundedCorners = true;
            this.searchbtn.BorderRadius = 9;
            this.searchbtn.CheckedState.Parent = this.searchbtn;
            this.searchbtn.CustomImages.Parent = this.searchbtn;
            this.searchbtn.FillColor = System.Drawing.Color.Thistle;
            this.searchbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.HoverState.Parent = this.searchbtn;
            this.searchbtn.Location = new System.Drawing.Point(381, 18);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.ShadowDecoration.Parent = this.searchbtn;
            this.searchbtn.Size = new System.Drawing.Size(84, 21);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "search";
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Location = new System.Drawing.Point(315, 110);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(291, 124);
            this.richTextBox.TabIndex = 5;
            this.richTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Status : ";
            // 
            // printbtn
            // 
            this.printbtn.Animated = true;
            this.printbtn.AutoRoundedCorners = true;
            this.printbtn.BorderRadius = 18;
            this.printbtn.CheckedState.Parent = this.printbtn;
            this.printbtn.CustomImages.Parent = this.printbtn;
            this.printbtn.FillColor = System.Drawing.Color.LightSteelBlue;
            this.printbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.printbtn.ForeColor = System.Drawing.Color.White;
            this.printbtn.HoverState.Parent = this.printbtn;
            this.printbtn.Location = new System.Drawing.Point(162, 403);
            this.printbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printbtn.Name = "printbtn";
            this.printbtn.ShadowDecoration.Parent = this.printbtn;
            this.printbtn.Size = new System.Drawing.Size(169, 38);
            this.printbtn.TabIndex = 9;
            this.printbtn.Text = "print dairy";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // dairygridview
            // 
            this.dairygridview.AllowUserToAddRows = false;
            this.dairygridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dairygridview.BackgroundColor = System.Drawing.Color.White;
            this.dairygridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dairygridview.ColumnHeadersHeight = 29;
            this.dairygridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dairygridview.Location = new System.Drawing.Point(60, 277);
            this.dairygridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dairygridview.MultiSelect = false;
            this.dairygridview.Name = "dairygridview";
            this.dairygridview.ReadOnly = true;
            this.dairygridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dairygridview.RowHeadersWidth = 51;
            this.dairygridview.RowTemplate.Height = 24;
            this.dairygridview.Size = new System.Drawing.Size(545, 113);
            this.dairygridview.TabIndex = 22;
            this.dairygridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dairygridview_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LEMON MILK", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 27);
            this.label2.TabIndex = 24;
            this.label2.Text = "All dairy preview and choose to print.";
            // 
            // emopic
            // 
            this.emopic.BackColor = System.Drawing.Color.Transparent;
            this.emopic.Image = global::final.Properties.Resources.happy;
            this.emopic.Location = new System.Drawing.Point(371, 63);
            this.emopic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emopic.Name = "emopic";
            this.emopic.ShadowDecoration.Parent = this.emopic;
            this.emopic.Size = new System.Drawing.Size(53, 42);
            this.emopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emopic.TabIndex = 23;
            this.emopic.TabStop = false;
            // 
            // picturebox
            // 
            this.picturebox.BackColor = System.Drawing.Color.Transparent;
            this.picturebox.Location = new System.Drawing.Point(60, 63);
            this.picturebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturebox.Name = "picturebox";
            this.picturebox.ShadowDecoration.Parent = this.picturebox;
            this.picturebox.Size = new System.Drawing.Size(236, 171);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox.TabIndex = 4;
            this.picturebox.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // clearbtn
            // 
            this.clearbtn.Animated = true;
            this.clearbtn.AutoRoundedCorners = true;
            this.clearbtn.BorderRadius = 18;
            this.clearbtn.CheckedState.Parent = this.clearbtn;
            this.clearbtn.CustomImages.Parent = this.clearbtn;
            this.clearbtn.FillColor = System.Drawing.Color.LightSteelBlue;
            this.clearbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.HoverState.Parent = this.clearbtn;
            this.clearbtn.Location = new System.Drawing.Point(381, 403);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.ShadowDecoration.Parent = this.clearbtn;
            this.clearbtn.Size = new System.Drawing.Size(163, 38);
            this.clearbtn.TabIndex = 25;
            this.clearbtn.Text = "clear";
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(380, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Clear the data to print a new document. ";
            // 
            // read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emopic);
            this.Controls.Add(this.dairygridview);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchdatetimepicker);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "read";
            this.Size = new System.Drawing.Size(669, 463);
            this.Load += new System.EventHandler(this.read_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dairygridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker searchdatetimepicker;
        private Guna.UI2.WinForms.Guna2Button searchbtn;
        private Guna.UI2.WinForms.Guna2PictureBox picturebox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button printbtn;
        private System.Windows.Forms.DataGridView dairygridview;
        private Guna.UI2.WinForms.Guna2PictureBox emopic;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2Button clearbtn;
        private System.Windows.Forms.Label label3;
    }
}
