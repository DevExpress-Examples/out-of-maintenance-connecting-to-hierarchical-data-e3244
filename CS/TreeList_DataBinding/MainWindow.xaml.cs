using System.Windows;

namespace TreeList_DataBinding {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            treeList.ItemsSource = Staff.GetStaff();
            treeListView1.ExpandAllNodes();
        }
    }
}
