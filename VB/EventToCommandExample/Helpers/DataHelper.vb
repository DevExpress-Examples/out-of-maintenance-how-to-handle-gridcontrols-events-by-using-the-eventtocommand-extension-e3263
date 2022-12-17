Imports System
Imports System.Collections.ObjectModel
Imports EventToCommandExample.Models

Namespace EventToCommandExample.Helpers

    Public Class DataHelper

        Public Shared Function GetData(ByVal value As Integer) As ObservableCollection(Of SampleData)
            Dim rnd As Random = New Random()
            Dim collection = New ObservableCollection(Of SampleData)()
            For i As Integer = 0 To 10 - 1
                collection.Add(New SampleData() With {.ID = i, .Text = "Row#" & i.ToString(), .Value = rnd.Next(100)})
            Next

            Return collection
        End Function
    End Class
End Namespace
