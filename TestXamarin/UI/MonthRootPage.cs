using Xamarin.Forms;
using System;


namespace TestXamarin
{
    public partial class MonthRootPage : ContentPage
    {

        Button editMonthButton;
        Picker yearPicker;
        Picker monthPicker;

        public MonthRootPage()
        {
            var button = new Button { Text = "press me" };
            button.Clicked += OnEditMonthButtonClicked;
            Title = "Month";

            Content = new StackLayout
            {
                Children =
                {
                    new BoxView
                    {
                        Color = Color.Blue,
                        HeightRequest = 100f,
                        VerticalOptions = LayoutOptions.Center
                    },
                    button
                }

            };
        }

        async void OnEditMonthButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MonthEditPage());
        }
    }
}
