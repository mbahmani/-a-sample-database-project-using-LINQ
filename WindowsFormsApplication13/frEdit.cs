using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class frEdit : Form
    {
        public frEdit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btupdate_Click(object sender, EventArgs e)
        {
            var db = new LINQDataContext();
            db.Pedit(Convert.ToInt32(txrow.Text), txname.Text, txfamily.Text);

            Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frEdit_Load(object sender, EventArgs e)
        {

        }
        
    }
}
