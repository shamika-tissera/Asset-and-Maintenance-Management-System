using Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets;
using Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.Inventory;

namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing
{
    public partial class settingsParent : Form
    {
        private int winCount = 0;

        private int Heater = 0;
        private int Network = 0;
        private int Sanitation = 0;
        private int Printer = 0;
        private int Lift = 0;
        private int Extinguisher = 0;
        private int Computer = 0;
        private int Plumbing = 0;
        private int Phone = 0;
        private int Sink = 0;
        private int Lighting = 0;
        private int Product = 0;

        private DataTable childForms;
        private addItem_assetCategory assetCategory;
        private Form choice;
        bool isRedirected;
        private List<Form> items;
        ToolStripItem[] stripItems;

        Dashboard.MainDashboard inst;
        private add_item item;
        public settingsParent()
        {
            InitializeComponent();
            items = new List<Form>();
            childForms = new DataTable();
            childForms.Columns.Add("Form Name", typeof(string));
            childForms.Columns.Add("Form Object", typeof(Form));
            assetCategory = new addItem_assetCategory(this);
            FormHeater.setSettingsParentInstance(this);
            

            //System.Timers.Timer delay = new System.Timers.Timer();
            //delay.Interval = 1000;
            //delay.Elapsed += setTime;
            //delay.Start();

        }
        private void setTime(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                foreach (Form form in this.MdiChildren)
                {
                    bool found = false;
                    int index = -1;
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (form == items[i])
                        {
                            found = true;
                            index = i;
                        }
                    }
                    if (!found)
                    {
                        items.RemoveAt(index);
                    }
                }
            }));
        }
        public void clickedAddItemOK()
        {
            inst.clickedAssetAddItemOK();

            //perform database entry here
            //if database entry successful, message will display
            MessageBox.Show("Added record successfully!");
        }
        //private void updateItemList()
        //{
        //    foreach(Form form in this.MdiChildren)
        //    {
        //        bool found = false;
        //        int index = -1;
        //        for(int i = 0; i < items.Count; i++)
        //        {
        //            if (form == items[i])
        //            {
        //                found = true;
        //                index = i;
        //            }
        //        }
        //        if (!found)
        //        {
        //            items.RemoveAt(index);
        //        }
        //    }
        //}
        public settingsParent(bool isRedirected, Dashboard.MainDashboard inst) : this()
        {
            this.isRedirected = isRedirected;
            this.inst = inst;
            this.Show();
            new addItem_assetCategory(this).Show();
        }
        public void clickedAddItemCancel()
        {
            item.Hide();
        }
        public void setDashboardInstance(Dashboard.MainDashboard inst)
        {
            this.inst = inst;
        }
        private void assetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new addItem_assetCategory(this).Show();

        }
        public void displayAssetAdditionForm(String formType)
        {
            winCount++;
            switch (formType)
            {
                case "Heater":
                    choice = new add_item(formType);
                    Heater++;
                    if (Heater == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Heater - 1) + ")";
                    }
                    break;
                case "Network Device":
                    choice = new add_item(formType);
                    Network++;
                    if (Network == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Network - 1) + ")";
                    }
                    break;
                case "Sanitation Device":
                    choice = new add_item(formType);
                    Sanitation++;
                    if (Sanitation == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Sanitation - 1) + ")";
                    }
                    break;
                case "Printer/Scanner":
                    choice = new add_item("PrinterScanner");
                    Printer++;
                    if (Printer == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Printer - 1) + ")";
                    }
                    break;
                case "Lift":
                    choice = new add_item(formType);
                    Lift++;
                    if (Lift == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Lift - 1) + ")";
                    }
                    break;
                case "Fire Extinguisher":
                    choice = new add_item(formType);
                    Extinguisher++;
                    if (Extinguisher == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Extinguisher - 1) + ")";
                    }
                    break;
                case "Computer":
                    choice = new add_item(formType);
                    Computer++;
                    if (Computer == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Computer - 1) + ")";
                    }
                    break;
                case "Plumbing Device":
                    choice = new add_item(formType);
                    Plumbing++;
                    if (Plumbing == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Plumbing - 1) + ")";
                    }
                    break;
                case "Phone":
                    choice = new add_item(formType);
                    Phone++;
                    if (Phone == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Phone - 1) + ")";
                    }
                    break;
                case "Sink":
                    choice = new add_item(formType);
                    Sink++;
                    if (Sink == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Sink - 1) + ")";
                    }
                    break;
                case "Lighting":
                    choice = new add_item(formType);
                    Lighting++;
                    if (Lighting == 1)
                    {
                        choice.Text = "Add" + formType;
                    }
                    else
                    {
                        choice.Text = "Add" + formType + "(" + (Lighting - 1) + ")";
                    }
                    break;
            }
            
            choice.MdiParent = this;
            choice.Show();
            choice.BringToFront();
            panel1.SendToBack();
            tblLayout_Options.Visible = false;
            populateWindowMenu(choice.Text, choice);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult response =  MessageBox.Show("You are about to exit. Any unsaved changes will be lost.\nAre you sure you want to exit?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (response == DialogResult.Yes)
            {
                this.Dispose();
            }            
        }

        private void heaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Heater");
        }

        private void networkDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Network Device");
        }

        private void sanitationDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Sanitation Device");
        }

        private void printerScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Printer/Scanner");
        }

        private void liftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Lift");
        }

        private void fireExtinguisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Fire Extinguisher");
        }

        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Computer");
        }

        private void plumbingDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Plumbing Device");
        }

        private void phoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Phone");
        }

        private void sinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Sink");
        }

        private void lightingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayAssetAdditionForm("Lighting");
        }
        private void populateWindowMenu(string formName, Form formObject)
        {
            this.items.Add(formObject);
            

            stripItems = new ToolStripItem[items.Count];
            for (int i = 0; i < items.Count; i++)
            {
                stripItems[i] = new ToolStripMenuItem();
                stripItems[i].Name = items[i].Text;
                //stripItems[i].Tag = "specialDataHere";
                stripItems[i].Text = items[i].Text;


                clickedItem = items[i].Text;
                items[i].Click += new EventHandler(MenuItemClickHandler);
            }

            for(int i = winCount - 1; i < winCount; i++)
            {

                windowsToolStripMenuItem.DropDownItems.Add(stripItems[i]);
            }
            
        }
        private String clickedItem;
        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            int i, index = -1;
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            for(i = 0; i < winCount; i++)
            {
                if(items[i].Text.Equals(clickedItem))
                {
                    index = i;
                }
            }
            items[index].BringToFront();
        }
        private void settingsParent_Load(object sender, EventArgs e)
        {

        }
        private void child_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uc_addProduct_form addItem = new uc_addProduct_form();
            Product++;
            addItem.MdiParent = this;
            tblLayout_Options.Visible = false;
            if (Product == 1)
            {
                addItem.Text = "Add New Product";
            }
            else
            {
                addItem.Text = "Add New Product" + "(" + (Product - 1) + ")";
            }
            panel1.SendToBack();
            addItem.Show();
            winCount++;
            populateWindowMenu(addItem.Text, addItem);
        }

        private void btn_backlog_Click(object sender, EventArgs e)
        {
            AddInventoryItemType inventory = new AddInventoryItemType();
            inventory.MdiParent = this;
            inventory.Show();
            inventory.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productToolStripMenuItem_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assetToolStripMenuItem_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}