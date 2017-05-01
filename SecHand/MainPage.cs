using System;
using Xamarin.Forms;

namespace SecHand
{
	public class MainPage : TabbedPage
	{

		public MainPage()
		{
            Children.Add(new MyMatchesPage { Icon = "list.png" });
            Children.Add(new FindMatchPage { Icon = "maginfyingGlass.png"});
		}
	}
}
