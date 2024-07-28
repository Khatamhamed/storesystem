using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_store
{ 
    public partial class Pharmacy2 : Form
    {


        public Pharmacy2()
        {
            InitializeComponent();
        }

      
       public void cloneListView(ListView FromLV, ListView ToLV)
        {
            foreach(ListViewItem item in FromLV.Items)
            {
                ListViewItem cloneditems = (ListViewItem)item.Clone();

                ToLV.Items.Add(cloneditems);
            }
        }
        

        private void AddBN_Click(object sender, EventArgs e)
        {

            ListViewItem newitem = new ListViewItem(NameTB.Text);
            newitem.SubItems.Add(StorageTB.Text);
            newitem.SubItems.Add(QuantityNum.Text);
            newitem.SubItems.Add(PriceTB.Text);
            listView1.Items.Add(newitem);


            //Add items and fill delete , update and find listview

            listView2.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();


            cloneListView(listView1, listView2);
            cloneListView(listView1, listView3);
            cloneListView(listView1, listView4);



            //clear data to add new data

            NameTB.Clear();
            StorageTB.Clear();
            QuantityNum.Value = 0;
            PriceTB.Clear();

            NameTB.Focus();

            MessageBox.Show("Medicine Added Successfuly", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }


        private void Pharmacy2_Load(object sender, EventArgs e)
        {
            //Add columns to listview

            listView1.Columns.Add("Medicine Name", 120);
            listView1.Columns.Add("Storage Place", 120);
            listView1.Columns.Add("Quantity", 120);
            listView1.Columns.Add("Price", 120);

            listView2.Columns.Add("Medicine Name", 120);
            listView2.Columns.Add("Storage Place", 120);
            listView2.Columns.Add("Quantity", 120);
            listView2.Columns.Add("Price", 120);

            listView3.Columns.Add("Medicine Name", 120);
            listView3.Columns.Add("Storage Place", 120);
            listView3.Columns.Add("Quantity", 120);
            listView3.Columns.Add("Price", 120);

            listView4.Columns.Add("Medicine Name", 120);
            listView4.Columns.Add("Storage Place", 120);
            listView4.Columns.Add("Quantity", 120);
            listView4.Columns.Add("Price", 120);


        }
       

        private void listView2_Click(object sender, EventArgs e)
        {
          if (listView2.SelectedItems.Count>0)
            {
                NameTB.Text = listView2.SelectedItems[0].SubItems[0].Text;
               StorageTB.Text = listView2.SelectedItems[0].SubItems[1].Text;
               QuantityNum.Text = listView2.SelectedItems[0].SubItems[2].Text;
                PriceTB.Text = listView2.SelectedItems[0].SubItems[3].Text;

            }
        }
      
        private void UpdateBN_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                 listView2.SelectedItems[0].SubItems[0].Text= NameTB2.Text;
                  listView2.SelectedItems[0].SubItems[1].Text= StorageTB2.Text;
                 listView2.SelectedItems[0].SubItems[2].Text = QuantityNum2.Text;
                 listView2.SelectedItems[0].SubItems[3].Text=PriceTB2.Text;

            }

            //Update All listviews

            listView1.Items.Clear();
            listView3.Items.Clear();
            listView4.Items.Clear();


            cloneListView(listView2, listView1);
            cloneListView(listView2, listView3);
            cloneListView(listView2, listView4);



            MessageBox.Show("Medicine is Updated", "Success", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

            
        }

        private void DeleteBN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure That You Want To Delete This Medicine?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)


            {
                listView3.Items.Remove(listView3.SelectedItems[0]);

                //Update All listviews
                listView1.Items.Clear();
                listView2.Items.Clear();
                listView4.Items.Clear();

                cloneListView(listView3, listView1);
                cloneListView(listView3, listView2);
                cloneListView(listView3, listView4);

                MessageBox.Show("Medicine is deleted", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else 
                return;


           

        }

        private void SearchItem(ListView listV, string searchtxt)
        {

            foreach (ListViewItem item in listV.Items)
            {
                if (item.Text.Equals(searchtxt, StringComparison.OrdinalIgnoreCase))
                {

                    listV.SelectedItems.Clear();
                    item.Selected = true;
                    item.EnsureVisible();
                    listV.Focus();

                    break;


                }
               
            }
            if(listV.SelectedItems.Count>0)
            {
                return;
            }
            else
            {
                MessageBox.Show("item not found");
            }

        }
       
    
        private void FindBN_Click(object sender, EventArgs e)
        {

            SearchItem(listView4, FindTB.Text.ToString());
              
        }

        private void SearchDBN_Click(object sender, EventArgs e)
        {
            SearchItem(listView3, DeleteTB.Text.ToString());
        }
        private void SearchBN_Click(object sender, EventArgs e)
        {
            SearchItem(listView2, updateTB.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newform = new Pharmacy1();
            newform.Show();
            this.Close();
           
        }
    }
}
