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
    public partial class NotifycationForm : Form
    {
        string fileName;
        string username;
        string today;

        string regist;
        string mediatype;
        string title;
        string period;

        string ListItem;
        string MediaTitle;
        string MediaPeriod;
        
        DeleteXML Deletexml = new DeleteXML();

        public NotifycationForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            username = Environment.UserName;
            fileName = @"C:\Users\" + username + @"\Documents\RentalNotification"; ;
            today = DateTime.Today.AddDays(1).ToString("yyyy/MM/dd");
            label1.Text = "返却するものがあります確認してください。";
        }
        internal void ReadXML()
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

                    if (DateTime.Parse(XmlNodePeriod[cnode].InnerText) <= DateTime.Parse(today))
                    {
                        regist = XmlNodeRegistDay[cnode].InnerText;
                        mediatype = XmlNodeMediaType[cnode].InnerText;
                        title = XmlNodeTitle[cnode].InnerText;
                        period = XmlNodePeriod[cnode].InnerText;
                        string DisplayText;
                        DisplayText = mediatype + " , " + title + " , " + period;
                        MediaPeriod = period;
                        listBox1.Items.Add(DisplayText);
                    }
                }
                Show();
            }
            catch (FileNotFoundException)
            {
                XmlTextWriter SaveXML = new XmlTextWriter(fileName + @"\test.xml", null);
                SaveXML.Flush();
                SaveXML.Close();
                SaveXML.Dispose();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
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
                Show();
                button2.Enabled = false;
            }
            catch (FileNotFoundException)
            {
                XmlTextWriter SaveXML = new XmlTextWriter(fileName + @"\test.xml", null);
                SaveXML.Flush();
                SaveXML.Close();
                SaveXML.Dispose();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
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

        //返却物確認
        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmationForm Confirm = new ConfirmationForm();
            Confirm.AllReadXML(); 
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
                }
            }
        }
    }
}
