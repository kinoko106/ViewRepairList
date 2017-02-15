using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewRepairList.CatalogFilter;
using Grabacr07.KanColleWrapper.Models;
using Grabacr07.KanColleViewer.Models;
using Grabacr07.KanColleViewer.Models.Settings;
using Grabacr07.KanColleWrapper;

namespace ViewRepairList.EquipCatalogViewModel
{
    class EquipCatalogViewModel
    {
        //ソートクラス


        //ウィンドウ設定


        //フィルタ
        private EquipScrewFilter EquipScrewFilter { get; }
        private EquipUsedNumFilter EquipUsedNumFilter { get; }
        private DevelopCostFilter DevelopCostFilter { get; }
        private SecondShipFilter SecondShipFilter { get; }

        public EquipCatalogViewModel()
        {
            var uitems = KanColleClient.Current.Master.UseItems.ToList();
            this.EquipScrewFilter = new EquipScrewFilter(this.Update);
        }

        public void Update()
        {

        }
    }
}
