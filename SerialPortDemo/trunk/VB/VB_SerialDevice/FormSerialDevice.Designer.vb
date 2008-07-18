<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSerialDevice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.richTextBoxReceive = New System.Windows.Forms.RichTextBox
        Me.port = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'richTextBoxReceive
        '
        Me.richTextBoxReceive.Location = New System.Drawing.Point(12, 12)
        Me.richTextBoxReceive.Name = "richTextBoxReceive"
        Me.richTextBoxReceive.Size = New System.Drawing.Size(268, 242)
        Me.richTextBoxReceive.TabIndex = 1
        Me.richTextBoxReceive.Text = ""
        '
        'port
        '
        Me.port.PortName = "COM5"
        '
        'FormSerialDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.richTextBoxReceive)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.SerialDevice_VB.My.MySettings.Default, "SerialDevice_Location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.SerialDevice_VB.My.MySettings.Default.SerialDevice_Location
        Me.Name = "FormSerialDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SerialDevice VB"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents richTextBoxReceive As System.Windows.Forms.RichTextBox
    Private WithEvents port As System.IO.Ports.SerialPort

End Class
