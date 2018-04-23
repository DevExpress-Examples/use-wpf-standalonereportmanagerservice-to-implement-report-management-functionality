Imports DevExpress.Mvvm
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace StandaloneReportManagerServiceExample.ViewModels
    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Items() As List(Of ItemViewModel)
            Get
                Return GetProperty(Function() Items)
            End Get
            Set(ByVal value As List(Of ItemViewModel))
                SetProperty(Function() Items, value)
            End Set
        End Property

        Public Sub New()
            Items = New List(Of ItemViewModel)() From { _
                New ItemViewModel() With {.ID = 1, .Name = "First"}, _
                New ItemViewModel() With {.ID = 2, .Name = "Second"}, _
                New ItemViewModel() With {.ID = 3, .Name = "Third"}, _
                New ItemViewModel() With {.ID = 4, .Name = "Fourth"} _
            }
        End Sub
    End Class

    Public Class ItemViewModel
        Inherits ViewModelBase

        Public Property Name() As String
            Get
                Return GetProperty(Function() Name)
            End Get
            Set(ByVal value As String)
                SetProperty(Function() Name, value)
            End Set
        End Property
        Public Property ID() As Integer
            Get
                Return GetProperty(Function() ID)
            End Get
            Set(ByVal value As Integer)
                SetProperty(Function() ID, value)
            End Set
        End Property
    End Class
End Namespace
