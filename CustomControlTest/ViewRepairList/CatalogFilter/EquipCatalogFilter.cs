using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grabacr07.KanColleWrapper;
using Grabacr07.KanColleWrapper.Models;
using Livet;

namespace ViewRepairList.CatalogFilter
{
    public abstract class EquipCatalogFilter : NotificationObject
    {
        private readonly Action action;

        public abstract bool Predicate(SlotItem item);

        protected EquipCatalogFilter(Action updateAction)
        {
            this.action = updateAction;
        }

        protected void Update()
        {
            this.action?.Invoke();
        }
    }

    #region ネジのフィルタ 消費が1つのみor全部
    //KanColleClient.Current.Homeport.Itemyard.UserItems
    class EquipScrewFilter : EquipCatalogFilter
    {

        #region All 変更通知
        bool _All;
        public bool All
        {
            get { return _All; }
            set
            {
                if (_All != value)
                {
                    _All = value;
                    RaisePropertyChanged();
                    Update();
                }
            }
        }

        #endregion

        #region One 変更通知
        bool _One;
        public bool One
        {
            get { return _One; }
            set
            {
                if (_One != value)
                {
                    _One = value;
                    RaisePropertyChanged();
                    Update();
                }
            }
        }

        #endregion

        public EquipScrewFilter(Action updateAction/*,List<SlotItem> sitem*/) : base(updateAction)
        {
            _All = true;
        }

        //
        public override bool Predicate(SlotItem item)
        {
            //引数のslotitem からIDを取得
            //itemからIDの一致する装備を取得して、さらにJsonファイル記載の消費個数を受け取り判定
            //var id = _SlotItem.FirstOrDefault(x => x.Name == item.Name);

            int num = 0;//ネジの消費数(予定)

            if (_All) return true;
            if (_One && num == 1) return true;
            return false;
        }
    }
    #endregion

    #region 消費装備のフィルタ 消費装備の有無
    class EquipUsedNumFilter : EquipCatalogFilter
    {
        //消費アイテム情報 やっぱいらなくね？
        //private UseItem _UserItem;

        #region Used 変更通知
        bool _Used;
        public bool All
        {
            get { return _Used; }
            set
            {
                if (_Used != value)
                {
                    _Used = value;
                    RaisePropertyChanged();
                    Update();
                }
            }
        }

        #endregion

        #region WithOut 変更通知
        bool _WithOut;
        public bool One
        {
            get { return _WithOut; }
            set
            {
                if (_WithOut != value)
                {
                    _WithOut = value;
                    RaisePropertyChanged();
                    Update();
                }
            }
        }

        #endregion

        public EquipUsedNumFilter(Action updateAction/*, UseItem uitem*/) : base(updateAction)
        {
            //_UserItem = uitem;
            _Used = true;
        }

        //
        public override bool Predicate(SlotItem item)
        {
            //Jsonの中身捜査、itemのIDから消費装備の有無を調べる

            if (_Used) return true;
            if (_WithOut) return true;
            return false;
        }
    }
    #endregion

    #region 開発資材のフィルタ 所有数以下のみかどうか
    class DevelopCostFilter : EquipCatalogFilter
    {
		private int _devMaterials;
        #region Less変更通知
        bool _Less;
        public bool Less
        {
            get { return _Less; }
            set
            {
                if (_Less != value)
                {
                    _Less = value;
                    RaisePropertyChanged();
                    Update();
                }
            }
        }

        #endregion

        public DevelopCostFilter(Action updateAction, int devMaterials) : base(updateAction)
        {
            _Less = true;
			_devMaterials = devMaterials;
		}

        //
        public override bool Predicate(SlotItem item)
        {
			//Jsonからitemの消費資材数を取得

			int devCost = 1;

			//消費資材数が現在所持数より多い装備は排除
            if (_Less && devCost >= _devMaterials) return false;
            return false;
        }
    }
    #endregion

    #region 2番艦の制限 遠征中は除外 持ってない艦娘も除外
    class SecondShipFilter : EquipCatalogFilter
    {
		private List<KeyValuePair<int, Fleet>> _fleets;
		private List<Ship> _ships;
		private List<Ship> lostShips;//持ってるけどいない艦娘

		#region Expedition変更通知
		bool _Expedition;

        public bool Expedition
        {
            get { return _Expedition; }
            set
            {
                if (_Expedition != value)
                {
                    _Expedition = value;
                    RaisePropertyChanged();
                    Update();
                }
            }
        }
        #endregion
		
        #region Belong変更通知
        bool _Belong;

        public bool Belong
        {
            get { return _Belong; }
            set
            {
                if (_Belong != value)
                {
                    _Belong = value;
                    RaisePropertyChanged();
                    Update();
                }
            }
        }
        #endregion

        public SecondShipFilter(Action updateAction,
			List<KeyValuePair<int,Fleet>> fleets, 
			List<Ship> ships) : base(updateAction)
        {
            _Expedition = true;
            _Belong = true;
			_fleets = fleets;
			_ships = ships;
		}

        public override bool Predicate(SlotItem item)
        {
			//Jsonから持ってきたEquipリストと照らし合わせて、itemを回収可能な艦娘を取得する(1～複数)
			//ShipInfo.Id なら艦娘を一意に特定可能
			var AssistShips = new List<string> { "翔鶴改二甲", "瑞鶴改二甲", "Warspite改", "山風", "鬼怒改二" };//改修可能な艦娘たち(名前) Jsonから得られたやつ

			List<Ship> doAssistShip = new List<Ship>();
			//艦隊の編成状況と状態を取得
			//今すぐ編成できない人たち

			//所属艦に限定しないとき
			if (_Belong)
			{
				//遠征中の艦娘除外チェックがtrueなら
				if (_Expedition)
				{
					foreach (var f in _fleets)
					{
						if (f.Value.State.Situation == FleetSituation.Expedition) //遠征中
						{
							lostShips.AddRange(f.Value.Ships.ToList());
						}
					}
				}

				foreach (var s in AssistShips)
				{
					//もってるor遠征中でない艦娘たち
					var ship = _ships?.FirstOrDefault(x => x.Info.Name == s);
					var lship = lostShips?.FirstOrDefault(x => x.Info.Name == s);
					//今すぐ来れる艦娘だけ抽出
					if (ship != null && lship == null) doAssistShip.Add(ship);
				}
			}else
			{
				doAssistShip = _ships;
			}

			//引数のslotitem からIDを取得
			//sitemからIDの一致する装備を取得して、さらにJsonファイル記載の消費個数を受け取り判定
			//var id = _SlotItem.Where(x => x.Id == item.Id).Select(x => x.Id).ToList()
			//var s = _ships.FirstOrDefault(x => x.Info.Name == )

			if (doAssistShip != null) return true;
			return false;
        }
    }
    #endregion

}
