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

namespace ViewRepairList
{
    /// <summary>
    /// repairListWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class repairListWindow : Window
    {
        //List<Equip> json = new List<Equip>();
        //int cnt = 0;

        //public repairListWindow()
        //{
        //    InitializeComponent();
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
        //}

        //#region Equip checked
        //private void EquipType_Checked(object sender, RoutedEventArgs e)
        //{
        //    var s = (CheckBox)sender;

        //    bool b = s.Focus();
        //    //コントロール名で絞り込み条件を加算
        //    //表示リスト更新
        //}

        //private void EquipType_UnChecked(object sender, RoutedEventArgs e)
        //{
        //    var s = (CheckBox)sender;
        //    //コントロール名で絞り込み条件を減算
        //    //表示リスト更新
        //}

        //private void EquipTypeButton_Clicked(object sender, RoutedEventArgs e)
        //{
        //    var s = (Button)sender;
        //    //関連チェックボックス以外のチェックを外す
        //    AllWepones.IsChecked = false; 
        //    var unSelects = EquipCheckBox.Children.OfType<CheckBox>().Where(
        //            ch => !ch.Uid.Contains(s.Uid));
        //    foreach (var b in unSelects)
        //    {
        //        b.IsChecked = false;
        //    }

        //    //装備種別チェックボックスの選択,一括解除
        //    var checkBoxes = EquipCheckBox.Children.OfType<CheckBox>().Where(
        //            ch => ch.Uid.Contains(s.Uid));

        //    foreach (var c in checkBoxes)
        //    {
        //        c.IsChecked = true;
        //    }

        //    //コントロール名で絞り込み条件を減算
        //    //表示リスト更新
        //}

        //private void EquipType_CheckedAll(object sender, RoutedEventArgs e)
        //{
        //    var checkBoxes = EquipCheckBox.Children.OfType<CheckBox>();

        //    foreach (var c in checkBoxes)
        //    {
        //        c.IsChecked = true;
        //    }
        //}

        //private void EquipType_UnCheckedAll(object sender, RoutedEventArgs e)
        //{
        //    var checkBoxes = EquipCheckBox.Children.OfType<CheckBox>();

        //    foreach (var c in checkBoxes)
        //    {
        //        c.IsChecked = false;
        //    }
        //}
        //#endregion

        //#region weekday checked
        //private void WeekOfDay_Checked(object sender, RoutedEventArgs e)
        //{

        //}

        //private void WeekOfDay_UnChecked(object sender, RoutedEventArgs e)
        //{

        //}

        //private void WeekOfDay_CheckedAll(object sender, RoutedEventArgs e)
        //{
        //    var s = (CheckBox)sender;
        //    var checkBoxes = WeekOfDays.Children.OfType<CheckBox>().Where(ch => ch != s);

        //    foreach (var c in checkBoxes)
        //    {
        //        c.IsChecked = true;
        //    }
        //}

        //private void WeekOfDay_UnCheckedAll(object sender, RoutedEventArgs e)
        //{
        //    var s = (CheckBox)sender;
        //    var checkBoxes = WeekOfDays.Children.OfType<CheckBox>().Where(ch => ch != s);

        //    foreach (var c in checkBoxes)
        //    {
        //        c.IsChecked = false;
        //    }
        //}
        //#endregion

        //表示装備リスト作成
    }
}
