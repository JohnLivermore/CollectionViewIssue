using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CollectionViewIssue.Pages
{
    public class MetersViewModel : NotifyPropertyChangedBase
    {
        public MetersViewModel()
        {
            Items = new ObservableCollection<MeterAdjustmentsRow>();
        }

        private bool _isVisible;
        public bool IsVisible { get => _isVisible; set => SetField(ref _isVisible, value, nameof(IsVisible)); }

        public ObservableCollection<MeterAdjustmentsRow> Items { get; set; }

        public void Load()
        {
            Items.Clear();

            foreach (var item in GetData())
            {
                Items.Add(item);
            }
        }

        private List<MeterAdjustmentsRow> GetData()
        {
            var list = new List<MeterAdjustmentsRow>();

            list.Add(new MeterAdjustmentsRow() { MeterNumber = "AAAAAA" });
            list.Add(new MeterAdjustmentsRow() { MeterNumber = "BBBBBB" });
            list.Add(new MeterAdjustmentsRow() { MeterNumber = "CCCCCC" });
            list.Add(new MeterAdjustmentsRow() { MeterNumber = "DDDDDD" });

            return list;
        }
    }

    public class MeterAdjustmentsRow
    {
        public string MeterNumber { get; set; }
    }
}
