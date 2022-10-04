using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MauiAppCenterSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		Analytics.TrackEvent("counter", new Dictionary<string, string> { { "count", count.ToString() } });


		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

