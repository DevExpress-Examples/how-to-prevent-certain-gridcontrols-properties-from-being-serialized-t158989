Imports DevExpress.Xpf.Core.Serialization
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WpfApplication58
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            Dim customers As New ObservableCollection(Of Customer)()
            For i As Integer = 1 To 29
                customers.Add(New Customer() With {.ID = i, .Name = "Name" & i})
            Next i
            grid.ItemsSource = customers
            grid.Columns("ID").AddHandler(DXSerializer.AllowPropertyEvent, New AllowPropertyEventHandler(AddressOf OnAllowProperty))

        End Sub
        Private Sub OnAllowProperty(ByVal sender As Object, ByVal e As AllowPropertyEventArgs)
            If e.DependencyProperty Is GridColumn.ActualWidthProperty Then

                e.Allow = False
            End If
        End Sub
        Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid.RestoreLayoutFromXml("layout.xml")
        End Sub

        Private Sub Button_Click_2(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid.SaveLayoutToXml("layout.xml")
        End Sub
    End Class

    Public Class Customer
        Public Property ID() As Integer

        Public Property Name() As String
    End Class
End Namespace
