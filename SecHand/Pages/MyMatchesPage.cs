using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SecHand.ConcreteEntities;

namespace SecHand.Pages
{
	public class MyMatchesPage : ContentPage
	{
		private ListView MyMatchesList{ get; set; }
        public List<PostViewCell> MatchCollection { get; set; }


		public MyMatchesPage()
		{
			Title = "My Matches";
            MatchCollection = new List<PostViewCell>();
            MyMatchesList = new ListView { BackgroundColor = Color.Ivory, RowHeight = 100, Margin = 0 };
			
            MatchCollection.Add(new PostViewCell { Img = ImageSource.FromFile("house.jpeg"),  Header = "The Metzadim", Details = "Some more info"});
            MatchCollection.Add(new PostViewCell { Img = ImageSource.FromFile("house.jpeg"), Header = "Mazda", Details ="year 2013, 200,000 km" });
		
            MyMatchesList.ItemsSource = MatchCollection;
			
            DataTemplate template = new DataTemplate(typeof(ImageCell));
            template.SetBinding(TextCell.TextProperty, "Header");
            template.SetBinding(TextCell.DetailProperty, "Details");
			template.SetBinding(ImageCell.ImageSourceProperty, "Img");
			
            MyMatchesList.ItemTemplate = template;


			Content = MyMatchesList;
		}
	}
}
