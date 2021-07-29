
namespace Medical_Insurance
{
    partial class SearchPolicy
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
            this.Insertion = new System.Windows.Forms.Label();
            this.Inserted_SSNS = new System.Windows.Forms.ComboBox();
            this.NameL = new System.Windows.Forms.Label();
            this.NameT = new System.Windows.Forms.TextBox();
            this.ShowNames = new System.Windows.Forms.Button();
            this.AddressL = new System.Windows.Forms.Label();
            this.End_DateT = new System.Windows.Forms.TextBox();
            this.GenderL = new System.Windows.Forms.Label();
            this.Start_DateT = new System.Windows.Forms.TextBox();
            this.StatusL = new System.Windows.Forms.Label();
            this.SSNT = new System.Windows.Forms.TextBox();
            this.EmailL = new System.Windows.Forms.Label();
            this.Medical_historyT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PolicyTypeT = new System.Windows.Forms.TextBox();
            this.PolicyIDL = new System.Windows.Forms.Label();
            this.PolicyIDT = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.Confirm_insertion = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Insertion
            // 
            this.Insertion.AutoSize = true;
            this.Insertion.Location = new System.Drawing.Point(294, 73);
            this.Insertion.Name = "Insertion";
            this.Insertion.Size = new System.Drawing.Size(86, 13);
            this.Insertion.TabIndex = 19;
            this.Insertion.Text = "Select Person ID";
            // 
            // Inserted_SSNS
            // 
            this.Inserted_SSNS.FormattingEnabled = true;
            this.Inserted_SSNS.Location = new System.Drawing.Point(411, 68);
            this.Inserted_SSNS.Name = "Inserted_SSNS";
            this.Inserted_SSNS.Size = new System.Drawing.Size(125, 21);
            this.Inserted_SSNS.TabIndex = 18;
            this.Inserted_SSNS.SelectedIndexChanged += new System.EventHandler(this.Inserted_SSNS_SelectedIndexChanged);
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(22, 73);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(106, 13);
            this.NameL.TabIndex = 21;
            this.NameL.Text = "Enter Person\'s Name";
            // 
            // NameT
            // 
            this.NameT.Location = new System.Drawing.Point(146, 69);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(125, 20);
            this.NameT.TabIndex = 20;
            // 
            // ShowNames
            // 
            this.ShowNames.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowNames.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNames.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowNames.Location = new System.Drawing.Point(25, 119);
            this.ShowNames.Name = "ShowNames";
            this.ShowNames.Size = new System.Drawing.Size(120, 41);
            this.ShowNames.TabIndex = 22;
            this.ShowNames.Text = "Show ID";
            this.ShowNames.UseVisualStyleBackColor = false;
            this.ShowNames.Click += new System.EventHandler(this.ShowNames_Click);
            // 
            // AddressL
            // 
            this.AddressL.AutoSize = true;
            this.AddressL.Location = new System.Drawing.Point(294, 313);
            this.AddressL.Name = "AddressL";
            this.AddressL.Size = new System.Drawing.Size(54, 13);
            this.AddressL.TabIndex = 34;
            this.AddressL.Text = "End_Date";
            // 
            // End_DateT
            // 
            this.End_DateT.Location = new System.Drawing.Point(411, 309);
            this.End_DateT.Name = "End_DateT";
            this.End_DateT.Size = new System.Drawing.Size(125, 20);
            this.End_DateT.TabIndex = 33;
            // 
            // GenderL
            // 
            this.GenderL.AutoSize = true;
            this.GenderL.Location = new System.Drawing.Point(294, 252);
            this.GenderL.Name = "GenderL";
            this.GenderL.Size = new System.Drawing.Size(60, 13);
            this.GenderL.TabIndex = 32;
            this.GenderL.Text = "Start_Date";
            // 
            // Start_DateT
            // 
            this.Start_DateT.Location = new System.Drawing.Point(411, 248);
            this.Start_DateT.Name = "Start_DateT";
            this.Start_DateT.Size = new System.Drawing.Size(125, 20);
            this.Start_DateT.TabIndex = 31;
            // 
            // StatusL
            // 
            this.StatusL.AutoSize = true;
            this.StatusL.Location = new System.Drawing.Point(294, 191);
            this.StatusL.Name = "StatusL";
            this.StatusL.Size = new System.Drawing.Size(26, 13);
            this.StatusL.TabIndex = 30;
            this.StatusL.Text = "SSN";
            // 
            // SSNT
            // 
            this.SSNT.Location = new System.Drawing.Point(411, 189);
            this.SSNT.Name = "SSNT";
            this.SSNT.Size = new System.Drawing.Size(125, 20);
            this.SSNT.TabIndex = 29;
            this.SSNT.TextChanged += new System.EventHandler(this.SSNT_TextChanged);
            // 
            // EmailL
            // 
            this.EmailL.AutoSize = true;
            this.EmailL.Location = new System.Drawing.Point(29, 314);
            this.EmailL.Name = "EmailL";
            this.EmailL.Size = new System.Drawing.Size(79, 13);
            this.EmailL.TabIndex = 28;
            this.EmailL.Text = "Medical History";
            // 
            // Medical_historyT
            // 
            this.Medical_historyT.Location = new System.Drawing.Point(146, 312);
            this.Medical_historyT.Name = "Medical_historyT";
            this.Medical_historyT.Size = new System.Drawing.Size(125, 20);
            this.Medical_historyT.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Policy Type";
            // 
            // PolicyTypeT
            // 
            this.PolicyTypeT.Location = new System.Drawing.Point(146, 248);
            this.PolicyTypeT.Name = "PolicyTypeT";
            this.PolicyTypeT.Size = new System.Drawing.Size(125, 20);
            this.PolicyTypeT.TabIndex = 25;
            // 
            // PolicyIDL
            // 
            this.PolicyIDL.AutoSize = true;
            this.PolicyIDL.Location = new System.Drawing.Point(29, 191);
            this.PolicyIDL.Name = "PolicyIDL";
            this.PolicyIDL.Size = new System.Drawing.Size(48, 13);
            this.PolicyIDL.TabIndex = 24;
            this.PolicyIDL.Text = "Policy ID";
            // 
            // PolicyIDT
            // 
            this.PolicyIDT.Location = new System.Drawing.Point(146, 187);
            this.PolicyIDT.Name = "PolicyIDT";
            this.PolicyIDT.ReadOnly = true;
            this.PolicyIDT.Size = new System.Drawing.Size(125, 20);
            this.PolicyIDT.TabIndex = 23;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Back.Location = new System.Drawing.Point(443, 379);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(120, 41);
            this.Back.TabIndex = 35;
            this.Back.Text = "<- Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Confirm_insertion
            // 
            this.Confirm_insertion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Confirm_insertion.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_insertion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Confirm_insertion.Location = new System.Drawing.Point(241, 379);
            this.Confirm_insertion.Name = "Confirm_insertion";
            this.Confirm_insertion.Size = new System.Drawing.Size(108, 41);
            this.Confirm_insertion.TabIndex = 36;
            this.Confirm_insertion.Text = "Insert";
            this.Confirm_insertion.UseVisualStyleBackColor = false;
            this.Confirm_insertion.Click += new System.EventHandler(this.Confirm_insertion_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Search.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Search.Location = new System.Drawing.Point(25, 379);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(108, 41);
            this.Search.TabIndex = 37;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(213, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Policy Form";
            // 
            // SearchPolicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Confirm_insertion);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddressL);
            this.Controls.Add(this.End_DateT);
            this.Controls.Add(this.GenderL);
            this.Controls.Add(this.Start_DateT);
            this.Controls.Add(this.StatusL);
            this.Controls.Add(this.SSNT);
            this.Controls.Add(this.EmailL);
            this.Controls.Add(this.Medical_historyT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PolicyTypeT);
            this.Controls.Add(this.PolicyIDL);
            this.Controls.Add(this.PolicyIDT);
            this.Controls.Add(this.ShowNames);
            this.Controls.Add(this.NameL);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.Insertion);
            this.Controls.Add(this.Inserted_SSNS);
            this.Name = "SearchPolicy";
            this.Text = "SearchPolicy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchPolicy_FormClosing);
            this.Load += new System.EventHandler(this.SearchPolicy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Insertion;
        private System.Windows.Forms.ComboBox Inserted_SSNS;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.Button ShowNames;
        private System.Windows.Forms.Label AddressL;
        private System.Windows.Forms.TextBox End_DateT;
        private System.Windows.Forms.Label GenderL;
        private System.Windows.Forms.TextBox Start_DateT;
        private System.Windows.Forms.Label StatusL;
        private System.Windows.Forms.TextBox SSNT;
        private System.Windows.Forms.Label EmailL;
        private System.Windows.Forms.TextBox Medical_historyT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PolicyTypeT;
        private System.Windows.Forms.Label PolicyIDL;
        private System.Windows.Forms.TextBox PolicyIDT;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Confirm_insertion;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label2;
    }
}