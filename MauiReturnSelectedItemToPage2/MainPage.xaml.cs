using MauiReturnSelectedItemToPage2.ViewModels;

namespace MauiReturnSelectedItemToPage2
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            // Set the navigation instance into the view model.
            viewModel.Nav = Navigation;
            BindingContext = viewModel;
        }
    }
}
