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
    public partial class AddUser : Form
    {
        private List<Group> gList;
        private List<User> uList;

        public AddUser(List<Group> groupsList,List<User> utilizatori)
        {
            InitializeComponent();
            gList = groupsList;
            uList = utilizatori;
            displayGroups();
            DisplayUsers();
        }

        public void displayGroups()
        {
            listGroup.Items.Clear();
            foreach(Group g in gList)
            {
                ListViewItem item = new ListViewItem(g.Name);
                item.SubItems.Add(g.right.RightName);
                item.Tag = g;
                listGroup.Items.Add(item);
            }
        }


        public void DisplayUsers()
        {
            listUsers.Items.Clear();

            foreach(User user in uList)
            {
                ListViewItem lui = new ListViewItem(user.FirstName);
                //lui.SubItems.Add(user.Firstname);
                lui.SubItems.Add(user.LastName);
                lui.SubItems.Add(user.Age.ToString());
                lui.SubItems.Add(user.group.Name);
                lui.SubItems.Add(user.group.right.RightName);
                lui.Tag = user;
                listUsers.Items.Add(lui);

            }
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(listGroup.SelectedItems.Count==0)
            {
                MessageBox.Show("Choose a group");
            }
            else
            {
                //User eusere = listUsers.SelectedItems[0].Tag as User;
                Group egroup = listGroup.SelectedItems[0].Tag as Group;

                User newuser = new User(tbFirstname.Text,tbLastName.Text,Int32.Parse(tbAge.Text),egroup);
                //newuser.Firstname = tbFirstname.Text;
                //newuser.Lastname = tbLastName.Text;
                //newuser.age =Int32.Parse( tbAge.Text);
                //newuser.group = egroup;

                uList.Add(newuser);


                tbFirstname.Clear();
                tbLastName.Clear();
                tbAge.Clear();

                DisplayUsers();
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if(listUsers.SelectedItems.Count!=0)
            {
                User selected = listUsers.SelectedItems[0].Tag as User;

                EditUser editForm = new EditUser(selected);
                editForm.ShowDialog();

                DisplayUsers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if(listUsers.SelectedItems.Count==0)
            {
                MessageBox.Show("Choose an user! ");
            }
            else
            {
                User euser = listUsers.SelectedItems[0].Tag as User;
                uList.Remove(euser);
                tbFirstname.Clear();
                tbLastName.Clear();
                tbAge.Clear();

                DisplayUsers();
            }

        }
    }
}
