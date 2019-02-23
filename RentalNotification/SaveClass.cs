using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RentalNotification
{
    class SaveClass
    {
        DateTime TodayDate = DateTime.Today;
        string today;
        string username;
        string fileName;
        List<RetentionData> StoreData = new List<RetentionData>();  //RetentionData保持用動的配列

        //コンストラクタ：現在のユーザー名取得、保存先指定、今日の日付取得
        internal SaveClass()
        {
            username = Environment.UserName;
            fileName = @"C:\Users\" + username + @"\Documents\RentalNotification";
            today = (TodayDate.Date).ToString("yyyy/MM/dd");
        }

        //メモリ上にデータを保存する。
        internal void SaveToFile(string MediaKind, string MediaName, string Period)
        {
            try
            {
                Period = CalucPeriodDate(today, Period);
                RetentionData SaveData = new RetentionData(today, MediaKind, MediaName, Period);
                StoreData.Add(SaveData);
            }
            catch (FormatException)
            {
                MessageBox.Show("期間日数を数字で\n入力してください。");
            }
        }
        private string CalucPeriodDate(string toDay, string Period)
        {
            DateTime ToDay = DateTime.Parse(toDay);
            int PeriodDay = int.Parse(Period);
            string rPeriodDate;

            ToDay = ToDay.AddDays(PeriodDay);
            rPeriodDate = (ToDay.Date).ToString("yyyy/MM/dd");

            return rPeriodDate;
        }

        //メモリに保存したデータをXMLファイルへ保存する。include : SaveToXML();
        internal void Save()
        {
            try
            {
                Directory.CreateDirectory(fileName);
                SaveToXML();
                StoreData.Clear();
        }
            catch (IOException)
            {
                SaveToXML();
    }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("フォルダにアクセス許可がありませんでした。");
            }
        }
        private void SaveToXML()
        {
            try
            {
                if (StoreData.Count != 0)
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
                    SaveXML.Dispose();
                    StoreData.Clear();
                }

            }
            catch (IOException ioex)
            {
                MessageBox.Show(ioex.ToString());
            }

        }

        //XMLファイルから読み込み
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
                    string regist = XmlNodeRegistDay[cnode].InnerText;
                    string mediatype = XmlNodeMediaType[cnode].InnerText;
                    string title = XmlNodeTitle[cnode].InnerText;
                    string period = XmlNodePeriod[cnode].InnerText;

                    RetentionData SaveData = new RetentionData(regist, mediatype, title, period);
                    StoreData.Add(SaveData);
                }
            }
            //catch (FileNotFoundException)
            //{
            //    XmlTextWriter SaveXML = new XmlTextWriter(fileName + @"\test.xml", null);
            //    SaveXML.Close();
            //}
            catch (Exception)
            {
                //MessageBox.Show(excep.ToString());
            }
        }
    }
}
 