Imports System.Collections.Generic
Imports System

Public Class DataReceivedEventArgs
    Inherits EventArgs

    Public Sub New(ByVal data As String)
        _data = data
    End Sub

    Private _data As String
    Public Property Data() As String
        Get
            Return _data
        End Get
        Set(ByVal Value As String)
            _data = Value
        End Set
    End Property

End Class
