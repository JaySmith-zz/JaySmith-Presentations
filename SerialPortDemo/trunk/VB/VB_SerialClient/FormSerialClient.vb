Imports System.IO.Ports

Public Class FormSerialClient

    Private _inputBuffer As String

    Private Sub FormSerialClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

        port.PortName = "COM1"
        port.BaudRate = 9600
        port.Parity = Parity.None
        port.DataBits = 8
        port.StopBits = StopBits.One
        port.NewLine = "!%"

        port.Open()

        If port.IsOpen Then
            richTextBoxReceive.AppendText("Serial Port is open..." & vbCrLf)
        End If

    End Sub

    Private Sub buttonSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSend.Click

        If textBoxMessage.Text <> String.Empty Then
            port.WriteLine(textBoxMessage.Text)
        End If

    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles port.DataReceived

        If port.IsOpen Then

            _inputBuffer = port.ReadTo(port.NewLine)
            If port.ReadExisting().Length = 0 Then

                richTextBoxReceive.AppendText(_inputBuffer & vbCrLf)
                _inputBuffer = String.Empty

            End If

        End If

    End Sub


    Private Sub FormSerialClient_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.SerialClient_Location = Me.Location
        My.Settings.Save()
    End Sub
End Class
