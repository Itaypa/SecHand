using System;
using SecHand.Entities;
using Xamarin.Forms;
namespace SecHand.ConcreteEntities
{
    public class PostViewCell : IListItem
    {        
        public string Header { get; set; }
        public string Details { get; set; }
        public ImageSource Img { get; set; }
    }
}
