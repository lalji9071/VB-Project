
Public Class emsform
    Private connect As New MysqlConnect
    Dim RegisterV As Single
    Dim backlighttime As Single
    Dim thread As System.Threading.Thread
    Dim thread1 As System.Threading.Thread
    Dim thread2 As System.Threading.Thread
    Dim thread3 As System.Threading.Thread
    Dim comPORT As String
    Dim baudRATE As Integer
    Dim timeStamp As DateTime = DateTime.Now
    Dim x_date As String
    Dim RC As Integer = 0 'it must be decalred here
    Private machine1 As New ModbusConnect

    Private Sub emsform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False

        comPORT = “”
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next

        If baud_ComboBox.Items.Count > 0 Then
            baud_ComboBox.SelectedIndex = 0    ' The first item has index 0 '
        End If
    End Sub

    '====================================================================================
#Region "Functions"
    Private Async Sub Flash()
        For i = 0 To 10
            Await Task.Delay(1000)
            mc1Label.Visible = Not mc1Label.Visible
        Next
        'set .Visible to True just to be sure
        mc1Label.Visible = True
    End Sub
    Private Sub MC_Status()
        If RegisterV > 0 Then

            mc1Label.BackColor = Color.LawnGreen
            mc1Label.Font = New Font("Microsoft YaHei UI", 8, FontStyle.Bold, GraphicsUnit.Point)
            'Label.Image = Image.FromFile("C:\Images\Dock.jpg")
        Else
            mc1Label.Font = New Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point)
            mc1Label.BackColor = Color.Transparent
            lblValueHR.Text = RegisterV.ToString
        End If
    End Sub
    Private Sub MCStatus()
        Dim HoldingRegistersArray As Integer() = machine1.ReadHolregister(16384, 2)
        'set value of label with value of holding register
        'Dim rhrArray As Integer()

        RegisterV = HoldingRegistersArray(0) / 10
        MC_Status()
        lblValueHR.Text = RegisterV.ToString
        gc1.SetPointerValue("Scale1", "Pointer1", RegisterV)
    End Sub
    Private Sub DisConnectModbus()
        'modbusClient.Disconnect()
        'lblValueHR.Text = ""
        machine1.CloseConnectioin()
    End Sub
    Public Sub importXL()
        If machine1.modbsclient.Connected Then

            Dim HoldingRegistersArray As Integer() = machine1.ReadHolregister(16384, 2)
            Dim lighttime As Integer() = machine1.ReadHolregister(18954, 1)
            Dim dt As Date = Now
            Dim dtt As Date = Date.Today

            'set value of label with value of holding register
            RegisterV = HoldingRegistersArray(0) / 10

            backlighttime = lighttime(0)
            backLightTimeLbl.Text = backlighttime
            lblValueHR.Text = RegisterV.ToString
            x_date = Date.Now.ToString("dd/MM/yyyy")
            RichTextBox1.Text &= RegisterV.ToString + "V  (" + x_date + ")" + vbCrLf
            RC += 1
            If RC = 10 Then
                RichTextBox1.Clear()
                RC = 0
            End If

            Dim query As String
            query = "insert into et.ems (mc1_total_KWH) values ('" & RegisterV & "')"
            connect.addtodatabase(query)
            'Date.Now.ToString("dd/MM/yyyy HH:mm:ss")
            'range.EntireColumn.AutoFit()
            'Me.Chart1.Series("voltage").Points.AddXY(x_date, RegisterV.ToString)

        End If
    End Sub
#End Region
#Region "Timer"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        thread2 = New System.Threading.Thread(AddressOf importXL)
        thread2.Start()
        Flash()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        thread3 = New System.Threading.Thread(AddressOf MCStatus)
        thread3.Start()
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MC_Status()
    End Sub
#End Region
#Region "connet disconnect "

    Private Sub Connect_BTN_Click(sender As Object, e As EventArgs) Handles Connect_BTN.Click
        mcStatusBtn.Enabled = True
        DisconBtn.Enabled = True
        Dim machine1ID As Integer
        machine1ID = machine1IDtxt.Text
        If (comPORT <> “”) Then
            machine1.setParameter(comPORT, machine1ID, baudRATE)
            Timer1.Interval = CInt(sample_Text.Text)
            Connect_BTN.BackColor = Color.LawnGreen
            Connect_BTN.Enabled = False
            machine1.OpenConnectioin()
        Else
            MsgBox(“Select a COM port first”)
        End If
    End Sub

    Private Sub DisconBtn_Click(sender As Object, e As EventArgs) Handles DisconBtn.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Enabled = True
        Timer3.Start()

        RegisterV = 0
        gc1.SetPointerValue("Scale1", "Pointer1", RegisterV)
        Connect_BTN.Enabled = True
        machine1.CloseConnectioin()
        mcStatusBtn.Enabled = False
        DisconBtn.Enabled = False

    End Sub

    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub

    Private Sub baud_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles baud_ComboBox.SelectedIndexChanged
        baudRATE = baud_ComboBox.SelectedItem
    End Sub
#End Region
    Private Sub Import_Btn_Click(sender As Object, e As EventArgs) Handles Import_Btn.Click
        'Timer2.Stop()
        Timer2.Enabled = False
        Timer1.Enabled = True
        DisconBtn.Enabled = True
        stopImportBtn.Enabled = True
        Timer1.Start()
    End Sub
    Private Sub mcStatusBtn_Click(sender As Object, e As EventArgs) Handles mcStatusBtn.Click
        Timer2.Enabled = True
        Timer2.Start()
        Import_Btn.Enabled = True
        DisconBtn.Enabled = True

    End Sub
    Private Sub stopImportBtn_Click(sender As Object, e As EventArgs) Handles stopImportBtn.Click
        Timer1.Enabled = False
        Timer1.Stop()
    End Sub
End Class