Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports EventToCommandExample.Models
Imports EventToCommandExample.Helpers

Namespace EventToCommandExample.ViewModels
    <POCOViewModel> _
    Public Class MainViewModel
        Public Overridable ReadOnly Property MessageBoxService() As IMessageBoxService
            Get
                Return Nothing
            End Get
        End Property
        Public Overridable Property GridData() As ObservableCollection(Of SampleData)
        Public Sub New()
            GridData = DataHelper.GetData(10)

        End Sub
        Public Overridable Sub ShowRowDetails(ByVal obj As SampleData)
            MessageBoxService.Show(obj.ToString(), "Row Details")
        End Sub
    End Class
End Namespace
