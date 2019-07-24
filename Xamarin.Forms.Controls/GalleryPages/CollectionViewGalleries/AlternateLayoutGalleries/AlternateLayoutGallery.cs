using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.Controls.GalleryPages.CollectionViewGalleries.AlternateLayoutGalleries
{
	internal class AlternateLayoutGallery : ContentPage
	{
		public AlternateLayoutGallery()
		{
			var descriptionLabel =
					new Label { Text = "Alternate Layout Galleries", Margin = new Thickness(2, 2, 2, 2) };

			Title = "Alternate Layout Galleries";

			Content = new ScrollView
			{
				Content = new StackLayout
				{
					Children =
					{
						descriptionLabel,
						GalleryBuilder.NavButton("Staggered", () =>
							new StaggeredLayout(), Navigation),
					}
				}
			};
		}
	}
}
