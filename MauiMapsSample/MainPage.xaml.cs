namespace MauiMapsSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin
		{
			Label = "Subscribe to my channel?",
			Location = new Location(50.8514, 5.6910),
		});
	}

	protected async override void OnAppearing()
	{
        await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

    }
}

