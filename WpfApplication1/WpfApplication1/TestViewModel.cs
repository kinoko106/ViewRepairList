using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livet;

namespace WpfApplication1.ViewModels
{
	public class SampleData
	{
		public int Number { get; set; }
		public string Name { get; set; }
	}

	public class TestCheckBoxViewModel : ViewModel
	{
		public List<SampleData> Samples { get; set; }

		//public TestCheckBoxViewModel() { }
		public TestCheckBoxViewModel()
		{
			this.Samples = new List<SampleData>
			{
				new SampleData { Number = 1, Name = "赤城" },
				new SampleData { Number = 2, Name = "加賀" },
				new SampleData { Number = 3, Name = "蒼龍" },
				new SampleData { Number = 4, Name = "飛龍" },
				new SampleData { Number = 5, Name = "翔鶴" },
				new SampleData { Number = 6, Name = "瑞鶴" },
			};
		}

		/*
		#region DisplayName 変更通知プロパティ

		private string _DisplayName;

		public string DisplayName
		{
			get { return this._DisplayName; }
			set
			{
				if (this._DisplayName != value)
				{
					this._DisplayName = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

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
					//if (this.SelectionChangedAction != null) this.SelectionChangedAction();
				}
			}
		}
		#endregion
		*/
	}
}
