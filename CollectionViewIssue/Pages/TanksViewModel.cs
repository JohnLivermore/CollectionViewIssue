using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CollectionViewIssue.Pages
{
    public class TanksViewModel : NotifyPropertyChangedBase
    {
        public TanksViewModel()
        {
            Items = new ObservableCollection<TankAdjustmentsRow>();
        }

        private bool _isVisible;
        public bool IsVisible { get => _isVisible; set => SetField(ref _isVisible, value, nameof(IsVisible)); }

        public ObservableCollection<TankAdjustmentsRow> Items { get; set; }

        public void Load()
        {
            Items.Clear();

            foreach (var item in GetData())
            {
                Items.Add(item);
            }
        }

        private List<TankAdjustmentsRow> GetData()
        {
            var list = new List<TankAdjustmentsRow>();

            list.Add(new TankAdjustmentsRow() { TankNumber = "0001" });
            list.Add(new TankAdjustmentsRow() { TankNumber = "0002" });
            list.Add(new TankAdjustmentsRow() { TankNumber = "0003" });
            list.Add(new TankAdjustmentsRow() { TankNumber = "0004" });
            list.Add(new TankAdjustmentsRow() { TankNumber = "0005" });

            return list;
        }
    }

    public class TankAdjustmentsRow
    {
        public string TankNumber { get; set; }
    }
}
