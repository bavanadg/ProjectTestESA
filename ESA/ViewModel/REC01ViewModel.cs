using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;

namespace ESA.ViewModel
{
    // REC: The implementation of the INotifyPropertyChanged 
    // interfase allows Xamarin forms to know that something 
    // has been updated (And do something about it if necessary).

    public class REC01ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        // REC: The statement above is necessary to implement the INotifyPropertyChanged
        // and is linked to the OnPropertyChanged method (see below).

        // Variables:
        string name = string.Empty;
        // string website = string.Empty;
        string website = "https://www.google.com.au/";
        bool answer;
        bool isBusy;

        // Constructor
        public REC01ViewModel()
        {
            // The below constructor tells Xamarin Forms what to do with the LaunchWebsite method
            LaunchWebsiteCommand = new Command(LaunchWebsite);
        }

        // Getters and Setters
        public bool Response
        {
            get { return answer; }
            set
            {
                answer = value;
                OnPropertyChanged(nameof(Options));
            }
        }

        public string WelcomeLabel { get { return $"Welcome {Name} to Rodrigo's Page."; } }
        public string Question { get { return $"Hey {Name}, would you like to visit Mexico?"; } }
        public string Options
        {
            get
            {
                if (answer == true)
                {
                    return $"Great mate, it's a magical country!";
                }
                else
                {
                    return $"No dramas, maybe some other time.";
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(WelcomeLabel));
                OnPropertyChanged(nameof(Question));
                OnPropertyChanged(nameof(Options));
            }
        }


        public string Website
        {
            get { return website; }
            set { website = value; }
        }
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; }
        }

        // Methods

        // Creating the command method below (To avoid coding outside the viewmodel for the click Button)
        // See theory @ 22:20 of Episode 5_ MVVM &amp; Data Binding with Xamarin.Forms.mp4).
        public Command LaunchWebsiteCommand { get; }

        // Launching the Website Method.
        void LaunchWebsite()
        {
            try
            {
                Device.OpenUri(new Uri(website));
            }
            catch (Exception)
            {
                throw;
            }
        }

        async Task SaveContact()
        {
            isBusy = true;
            await Task.Delay(4000);
            isBusy = false;
            await Application.Current.MainPage.DisplayAlert("Save", "Contact Saved", "Ok");
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(name));
            // ? functions as a verification that PropertyChanged
            // is not null. This allows to update other properties 
            // whenever there are changes in user modified properties.
        }
    }
}
