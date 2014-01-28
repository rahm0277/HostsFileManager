using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostsFileManager
{
    public partial class Form1 : Form
    {
        DataTable hosts;
        DataTable groups;
        SQLiteDatabase db;

        public Form1()
        {
            InitializeComponent();
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new SQLiteDatabase();
            string query = "select GroupID, GroupName from Groups order by GroupName";
            groups = db.GetDataTable(query);
        }

        private void GetEntries(string searchText)
        {
            try
            {
                
                
                //String query = "select ;";
                String query = "select IpAddress, HostName, Hosts.GroupID, GroupName, HostID from Hosts, Groups where Hosts.GroupID = Groups.GroupID and ";
                query += "(GroupName like '%" + searchText + "%' OR GroupName like '%" + searchText + "%');";

                //query += "PREP_TIME \"Prep Time\", COOKING_TIME \"Cooking Time\"";
                //query += "from RECIPE;";
                hosts = db.GetDataTable(query);
                // The results can be directly applied to a DataGridView control
                hostsGrid.DataSource = hosts;
                hostsGrid.Columns[4].Visible = false;
                hostsGrid.Columns[5].Visible = false;
                /*
                // Or looped through for some other reason
                foreach (DataRow r in recipe.Rows)
                {
                    MessageBox.Show(r["Name"].ToString());
                    MessageBox.Show(r["Description"].ToString());
                    MessageBox.Show(r["Prep Time"].ToString());
                    MessageBox.Show(r["Cooking Time"].ToString());
                }
	
                */
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                this.Close();
            }

        }

        private void UpdateEntries()
        {


        }

        private void hostsGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //hostsGrid.Rows[e.RowIndex].Cells[3]. = groups;
            DataGridViewComboBoxColumn combo = (DataGridViewComboBoxColumn)hostsGrid.Rows[e.RowIndex].Cells["GroupField"].OwningColumn;
            
            combo.DataSource = groups;
            combo.ValueMember = "GroupID";
            combo.DisplayMember = "GroupName";

            //DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)hostsGrid.Rows[e.RowIndex].Cells["GroupField"];
            //hostsGrid.Rows[e.RowIndex].Cells["GroupField"].Value = hosts.Rows[e.RowIndex]["GroupID"].ToString();
            //comboBoxCell.Items[e.RowIndex]
            //comboBoxCell.ValueType = typeof(String);
            //comboBoxCell.Value = hosts.Rows[e.RowIndex]["GroupName"].ToString();
            
            //hostsGrid.CurrentRow.Cells["GroupField"]
        
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            GetEntries(searchText.Text);
       
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void hostsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void ChooseGroups(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in hostsGrid.Rows)
                {
                    DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell)row.Cells["GroupField"];
                    if (row.Cells["GroupID"].Value != null)
                    {
                        comboBoxCell.Value = row.Cells["GroupName"].Value.ToString();
                    }

                }
            }
            catch(Exception crap)
            {
                string mess = crap.Message;
            }
            
        }

        private void DoNothing(object sender, DataGridViewDataErrorEventArgs e)
        {

        }



        private void SaveEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            else
            {

                string ip = hostsGrid.Rows[e.RowIndex].Cells["IP"].Value.ToString();
                string hostname = hostsGrid.Rows[e.RowIndex].Cells["HostName"].Value.ToString();
                string groupName = hostsGrid.Rows[e.RowIndex].Cells["GroupField"].Value.ToString();
                string hostID = hostsGrid.Rows[e.RowIndex].Cells["HostID"].Value.ToString();
                string groupID = "0";

                if (groupName != "")
                {
                    DataRow result = groups.AsEnumerable().Where(dr => dr.Field<string>("GroupName") == groupName).First();
                    if (result != null)
                    {
                        groupID = ((DataRow)result)["GroupID"].ToString();
                    }
                }

                Dictionary<string, string> fields = new Dictionary<string,string>();
                fields.Add("HostName", hostname);
                fields.Add("GroupID", groupID);
                fields.Add("IpAddress", ip);
                db.Update("Hosts", fields, "HostID = " + hostID);


            }
        }

        private void RemoveRow()
        {
            
        }

        private void R_Click(object sender, EventArgs e)
        {

            if (hostsGrid.Rows.Count > 0)
            {
                if(hostsGrid.SelectedRows.Count > 0)
                {
                    foreach(DataGridViewRow drv in hostsGrid.SelectedRows)
                    {
                        string hostID = drv.Cells["HostID"].Value.ToString();
                        string query = "delete from hosts where hostID = " + hostID;
                        db.ExecuteNonQuery(query);
                    }
                }
                
            }

        }
    }
}
