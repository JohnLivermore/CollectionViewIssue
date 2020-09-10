using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewIssue.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DailyEntryPage : ContentPage
    {
        public DailyEntryPage()
        {
            InitializeComponent();

            BindingContext = new DailyEntryPageModel();
        }

        protected override void OnAppearing()
        {
            ((DailyEntryPageModel)BindingContext).Load();
        }
    }
}