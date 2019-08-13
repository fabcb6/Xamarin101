using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using GorillaTest.Model;
using GorillaTest.ViewModel;
using Xamarin.Forms;

namespace GorillaTest.View
{
    public partial class MenuView : ContentPage
    {

        public MenuView()
        {
            InitializeComponent();


            BindingContext = new MenuViewModel();
        }
    }
}
