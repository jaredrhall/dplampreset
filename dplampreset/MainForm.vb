Imports System.IO.Ports

Public Class MainForm
    'This is the container for the projector settings.
    Dim dpProjector As Projector

    ''' <summary>
    ''' This sub is called to populate the Combo_serialPort box with the list of available serial ports.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub retrieveComPorts()
        Combo_serialPort.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            Combo_serialPort.Items.Add(sp)
        Next
    End Sub

    ''' <summary>
    ''' This method initializes a Projector object with the correct settings for a Digital Projection E-Vision 800 Series projector.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initProjector()
        dpProjector = New Projector(38400, 8, StopBits.One, Parity.None)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bring this form to the foreground
        Me.Activate()

        ToolStripStatusLabel1.Text = "Retrieving COM ports..."
        'populate the list of available com ports
        retrieveComPorts()

        ToolStripStatusLabel1.Text = "Loading serial communication settings..."
        'load the serial settings for the projector
        initProjector()

        Button_reset.Enabled = True
        ToolStripStatusLabel1.Text = "Ready."
    End Sub

    ''' <summary>
    ''' This subroutine builds the confirmation box prompt based on the user selections.
    ''' </summary>
    ''' <remarks></remarks>
    Private Function buildConfirmationPrompt() As String
        Dim str As String
        Dim selectedCom As String
        Dim lamp1 As String
        Dim lamp2 As String

        If Combo_serialPort.SelectedIndex = -1 Then Throw New Exception("You must select a valid COM/Serial port to continue.")
        If Check_lamp1.Checked = False And Check_lamp2.Checked = False Then Throw New Exception("You must select at least one lamp counter to reset.")

        selectedCom = Combo_serialPort.SelectedItem
        If Check_lamp1.Checked Then lamp1 = "YES" Else lamp1 = "NO"
        If Check_lamp2.Checked Then lamp2 = "YES" Else lamp2 = "NO"

        str = "You have selected the following options:" & vbCr & vbLf
        str = str & vbCr & vbLf
        str = str & vbTab & "Serial Port:" & vbTab & selectedCom & vbCr & vbLf
        str = str & vbTab & "Reset Lamp 1:" & vbTab & lamp1 & vbCr & vbLf
        str = str & vbTab & "Reset Lamp 2:" & vbTab & lamp2 & vbCr & vbLf
        str = str & vbCr & vbLf
        str = str & "YOU ARE ABOUT TO RESET THE LISTED LAMP HOUR METERS." & vbCr & vbLf
        str = str & "PRESS OK TO CONTINUE, OR CANCEL TO ABORT."

        Return str
    End Function

    ''' <summary>
    ''' This method executes the reset based on the selected port and lamp options.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub executeReset()
        ToolStripStatusLabel1.Text = "Preparing to write settings to projector..."

        'Build strings to send
        Dim resetLamp1 As String = "op lamp1.reset " & Chr(13)
        Dim resetLamp2 As String = "op lamp2.reset " & Chr(13)
        Dim serialPortName As String = Combo_serialPort.SelectedItem

        'open serial port
        'serial.PortName = Combo_serialPort.SelectedItem
        'serial.BaudRate = dpProjector.BaudRate
        'serial.DataBits = dpProjector.DataLength
        'serial.StopBits = dpProjector.StopBits
        'serial.Parity = dpProjector.Parity
        'serial.Open()

        Using comPort As IO.Ports.SerialPort = My.Computer.Ports.OpenSerialPort(serialPortName, dpProjector.BaudRate, dpProjector.Parity, dpProjector.DataLength, dpProjector.StopBits)

            ToolStripStatusLabel1.Text = "Writing settings..."

            If Check_lamp1.Checked Then comPort.Write(resetLamp1)
            If Check_lamp2.Checked Then comPort.Write(resetLamp2)

            ToolStripStatusLabel1.Text = "Closing port..."
        End Using

        ToolStripStatusLabel1.Text = " Settings written successfully."
    End Sub

    ''' <summary>
    ''' This method cleans up the form. Once a reset operation is completed, checkboxes should be cleared, though the COM port selection can remain.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearForm()
        Check_lamp1.Checked = False
        Check_lamp2.Checked = False
    End Sub

    ''' <summary>
    ''' This method handles the Click event for the reset button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Button_reset_Click(sender As Object, e As EventArgs) Handles Button_reset.Click
        Try
            Dim result As MsgBoxResult
            result = MsgBox(buildConfirmationPrompt(), MsgBoxStyle.OkCancel, "CONFIRM RESET OPTIONS")

            If result = MsgBoxResult.Ok Then
                executeReset()
                clearForm()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    ''' <summary>
    ''' This method handles the Click event for the Refresh Ports menu item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RefreshPortsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshPortsToolStripMenuItem.Click
        ToolStripStatusLabel1.Text = "Retrieving available COM ports..."
        retrieveComPorts()
        ToolStripStatusLabel1.Text = "COM port list updated."
    End Sub

    ''' <summary>
    ''' This method handles the Click event for the Exit menu item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' This method handles the Click event for the About menu item. It opens and displays the AboutBox1 as a modal dialog window.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
