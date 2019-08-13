using System;
using System.Collections.Generic;
using GorillaTest.ViewModel;
using Xamarin.Forms;

namespace GorillaTest.View
{
    public partial class InfoStudent : ContentPage
    {
        public InfoStudent()
        {
            InitializeComponent();


            BindingContext = StudentViewModel.GetInstance();
        }
    }
}
