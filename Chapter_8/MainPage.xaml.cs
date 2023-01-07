using Chapter_8.ClsRenderer;
using Chapter_8.View.p1;

namespace Chapter_8;

public partial class MainPage : ContentPage
{
    CustomBtn b = new CustomBtn();
    public MainPage()
	{
		InitializeComponent();
		
		b.Clicked += async (sender, e) =>
		{
			await Navigation.PushAsync(new Page1());
		};
	}

	
}

