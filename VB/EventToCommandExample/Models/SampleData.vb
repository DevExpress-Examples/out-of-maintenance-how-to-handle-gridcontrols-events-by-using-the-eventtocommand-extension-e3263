Namespace EventToCommandExample.Models
    Public Class SampleData
        Public Overridable Property ID() As Integer
        Public Overridable Property Text() As String
        Public Overridable Property Value() As Integer
        Public Overrides Function ToString() As String
            Return String.Format("{0} - {1} - {2}", ID, Text, Value)
        End Function
    End Class
End Namespace
