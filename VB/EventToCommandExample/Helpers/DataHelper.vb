Imports System
Imports System.Collections.ObjectModel
Imports EventToCommandExample.Models

Namespace EventToCommandExample.Helpers
    Public Class DataHelper
        Public Shared Function GetData(ByVal value As Integer) As ObservableCollection(Of SampleData)
            Dim rnd As New Random()
            Dim collection = New ObservableCollection(Of SampleData)()
            For i As Integer = 0 To 9
                collection.Add(New SampleData() With {.ID = i, .Text = "Row#" & i.ToString(), .Value = rnd.Next(100)})
            Next i
            Return collection
        End Function
    End Class
End Namespace
