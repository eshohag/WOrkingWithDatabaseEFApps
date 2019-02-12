using CustomClassLibrary;
using System;
using System.Windows.Forms;
using WOrkingWithDatabaseEFApps.BAL;

namespace WOrkingWithDatabaseEFApps.UI
{
    public partial class ExtensionMethodForm : Form
    {
        public ExtensionMethodForm()
        {
            InitializeComponent();
        }

        private void ExtensionMethodForm_Load(object sender, EventArgs e)
        {
            PrintSomeValue aPrintSomeValue = new PrintSomeValue();
            label1.Text = aPrintSomeValue.Print();
            label2.Text = aPrintSomeValue.PrintByRiseUp();
            label3.Text = aPrintSomeValue.ExtensionMethod();

        }
    }
}
