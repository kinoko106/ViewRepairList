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
using WpfApplication1.ViewModels;

namespace WpfApplication1
{
	/// <summary>
	/// MainWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class MainWindow : Window
	{
		//public List<TestCheckBoxViewModel> TestCheckBoxes;

		public MainWindow()
		{
			InitializeComponent();

			//TestCheckBoxes.Add(new TestCheckBoxViewModel(false,"name1"));
			//TestCheckBoxes.Add(new TestCheckBoxViewModel(false, "name2"));
			//TestCheckBoxes.Add(new TestCheckBoxViewModel(false, "name3"));
			//TestCheckBoxes.Add(new TestCheckBoxViewModel(false, "name4"));
			//TestCheckBoxes.Add(new TestCheckBoxViewModel(false, "name5"));
		}
	}


}
