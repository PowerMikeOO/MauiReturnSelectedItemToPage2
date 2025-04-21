using MauiReturnSelectedItemToPage2.Models;

namespace MauiReturnSelectedItemToPage2.Services
{
    public class SelectionState : ISelectionState
    {
        public Item SelectedItem { get; set; }
    }
}
