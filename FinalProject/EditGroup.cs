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
    public partial class EditGroup : Form
    {
        Group g;
        public EditGroup(Group group)
        {

            InitializeComponent();
            g = group;
            tbName.Text = group.Name;
            tbAge.Text = group.AgeRestricted;
            tbDescription.Text = group.Description;
            tbRights.Text = group.right.RightName;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            g.Name = tbName.Text;
            g.AgeRestricted = tbAge.Text;
            g.Description = tbDescription.Text;
            g.right.RightName = tbRights.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
