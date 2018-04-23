Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Windows
Imports EventToCommandExample.ViewModels

Namespace EventToCommandExample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Me.DataContext = New MainViewModel()
		End Sub
	End Class
End Namespace
