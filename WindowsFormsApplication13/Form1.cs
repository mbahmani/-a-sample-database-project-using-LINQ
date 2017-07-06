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
    public partial class Form1:Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydb1DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.mydb1DataSet.Table1);
            var db = new LINQDataContext();
            

            gvtable1.DataSource = db.Table1s;
        }

        private void btsave_Click(object sender, EventArgs e)
          
        {
            var db = new LINQDataContext();
        
           db.pSave(Convert.ToInt32(txrow.Text), txname.Text, txfamily.Text);
            gvtable1.DataSource = db.Table1s;
            
        }

        private void gvtable1_DoubleClick(object sender, EventArgs e)
        {
            if (gvtable1.RowCount > 0)
            {
                var f = new frEdit();

                f.txrow.Text = gvtable1.CurrentRow.Cells["row"].Value.ToString();
                f.txname.Text = gvtable1.CurrentRow.Cells["Name"].Value.ToString();
                f.txfamily.Text = gvtable1.CurrentRow.Cells["Family"].Value.ToString();
                f.ShowDialog();
                var db = new LINQDataContext();
               gvtable1.DataSource = db.Table1s; //Refresh Grid After Edit
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (gvtable1.RowCount <= 0) return;
            if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
   
            {
                var db = new LINQDataContext();
                db.pDelete(Convert.ToInt32(gvtable1.CurrentRow.Cells["Row"].Value));
                gvtable1.DataSource = db.Table1s; //refresh grid after update
            }
        }

        private void txfamilysearch_TextChanged(object sender, EventArgs e)
        {
            var db = new LINQDataContext();
             
            if (txfamilysearch.Text == "")
                gvtable1.DataSource = db.Table1s; //Load All Records to Grid
            else
                gvtable1.DataSource = db.Table1s.Where(c => c.family.Substring(0,
                txfamilysearch.Text.Length) == txfamilysearch.Text).Select(c => c);
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btcount_Click(object sender, EventArgs e)
        {
            var db = new LINQDataContext();
            
            int count = db.Table1s.Where(c => c.family == c.name).Count();
            txcount.Text = count.ToString();
            txcount.Text = db.Table1s.Count().ToString();
            txshart.Text = db.Table1s.Where(c => c.name == "reza").Count().ToString();
            //object mx = db.Table1s.Select(c => c.Mark).Max();
            //var q = db.Table1s.Where(c => c.row == 1).Select(c => c).First();
            //gvClass.DataSource = db.Table1s.Where(c => c.Mark < 10).Select(c => c).OrderBy(c => c.Family);
            //gvClass.DataSource = db.Table1s.Select(c => c).OrderByDescending(c => c.Family);
            //var q = db.Table1s.Select(c => c).OrderByDescending(c => c.row).Take(3);
            //cbLesson.DataSource = db.tClasses.Select(c => c.Lesson).Distinct();
            //if (db.tLogins.Where(c => c.Password == txPassword.Text).Count() == 0)
            //MessageBox.Show("Invalid password!");
        }

        private void btshowname_Click(object sender, EventArgs e)
        {
            var db = new LINQDataContext();
            cballname.DataSource = db.Table1s.Select(c => c.family);


            
        }



    }
}
