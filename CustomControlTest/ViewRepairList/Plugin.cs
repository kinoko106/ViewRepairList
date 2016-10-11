using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleWrapper;
using Grabacr07.KanColleWrapper.Models.Raw;
using Grabacr07.KanColleWrapper.Models;
using Grabacr07.KanColleViewer.Controls;
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
    [Export(typeof(IPlugin))]
    [Export(typeof(ITool))]
    [ExportMetadata("Guid", "5495FE91-D41E-4407-B2C0-4B22ED0B18B6")]
    [ExportMetadata("Title", "ViewRepairList")]
    [ExportMetadata("Description", "改修リストの表示を行うよ")]
    [ExportMetadata("Version", "1.0")]
    [ExportMetadata("Author", "@kinoko")]
    class Plugin : IPlugin, ITool
    {
        public string exepath { get; private set; }
        public string exeFullPath { get; private set; }
        public string startupPath { get; private set; }

        public void Initialize()
        {
        }

        public string GetKanmusuName(int num)
        {
            //var ships = KanColleClient.Current.Master.Ships.Values.ToList();
            //return ships[num].Name;
            return "";
        }

        public int GetKanmusuId(int num)
        {
            //var ships = KanColleClient.Current.Master.Ships.Values.ToList();
            //return ships[num].Id;
            return 0;
        }

        public void GetAppPath()
        {
            exepath = Environment.GetCommandLineArgs()[0];
            exeFullPath = System.IO.Path.GetFullPath(exepath);
            startupPath = System.IO.Path.GetDirectoryName(exeFullPath);
        }

        public string Name => "Rapair List";
        public object View => new RepairList();
    }
}
