using Microsoft.Maui.Controls;
using System;

namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new UserProfileViewModel();
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            if (BindingContext is UserProfileViewModel viewModel)
            {
                viewModel.UpdateConfirmationText();
            }
        }

        private void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            if (BindingContext is UserProfileViewModel viewModel)
            {
                viewModel.Bio = e.NewTextValue;
            }
        }

        private void OnEditorCompleted(object sender, EventArgs e)
        {
            if (BindingContext is UserProfileViewModel viewModel)
            {
                viewModel.ConfirmationText = "Editing completed!";
                viewModel.IsConfirmationVisible = true;
            }
        }
    }
}
