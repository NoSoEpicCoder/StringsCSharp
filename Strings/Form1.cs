using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strings {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            string stringVar = textBox1.Text;
            textBox1.Text = stringVar.ToUpper();
        }

        private void Button2_Click(object sender, EventArgs e) {
            string stringTrim = textBox2.Text;
            stringTrim = stringTrim.Trim();
            int stringLength = stringTrim.Length;
        }

        private void hyphenTrim() {
            string stringTrim = "someText---";
            if (stringTrim.Contains("-")) {
                char[] trimChars = { '-' };
                stringTrim = stringTrim.TrimEnd(trimChars);
            }
        }

        private void Button3_Click(object sender, EventArgs e) {
            string stringEmail = textBox3.Text;
            int result = stringEmail.IndexOf("@");
            if(result == -1) {
                MessageBox.Show("Invalid email addess");
            } else {
                MessageBox.Show("@ found position " + result.ToString());
            }
        }

        private void checkWebsite() {
            string address = "https://www.site.ca";
            string checkAddress = "http://www.site.ca/home";
            int start = 0;
            int numChars = 10;
            int result = address.IndexOf(checkAddress, start, numChars);

            if(result != -1) {
                MessageBox.Show("Address okay");
            } else {
                MessageBox.Show("Invalid address");
            }
        }
    }
}
