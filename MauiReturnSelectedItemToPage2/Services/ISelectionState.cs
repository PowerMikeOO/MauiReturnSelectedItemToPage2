using MauiReturnSelectedItemToPage2.Models;
using System.ComponentModel;

namespace MauiReturnSelectedItemToPage2.Services
{
    public interface ISelectionState : INotifyPropertyChanged
    {
        Item SelectedItem { get; set; }
    }
}
