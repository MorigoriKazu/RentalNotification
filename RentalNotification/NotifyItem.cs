  using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RentalNotification
{
    class NotifyItem
    {
        //プロパティ、通知予定日の設定等
        int NotifyReturnDayBefor = 1;
        string fileName;
        string username;

        //本日保持
        DateTime ToD = DateTime.Today;
        //返却日保持
        DateTime ReD;
        string ReturnDay;


        internal NotifyItem()
        {
            username = Environment.UserName;
            fileName = @"C:\Users\" + username + @"\Documents\RentalNotification";
            ToD = ToD.AddDays(NotifyReturnDayBefor);
        }

        internal void Notify()
        {
            try
            {
                XmlDocument XMLDoc = new XmlDocument();

                XMLDoc.Load(fileName + @"\test.xml");

                XmlNodeList XmlNodeCount = XMLDoc.GetElementsByTagName("Rental");

            for (int cnode = 0; cnode <= XmlNodeCount.Count - 1; cnode++)
            {
                XmlNodeList XmlNodePeriod = XMLDoc.GetElementsByTagName("Period");
                ReturnDay = XmlNodePeriod[cnode].InnerText;
                ReD = DateTime.Parse(ReturnDay);
                if (ToD >= ReD)
                {
                        NotifycationForm Notify = new NotifycationForm();
                        Notify.ReadXML();
                        break;
                }
            }
        }
            catch (FileNotFoundException)
            {

            }
            catch (Exception)
            {
                
            }
        }


    }
}
