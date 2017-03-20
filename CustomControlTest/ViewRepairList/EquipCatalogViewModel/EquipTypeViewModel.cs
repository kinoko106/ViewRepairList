using Grabacr07.KanColleWrapper.Models;
using Livet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewRepairList.EquipCatalogViewModel
{
	//チェックボックスにバインド
	class EquipTypeViewModel : ViewModel
	{
		public Action SelectionChangedAction { get; set; }

		#region IsSelected 変更通知プロパティ

		private bool _IsSelected;

		public bool IsSelected
		{
			get { return this._IsSelected; }
			set
			{
				if (this._IsSelected != value)
				{
					this._IsSelected = value;
					this.RaisePropertyChanged();
					if (this.SelectionChangedAction != null) this.SelectionChangedAction();
				}
			}
		}
		#endregion

		//まるでわからんぞ！
		public EquipTypeViewModel(SlotItemType slotItemType)
		{
		}
	}
}
