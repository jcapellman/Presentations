using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEcosystem.ViewModels;
using Xamarin.Forms;

namespace CSharpEcosystem
{
    public partial class MainPage : ContentPage
    {
        public MainPageModel viewModel => (MainPageModel) BindingContext;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageModel();
        }

        protected override async void OnBindingContextChanged()
        {
            var result = await viewModel.LoadData();
        }
    }
}