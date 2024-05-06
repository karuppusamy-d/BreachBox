using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreachBox
{
    public partial class BreachBox : Form
    {
        public BreachBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            String password = password_input.Text;
            bool result = PasswordValidator.checkKey(password);
            if (result) {
                MessageBox.Show("Access Granted: Congratulations, Code Whisperer!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else
            {
                MessageBox.Show("Access Denied: Did You Try ‘Password123’? 🙃", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submit_secure_Click(object sender, EventArgs e)
        {
            String password = password_input.Text;
            bool result = PasswordValidator.secureCheckKey(password);
            if (result)
            {
                MessageBox.Show("Access Granted: Level Up Your Hacker Hat!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Access Denied: Did You Forget to Wear Your Hacker Hat?", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
