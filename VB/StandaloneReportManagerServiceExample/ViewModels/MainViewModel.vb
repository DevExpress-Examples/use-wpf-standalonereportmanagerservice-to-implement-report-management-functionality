Imports DevExpress.Mvvm
Imports System.Collections.Generic

Namespace StandaloneReportManagerServiceExample.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Items As List(Of ItemViewModel)
            Get
                Return GetProperty(Function() Me.Items)
            End Get

            Set(ByVal value As List(Of ItemViewModel))
                SetProperty(Function() Items, value)
            End Set
        End Property

        Public Sub New()
            Items = New List(Of ItemViewModel)() From {New ItemViewModel() With {.ID = 1, .Name = "First"}, New ItemViewModel() With {.ID = 2, .Name = "Second"}, New ItemViewModel() With {.ID = 3, .Name = "Third"}, New ItemViewModel() With {.ID = 4, .Name = "Fourth"}}
        End Sub
    End Class

    Public Class ItemViewModel
        Inherits ViewModelBase

        Public Property Name As String
            Get
                Return GetProperty(Function() Me.Name)
            End Get

            Set(ByVal value As String)
                SetProperty(Function() Name, value)
            End Set
        End Property

        Public Property ID As Integer
            Get
                Return GetProperty(Function() Me.ID)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() ID, value)
            End Set
        End Property
    End Class
End Namespace
