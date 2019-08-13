using System;
using System.Collections.Generic;
using GorillaTest.ViewModel;
using Xamarin.Forms;

namespace GorillaTest.View
{
    public partial class StudentView : ContentPage
    {
        public StudentView()
        {
            InitializeComponent();


            BindingContext = StudentViewModel.GetInstance();
        }
    }
}
