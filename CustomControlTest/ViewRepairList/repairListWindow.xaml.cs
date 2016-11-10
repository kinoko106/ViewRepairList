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
            //装備種別チェックボックスの反転

            //コントロール名で絞り込み条件を減算
            //表示リスト更新
        }



        //表示装備リスト作成
        //リストの表示
    }
}
