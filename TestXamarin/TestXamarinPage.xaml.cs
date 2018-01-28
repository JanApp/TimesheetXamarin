using Xamarin.Forms;
using System;

namespace TestXamarin
{
    public partial class TestXamarinPage : TabbedPage {
        public TestXamarinPage()
        {
            InitializeComponent();

            this.Children.Add(new ContentPage
            {
                Title = "Blauw",
                Content = new BoxView
                {
                    Color = Color.Blue,
                    HeightRequest = 100f,
                    VerticalOptions = LayoutOptions.Center
                },
            }
            );

            this.Children.Add(new ContentPage
            {
                Title = "Blue and Red",
                Content = new StackLayout
                {
                    Children = {
                    new BoxView { Color = Color.Blue },
                    new BoxView { Color = Color.Red}
                }
                }
            });

            this.Children.Add(new ContentPage
            {
                Title = "Blue and Red",
                Content = new StackLayout
                {
                    Children = {
                    new BoxView { Color = Color.Blue },
                    new BoxView { Color = Color.Red}
                }
                }
            });

            this.Children.Add(new ContentPage
            {
                Title = "Blue and Red",
                Content = new StackLayout
                {
                    Children = {
                    new BoxView { Color = Color.Blue },
                    new BoxView { Color = Color.Red}
                }
                }
            });

   
        }


    }
}
