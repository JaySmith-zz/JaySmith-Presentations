<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSerialClient
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
        Me.port = New System.IO.Ports.SerialPort(Me.components)
        Me.textBoxMessage = New System.Windows.Forms.TextBox
        Me.buttonSend = New System.Windows.Forms.Button
        Me.richTextBoxReceive = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'port
        '
        '
        'textBoxMessage
        '
        Me.textBoxMessage.Location = New System.Drawing.Point(12, 12)
        Me.textBoxMessage.Name = "textBoxMessage"
        Me.textBoxMessage.Size = New System.Drawing.Size(187, 20)
        Me.textBoxMessage.TabIndex = 5
        Me.textBoxMessage.Text = "Hello World!"
        '
        'buttonSend
        '
        Me.buttonSend.Location = New System.Drawing.Point(205, 12)
        Me.buttonSend.Name = "buttonSend"
        Me.buttonSend.Size = New System.Drawing.Size(75, 23)
        Me.buttonSend.TabIndex = 4
        Me.buttonSend.Text = "Send"
        Me.buttonSend.UseVisualStyleBackColor = True
        '
        'richTextBoxReceive
        '
        Me.richTextBoxReceive.Location = New System.Drawing.Point(12, 38)
        Me.richTextBoxReceive.Name = "richTextBoxReceive"
        Me.richTextBoxReceive.Size = New System.Drawing.Size(268, 216)
        Me.richTextBoxReceive.TabIndex = 3
        Me.richTextBoxReceive.Text = ""
        '
        'FormSerialClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.textBoxMessage)
        Me.Controls.Add(Me.buttonSend)
        Me.Controls.Add(Me.richTextBoxReceive)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.SerialClient_VB.My.MySettings.Default, "SerialClient_Location", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.SerialClient_VB.My.MySettings.Default.SerialClient_Location
        Me.Name = "FormSerialClient"
        Me.Text = "SerialClient VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents port As System.IO.Ports.SerialPort
    Private WithEvents textBoxMessage As System.Windows.Forms.TextBox
    Private WithEvents buttonSend As System.Windows.Forms.Button
    Private WithEvents richTextBoxReceive As System.Windows.Forms.RichTextBox

End Class
