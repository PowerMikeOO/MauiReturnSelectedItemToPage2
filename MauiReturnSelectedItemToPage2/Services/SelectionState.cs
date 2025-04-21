using MauiReturnSelectedItemToPage2.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiReturnSelectedItemToPage2.Services
{
    public class SelectionState : ISelectionState, INotifyPropertyChanged
    {
        private Item _selectedItem;

        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
