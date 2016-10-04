using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleWrapper;
using Grabacr07.KanColleWrapper.Models.Raw;
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
        public void Initialize()
        {

            //KanColleClient.Current.Proxy.api_port.TryParse<kcsapi_port>().Select(x => x.Data.api_material).Subscribe(x => materialSubscribe(x));
        }

        //public string Guid => "id";
        public string Name => "Rapair List";
        public object View => new UserControl1();
    }
}
