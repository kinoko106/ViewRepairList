using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewRepairList
{
    //改修装備クラス
    class Equip
    {
        public Equip()
        {
            DevelopCost = new Dictionary<int, int>();
            ScrewCost = new Dictionary<int, int>();
            EquipCost = new Dictionary<int, int>();
        }
        public string EquipId { get; set; }      //装備ID
        public string Name { get; set; }    //装備名
        public int Fuel { get; set; }       //消費燃料
        public int Ammo { get; set; }       //弾薬
        public int Steel { get; set; }      //鋼材
        public int Baux { get; set; }       //ボーキサイト

        public Dictionary<int, int> DevelopCost { get; set; }
        public Dictionary<int, int> ScrewCost { get; set; }
        public Dictionary<int, int> EquipCost { get; set; }

        public int[] week;//改修可能曜日リスト

    }

    //改修担当艦娘
    class AssistShip
    {
        public string EquipId { get; set; } //改修対象装備ID
        public string shipId { get; set; }  //艦娘ID
        public int[] week;                  //改修可能曜日
    }
}