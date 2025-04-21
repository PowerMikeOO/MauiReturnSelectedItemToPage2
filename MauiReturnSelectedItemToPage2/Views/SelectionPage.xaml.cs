using MauiReturnSelectedItemToPage2.ViewModels;

namespace MauiReturnSelectedItemToPage2.Views;

public partial class SelectionPage : ContentPage
{
    public SelectionPage(SelectionViewModel viewModel)
    {
        InitializeComponent();
        // Set the navigation instance into the view model (if not already set in constructor).
        BindingContext = viewModel;
    }
}
