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
    //要:消費アイテム情報
    //KanColleClient.Current.Homeport.Itemyard.UserItems
    class EquipScrewFilter : EquipCatalogFilter
    {
        private List<UseItem> _UserItem;

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

        public EquipScrewFilter(Action updateAction,List<UseItem> uitem) : base(updateAction)
        {
            _UserItem = uitem;
            _All = true;
        }

        //
        public override bool Predicate(SlotItem item)
        {
            //引数のslotitem からIDを取得
            //uitemからIDの一致する装備を取得して、個数を受け取る
            var num = _UserItem.Where(x => x.Id == item.Id).Select(x => x.Count).ToList();

            if (_All) return true;
            if (_One && num[0] == 1) return true;
            return false;
        }
    }
    #endregion

    #region 消費装備のフィルタ 消費装備の有無
    class EquipUsedNumFilter : EquipCatalogFilter
    {
        private UseItem _UserItem;

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

        public EquipUsedNumFilter(Action updateAction, UseItem uitem) : base(updateAction)
        {
            _UserItem = uitem;
            _Used = true;
        }

        //
        public override bool Predicate(SlotItem item)
        {
            if (_Used) return true;
            if (_WithOut) return true;
            return false;
        }
    }
    #endregion

    #region 開発資材のフィルタ 所有数以下のみかどうか
    class DevelopCostFilter : EquipCatalogFilter
    {
        private UseItem _UserItem;

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

        public DevelopCostFilter(Action updateAction, UseItem uitem) : base(updateAction)
        {
            _UserItem = uitem;
            _Less = true;
        }

        //
        public override bool Predicate(SlotItem item)
        {
            if (_Less) return true;
            return false;
        }
    }
    #endregion

    #region 2番艦の制限 遠征中は除外 持ってない艦娘も除外
    class SecondShipFilter : EquipCatalogFilter
    {
        private UseItem _UserItem;

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


        public SecondShipFilter(Action updateAction, UseItem uitem) : base(updateAction)
        {
            _UserItem = uitem;
            _Expedition = true;
            _Belong = true;
        }

        public override bool Predicate(SlotItem item)
        {
            if (_Expedition /*&& 遠征中であるか */) return true;
            if (_Belong /* && 艦隊にいるかいないか */) return true;
            return false;
        }
    }
    #endregion

}
