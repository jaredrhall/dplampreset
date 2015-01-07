<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshPortsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Combo_serialPort = New System.Windows.Forms.ComboBox()
        Me.Label_serialPort = New System.Windows.Forms.Label()
        Me.Label_lamp = New System.Windows.Forms.Label()
        Me.Button_reset = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Check_lamp1 = New System.Windows.Forms.CheckBox()
        Me.Check_lamp2 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(355, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshPortsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RefreshPortsToolStripMenuItem
        '
        Me.RefreshPortsToolStripMenuItem.Name = "RefreshPortsToolStripMenuItem"
        Me.RefreshPortsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshPortsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RefreshPortsToolStripMenuItem.Text = "Refresh Ports"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 161)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(355, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel1.Text = "Waiting..."
        '
        'Combo_serialPort
        '
        Me.Combo_serialPort.FormattingEnabled = True
        Me.Combo_serialPort.Location = New System.Drawing.Point(184, 36)
        Me.Combo_serialPort.Name = "Combo_serialPort"
        Me.Combo_serialPort.Size = New System.Drawing.Size(159, 21)
        Me.Combo_serialPort.TabIndex = 2
        '
        'Label_serialPort
        '
        Me.Label_serialPort.AutoSize = True
        Me.Label_serialPort.Location = New System.Drawing.Point(12, 39)
        Me.Label_serialPort.Name = "Label_serialPort"
        Me.Label_serialPort.Size = New System.Drawing.Size(58, 13)
        Me.Label_serialPort.TabIndex = 5
        Me.Label_serialPort.Text = "Serial Port:"
        '
        'Label_lamp
        '
        Me.Label_lamp.AutoSize = True
        Me.Label_lamp.Location = New System.Drawing.Point(12, 67)
        Me.Label_lamp.Name = "Label_lamp"
        Me.Label_lamp.Size = New System.Drawing.Size(72, 13)
        Me.Label_lamp.TabIndex = 6
        Me.Label_lamp.Text = "Reset Lamps:"
        '
        'Button_reset
        '
        Me.Button_reset.Enabled = False
        Me.Button_reset.Location = New System.Drawing.Point(255, 124)
        Me.Button_reset.Name = "Button_reset"
        Me.Button_reset.Size = New System.Drawing.Size(88, 23)
        Me.Button_reset.TabIndex = 8
        Me.Button_reset.Text = "Reset"
        Me.Button_reset.UseVisualStyleBackColor = True
        '
        'Check_lamp1
        '
        Me.Check_lamp1.AutoSize = True
        Me.Check_lamp1.Location = New System.Drawing.Point(184, 66)
        Me.Check_lamp1.Name = "Check_lamp1"
        Me.Check_lamp1.Size = New System.Drawing.Size(61, 17)
        Me.Check_lamp1.TabIndex = 9
        Me.Check_lamp1.Text = "Lamp 1"
        Me.Check_lamp1.UseVisualStyleBackColor = True
        '
        'Check_lamp2
        '
        Me.Check_lamp2.AutoSize = True
        Me.Check_lamp2.Location = New System.Drawing.Point(184, 89)
        Me.Check_lamp2.Name = "Check_lamp2"
        Me.Check_lamp2.Size = New System.Drawing.Size(61, 17)
        Me.Check_lamp2.TabIndex = 10
        Me.Check_lamp2.Text = "Lamp 2"
        Me.Check_lamp2.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 183)
        Me.Controls.Add(Me.Check_lamp2)
        Me.Controls.Add(Me.Check_lamp1)
        Me.Controls.Add(Me.Button_reset)
        Me.Controls.Add(Me.Label_lamp)
        Me.Controls.Add(Me.Label_serialPort)
        Me.Controls.Add(Me.Combo_serialPort)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DP Lamp Reset Utility"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Combo_serialPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label_serialPort As System.Windows.Forms.Label
    Friend WithEvents Label_lamp As System.Windows.Forms.Label
    Friend WithEvents Button_reset As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Check_lamp1 As System.Windows.Forms.CheckBox
    Friend WithEvents Check_lamp2 As System.Windows.Forms.CheckBox
    Friend WithEvents RefreshPortsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
