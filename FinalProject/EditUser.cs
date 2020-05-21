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
    public partial class EditUser : Form
    {
        User _user;

        public EditUser(User user)
        {
            InitializeComponent();
            _user = user;
            tbFirstNameEdit.Text = user.FirstName;
            tbLastNameEdit.Text = user.LastName;
            tbAgeEdit.Text = user.Age.ToString();
           // tbGroupEdit.Text = user.group.name;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _user.FirstName = tbFirstNameEdit.Text;
            _user.LastName = tbLastNameEdit.Text;
            _user.Age =Int32.Parse(tbAgeEdit.Text);
           // _user.group.name = tbGroupEdit.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
