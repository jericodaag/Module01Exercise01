using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Module01Exercise01
{
    public class UserProfileViewModel : INotifyPropertyChanged
    {
        private string _name = string.Empty;
        private string _email = string.Empty;
        private DateTime _dateOfBirth = DateTime.Today;
        private string _bio = string.Empty;
        private string _confirmationText = string.Empty;
        private bool _isConfirmationVisible;
        private bool _isSaveButtonEnabled = true;
        private string _saveButtonText = "Save Changes";

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                _dateOfBirth = value;
                OnPropertyChanged();
            }
        }

        public string Bio
        {
            get => _bio;
            set
            {
                _bio = value;
                OnPropertyChanged();
            }
        }

        public string ConfirmationText
        {
            get => _confirmationText;
            set
            {
                _confirmationText = value;
                OnPropertyChanged();
            }
        }

        public bool IsConfirmationVisible
        {
            get => _isConfirmationVisible;
            set
            {
                _isConfirmationVisible = value;
                OnPropertyChanged();
            }
        }

        public bool IsSaveButtonEnabled
        {
            get => _isSaveButtonEnabled;
            set
            {
                _isSaveButtonEnabled = value;
                OnPropertyChanged();
            }
        }

        public string SaveButtonText
        {
            get => _saveButtonText;
            set
            {
                _saveButtonText = value;
                OnPropertyChanged();
            }
        }

        public DateTime MinDate { get; } = new DateTime(1900, 1, 1);
        public DateTime MaxDate { get; } = DateTime.Today;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void UpdateConfirmationText()
        {
            ConfirmationText = "Changes have been saved.";
            IsConfirmationVisible = true;
        }
    }
}
