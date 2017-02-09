using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipJsonMaker
{
    public class eqpcs
    {
        public int key { get; set; }
        public string name { get; set; }
        public int num { get; set; }
        public eqpcs(int key, string name, int num)
        {
            this.key = key;
            this.name = name;
            this.num = num;
        }
    }

    public class EquipJson
    {
        public int groupId { get; set; }
        public string Name { get; set; }
        public int Fuel { get; set; }
        public int Ammo { get; set; }
        public int Steel { get; set; }
        public int Baux { get; set; }
        public int[,] DevelopCost { get; set; }
        public int[,] ScrewCost { get; set; }
        public eqpcs[] EquipCost { get; set; }
        public Dictionary<string, int> Assist { get; set; }

        public EquipJson()
        {
            DevelopCost = new int[3, 2];
            ScrewCost = new int[3, 2];
            EquipCost = new eqpcs[3];
        }
    }
}
