using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Threading;
using Livet;
using Grabacr07.KanColleWrapper;
using Grabacr07.KanColleWrapper.Models;

namespace ViewRepairList
{
    /// <summary>
    /// repairListWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class repairListWindow : Window
    {
		//ウィンドウそのものもViewModel
		//ウィンドウ内の各コントロール１つ１つもVewModel
		//複数のコントロールをまとめた何某もViewModelで管理するっぽい

		//List<Equip> json = new List<Equip>();
		//int cnt = 0;
		EquipCatalog.EquipCatalogViewModel equipCatalogViewModel;

		public repairListWindow()
        {
			InitializeComponent();

			equipCatalogViewModel = new EquipCatalog.EquipCatalogViewModel();

			//Json読み取り また今度
			//var json = File.ReadAllText("RepairList.json");
			//var dec = JsonConvert.DeserializeObject<Equip>(json);

			//var _fleets = KanColleClient.Current.Homeport.Organization.Fleets.ToList();
			//var _ships = KanColleClient.Current.Homeport.Organization.Ships.Values.ToList();
			//List<Ship> lostShips = new List<Ship>();//持ってるけどいない艦娘
			//List<Ship> doAssistShip = new List<Ship>();//結局改修できる艦娘たち
			////ShipInfo.Id なら艦娘を一意に特定可能
			//var AssistShips = new List<string> { "翔鶴改二", "瑞鶴改二", "Warspite改","山風","鬼怒改二" };//回収可能な艦娘たち(名前) Jsonから得られたやつ

			////艦隊の編成状況と状態を取得
			////2艦隊にいて今すぐ編成できない人たち
			//if (_fleets[1].Value.State.Situation == FleetSituation.Combined || //連合艦隊を編成中
			//	_fleets[1].Value.State.Situation == FleetSituation.Expedition)//艦隊は遠征中
			//{
			//	lostShips.AddRange(_fleets[1].Value.Ships.ToList());
			//}
			//if (_fleets[2].Value.State.Situation == FleetSituation.Expedition)//艦隊は遠征中
			//{
			//	lostShips.AddRange(_fleets[2].Value.Ships.ToList());
			//}
			//if (_fleets[3].Value.State.Situation == FleetSituation.Expedition)//艦隊は遠征中
			//{
			//	lostShips.AddRange(_fleets[3].Value.Ships.ToList());
			//}

			//foreach (var s in AssistShips)
			//{
			//	//もってるor遠征中でない艦娘たち
			//	var ship = _ships.FirstOrDefault(x => x.Info.Name == s);
			//	var lship = lostShips.FirstOrDefault(x => x.Info.Name == s);
			//	//今すぐ来れる艦娘だけ抽出
			//	if (ship != null && lship == null) doAssistShip.Add(ship);
			//}
			//    Loaded += (s, e) => 
			//    {
			//        json = JsonConvert.DeserializeObject<List<Equip>>(File.ReadAllText(
			//            "C:\\Users\\daichi\\Source\\Repos\\ViewRepairList\\CustomControlTest\\ViewRepairList\\RepairList.json"
			//            ).ToString());

			//        var equipCheckBoxes = EquipCheckBox.Children.OfType<CheckBox>();
			//        foreach(var c in equipCheckBoxes)
			//        {
			//            c.IsChecked = true;
			//        }
			//        var weekCheckBoxes = WeekOfDays.Children.OfType<CheckBox>();
			//        foreach (var c in weekCheckBoxes)
			//        {
			//            c.IsChecked = true;
			//        }
			//        AllWepones.IsChecked = true;
			//        Alldays.IsChecked = true;
			//    };
		}

        //表示装備リスト作成
    }
}
