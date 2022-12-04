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
    public partial class Usestate : UserControl
    {
        public Usestate()
        {
            InitializeComponent();
        }
        public States SelectedState {
            get
            {
                return (States)cmb.SelectedItem;
            }
            }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Usestate_Load(object sender, EventArgs e)
        {
            List<States> list = new List<States>();
            list.Add(new States() { ID = 1, Name = "REEM" });
            list.Add(new States() { ID = 2, Name = "FARAH" });
            list.Add(new States() { ID = 3, Name = "HUSSAIN" });
            list.Add(new States() { ID = 4, Name = "AHMAD" });
            cmb.DataSource= list;
            cmb.ValueMember = "ID";
            cmb.DisplayMember = "Name";
        }
    }
}
