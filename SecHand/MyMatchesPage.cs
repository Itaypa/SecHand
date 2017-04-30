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
			MyMatchesList = new ListView();
			MatchCollection.Add(new ImageCell { ImageSource = ImageSource.FromFile("house.png"),  Text = "The Metzadim" });
			MatchCollection.Add(new ImageCell { ImageSource = ImageSource.FromFile("car.png"), Text = "Mazda" });
			MyMatchesList.ItemsSource = MatchCollection;
			DataTemplate template = new DataTemplate(typeof(ImageCell));
			template.SetBinding(ImageCell.TextProperty, "Text");
			template.SetBinding(ImageCell.ImageSourceProperty, "ImageSource");
			MyMatchesList.ItemTemplate = template;
			Content = MyMatchesList;
		}

		public class MatchView : ImageCell 
		{
			public MatchView()
			{
			//	ImageSource.SetBinding(Label.IsEnabledProperty, new Binding("ImageSource"));
			//	Text.SetBinding(Label.TextProperty, new Binding("Text"));

			}
		
		}


	}
}
