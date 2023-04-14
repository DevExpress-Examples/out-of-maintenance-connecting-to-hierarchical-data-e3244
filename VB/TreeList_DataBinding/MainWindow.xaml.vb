Imports System.Windows

Namespace TreeList_DataBinding

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.treeList.ItemsSource = GetStaff()
            Me.treeListView1.ExpandAllNodes()
        End Sub
    End Class
End Namespace
