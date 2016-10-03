using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandelMaker
{
    public partial class CandelMaker : Form
    {
        private Maker make = new Maker();

        public CandelMaker()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbSelectFileRead.Text = openFileDialog1.FileName;
                make.SetFileRead(openFileDialog1.FileName);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbSelectFileSave.Text = folderBrowserDialog1.SelectedPath;
                make.SetFileSave(folderBrowserDialog1.SelectedPath);
            }
        }

        private void cBCandelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbNameCandel.Text = cBCandelType.Text;
            make.SetCandelType(cBCandelType.Text);
        }

        private void tbSettings_TextChanged(object sender, EventArgs e)
        {
            tbValueCandel.Text = tbSettings.Text;
            make.SetCandelValue(tbSettings.Text);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            make.MakeCandel((Button) sender);
        }

        private void tbSettings_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbValueCandel.Text == "" || tbValueCandel.Text.Contains(","))
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            else if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }
    }
}
