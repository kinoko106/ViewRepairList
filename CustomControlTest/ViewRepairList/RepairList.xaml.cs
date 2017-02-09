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

            //var slotItemMaster = KanColleClient.Current.Master.SlotItems;
            //var info = slotItemMaster[0];

            //var useItemMaster = KanColleClient.Current.Master.UseItems;
            //var use = useItemMaster[0];

            //var shipMaster = KanColleClient.Current.Master.Ships;
            //var ship = shipMaster[0];

            //var eqType = KanColleClient.Current.Master.SlotItemEquipTypes;
            //var eq = eqType[0];

            //var itemYard = KanColleClient.Current.Homeport.Itemyard;
            //var useitem = itemYard.UseItems;
            //var uitem = useitem[0];

            //var slotItems = itemYard.SlotItems.ToList();
            //var sitem = slotItems[0];

            //DataContext = new { text1 = sitem.Value.Info.Name };
            //DataContext = new { Icon1 = info.IconType };

            //Plugin p = new Plugin();
            //p.GetAppPath();

            //string name = p.GetKanmusuName(0);
            //int id = p.GetKanmusuId(0);
            //string pluginPath = p.startupPath + "\\Plugin\\";

            //DataContext = new
            //{
            //    Name = name,
            //};

            //StackPanelの入れ子で表を表現？
            //横軸:Equipクラスメンバの数 または表示したい行の数
            //縦軸:装備数 List<Equip>のLength

            //StackPanel r = this.rootStackPanel;

            //StackPanel sp = new StackPanel();
            //sp.Name = "StackPanel1";
            //sp.Orientation = Orientation.Horizontal;
            //sp.Width = 100;
            //sp.Height = 30;

            //Border borderline = new Border();
            //borderline.BorderBrush = Brushes.Black;
            //borderline.Padding = new Thickness(5, 5, 5, 5);
            //borderline.BorderThickness = new Thickness(5, 5, 5, 5);
            //sp.Children.Add(borderline);

            //sp.Visibility = Visibility.Visible;
            //r.Children.Add(sp);
        }

        private void open_repairList(object sender, RoutedEventArgs e)
        {
            repairListWindow win = new repairListWindow();
            win.Show();
        }
    }
}
