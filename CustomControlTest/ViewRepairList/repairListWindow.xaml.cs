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

namespace ViewRepairList
{
    /// <summary>
    /// repairListWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class repairListWindow : Window
    {

        public repairListWindow()
        {
            InitializeComponent();
        }

        private void EquipType_Checked(object sender, RoutedEventArgs e)
        {
            var s = (CheckBox)sender;
            //コントロール名で絞り込み条件を加算
            //表示リスト更新
        }

        private void EquipType_UnChecked(object sender, RoutedEventArgs e)
        {
            var s = (CheckBox)sender;
            //コントロール名で絞り込み条件を減算
            //表示リスト更新
        }

        private void EquipTypeButton_Clicked(object sender, RoutedEventArgs e)
        {
            var s = (Button)sender;
            //装備種別チェックボックスの選択,一括解除
            var checkBoxes = EquipCheckBox.Children.OfType<CheckBox>().Where(
                    ch => ch.Uid.Contains(s.Uid));
            if (checkBoxes.Where(ch => ch.IsChecked == true).Count() == checkBoxes.Count())
            {
                foreach (var c in checkBoxes)
                {
                    c.IsChecked = false;
                }
            }else
            {
                foreach (var c in checkBoxes)
                {
                    c.IsChecked = true;
                }
            }
            //関連チェックボックス以外のチェックを外す
            var unSelects = EquipCheckBox.Children.OfType<CheckBox>().Where(
                    ch => !ch.Uid.Contains(s.Uid));
            foreach (var b in unSelects)
            {
                b.IsChecked = false;
            }
            //コントロール名で絞り込み条件を減算
            //表示リスト更新
        }

        private void AllCheck(object sender, RoutedEventArgs e)
        {
            //装備と曜日でツリーの深さが違うので一般化できなさそう
            var ch = (CheckBox)sender;
            var parent = (WrapPanel)ch.Parent;
            var checkBoxes = parent.Children.OfType<CheckBox>();

            foreach(var c in checkBoxes)
            {
                string str = c.Name;
            }
        }



        //表示装備リスト作成
        //リストの表示
    }
}
