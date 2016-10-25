using Grabacr07.KanColleViewer.Composition;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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
using ViewRepairList;

namespace CustomControlTest
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    [Export(typeof(IPlugin))]
    [ExportMetadata("Title", "")]
    [ExportMetadata("Description", "")]
    [ExportMetadata("Version", "")]
    [ExportMetadata("Author", "")]
    [ExportMetadata("Guid", "F9EE8BF4-51A9-4A21-AF56-7174C8EF76B2")]
    public partial class MainWindow : Window, IPlugin
    {
        public new string Name => "Rapair List";
        public object View => new RepairList();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
