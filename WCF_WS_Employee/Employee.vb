Imports System.Runtime.Serialization

<DataContract>
Public Class Employee
    Private m_IdEmployee As Integer
    Private m_Name As String
    Private m_LastName As String

    <DataMember>
    Public Property IdEmployee() As Integer
        Get
            Return m_IdEmployee
        End Get
        Set(ByVal value As Integer)
            m_IdEmployee = value
        End Set
    End Property

    <DataMember>
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property

    <DataMember>
    Public Property LastName() As String
        Get
            Return m_LastName
        End Get
        Set(ByVal value As String)
            m_LastName = value
        End Set
    End Property

    Public Sub New(ByVal IdEmployee As Integer, ByVal Name As String, ByVal LastName As String)
        Me.m_IdEmployee = IdEmployee
        Me.m_Name = Name
        Me.m_LastName = LastName

    End Sub
End Class
