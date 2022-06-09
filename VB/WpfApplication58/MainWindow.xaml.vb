Imports DevExpress.Xpf.Core.Serialization
Imports DevExpress.Xpf.Grid
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace WpfApplication58

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim customers As ObservableCollection(Of Customer) = New ObservableCollection(Of Customer)()
            For i As Integer = 1 To 30 - 1
                customers.Add(New Customer() With {.ID = i, .Name = "Name" & i})
            Next

            Me.grid.ItemsSource = customers
            Me.grid.Columns(NameOf(Customer.ID)).AddHandler(DXSerializer.AllowPropertyEvent, New AllowPropertyEventHandler(AddressOf OnAllowProperty))
        End Sub

        Private Sub OnAllowProperty(ByVal sender As Object, ByVal e As AllowPropertyEventArgs)
            If e.DependencyProperty Is BaseColumn.WidthProperty Then e.Allow = False
        End Sub

        Private Sub OnSaveLayout(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.grid.SaveLayoutToXml("layout.xml")
        End Sub

        Private Sub OnRestoreLayout(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.grid.RestoreLayoutFromXml("layout.xml")
        End Sub
    End Class

    Public Class Customer

        Public Property ID As Integer

        Public Property Name As String
    End Class
End Namespace
