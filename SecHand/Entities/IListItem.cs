using System;
using Xamarin.Forms;

namespace SecHand.Entities
{
    public interface IListItem
    {

        String Header { get; set; }

        String Details { get; set; }

        ImageSource Img { get; set; }
    }
}
