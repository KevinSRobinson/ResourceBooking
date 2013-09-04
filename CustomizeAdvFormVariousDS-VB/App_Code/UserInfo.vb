Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

''' <summary>
''' Summary description for UserInfo
''' </summary>
Public Class UserInfo

    Private _id As Integer
    Private _text As String

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            _text = value
        End Set
    End Property


    Public Sub New(id As Integer, text As String)
        Me.ID = id
        Me.Text = text
    End Sub
End Class
