using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace FishData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Сделал Open текстовых данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = ofd.FileName;
                    string fileText = System.IO.File.ReadAllText(filename);
                    var q = fileText.Split(' ');
                    txtData.Text = $"{q[0]} {q[1]}";
                    txtTemp.Text = q[2];
                }
                catch
                {
                    MessageBox.Show("невозможно открыть файл");
                }
            }
        }

        /// <summary>
        /// Попытался сделать кнопку проверки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
/*            int min = Convert.ToInt32(txtMinT.Text);
            txtResult.Text = txtTemp.Text.Split(',');*/
    
        }

        /// <summary>
        /// Сделал кнопку Clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtData.Clear();
            txtFish.Clear();
            txtMaxT.Clear();
            txtMaxTime.Clear();
            txtMinT.Clear();
            txtMinTime.Clear();
            txtTemp.Clear();
            txtResult.Clear();
        }

        /// <summary>
        /// Ограничил ввод данных в TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMaxT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtMaxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void txtMinTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void txtFish_KeyPress(object sender, KeyPressEventArgs e)
        {     
            if (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void txtMinT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != 8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ':' && e.KeyChar != 8 && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Сделал Save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files (.txt)|.txt|All files (.)|.";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filename = sfd.FileName;
                    File.WriteAllText(filename, $"{txtResult}");
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить файл");
                }
            }
        }
    }
}
