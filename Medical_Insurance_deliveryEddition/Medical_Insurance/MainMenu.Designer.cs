
namespace Medical_Insurance
{
    partial class MainMenu
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
            this.Insert_Person = new System.Windows.Forms.Button();
            this.Search_Person = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dependent = new System.Windows.Forms.Button();
            this.GetReports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Insert_Person
            // 
            this.Insert_Person.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Insert_Person.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_Person.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Insert_Person.Location = new System.Drawing.Point(9, 127);
            this.Insert_Person.Name = "Insert_Person";
            this.Insert_Person.Size = new System.Drawing.Size(174, 61);
            this.Insert_Person.TabIndex = 0;
            this.Insert_Person.Text = "Insert Person";
            this.Insert_Person.UseVisualStyleBackColor = false;
            this.Insert_Person.Click += new System.EventHandler(this.Insert_Person_Click);
            // 
            // Search_Person
            // 
            this.Search_Person.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search_Person.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Person.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Search_Person.Location = new System.Drawing.Point(452, 127);
            this.Search_Person.Name = "Search_Person";
            this.Search_Person.Size = new System.Drawing.Size(174, 61);
            this.Search_Person.TabIndex = 1;
            this.Search_Person.Text = "Insert/Search Policy";
            this.Search_Person.UseVisualStyleBackColor = false;
            this.Search_Person.Click += new System.EventHandler(this.Search_Person_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(117, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health Insurance System";
            // 
            // Dependent
            // 
            this.Dependent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dependent.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dependent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dependent.Location = new System.Drawing.Point(235, 198);
            this.Dependent.Name = "Dependent";
            this.Dependent.Size = new System.Drawing.Size(174, 76);
            this.Dependent.TabIndex = 3;
            this.Dependent.Text = "Manage Dependent";
            this.Dependent.UseVisualStyleBackColor = false;
            this.Dependent.Click += new System.EventHandler(this.Dependent_Click);
            // 
            // GetReports
            // 
            this.GetReports.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GetReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.GetReports.ForeColor = System.Drawing.Color.FloralWhite;
            this.GetReports.Location = new System.Drawing.Point(9, 293);
            this.GetReports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetReports.Name = "GetReports";
            this.GetReports.Size = new System.Drawing.Size(174, 107);
            this.GetReports.TabIndex = 4;
            this.GetReports.Text = "Get Persons Report";
            this.GetReports.UseVisualStyleBackColor = false;
            this.GetReports.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(452, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 107);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Dependents Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(655, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetReports);
            this.Controls.Add(this.Dependent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_Person);
            this.Controls.Add(this.Insert_Person);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert_Person;
        private System.Windows.Forms.Button Search_Person;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Dependent;
        private System.Windows.Forms.Button GetReports;
        private System.Windows.Forms.Button button1;
    }
}

