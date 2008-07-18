Imports System.IO.Ports

Public Class FormSerialDevice

    Private _inputBuffer As String

    Private Sub FormSerialDevice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

        port.PortName = "COM5"
        port.BaudRate = 9600
        port.Parity = Parity.None
        port.DataBits = 8
        port.StopBits = StopBits.One
        port.NewLine = "!%"

        port.Open()

        If port.IsOpen Then
            richTextBoxReceive.AppendText("Serial Port is open..." + vbCrLf)
        End If

    End Sub

    Private Sub port_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles port.DataReceived

        If port.IsOpen Then

            _inputBuffer = port.ReadTo(port.NewLine)
            If port.ReadExisting().Length = 0 Then

                richTextBoxReceive.AppendText(_inputBuffer & vbCrLf)
                port.WriteLine(_inputBuffer)
                _inputBuffer = String.Empty

            End If

        End If

    End Sub

    Private Sub FormSerialDevice_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.SerialDevice_Location = Me.Location
        My.Settings.Save()
    End Sub
End Class
