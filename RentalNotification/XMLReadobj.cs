using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalNotification
{
    class XMLReadobj
    {
        public string KindMedia;
        public string MediaName;
        public DateTime Period;

        
        public XMLReadobj()
        {
            //引数なしのコンストラクタ
        }

        //初期化用コンストラクタ
        public XMLReadobj(string pKindMedia, string pMediaName, string pPeriod)
        {
            try
            {
                KindMedia = pKindMedia;
                MediaName = pMediaName;
                Period = DateTime.Parse(pPeriod);
            }
            catch (FormatException)
            {
                MessageBox.Show("日付ではありません。");
            }            
        }
    }
}
