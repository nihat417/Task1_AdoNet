namespace Task1_AdoNet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.books_Listbox = new System.Windows.Forms.ListBox();
            this.Refresh_Btn = new System.Windows.Forms.Button();
            this.Execute_Btn = new System.Windows.Forms.Button();
            this.Insert_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Authors_cmbx = new System.Windows.Forms.ComboBox();
            this.Category_cmbx = new System.Windows.Forms.ComboBox();
            this.Insert_Nametextbox = new System.Windows.Forms.TextBox();
            this.Insert_LastNametextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // books_Listbox
            // 
            this.books_Listbox.FormattingEnabled = true;
            this.books_Listbox.ItemHeight = 15;
            this.books_Listbox.Location = new System.Drawing.Point(12, 103);
            this.books_Listbox.Name = "books_Listbox";
            this.books_Listbox.Size = new System.Drawing.Size(543, 259);
            this.books_Listbox.TabIndex = 0;
            // 
            // Refresh_Btn
            // 
            this.Refresh_Btn.Location = new System.Drawing.Point(183, 38);
            this.Refresh_Btn.Name = "Refresh_Btn";
            this.Refresh_Btn.Size = new System.Drawing.Size(105, 31);
            this.Refresh_Btn.TabIndex = 1;
            this.Refresh_Btn.Text = "refresh";
            this.Refresh_Btn.UseVisualStyleBackColor = true;
            this.Refresh_Btn.Click += new System.EventHandler(this.Refresh_Btn_Click);
            // 
            // Execute_Btn
            // 
            this.Execute_Btn.Location = new System.Drawing.Point(339, 43);
            this.Execute_Btn.Name = "Execute_Btn";
            this.Execute_Btn.Size = new System.Drawing.Size(100, 26);
            this.Execute_Btn.TabIndex = 2;
            this.Execute_Btn.Text = "EXECUTE";
            this.Execute_Btn.UseVisualStyleBackColor = true;
            this.Execute_Btn.Click += new System.EventHandler(this.Execute_Btn_Click);
            // 
            // Insert_Btn
            // 
            this.Insert_Btn.Location = new System.Drawing.Point(572, 218);
            this.Insert_Btn.Name = "Insert_Btn";
            this.Insert_Btn.Size = new System.Drawing.Size(105, 31);
            this.Insert_Btn.TabIndex = 3;
            this.Insert_Btn.Text = "Insert";
            this.Insert_Btn.UseVisualStyleBackColor = true;
            this.Insert_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(683, 218);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(105, 31);
            this.Delete_Btn.TabIndex = 4;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Authors_cmbx
            // 
            this.Authors_cmbx.FormattingEnabled = true;
            this.Authors_cmbx.Location = new System.Drawing.Point(23, 43);
            this.Authors_cmbx.Name = "Authors_cmbx";
            this.Authors_cmbx.Size = new System.Drawing.Size(140, 23);
            this.Authors_cmbx.TabIndex = 5;
            this.Authors_cmbx.SelectedIndexChanged += new System.EventHandler(this.Authors_cmbx_SelectedIndexChanged);
            // 
            // Category_cmbx
            // 
            this.Category_cmbx.FormattingEnabled = true;
            this.Category_cmbx.Location = new System.Drawing.Point(495, 43);
            this.Category_cmbx.Name = "Category_cmbx";
            this.Category_cmbx.Size = new System.Drawing.Size(121, 23);
            this.Category_cmbx.TabIndex = 6;
            // 
            // Insert_Nametextbox
            // 
            this.Insert_Nametextbox.Location = new System.Drawing.Point(577, 103);
            this.Insert_Nametextbox.Name = "Insert_Nametextbox";
            this.Insert_Nametextbox.Size = new System.Drawing.Size(211, 23);
            this.Insert_Nametextbox.TabIndex = 7;
            // 
            // Insert_LastNametextbox
            // 
            this.Insert_LastNametextbox.Location = new System.Drawing.Point(577, 167);
            this.Insert_LastNametextbox.Name = "Insert_LastNametextbox";
            this.Insert_LastNametextbox.Size = new System.Drawing.Size(211, 23);
            this.Insert_LastNametextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(69, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Authors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(75, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 69);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10);
            this.label3.Size = new System.Drawing.Size(81, 35);
            this.label3.TabIndex = 11;
            this.label3.Text = "FirstName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 129);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(80, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "LastName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert_LastNametextbox);
            this.Controls.Add(this.Insert_Nametextbox);
            this.Controls.Add(this.Category_cmbx);
            this.Controls.Add(this.Authors_cmbx);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Insert_Btn);
            this.Controls.Add(this.Execute_Btn);
            this.Controls.Add(this.Refresh_Btn);
            this.Controls.Add(this.books_Listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox books_Listbox;
        private Button Refresh_Btn;
        private Button Execute_Btn;
        private Button Insert_Btn;
        private Button Delete_Btn;
        private ComboBox Authors_cmbx;
        private ComboBox Category_cmbx;
        private TextBox Insert_Nametextbox;
        private TextBox Insert_LastNametextbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}