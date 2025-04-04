using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamzNegari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnlock_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                try
                {
                    string userName = Environment.UserName;
                    DirectorySecurity ds = Directory.GetAccessControl(path);
                    FileSystemAccessRule accessRule = new FileSystemAccessRule(userName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(accessRule);
                    Directory.SetAccessControl(path, ds);
                    MessageBox.Show("پوشه قفل شد");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK) ;
            {
                string path = folderBrowserDialog1.SelectedPath;
                groupBox1.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //groupBox1.Visible = false;
        }

        private void BtnUnlock_Click(object sender, EventArgs e)
        {
            string Password = text1.Text;
            if (Password == @"Passw@rd" && !string.IsNullOrEmpty(Password))
            {
                string path = folderBrowserDialog2.SelectedPath;
                try
                {
                    string userName = Environment.UserName;
                    DirectorySecurity ds = Directory.GetAccessControl(path);
                    FileSystemAccessRule accessRule = new FileSystemAccessRule(userName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.RemoveAccessRule(accessRule);
                    Directory.SetAccessControl(path, ds);
                    MessageBox.Show("پوشه باز شد");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("رمز اشتباه است");
            }
        }

        private void checkedListBoxHide_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (checkedListBoxHide.Checked)
            //{
            //    text1.UseSystemPasswordChar=true;
            //}
            ////else
            ////{
            ////    text1.UseSystemPasswordChar = false;
            ////}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }




        //if (checkBoxX1.Checked)
        //{
        //    text1.UseSystemPasswordChar = false;
        //}

        //else 
        //{
        //    text1.UseSystemPasswordChar = true;
        //}
    }
}














