using System;
using CollectionViewIssue.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewIssue
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DailyEntryPage();
        }
    }
}
