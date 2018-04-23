using System.Windows;

namespace TreeList_DataBinding {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            treeList.ItemsSource = Stuff.GetStuff();
            treeListView1.ExpandAllNodes();
        }
    }
}
