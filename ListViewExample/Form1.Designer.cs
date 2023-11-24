namespace ListViewExample
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.age_nupd = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.status_lbl = new System.Windows.Forms.Label();
            this.status_cmbx = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.getUser_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.age_nupd)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(166, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(312, 321);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(15, 67);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 2;
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(15, 141);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(100, 20);
            this.surname_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // age_nupd
            // 
            this.age_nupd.Location = new System.Drawing.Point(12, 204);
            this.age_nupd.Name = "age_nupd";
            this.age_nupd.Size = new System.Drawing.Size(125, 20);
            this.age_nupd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age";
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(12, 248);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(37, 13);
            this.status_lbl.TabIndex = 7;
            this.status_lbl.Text = "Status";
            // 
            // status_cmbx
            // 
            this.status_cmbx.FormattingEnabled = true;
            this.status_cmbx.Items.AddRange(new object[] {
            "Active",
            "Passive"});
            this.status_cmbx.Location = new System.Drawing.Point(12, 279);
            this.status_cmbx.Name = "status_cmbx";
            this.status_cmbx.Size = new System.Drawing.Size(121, 21);
            this.status_cmbx.TabIndex = 8;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(15, 325);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(122, 23);
            this.add_btn.TabIndex = 9;
            this.add_btn.Text = "Add User";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(571, 54);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(312, 321);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // getUser_btn
            // 
            this.getUser_btn.Location = new System.Drawing.Point(632, 407);
            this.getUser_btn.Name = "getUser_btn";
            this.getUser_btn.Size = new System.Drawing.Size(156, 23);
            this.getUser_btn.TabIndex = 11;
            this.getUser_btn.Text = "Get User List";
            this.getUser_btn.UseVisualStyleBackColor = true;
            this.getUser_btn.Click += new System.EventHandler(this.getUser_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 470);
            this.Controls.Add(this.getUser_btn);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.status_cmbx);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.age_nupd);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.age_nupd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown age_nupd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.ComboBox status_cmbx;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button getUser_btn;
    }
}

