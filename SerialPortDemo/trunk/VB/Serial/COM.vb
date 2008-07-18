Imports System.IO.Ports
Imports System

Public Class COM

    Private _portName As String
    Private WithEvents _port As SerialPort
    Private _inputBuffer As String

    Public Event OnDataReceived As EventHandler(Of DataReceivedEventArgs)

    Public Sub New(ByVal portName As String)
        _portName = portName

        _port = New SerialPort(_portName, 9600, Parity.None, 8, StopBits.One)
        _port.NewLine = "\n"

        _port.Open()
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles _port.DataReceived

        If _port.IsOpen Then
            _inputBuffer = _port.ReadTo(_port.NewLine)
            If (_port.ReadExisting().Length = 0) Then
                Invoker.Invoke(OnDataReceived, Me, New DataReceivedEventArgs(_inputBuffer))
                _inputBuffer = String.Empty
            End If
        End If

    End Sub

    Private Sub Write(ByVal buffer As String)
        Try
            _port.Write(buffer)
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub WriteLine(ByVal buffer As String)
        Try
            _port.WriteLine(buffer)
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
