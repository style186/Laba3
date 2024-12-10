using LABA3.ViewModels;
using LABA3.Models;

namespace LABA3.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnToggleToggled(object sender, ToggledEventArgs e)
        {
            if (sender is Switch toggleSwitch && toggleSwitch.BindingContext is TodoItem item)
            {
                var viewModel = (TodoViewModel)BindingContext;
                viewModel.ToggleCommand.Execute(item);
            }
        }
    }
}


