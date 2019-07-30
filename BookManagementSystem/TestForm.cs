using BookManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class TestForm : Form
    {
        Form form;
        public TestForm(Form _form)
        {
            form = _form;
            InitializeComponent();
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainForm = Session.form;
            mainForm.Close();
        }
    }
}
