using Xamarin.Forms;
using System;

namespace TestXamarin
{
    public partial class TestXamarinPage : TabbedPage {
        public TestXamarinPage()
        {
            InitializeComponent();

            //Input tab

            var inputPage = new InputPage();

            this.Children.Add(inputPage);

            //Day tab

            var dayPage = new DayPage();

            this.Children.Add(dayPage);

            //Month tab:

            NavigationPage monthNavigationPage = new NavigationPage(new MonthRootPage());
            monthNavigationPage.BarBackgroundColor = Color.Blue;
            monthNavigationPage.Title = "Month";

            this.Children.Add(monthNavigationPage);

            //Sheet tab

            var sheetPage = new SheetPage();

            this.Children.Add(sheetPage);

        }


    }
}
