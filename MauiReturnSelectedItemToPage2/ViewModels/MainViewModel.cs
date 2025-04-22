using System.Windows.Input;
using Microsoft.Maui.Controls;
using MauiReturnSelectedItemToPage2.Models;
using MauiReturnSelectedItemToPage2.Services;
using MauiReturnSelectedItemToPage2.Views;

namespace MauiReturnSelectedItemToPage2.ViewModels
{
    // The MainViewModel coordinates the main UI, providing navigation and data binding for the MainPage.
    // It exposes the currently selected item as stored in a shared ISelectionState instance.
    public class MainViewModel : BaseViewModel
    {
        private readonly ISelectionState _selectionState;

        // Gets or sets the navigation instance. This must be set from the code-behind.
        public INavigation Nav { get; set; }

        // Gets the command that navigates to the selection page where the user can pick an item.
        public ICommand GoPickCommand { get; }

        // Initializes a new instance of the MainViewModel class.
        // Subscribes to the shared selection state notifications to update the UI when the selected item changes.
        // selectionState: The shared selection state.
        public MainViewModel(ISelectionState selectionState)
        {
            _selectionState = selectionState;

            // Subscribe to property changes in the selection state to update the UI.
            _selectionState.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(_selectionState.SelectedItem))
                {
                    OnPropertyChanged(nameof(SelectedItem));
                }
            };

            GoPickCommand = new Command(async () =>
            {
                // Navigate to the SelectionPage, passing in a new SelectionViewModel using the shared selection state.
                await Nav.PushAsync(new SelectionPage(new SelectionViewModel(_selectionState, Nav)));
            });
        }

        // Gets the currently selected item from the shared ISelectionState.
        // This value is automatically updated in the UI when the selection state changes.
        public Item SelectedItem => _selectionState.SelectedItem;
    }
}
