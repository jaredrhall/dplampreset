''' <summary>
''' This class is designed to encapsulate the predefined parameters for projectors.
''' </summary>
''' <remarks></remarks>
Public Class Projector
    Private bRate As Integer
    Public ReadOnly Property BaudRate() As Integer
        Get
            Return bRate
        End Get
    End Property

    Private dLen As Integer
    Public ReadOnly Property DataLength() As Integer
        Get
            Return dLen
        End Get
    End Property

    Private sBits As System.IO.Ports.StopBits
    Public ReadOnly Property StopBits() As System.IO.Ports.StopBits
        Get
            Return sBits
        End Get
    End Property

    Private prty As System.IO.Ports.Parity
    Public ReadOnly Property Parity() As System.IO.Ports.Parity
        Get
            Return prty
        End Get
    End Property

    Sub New(br As Integer, dataLen As Integer, stBits As System.IO.Ports.StopBits, par As System.IO.Ports.Parity)
        Me.bRate = br
        Me.dLen = dataLen
        Me.sBits = stBits
        Me.prty = par
    End Sub
End Class
