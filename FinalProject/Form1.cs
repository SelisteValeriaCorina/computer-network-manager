using FinalProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public List<Group> groupsList = new List<Group>();
        public List<User> utilizatori = new List<User>();
        public List<Right> rightsList = new List<Right>();
        UserContext context;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            AddGroup addgroup = new AddGroup(groupsList, rightsList);
            addgroup.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser(groupsList, utilizatori);
            adduser.ShowDialog();
            DisplayEntities();
            DisplayEntities();

            DisplayEntities();

            context.utilizatori.Add(utilizatori.Last());
            context.SaveChanges();
        }


        private void DisplayEntities()
        {
            listUsers.Items.Clear();

            foreach(User user in utilizatori)
            {
                ListViewItem item = new ListViewItem(user.FirstName);
                item.SubItems.Add(user.LastName);
                item.SubItems.Add(user.Age.ToString());
                item.SubItems.Add(user.group.Name);
                item.SubItems.Add(user.group.right.RightName);
                item.SubItems.Add(user.group.Description);

                item.Tag = user;
                listUsers.Items.Add(item);
            }
        }

        private void serializationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream s = File.Create("serialized.bin"))
            {
                formatter.Serialize(s, utilizatori);
            }
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream s = File.OpenRead("serialized.bin"))
            {
                utilizatori= (List<User>)formatter.Deserialize(s);
                DisplayEntities();
            }


        }

        private void btnText_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save CSV as";
            dialog.Filter = "CSV file |*csv.";

            if(dialog.ShowDialog()==DialogResult.OK)
            {

                using (StreamWriter writer = new StreamWriter(dialog.FileName))
                {
                    writer.WriteLine("LastName,FristName,Age,Group,Rights");
                    foreach(User u in utilizatori)
                    {
                        writer.WriteLine($"{u.FirstName},{u.LastName},{u.Age},{u.group.Name},{u.group.right.RightName},{u.group.Description}");

                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e) { 
            context = new UserContext();
            context.Database.EnsureCreated();
            context.utilizatori.Load();
            this.userBindingSource.DataSource = context.utilizatori.Local.ToBindingList();
            context.Database.Migrate();
        }
    }
}
