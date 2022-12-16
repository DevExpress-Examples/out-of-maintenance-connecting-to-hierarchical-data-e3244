Imports System.Windows

Namespace TreeList_DataBinding

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.treeList.ItemsSource = GetStuff()
            Me.treeListView1.ExpandAllNodes()
        End Sub
    End Class
End Namespace
