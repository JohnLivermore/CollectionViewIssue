using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewIssue.Pages;
using Xamarin.Forms;

namespace CollectionViewIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ViewModel = new DailyEntryPageModel();
        }

        public DailyEntryPageModel ViewModel { get; set; }

        protected override void OnAppearing()
        {
            ViewModel.Load();
        }
    }
}
