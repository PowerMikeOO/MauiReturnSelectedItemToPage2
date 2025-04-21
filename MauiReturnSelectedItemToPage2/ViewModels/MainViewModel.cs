using System.Windows.Input;
using Microsoft.Maui.Controls;
using MauiReturnSelectedItemToPage2.Services;
using MauiReturnSelectedItemToPage2.Views;

namespace MauiReturnSelectedItemToPage2.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly ISelectionState _selectionState;

        // This will be set from the code-behind
        public INavigation Nav { get; set; }

        public ICommand GoPickCommand { get; }

        public MainViewModel(ISelectionState selectionState)
        {
            _selectionState = selectionState;
            GoPickCommand = new Command(async () =>
            {
                // Navigate to SelectionPage. The navigation instance is already set via the MainPage.
                await Nav.PushAsync(new SelectionPage(new SelectionViewModel(_selectionState, Nav)));
                OnPropertyChanged(nameof(SelectedItem));
            });
        }

        //public MauiReturnSelectedItemToPage2.Models.Item SelectedItem => _selectionState.SelectedItem;
        public Item SelectedItem
        {
            get => _selectionState.SelectedItem;
            set
            {
                if (_selectionState.SelectedItem != value)
                {
                    _selectionState.SelectedItem = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
