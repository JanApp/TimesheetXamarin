using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TestXamarin
{
    public class InputPage : ContentPage
    {

        List<String> itemList;
        ListView itemListView;
        Button addToListButton;
        Button stopWorkingDayButton;
        StackLayout stackLayout;

        public InputPage()
        {
            Title = "Input";

            addToListButton = new Button { Text = "Add to list" };
            addToListButton.Clicked += OnAddToListButtonClicked;

            stopWorkingDayButton = new Button { Text = "Stop Working" };

            itemListView = CreateList();
            refreshListView();

        }

        public ListView CreateList ()
        {
            var listView = new ListView();
            itemList = new List<String> {"a","b","c"};
            listView.ItemsSource = itemList;
            return listView;
        }

        void OnAddToListButtonClicked(object sender, EventArgs e)
        {
            itemList.Add("q");
            refreshListView();
            
        }

        void refreshListView()
        {
            stackLayout = new StackLayout
            {
                Children = {
                    addToListButton,
                    new ScrollView {Content = itemListView},
                    stopWorkingDayButton
                }

            };
            this.Content = stackLayout;
        }
    }
}
