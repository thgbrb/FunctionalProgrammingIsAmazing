﻿using System.Windows.Forms;

namespace QueryScoreBoard.Presentation
{
    public partial class frmSqlAnalyzer : Form
    {
        public frmSqlAnalyzer()
        {
            InitializeComponent();
        }

        private void btnAnalyse_Click(object sender, System.EventArgs e)
        {
            if (openFileDialogSql.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
