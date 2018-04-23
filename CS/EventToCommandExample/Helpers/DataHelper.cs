using System;
using System.Collections.ObjectModel;
using EventToCommandExample.Models;

namespace EventToCommandExample.Helpers {
    public class DataHelper {
        public static ObservableCollection<SampleData> GetData(int value) {
            Random rnd = new Random();
            var collection = new ObservableCollection<SampleData>();
            for (int i = 0; i < 10; i++)
                collection.Add(new SampleData() { ID = i, Text = "Row#" + i.ToString(), Value = rnd.Next(100)});
            return collection;
        }
    }
}
