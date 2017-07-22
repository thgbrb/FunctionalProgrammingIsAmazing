namespace QueryScoreBoard.Presentation
{
    partial class frmSqlAnalyzer
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
            this.openFileDialogSql = new System.Windows.Forms.OpenFileDialog();
            this.btnAnalyzer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialogSql
            // 
            this.openFileDialogSql.Filter = "*.sql|(*.sql)";
            // 
            // btnAnalyzer
            // 
            this.btnAnalyzer.Location = new System.Drawing.Point(12, 12);
            this.btnAnalyzer.Name = "btnAnalyzer";
            this.btnAnalyzer.Size = new System.Drawing.Size(422, 23);
            this.btnAnalyzer.TabIndex = 0;
            this.btnAnalyzer.Text = "Analisar SQL...";
            this.btnAnalyzer.UseVisualStyleBackColor = true;
            this.btnAnalyzer.Click += new System.EventHandler(this.btnAnalyzer_Click);
            // 
            // frmSqlAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 48);
            this.Controls.Add(this.btnAnalyzer);
            this.MaximizeBox = false;
            this.Name = "frmSqlAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Analyzer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogSql;
        private System.Windows.Forms.Button btnAnalyzer;
    }
}

