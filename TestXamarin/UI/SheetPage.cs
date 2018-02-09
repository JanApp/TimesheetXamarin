using System;
using Xamarin.Forms;

namespace TestXamarin
{
    public class SheetPage : ContentPage
    {
        public SheetPage()
        {
            Title = "Sheet";

            Label labelCurrentSheet = new Label
            {
                Text = "Current sheet"
            };

            String[] sheetList = new String[]
            {
                "Sheet1","Sheet2"
            };

            Picker sheetPicker = new Picker();
            sheetPicker.ItemsSource = sheetList;
            sheetPicker.SelectedItem = sheetList[0];

            Button newSheetButton = new Button
            {
                Text = "New sheet"

            };

            Button deleteCurrentSheetButton = new Button
            {
                Text = "Delete current sheet"
            };

            Content = new StackLayout
            {
                Children = {
                    labelCurrentSheet,
                    sheetPicker,
                    newSheetButton,
                    deleteCurrentSheetButton
                }
            };

        }
    }
}
