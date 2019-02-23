using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalNotification
{
    public partial class RentalSettingForm : Form
    {
        string KindofMedia;         //レンタルしたものの種類
        string RentalMediaName;     //レンタルしたものの名前
        string RentalPeriod;        //レンタル期間
        SaveClass Save = new SaveClass();

        public RentalSettingForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Save.ReadXML();
        }

        //レンタルしたものの種類を書き込む
        private void DVDAndBluray_CheckedChanged(object sender, EventArgs e)
        {
            KindofMedia = "DVD・Blu-ray";
        }

        private void CDs_CheckedChanged(object sender, EventArgs e)
        {
            KindofMedia = "CD";
        }

        private void Manga_CheckedChanged(object sender, EventArgs e)
        {
            KindofMedia = "マンガ";
        }

        //レンタルするものの名前
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RentalMediaName = textBox1.Text;
        }
        
        //レンタルする期間
        private void Days7_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            RentalPeriod = "7";
        }

        private void Days3_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            RentalPeriod = "3";
        }

        private void Days1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            RentalPeriod = "1";
        }

        private void Days30_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            RentalPeriod = "30";
        }
        
        private void OtherDays_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            RentalPeriod = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Equals(null)) || (textBox1.Text == ""))
            {
                MessageBox.Show("作品名を記入してください。");
            }
            else if (RentalPeriod == null)
            {
                MessageBox.Show("レンタル日数を選択してください。");
            }
            else
            {
                Save.SaveToFile(KindofMedia, RentalMediaName, RentalPeriod);
                textBox1.Clear();
            }
            
        }

        private void RentalSettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Save.Save();
            ConfirmationForm Confirm = new ConfirmationForm();
            Confirm.AllReadXML();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Days1.Checked = false;
            Days3.Checked = false;
            Days7.Checked = false;
            Days30.Checked = false;
            OtherDays.Checked = false;
            textBox2.Clear();
            textBox2.Enabled = false;
            textBox1.Clear();
        }
    }
}
