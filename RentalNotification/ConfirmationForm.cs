using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RentalNotification
{
    public partial class ConfirmationForm : Form
    {
        string fileName;
        string username;
        string today;

        string regist;
        string mediatype;
        string title;
        string period;

        string ListItem;
        string MediaTitle = null;
        string MediaPeriod = null;
        
        DeleteXML Deletexml = new DeleteXML();

        public ConfirmationForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            username = Environment.UserName;
            fileName = @"C:\Users\" + username + @"\Documents\RentalNotification"; ;
            today = DateTime.Today.AddDays(1).ToString("yyyy/MM/dd");
            label1.Text = "レンタルしているもののリストです。";
        }
        
        internal void AllReadXML()
        {
            try
            {
                XmlDocument XMLDoc = new XmlDocument();

                XMLDoc.Load(fileName + @"\test.xml");

                XmlNodeList XmlNodeCount = XMLDoc.GetElementsByTagName("Rental");

                for (int cnode = 0; cnode <= XmlNodeCount.Count - 1; cnode++)
                {
                    XmlNodeList XmlNodeRegistDay = XMLDoc.GetElementsByTagName("RegistDay");
                    XmlNodeList XmlNodeMediaType = XMLDoc.GetElementsByTagName("MediaType");
                    XmlNodeList XmlNodeTitle = XMLDoc.GetElementsByTagName("Title");
                    XmlNodeList XmlNodePeriod = XMLDoc.GetElementsByTagName("Period");
                    regist = XmlNodeRegistDay[cnode].InnerText;
                    mediatype = XmlNodeMediaType[cnode].InnerText;
                    title = XmlNodeTitle[cnode].InnerText;
                    period = XmlNodePeriod[cnode].InnerText;
                    string DisplayText;
                    DisplayText = mediatype + " , " + title + " , " + period;
                    MediaPeriod = period;
                    listBox1.Items.Add(DisplayText);
                    
                }
                if (listBox1.Items.Count == 0)
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                Show();
            }
            //catch (FileNotFoundException)
            //{
            //    XmlTextWriter SaveXML = new XmlTextWriter(fileName + @"\test.xml", null);
            //    SaveXML.Close();
            //}
            catch (Exception)
            {
                SaveClass tempSave = new SaveClass();
                tempSave.Save();
                AllReadXML();
            }
        }

        //リストボックス
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListItem = listBox1.Text;
                string[] TempText = listBox1.Text.Split(',');
                MediaTitle = TempText[1].Trim();
                MediaPeriod = TempText[2].Trim();
            }
            catch(IndexOutOfRangeException)
            {

            }
        }

        //追加レンタル
        private void button1_Click(object sender, EventArgs e)
        {
            RentalSettingForm Setting = new RentalSettingForm();
            Setting.Show();
            Hide();
        }

        //全削除
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult OKCANCEL = MessageBox.Show("すべて返却しましたか？\nもう一度確認して下さい。","確認" ,MessageBoxButtons.OKCancel);

            if(OKCANCEL == DialogResult.OK)
            {
                Deletexml.AllRemoveXML(MediaPeriod);
                listBox1.Items.Clear();
                MediaTitle = null;
                MediaPeriod = null;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            
        }

        //選択削除
        private void button3_Click(object sender, EventArgs e)
        {
            if ((MediaTitle == null) || (MediaTitle == ""))
            {
                MessageBox.Show("返却するものを選択してください。");
            }
            else
            {
                DialogResult OKCANCEL = MessageBox.Show(MediaTitle + "\nを返却しましたか？\nもう一度確認して下さい。", "確認", MessageBoxButtons.OKCancel);

                if (OKCANCEL == DialogResult.OK)
                {
                    Deletexml.SelectRemoveXML(MediaTitle, MediaPeriod);
                    listBox1.Items.Remove(ListItem);
                    MediaTitle = null;
                    MediaPeriod = null;
                    if (listBox1.Items.Count == 0)
                    {
                        button2.Enabled = false;
                        button3.Enabled = false;
                    }
                }
            }
            
        }
    }
}
