Imports System.Windows

Namespace TreeList_DataBinding
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            treeList.ItemsSource = Stuff.GetStuff()
            treeListView1.ExpandAllNodes()
        End Sub
    End Class
End Namespace
