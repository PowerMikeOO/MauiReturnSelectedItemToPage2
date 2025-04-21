using MauiReturnSelectedItemToPage2.Models;

namespace MauiReturnSelectedItemToPage2.Services
{
    public interface ISelectionState
    {
        Item SelectedItem { get; set; }
    }
}
