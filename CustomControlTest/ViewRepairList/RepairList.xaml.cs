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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Grabacr07.KanColleViewer.Controls;
using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleWrapper;
using Grabacr07.KanColleWrapper.Models.Raw;
using Grabacr07.KanColleWrapper.Models;

namespace ViewRepairList
{
    /// <summary>
    /// RepairList.xaml の相互作用ロジック
    /// </summary>
    public partial class RepairList : UserControl
    {
        public RepairList()
        {
            InitializeComponent();

            //アイコンを探しています・・・
            AppIcon icn = new AppIcon();
            SlotItemIcon icons = new SlotItemIcon();
            double d = icons.ActualHeight;

            Plugin p = new Plugin();
            p.GetAppPath();

            string name = p.GetKanmusuName(0);
            int id = p.GetKanmusuId(0);
            string pluginPath = p.startupPath + "\\Plugin\\";

            DataContext = new
            {
                text1 = d,
                Name = name,
                ID = id
            };

            //StackPanelの入れ子で表を表現？
            //横軸:Equipクラスメンバの数 または表示したい行の数
            //縦軸:装備数 List<Equip>のLength

            StackPanel r = this.rootStackPanel;

            StackPanel sp = new StackPanel();
            sp.Name = "StackPanel1";
            sp.Orientation = Orientation.Horizontal;
            sp.Width = 100;
            sp.Height = 30;

            Border borderline = new Border();
            borderline.BorderBrush = Brushes.Black;
            borderline.Padding = new Thickness(5, 5, 5, 5);
            borderline.BorderThickness = new Thickness(5, 5, 5, 5);
            sp.Children.Add(borderline);

            sp.Visibility = Visibility.Visible;

            r.Children.Add(sp);
        }
    }
}
