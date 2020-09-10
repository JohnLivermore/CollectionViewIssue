using Xamarin.Forms;

namespace CollectionViewIssue.Pages
{
    public class DailyEntryPageModel
    {
        public DailyEntryPageModel()
        {
            MetersViewModel = new MetersViewModel();
            TanksViewModel = new TanksViewModel();

            TanksViewModel.IsVisible = true;
        }

        public Command ButtonClick
        {
            get
            {
                return new Command(button =>
                {
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                    {
                        MetersViewModel.IsVisible = false;
                        TanksViewModel.IsVisible = false;

                        switch ((string)button)
                        {
                            case "Tanks":
                                TanksViewModel.Load();
                                TanksViewModel.IsVisible = true;
                                break;
                            case "Meters":
                                MetersViewModel.Load();
                                MetersViewModel.IsVisible = true;
                                break;
                        }
                    });
                });
            }
        }

        public void Load()
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                if (TanksViewModel.IsVisible)
                {
                    TanksViewModel.Load();
                }

                if (MetersViewModel.IsVisible)
                {
                    MetersViewModel.Load();
                }
            });
        }

        public TanksViewModel TanksViewModel { get; set; }
        public MetersViewModel MetersViewModel { get; set; }
    }
}
