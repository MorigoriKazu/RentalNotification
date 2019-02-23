using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalNotification
{
    /*
    *
    *   XMLデータの格納用クラス
    *
    */
    class RetentionData
    {
        internal string RegistrationDay;
        internal string KindofItem;
        internal string ItemName;
        internal string RentalPeriod;

        public RetentionData()
        {
            //引数なしのコンストラクタ
        }

        public RetentionData(string pRegistrationDay, string pKindofItem, string pItemName, string pRentalPeriod)
        {
            RegistrationDay = pRegistrationDay;
            KindofItem = pKindofItem;
            ItemName = pItemName;
            RentalPeriod = pRentalPeriod;
        }
        //登録日ゲッター
        internal string getRegistrationDay()
        {
            return RegistrationDay;
        }

        //アイテムの種類ゲッター
        internal string getKindofItem()
        {
            return KindofItem;
        }

        //アイテムの名前ゲッター
        internal string getItemName()
        {
            return ItemName;
        }

        //返却日ゲッター
        internal string getRentalPeriod()
        {
            return RentalPeriod;
        }
    }
}
