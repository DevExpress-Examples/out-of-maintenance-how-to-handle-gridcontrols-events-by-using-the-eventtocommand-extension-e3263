using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using EventToCommandExample.Models;
using EventToCommandExample.Helpers;

namespace EventToCommandExample.ViewModels {
    [POCOViewModel]
    public class MainViewModel {
        public virtual IMessageBoxService MessageBoxService { get { return null; } }
        public virtual ObservableCollection<SampleData> GridData { get; set; }
        public MainViewModel() {
            GridData = DataHelper.GetData(10); ;
        }
        public virtual void ShowRowDetails(SampleData obj) {
            MessageBoxService.Show(obj.ToString(), "Row Details");
        }
    }
}
