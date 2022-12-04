using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_User_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFetState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("state ID={0} Name={1}",usestate1.SelectedState.ID, usestate1.SelectedState.Name,"Message",MessageBoxButtons.OK,MessageBoxButtons.OK));
        }
    }
}
