
namespace LibrarySortApplication
{

    /// <summary>
    /// GABRIEL ROBBERTZE ST10082248
    /// PROG POE PART 1
    /// </summary>
    /// 
    partial class FindCallNumbers
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
            this.Question = new System.Windows.Forms.Label();
            this.cmbLevel1 = new System.Windows.Forms.ComboBox();
            this.cmbLevel2 = new System.Windows.Forms.ComboBox();
            this.cmbLevel3 = new System.Windows.Forms.ComboBox();
            this.btnLvlCheck1 = new System.Windows.Forms.Button();
            this.btnLvlCheck2 = new System.Windows.Forms.Button();
            this.btnLvlCheck3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(89, 88);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(66, 24);
            this.Question.TabIndex = 1;
            this.Question.Text = "label1";
            // 
            // cmbLevel1
            // 
            this.cmbLevel1.FormattingEnabled = true;
            this.cmbLevel1.Location = new System.Drawing.Point(6, 37);
            this.cmbLevel1.Name = "cmbLevel1";
            this.cmbLevel1.Size = new System.Drawing.Size(328, 21);
            this.cmbLevel1.TabIndex = 2;
            // 
            // cmbLevel2
            // 
            this.cmbLevel2.FormattingEnabled = true;
            this.cmbLevel2.Location = new System.Drawing.Point(6, 37);
            this.cmbLevel2.Name = "cmbLevel2";
            this.cmbLevel2.Size = new System.Drawing.Size(328, 21);
            this.cmbLevel2.TabIndex = 3;
            // 
            // cmbLevel3
            // 
            this.cmbLevel3.FormattingEnabled = true;
            this.cmbLevel3.Location = new System.Drawing.Point(6, 37);
            this.cmbLevel3.Name = "cmbLevel3";
            this.cmbLevel3.Size = new System.Drawing.Size(328, 21);
            this.cmbLevel3.TabIndex = 4;
            // 
            // btnLvlCheck1
            // 
            this.btnLvlCheck1.BackColor = System.Drawing.Color.Green;
            this.btnLvlCheck1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLvlCheck1.Location = new System.Drawing.Point(363, 37);
            this.btnLvlCheck1.Name = "btnLvlCheck1";
            this.btnLvlCheck1.Size = new System.Drawing.Size(75, 23);
            this.btnLvlCheck1.TabIndex = 5;
            this.btnLvlCheck1.Text = "SUBMIT";
            this.btnLvlCheck1.UseVisualStyleBackColor = false;
            this.btnLvlCheck1.Click += new System.EventHandler(this.btnLvlCheck1_Click);
            // 
            // btnLvlCheck2
            // 
            this.btnLvlCheck2.BackColor = System.Drawing.Color.Orange;
            this.btnLvlCheck2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLvlCheck2.Location = new System.Drawing.Point(363, 37);
            this.btnLvlCheck2.Name = "btnLvlCheck2";
            this.btnLvlCheck2.Size = new System.Drawing.Size(75, 23);
            this.btnLvlCheck2.TabIndex = 6;
            this.btnLvlCheck2.Text = "SUBMIT";
            this.btnLvlCheck2.UseVisualStyleBackColor = false;
            this.btnLvlCheck2.Click += new System.EventHandler(this.btnLvlCheck2_Click);
            // 
            // btnLvlCheck3
            // 
            this.btnLvlCheck3.BackColor = System.Drawing.Color.Red;
            this.btnLvlCheck3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLvlCheck3.Location = new System.Drawing.Point(363, 37);
            this.btnLvlCheck3.Name = "btnLvlCheck3";
            this.btnLvlCheck3.Size = new System.Drawing.Size(75, 23);
            this.btnLvlCheck3.TabIndex = 7;
            this.btnLvlCheck3.Text = "SUBMIT";
            this.btnLvlCheck3.UseVisualStyleBackColor = false;
            this.btnLvlCheck3.Click += new System.EventHandler(this.btnLvlCheck3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(83, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 224);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cmbLevel1);
            this.tabPage1.Controls.Add(this.btnLvlCheck1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(565, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EASY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SELECT THE OVERALL TOPIC OF THE ABOVE";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbLevel2);
            this.tabPage2.Controls.Add(this.btnLvlCheck2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(565, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MEDIUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SELECT THE SUBTOPIC FOR THE ABOVE";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cmbLevel3);
            this.tabPage3.Controls.Add(this.btnLvlCheck3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(565, 198);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HARD ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SELECT THE CORRELATING CODE FOR THIS BOOK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "QUESTION:";
            // 
            // FindCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(740, 464);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Question);
            this.Name = "FindCallNumbers";
            this.Text = "FindCallNumbers";
            this.Load += new System.EventHandler(this.FindCallNumbers_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.ComboBox cmbLevel1;
        private System.Windows.Forms.ComboBox cmbLevel2;
        private System.Windows.Forms.ComboBox cmbLevel3;
        private System.Windows.Forms.Button btnLvlCheck1;
        private System.Windows.Forms.Button btnLvlCheck2;
        private System.Windows.Forms.Button btnLvlCheck3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}