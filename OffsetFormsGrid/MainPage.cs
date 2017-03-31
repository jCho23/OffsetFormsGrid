using Xamarin.Forms;

namespace OffsetFormsGrid
{
	public class MainPage : ContentPage
	{
		double screenOffset = 40;

		public MainPage()
		{
			var gridLayout = new Grid
			{
				ColumnDefinitions = new ColumnDefinitionCollection
				{
					new ColumnDefinition{Width = GridLength.Star},
					new ColumnDefinition{Width = GridLength.Star}
				},
				RowDefinitions = new RowDefinitionCollection
				{
					//Offset
					new RowDefinition { Height = screenOffset },

					//first row on right column
					new RowDefinition { Height = (App.ScreenWidth / 2) - screenOffset },
					new RowDefinition { Height = screenOffset },
					//second row on right column
					new RowDefinition { Height = (App.ScreenWidth / 2) - screenOffset },
					new RowDefinition { Height = screenOffset },
					//third row on right column
					new RowDefinition { Height = (App.ScreenWidth / 2) - screenOffset },
					new RowDefinition { Height = screenOffset },
					//fourths row on right column
					new RowDefinition { Height = (App.ScreenWidth / 2) - screenOffset },
					new RowDefinition { Height = screenOffset },
					//fifth row on right column
					new RowDefinition { Height = (App.ScreenWidth / 2) - screenOffset },
					new RowDefinition { Height = screenOffset },
				}
			};

			gridLayout.BackgroundColor = Color.Black;

			//Left column tiles
			gridLayout.Children.Add(new ContentView { BackgroundColor = Color.Blue }, 0, 1, 0, 2);
			gridLayout.Children.Add(new ContentView { BackgroundColor = Color.Orange }, 0, 1, 2, 4);
			gridLayout.Children.Add(new ContentView { BackgroundColor = Color.Green }, 0, 1, 4, 6);
			gridLayout.Children.Add(new ContentView { BackgroundColor = Color.Yellow }, 0, 1, 6, 8);

			//Right column tiles
			gridLayout.Children.Add(new ContentView { BackgroundColor = Color.Purple }, 1, 2, 1, 3);
			gridLayout.Children.Add(new ContentView { BackgroundColor = Color.Gray }, 1, 2, 3, 5);
			gridLayout.Children.Add(new ContentView { BackgroundColor = Color.Olive }, 1, 2, 5, 7);
			gridLayout.Children.Add(new ContentView { BackgroundColor = Color.Aqua }, 1, 2, 7, 9);

			Content = new ScrollView
			{
				Content = gridLayout
			};
		}
	}
}