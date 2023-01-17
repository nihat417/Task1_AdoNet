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
            this.books_Listbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Insert_Idtextbox = new System.Windows.Forms.TextBox();
            this.AllAuthorsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Refresh_Btn
            // 
            this.Refresh_Btn.Location = new System.Drawing.Point(209, 51);
            this.Refresh_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Refresh_Btn.Name = "Refresh_Btn";
            this.Refresh_Btn.Size = new System.Drawing.Size(120, 41);
            this.Refresh_Btn.TabIndex = 1;
            this.Refresh_Btn.Text = "refresh";
            this.Refresh_Btn.UseVisualStyleBackColor = true;
            this.Refresh_Btn.Click += new System.EventHandler(this.Refresh_Btn_Click);
            // 
            // Execute_Btn
            // 
            this.Execute_Btn.Location = new System.Drawing.Point(387, 57);
            this.Execute_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Execute_Btn.Name = "Execute_Btn";
            this.Execute_Btn.Size = new System.Drawing.Size(114, 35);
            this.Execute_Btn.TabIndex = 2;
            this.Execute_Btn.Text = "EXECUTE";
            this.Execute_Btn.UseVisualStyleBackColor = true;
            this.Execute_Btn.Click += new System.EventHandler(this.Execute_Btn_Click);
            // 
            // Insert_Btn
            // 
            this.Insert_Btn.Location = new System.Drawing.Point(654, 369);
            this.Insert_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insert_Btn.Name = "Insert_Btn";
            this.Insert_Btn.Size = new System.Drawing.Size(123, 41);
            this.Insert_Btn.TabIndex = 3;
            this.Insert_Btn.Text = "Insert";
            this.Insert_Btn.UseVisualStyleBackColor = true;
            this.Insert_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Location = new System.Drawing.Point(795, 369);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(107, 41);
            this.Delete_Btn.TabIndex = 4;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Authors_cmbx
            // 
            this.Authors_cmbx.FormattingEnabled = true;
            this.Authors_cmbx.Location = new System.Drawing.Point(26, 57);
            this.Authors_cmbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Authors_cmbx.Name = "Authors_cmbx";
            this.Authors_cmbx.Size = new System.Drawing.Size(159, 28);
            this.Authors_cmbx.TabIndex = 5;
            this.Authors_cmbx.SelectedIndexChanged += new System.EventHandler(this.Authors_cmbx_SelectedIndexChanged);
            // 
            // Category_cmbx
            // 
            this.Category_cmbx.FormattingEnabled = true;
            this.Category_cmbx.Location = new System.Drawing.Point(566, 57);
            this.Category_cmbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Category_cmbx.Name = "Category_cmbx";
            this.Category_cmbx.Size = new System.Drawing.Size(138, 28);
            this.Category_cmbx.TabIndex = 6;
            // 
            // Insert_Nametextbox
            // 
            this.Insert_Nametextbox.Location = new System.Drawing.Point(654, 210);
            this.Insert_Nametextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insert_Nametextbox.Name = "Insert_Nametextbox";
            this.Insert_Nametextbox.Size = new System.Drawing.Size(241, 27);
            this.Insert_Nametextbox.TabIndex = 7;
            // 
            // Insert_LastNametextbox
            // 
            this.Insert_LastNametextbox.Location = new System.Drawing.Point(649, 284);
            this.Insert_LastNametextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insert_LastNametextbox.Name = "Insert_LastNametextbox";
            this.Insert_LastNametextbox.Size = new System.Drawing.Size(241, 27);
            this.Insert_LastNametextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 7);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.label1.Size = new System.Drawing.Size(82, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Authors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.label2.Size = new System.Drawing.Size(91, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 160);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.label3.Size = new System.Drawing.Size(98, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "FirstName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 233);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.label4.Size = new System.Drawing.Size(97, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "LastName";
            // 
            // books_Listbox
            // 
            this.books_Listbox.FormattingEnabled = true;
            this.books_Listbox.ItemHeight = 20;
            this.books_Listbox.Location = new System.Drawing.Point(26, 123);
            this.books_Listbox.Name = "books_Listbox";
            this.books_Listbox.Size = new System.Drawing.Size(534, 364);
            this.books_Listbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 89);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            this.label5.Size = new System.Drawing.Size(44, 46);
            this.label5.TabIndex = 15;
            this.label5.Text = "Id";
            // 
            // Insert_Idtextbox
            // 
            this.Insert_Idtextbox.Location = new System.Drawing.Point(661, 139);
            this.Insert_Idtextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Insert_Idtextbox.Name = "Insert_Idtextbox";
            this.Insert_Idtextbox.Size = new System.Drawing.Size(241, 27);
            this.Insert_Idtextbox.TabIndex = 14;
            // 
            // AllAuthorsBtn
            // 
            this.AllAuthorsBtn.Location = new System.Drawing.Point(724, 420);
            this.AllAuthorsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllAuthorsBtn.Name = "AllAuthorsBtn";
            this.AllAuthorsBtn.Size = new System.Drawing.Size(121, 41);
            this.AllAuthorsBtn.TabIndex = 16;
            this.AllAuthorsBtn.Text = "All Authors";
            this.AllAuthorsBtn.UseVisualStyleBackColor = true;
            this.AllAuthorsBtn.Click += new System.EventHandler(this.AllAuthorsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.AllAuthorsBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Insert_Idtextbox);
            this.Controls.Add(this.books_Listbox);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private ListBox books_Listbox;
        private Label label5;
        private TextBox Insert_Idtextbox;
        private Button AllAuthorsBtn;
    }
}