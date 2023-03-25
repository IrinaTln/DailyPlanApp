using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DailyPlanApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            Button DailyPlanPage = new Button
            {
                Text = "Дневник тревожника",
                TextColor = Color.FromHex("#2B797A"),
                FontSize = 18,
                BackgroundColor = Color.FromHex("#B7D3E6"),
                WidthRequest = 250,
                HeightRequest = 65,
                BorderWidth = 2,
                BorderColor = Color.FromHex("#2B797A"),
                CornerRadius = 10,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            StackLayout stack = new StackLayout();
            stack.Children.Add(DailyPlanPage);

            Content = stack;

            DailyPlanPage.Clicked += DailyPlanPage_Clicked;

        }

        private async void DailyPlanPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DailyPlanPage());    
        }
    }
}