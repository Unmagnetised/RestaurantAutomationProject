using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restoranDeneme2
{
    public partial class Form1 : Form
    {

        public Int32 numberOfTables =0;
        public static Form1 Form1Instance;
        public Form1()
        {
            //Everyone eveywhere in the app show know me as Form1.Form1Instance
            Form1Instance = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberOfTables = Convert.ToInt32(numberOfTableTxt.Text);
            Hide();
            var form2 = new Form2();
            form2.Show();
        }
    }
}
