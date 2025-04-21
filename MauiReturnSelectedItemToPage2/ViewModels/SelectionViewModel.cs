using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using MauiReturnSelectedItemToPage2.Models;
using MauiReturnSelectedItemToPage2.Services;

namespace MauiReturnSelectedItemToPage2.ViewModels
{
    public class SelectionViewModel : BaseViewModel
    {
        private readonly ISelectionState _selectionState;
        private readonly INavigation _nav;

        public ObservableCollection<Item> Items { get; }

        public SelectionViewModel(ISelectionState selectionState, INavigation nav)
        {
            _selectionState = selectionState;
            _nav = nav;
            Items = new ObservableCollection<Item>
            {
                new Item { Name = "Alpha" },
                new Item { Name = "Bravo" },
                new Item { Name = "Charlie" }
            };
        }

        public Item SelectedItem
        {
            get => _selectionState.SelectedItem;
            set
            {
                if (value != null)
                {
                    _selectionState.SelectedItem = value;
                    _ = _nav.PopAsync();
                }
            }
        }
    }
}
