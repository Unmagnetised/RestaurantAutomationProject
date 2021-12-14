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
    public partial class Form2 : System.Windows.Forms.Form
    {
        public static Form2 Form2Instance;
        public string[] MenuList = {"Cay", "Kola", "Ekmek" };
        Masa TableClickedObject = new Masa();

        public Form2()
        {
            Form2Instance = this;
            //initial Values
            TableClickedObject.TableID = 0;
            TableClickedObject.Orders = "";
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //newButton.Text = "Created Button";
            //newButton.Location = new Point(70, 70);
            //newButton.Size = new Size(50, 100);

            for (int i = 1; i <= Form1.Form1Instance.numberOfTables; i++)
            {

                Button newBtn = new Button();
                newBtn.Text = "Table" + " " + i.ToString();
                newBtn.Name = i.ToString();
                newBtn.Size = new Size(100, 50);
                newBtn.Click += new EventHandler(this.table_clicked);
          
                
                flowLayoutPanel1.Controls.Add(newBtn);
            }
        }

        //SELECT KULLANILMASI GEREKLIYMIS CLICK DEGIL SELECTLE ILGILI ARASTIRMA YAPILACAK.

        //create user defined function
        void table_clicked(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            
            //Get the button clicked
            Button btn = sender as Button;
            if (TableClickedObject.TableID != Convert.ToInt32(btn.Name))
            {
                Masa TableClickedObject = new Masa();
            }
            TableClickedObject.TableID = Convert.ToInt32(btn.Name);

            MessageBox.Show("Table" + " " + TableClickedObject.TableID + "Selected");
            foreach (string menuitem in MenuList)
            {
                listBox1.Items.Add(menuitem);
            }
            listBox2.Items.Add(TableClickedObject.Orders);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string selected = Convert.ToString(listBox1.SelectedItem);
            TableClickedObject.Orders = TableClickedObject.Orders + selected;
            listBox2.Items.Clear();
            listBox2.Items.Add(TableClickedObject.Orders);
        }
    }
}
