using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RentalNotification
{
    class DeleteXML
    {
        string username;
        string fileName;
        List<RetentionData> StoreData = new List<RetentionData>();

        internal DeleteXML()
        {
            username = Environment.UserName;
            fileName = @"C:\Users\" + username + @"\Documents\RentalNotification";
        }

        //条件付き全削除のための読み取り
        internal void AllRemoveXML(string Date)
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
                    string regist = XmlNodeRegistDay[cnode].InnerText;
                    string mediatype = XmlNodeMediaType[cnode].InnerText;
                    string title = XmlNodeTitle[cnode].InnerText;
                    string period = XmlNodePeriod[cnode].InnerText;

                    if (Date != period)
                    {
                        RetentionData SaveData = new RetentionData(regist, mediatype, title, period);
                        StoreData.Add(SaveData);
                    }
                }
                SaveToXML();
                StoreData.Clear();
            }
            catch (FileNotFoundException)
            {
                XmlTextWriter SaveXML = new XmlTextWriter(fileName + @"\test.xml", null);
                SaveXML.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }

        //一つずつ削除
        internal void SelectRemoveXML(string Title, string Date)
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
                    string regist = XmlNodeRegistDay[cnode].InnerText;
                    string mediatype = XmlNodeMediaType[cnode].InnerText;
                    string title = XmlNodeTitle[cnode].InnerText;
                    string period = XmlNodePeriod[cnode].InnerText;

                    if (Title != title)
                    {
                        RetentionData SaveData = new RetentionData(regist, mediatype, title, period);
                        StoreData.Add(SaveData);
                    }
                    
                }
                SaveToXML();
                StoreData.Clear();
            }
            catch (FileNotFoundException)
            {
                XmlTextWriter SaveXML = new XmlTextWriter(fileName + @"\test.xml", null);
                SaveXML.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }

        //削除したものを除きXMLへ保存する。
        private void SaveToXML()
        {
            try
            {
                XmlTextWriter SaveXML = new XmlTextWriter(fileName + @"\test.xml", null);
                SaveXML.Formatting = Formatting.Indented;

                SaveXML.WriteStartDocument();

                SaveXML.WriteStartElement("Item");

                for (int c = 0; c <= StoreData.Count - 1; c++)
                {
                    SaveXML.WriteStartElement("Rental");
                    SaveXML.WriteAttributeString("num", c.ToString());
                    SaveXML.WriteElementString("RegistDay", StoreData[c].getRegistrationDay());
                    SaveXML.WriteElementString("MediaType", StoreData[c].getKindofItem());
                    SaveXML.WriteElementString("Title", StoreData[c].getItemName());
                    SaveXML.WriteElementString("Period", StoreData[c].getRentalPeriod());
                    SaveXML.WriteEndElement();
                }
                SaveXML.WriteEndElement();
                SaveXML.WriteEndDocument();
                SaveXML.Flush();
                SaveXML.Close();
            }
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.ToString());
            }

        }
    }
}
