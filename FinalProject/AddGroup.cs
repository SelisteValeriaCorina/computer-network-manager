using FinalProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddGroup : Form
    {
        private List<Group> gList;
        private List<Right> rList;
        public AddGroup(List<Group> groupsList,List<Right> rightsList)
        {
            InitializeComponent();
            gList = groupsList;
            rList = rightsList;

            displayGroups();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (ValidateInput())
            //{
                Group newgroup = new Group(tbGroupName.Text, tbAgeRestriction.Text, tbDescription.Text,tbRight.Text);
                gList.Add(newgroup);
            
                displayGroups();

                tbDescription.Clear();
                tbGroupName.Clear();
                tbAgeRestriction.Clear();
                tbRight.Clear();
            //}
        }

        //private Boolean ValidateInput()
        //{
        //    bool valid = true;
        //    string groupName = tbGroupName.Text.Trim();
        //    string groupdescription = tbDescription.Text.Trim();
        //    String agerestriction = tbAgeRestriction.Text.Trim();

        //    if (string.IsNullOrEmpty(groupName))
        //    {
        //        errorroviderName.SetError(tbGroupName, "The field is empty!");
        //        valid = false;
        //    }
            

        //    return valid;
        //}


        private void displayGroups()
        {
            listGroup.Items.Clear();
            foreach(Group g in gList)
            {
                ListViewItem item = new ListViewItem(g.Name);
                item.SubItems.Add(g.AgeRestricted.ToString());
                item.SubItems.Add(g.Description);
                item.SubItems.Add(g.right.RightName);

                item.Tag = g;
                listGroup.Items.Add(item);
                
            }
        }

        private void tbGroupName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty( tbGroupName.Text.Trim()))
            {
                errorroviderName.SetError(tbGroupName, "The field is empty!");
                e.Cancel = true;
            }
        }

        private void tbGroupName_Validated(object sender, EventArgs e)
        {
            errorroviderName.SetError(tbGroupName,null);
        }

        private void tbAgeRestriction_Validating(object sender, CancelEventArgs e)
        {
            if (Int32.Parse(tbAgeRestriction.Text.Trim()) < 18)
            {
                providerAge.SetError(tbAgeRestriction, "The restriction age must be at least above 18 years!");
                e.Cancel = true;
            }

        }

        private void tbAgeRestriction_Validated(object sender, EventArgs e)
        {
            providerAge.SetError(tbAgeRestriction,null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listGroup.SelectedItems.Count==0)
            {
                MessageBox.Show("Chose a group!");
            }
            else
            {
                Group egroup = listGroup.SelectedItems[0].Tag as Group;
                gList.Remove(egroup);

                tbGroupName.Clear();
                tbAgeRestriction.Clear();
                tbDescription.Clear();
                tbRight.Clear();

                displayGroups();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {  //{
            //    if(listGroup.SelectedItems.Count==0)
            //    {
            //        MessageBox.Show("Choose a group!");
            //    }
            //    else
            //    {
            //        if (ValidateInput())
            //        {
            //            Group samegroup = listGroup.SelectedItems[0].Tag as Group;
            //            samegroup.name = tbGroupName.Text;
            //            samegroup.Restriction = tbAgeRestriction.Text;
            //            samegroup.description = tbDescription.Text;


            //            tbGroupName.Clear();
            //            tbDescription.Clear();
            //            tbAgeRestriction.Clear();

            //            displayGroups();
            //        }
            //    }
            if(listGroup.SelectedItems.Count!=0)
            {
                Group selected = listGroup.SelectedItems[0].Tag as Group;
                EditGroup editgroup = new EditGroup(selected);
                editgroup.ShowDialog();
                displayGroups();
            }

        }

        private void listGroup_MouseClick(object sender, MouseEventArgs e)
        {
            Group egroup = listGroup.SelectedItems[0].Tag as Group;
            tbGroupName.Text = egroup.Name;
            tbAgeRestriction.Text = egroup.AgeRestricted;// Restriction;
            tbDescription.Text = egroup.Description;// .description;
            tbRight.Text = egroup.right.RightName;
        }
    }
}
