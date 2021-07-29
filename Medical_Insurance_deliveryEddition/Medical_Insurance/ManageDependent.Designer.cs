
namespace Medical_Insurance
{
    partial class ManageDependent
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
            this.load = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.SSNL = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.DependentT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.load.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.load.Location = new System.Drawing.Point(190, 87);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(108, 41);
            this.load.TabIndex = 38;
            this.load.Text = "LOAD";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 256);
            this.dataGridView1.TabIndex = 39;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Save.Location = new System.Drawing.Point(389, 397);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 41);
            this.Save.TabIndex = 40;
            this.Save.Text = "SAVE";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SSNL
            // 
            this.SSNL.AutoSize = true;
            this.SSNL.Location = new System.Drawing.Point(231, 9);
            this.SSNL.Name = "SSNL";
            this.SSNL.Size = new System.Drawing.Size(26, 13);
            this.SSNL.TabIndex = 42;
            this.SSNL.Text = "SSN";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Back.Location = new System.Drawing.Point(256, 397);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 41);
            this.Back.TabIndex = 43;
            this.Back.Text = "<- Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DependentT
            // 
            this.DependentT.Location = new System.Drawing.Point(190, 42);
            this.DependentT.Name = "DependentT";
            this.DependentT.Size = new System.Drawing.Size(108, 20);
            this.DependentT.TabIndex = 41;
            // 
            // ManageDependent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SSNL);
            this.Controls.Add(this.DependentT);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.load);
            this.Name = "ManageDependent";
            this.Text = "ManageDependent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageDependent_FormClosing);
            this.Load += new System.EventHandler(this.ManageDependent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label SSNL;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox DependentT;
    }
}