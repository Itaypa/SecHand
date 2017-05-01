using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;
namespace SecHand
{
	public class MyMatchesPage : ContentPage
	{
		private ListView MyMatchesList{ get; set; }
		public List<ImageCell> MatchCollection { get; set; }

		public MyMatchesPage()
		{
			Title = "My Matches";
			MatchCollection = new List<ImageCell>(); 
            MyMatchesList = new ListView{ RowHeight = 80 } ;
			
            MatchCollection.Add(new ImageCell { ImageSource = ImageSource.FromFile("house.jpeg"),  Text = "The Metzadim", Detail = "Some more info"});
            MatchCollection.Add(new ImageCell { ImageSource = ImageSource.FromFile("house.jpeg"), Text = "Mazda", Detail="year 2013, 200,000 km" });
		
            MyMatchesList.ItemsSource = MatchCollection;
			
            DataTemplate template = new DataTemplate(typeof(ImageCell));
            template.SetBinding(TextCell.TextProperty, "Text");
            template.SetBinding(TextCell.DetailProperty, "Detail");
			template.SetBinding(ImageCell.ImageSourceProperty, "ImageSource");
			
            MyMatchesList.ItemTemplate = template;

			Content = MyMatchesList;
		}
	}
}
