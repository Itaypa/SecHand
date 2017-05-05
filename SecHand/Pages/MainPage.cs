using System;
using Xamarin.Forms;

namespace SecHand.Pages
{
	public class MainPage : TabbedPage
	{

		public MainPage()
		{
            Children.Add(new MyMatchesPage { Title = "My Matches", Icon = Device.OnPlatform("list.png", null, null) });
            Children.Add(new FindMatchPage { Title = "Search", Icon = Device.OnPlatform("maginfyingGlass.png", null, null)});
		}
	}
}
