using System;

using Xamarin.Forms;

namespace GorillaTest.View
{
    public class HomeView : ContentPage
    {
        public HomeView()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

