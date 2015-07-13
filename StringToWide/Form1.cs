using System;
using System.Windows.Forms;

namespace StringToWide {
    public partial class Form1 : Form {
        Transform trans;
        public Form1() {
            InitializeComponent();
            trans = new Transform();
        }

        private void tbInput_TextChanged(object sender, EventArgs e) {
            tbResult.Text = trans.TextTransform(tbInput.Text, cbToWide.Checked, cbToSimplified.Checked);
        }

        private void cbToSimplified_CheckedChanged(object sender, EventArgs e) {
            tbResult.Text = trans.TextTransform(tbInput.Text, cbToWide.Checked, cbToSimplified.Checked);
        
        }

        private void cbToWide_CheckedChanged(object sender, EventArgs e) {
            tbResult.Text = trans.TextTransform(tbInput.Text, cbToWide.Checked, cbToSimplified.Checked);
        }
    }
}
