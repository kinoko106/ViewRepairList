using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewRepairList.CatalogFilter;
using Grabacr07.KanColleWrapper.Models;
//using Grabacr07.KanColleViewer.Models;
//using Grabacr07.KanColleViewer.Models.Settings;
using Grabacr07.KanColleWrapper;

namespace ViewRepairList.EquipCatalog
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
            var uitems = KanColleClient.Current.Homeport.Itemyard.UseItems.ToList();
			var devMaterials = KanColleClient.Current.Homeport.Materials.DevelopmentMaterials;
			var fleets = KanColleClient.Current.Homeport.Organization.Fleets.ToList();
			var ships = KanColleClient.Current.Homeport.Organization.Ships.Values.ToList();
			//var slotitems = KanColleClient.Current.Master.Itemyard.UseItems.ToList();
			this.EquipScrewFilter = new EquipScrewFilter(this.Update);
			this.DevelopCostFilter = new DevelopCostFilter(this.Update, devMaterials);
			this.SecondShipFilter = new SecondShipFilter(this.Update,fleets,ships);

		}

		public void Update()
        {

        }
    }
}
