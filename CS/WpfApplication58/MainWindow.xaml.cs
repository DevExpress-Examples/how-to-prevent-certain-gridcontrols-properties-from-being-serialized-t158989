using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Grid;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApplication58 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
            for (int i = 1; i < 30; i++) {
                customers.Add(new Customer() { ID = i, Name = "Name" + i });
            }
            grid.ItemsSource = customers;

            grid.Columns[nameof(Customer.ID)].AddHandler(DXSerializer.AllowPropertyEvent, new AllowPropertyEventHandler(OnAllowProperty));
        }
        void OnAllowProperty(object sender, AllowPropertyEventArgs e) {
            if (e.DependencyProperty == GridColumn.WidthProperty)
                e.Allow = false;
        }
        void OnSaveLayout(object sender, RoutedEventArgs e) {
            grid.SaveLayoutToXml("layout.xml");
        }
        void OnRestoreLayout(object sender, RoutedEventArgs e) {
            grid.RestoreLayoutFromXml("layout.xml");
        }
    }

    public class Customer {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
