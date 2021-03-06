﻿using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleWrapper;
using Grabacr07.KanColleWrapper.Models.Raw;
using Grabacr07.KanColleWrapper.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewRepairList
{
    //消費装備クラス
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

    //改修装備クラス
    public class Equip
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

        public Equip()
        {
            DevelopCost = new int[3, 2];
            ScrewCost = new int[3, 2];
            EquipCost = new eqpcs[3];
        }
    }
}