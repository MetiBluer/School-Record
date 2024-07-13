namespace Final_Exam_project
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
            this.lblIns = new System.Windows.Forms.Label();
            this.cbOption = new System.Windows.Forms.ComboBox();
            this.dgvDisplay = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSubj = new System.Windows.Forms.Button();
            this.btnTeach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIns
            // 
            this.lblIns.AutoSize = true;
            this.lblIns.Location = new System.Drawing.Point(31, 90);
            this.lblIns.Name = "lblIns";
            this.lblIns.Size = new System.Drawing.Size(14, 16);
            this.lblIns.TabIndex = 0;
            this.lblIns.Text = "_";
            // 
            // cbOption
            // 
            this.cbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOption.FormattingEnabled = true;
            this.cbOption.Location = new System.Drawing.Point(34, 24);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(121, 24);
            this.cbOption.TabIndex = 1;
            this.cbOption.SelectedIndexChanged += new System.EventHandler(this.cbOption_SelectedIndexChanged);
            // 
            // dgvDisplay
            // 
            this.dgvDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplay.Location = new System.Drawing.Point(186, 24);
            this.dgvDisplay.Name = "dgvDisplay";
            this.dgvDisplay.ReadOnly = true;
            this.dgvDisplay.RowHeadersWidth = 51;
            this.dgvDisplay.RowTemplate.Height = 24;
            this.dgvDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplay.Size = new System.Drawing.Size(461, 300);
            this.dgvDisplay.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(34, 119);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(34, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSubj
            // 
            this.btnSubj.Location = new System.Drawing.Point(34, 301);
            this.btnSubj.Name = "btnSubj";
            this.btnSubj.Size = new System.Drawing.Size(110, 23);
            this.btnSubj.TabIndex = 5;
            this.btnSubj.Text = "Subject Form";
            this.btnSubj.UseVisualStyleBackColor = true;
            this.btnSubj.Click += new System.EventHandler(this.btnSubj_Click);
            // 
            // btnTeach
            // 
            this.btnTeach.Location = new System.Drawing.Point(34, 330);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(110, 23);
            this.btnTeach.TabIndex = 6;
            this.btnTeach.Text = "Teacher Form";
            this.btnTeach.UseVisualStyleBackColor = true;
            this.btnTeach.Click += new System.EventHandler(this.btnTeach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 389);
            this.Controls.Add(this.btnTeach);
            this.Controls.Add(this.btnSubj);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvDisplay);
            this.Controls.Add(this.cbOption);
            this.Controls.Add(this.lblIns);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIns;
        private System.Windows.Forms.ComboBox cbOption;
        private System.Windows.Forms.DataGridView dgvDisplay;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSubj;
        private System.Windows.Forms.Button btnTeach;
    }
}

