using System;
using System.Windows.Forms;

namespace WOrkingWithDatabaseEFApps.UI
{
    public partial class ProgressbarForm : Form
    {
        public ProgressbarForm()
        {
            InitializeComponent();
        }

        private void ProgressbarForm_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {

            }
            if (result == DialogResult.No)
            {

            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
    }
}