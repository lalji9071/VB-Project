<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class emsform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GaugeCircularScale2 As DevComponents.Instrumentation.GaugeCircularScale = New DevComponents.Instrumentation.GaugeCircularScale()
        Dim GradientFillColor4 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(emsform))
        Dim GaugePointer2 As DevComponents.Instrumentation.GaugePointer = New DevComponents.Instrumentation.GaugePointer()
        Dim GaugeRange2 As DevComponents.Instrumentation.GaugeRange = New DevComponents.Instrumentation.GaugeRange()
        Dim GradientFillColor5 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor()
        Dim GradientFillColor6 As DevComponents.Instrumentation.GradientFillColor = New DevComponents.Instrumentation.GradientFillColor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sample_Text = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.baud_ComboBox = New System.Windows.Forms.ComboBox()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Connect_BTN = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DisconBtn = New System.Windows.Forms.Button()
        Me.mcStatusBtn = New System.Windows.Forms.Button()
        Me.Import_Btn = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.mc1Label = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblValueHR = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.mc1lable = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gc1 = New DevComponents.Instrumentation.GaugeControl()
        Me.stopImportBtn = New System.Windows.Forms.Button()
        Me.machine1IDtxt = New System.Windows.Forms.TextBox()
        Me.backLightTimeLbl = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.gc1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 16)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Baud (Kbps) :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 16)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "COM Port"
        '
        'sample_Text
        '
        Me.sample_Text.Location = New System.Drawing.Point(247, 47)
        Me.sample_Text.Name = "sample_Text"
        Me.sample_Text.Size = New System.Drawing.Size(100, 22)
        Me.sample_Text.TabIndex = 29
        Me.sample_Text.Text = "1000"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label24.Location = New System.Drawing.Point(244, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(169, 16)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Sample Rate(Second) :"
        '
        'baud_ComboBox
        '
        Me.baud_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.baud_ComboBox.FormattingEnabled = True
        Me.baud_ComboBox.Items.AddRange(New Object() {"9600", "19200"})
        Me.baud_ComboBox.Location = New System.Drawing.Point(129, 65)
        Me.baud_ComboBox.Name = "baud_ComboBox"
        Me.baud_ComboBox.Size = New System.Drawing.Size(76, 21)
        Me.baud_ComboBox.TabIndex = 35
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(128, 31)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(69, 21)
        Me.comPort_ComboBox.TabIndex = 32
        '
        'Connect_BTN
        '
        Me.Connect_BTN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Connect_BTN.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Connect_BTN.Location = New System.Drawing.Point(12, 84)
        Me.Connect_BTN.Name = "Connect_BTN"
        Me.Connect_BTN.Size = New System.Drawing.Size(90, 37)
        Me.Connect_BTN.TabIndex = 20
        Me.Connect_BTN.Text = "CONNECT"
        Me.Connect_BTN.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.machine1IDtxt)
        Me.GroupBox2.Controls.Add(Me.DisconBtn)
        Me.GroupBox2.Controls.Add(Me.sample_Text)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Connect_BTN)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 135)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Configuration"
        '
        'DisconBtn
        '
        Me.DisconBtn.Enabled = False
        Me.DisconBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DisconBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisconBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.DisconBtn.Location = New System.Drawing.Point(117, 84)
        Me.DisconBtn.Name = "DisconBtn"
        Me.DisconBtn.Size = New System.Drawing.Size(125, 37)
        Me.DisconBtn.TabIndex = 30
        Me.DisconBtn.Text = "DISCONNECT"
        Me.DisconBtn.UseVisualStyleBackColor = True
        '
        'mcStatusBtn
        '
        Me.mcStatusBtn.Enabled = False
        Me.mcStatusBtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcStatusBtn.Location = New System.Drawing.Point(15, 154)
        Me.mcStatusBtn.Name = "mcStatusBtn"
        Me.mcStatusBtn.Size = New System.Drawing.Size(144, 37)
        Me.mcStatusBtn.TabIndex = 39
        Me.mcStatusBtn.Text = "Machine Status"
        Me.mcStatusBtn.UseVisualStyleBackColor = True
        '
        'Import_Btn
        '
        Me.Import_Btn.Enabled = False
        Me.Import_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Import_Btn.Location = New System.Drawing.Point(470, 12)
        Me.Import_Btn.Name = "Import_Btn"
        Me.Import_Btn.Size = New System.Drawing.Size(166, 26)
        Me.Import_Btn.TabIndex = 41
        Me.Import_Btn.Text = "Import to Excel or DB"
        Me.Import_Btn.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(470, 52)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(166, 95)
        Me.RichTextBox1.TabIndex = 40
        Me.RichTextBox1.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        '
        'mc1Label
        '
        Me.mc1Label.AutoSize = True
        Me.mc1Label.Location = New System.Drawing.Point(9, 63)
        Me.mc1Label.Name = "mc1Label"
        Me.mc1Label.Size = New System.Drawing.Size(57, 13)
        Me.mc1Label.TabIndex = 35
        Me.mc1Label.Text = "Machine 1"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(9, 88)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(57, 13)
        Me.Label31.TabIndex = 35
        Me.Label31.Text = "Machine 2"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 256)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 13)
        Me.Label23.TabIndex = 35
        Me.Label23.Text = "Machine 8"
        '
        'lblValueHR
        '
        Me.lblValueHR.AutoSize = True
        Me.lblValueHR.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblValueHR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValueHR.Location = New System.Drawing.Point(132, 61)
        Me.lblValueHR.Name = "lblValueHR"
        Me.lblValueHR.Size = New System.Drawing.Size(15, 16)
        Me.lblValueHR.TabIndex = 1
        Me.lblValueHR.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 228)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 13)
        Me.Label22.TabIndex = 35
        Me.Label22.Text = "Machine 7"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(9, 200)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Machine 6"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(9, 172)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 13)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Machine 5"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Machine 4"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Machine 3"
        '
        'mc1lable
        '
        Me.mc1lable.AutoSize = True
        Me.mc1lable.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mc1lable.Location = New System.Drawing.Point(108, 30)
        Me.mc1lable.Name = "mc1lable"
        Me.mc1lable.Size = New System.Drawing.Size(88, 16)
        Me.mc1lable.TabIndex = 37
        Me.mc1lable.Text = "Power(KWH)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(210, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Amp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Volt(V)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "PF"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label43)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.mc1lable)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lblValueHR)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.mc1Label)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(413, 301)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Machine Status"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(354, 254)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(15, 16)
        Me.Label45.TabIndex = 41
        Me.Label45.Text = "0"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(354, 226)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(15, 16)
        Me.Label41.TabIndex = 41
        Me.Label41.Text = "0"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(354, 197)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(15, 16)
        Me.Label37.TabIndex = 41
        Me.Label37.Text = "0"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(354, 169)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(15, 16)
        Me.Label33.TabIndex = 41
        Me.Label33.Text = "0"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(354, 141)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(15, 16)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(354, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 16)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(354, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 16)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(354, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "0"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(285, 254)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(15, 16)
        Me.Label44.TabIndex = 40
        Me.Label44.Text = "0"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(285, 226)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(15, 16)
        Me.Label40.TabIndex = 40
        Me.Label40.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(285, 197)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(15, 16)
        Me.Label36.TabIndex = 40
        Me.Label36.Text = "0"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(285, 169)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(15, 16)
        Me.Label32.TabIndex = 40
        Me.Label32.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(285, 141)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(15, 16)
        Me.Label27.TabIndex = 40
        Me.Label27.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(285, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 16)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(285, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "0"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(220, 254)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(15, 16)
        Me.Label43.TabIndex = 39
        Me.Label43.Text = "0"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(220, 226)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(15, 16)
        Me.Label39.TabIndex = 39
        Me.Label39.Text = "0"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(220, 197)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(15, 16)
        Me.Label35.TabIndex = 39
        Me.Label35.Text = "0"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(220, 169)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(15, 16)
        Me.Label30.TabIndex = 39
        Me.Label30.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(220, 141)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(15, 16)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(220, 113)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(220, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(220, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "0"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(132, 254)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(15, 16)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "0"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(132, 226)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(15, 16)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "0"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(132, 197)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(15, 16)
        Me.Label34.TabIndex = 1
        Me.Label34.Text = "0"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(132, 169)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(15, 16)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(132, 141)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(15, 16)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(132, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 16)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "0"
        '
        'gc1
        '
        GaugeCircularScale2.Labels.Layout.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!)
        GaugeCircularScale2.Labels.Layout.ScaleOffset = 0.075!
        GaugeCircularScale2.MajorTickMarks.Interval = 50.0R
        GaugeCircularScale2.MajorTickMarks.Layout.Length = 0.063!
        GaugeCircularScale2.MajorTickMarks.Layout.Width = 0.033!
        GaugeCircularScale2.MaxPin.EndOffset = 0.01!
        GaugeCircularScale2.MaxPin.Length = 0.026!
        GaugeCircularScale2.MaxPin.Name = "MaxPin"
        GaugeCircularScale2.MaxPin.ScaleOffset = -0.06!
        GaugeCircularScale2.MaxPin.Width = 0.026!
        GaugeCircularScale2.MaxValue = 300.0R
        GaugeCircularScale2.MinorTickMarks.Interval = 10.0R
        GradientFillColor4.BorderColor = System.Drawing.Color.DimGray
        GradientFillColor4.BorderWidth = 1
        GradientFillColor4.Color1 = System.Drawing.Color.LightYellow
        GaugeCircularScale2.MinorTickMarks.Layout.FillColor = GradientFillColor4
        GaugeCircularScale2.MinorTickMarks.Layout.Length = 0.042!
        GaugeCircularScale2.MinorTickMarks.Layout.Width = 0.013!
        GaugeCircularScale2.MinPin.EndOffset = 0.01!
        GaugeCircularScale2.MinPin.Length = 0.026!
        GaugeCircularScale2.MinPin.Name = "MinPin"
        GaugeCircularScale2.MinPin.ScaleOffset = -0.06!
        GaugeCircularScale2.MinPin.Width = 0.026!
        GaugeCircularScale2.Name = "Scale1"
        GaugeCircularScale2.PivotPoint = CType(resources.GetObject("GaugeCircularScale2.PivotPoint"), System.Drawing.PointF)
        GaugePointer2.CapFillColor.BorderColor = System.Drawing.Color.DimGray
        GaugePointer2.CapFillColor.BorderWidth = 1
        GaugePointer2.CapFillColor.Color1 = System.Drawing.Color.Gainsboro
        GaugePointer2.CapFillColor.Color2 = System.Drawing.Color.Silver
        GaugePointer2.FillColor.BorderColor = System.Drawing.Color.DimGray
        GaugePointer2.FillColor.BorderWidth = 1
        GaugePointer2.FillColor.Color1 = System.Drawing.Color.Black
        GaugePointer2.Name = "Pointer1"
        GaugePointer2.ScaleOffset = -0.057!
        GaugePointer2.Style = DevComponents.Instrumentation.PointerStyle.Needle
        GaugePointer2.Width = 0.032!
        GaugeCircularScale2.Pointers.AddRange(New DevComponents.Instrumentation.GaugePointer() {GaugePointer2})
        GaugeCircularScale2.Radius = 2.5!
        GaugeRange2.EndValue = 100.0R
        GaugeRange2.EndWidth = 0.07!
        GaugeRange2.FillColor.BorderColor = System.Drawing.Color.Gray
        GaugeRange2.FillColor.BorderWidth = 1
        GaugeRange2.FillColor.Color1 = System.Drawing.Color.Yellow
        GaugeRange2.FillColor.Color2 = System.Drawing.Color.Lime
        GaugeRange2.Name = "Range1"
        GaugeRange2.ScaleOffset = 0.033!
        GaugeRange2.StartValue = 0R
        GaugeRange2.StartWidth = 0.07!
        GaugeCircularScale2.Ranges.AddRange(New DevComponents.Instrumentation.GaugeRange() {GaugeRange2})
        GaugeCircularScale2.StartAngle = 240.0!
        GaugeCircularScale2.SweepAngle = 60.0!
        GaugeCircularScale2.Width = 0.011!
        Me.gc1.CircularScales.AddRange(New DevComponents.Instrumentation.GaugeCircularScale() {GaugeCircularScale2})
        Me.gc1.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GradientFillColor5.Color1 = System.Drawing.Color.Gainsboro
        GradientFillColor5.Color2 = System.Drawing.Color.DarkGray
        Me.gc1.Frame.BackColor = GradientFillColor5
        GradientFillColor6.BorderColor = System.Drawing.Color.Gainsboro
        GradientFillColor6.BorderWidth = 1
        GradientFillColor6.Color1 = System.Drawing.Color.White
        GradientFillColor6.Color2 = System.Drawing.Color.DimGray
        Me.gc1.Frame.FrameColor = GradientFillColor6
        Me.gc1.Frame.Style = DevComponents.Instrumentation.GaugeFrameStyle.Rectangular
        Me.gc1.Location = New System.Drawing.Point(431, 243)
        Me.gc1.Name = "gc1"
        Me.gc1.Size = New System.Drawing.Size(250, 83)
        Me.gc1.TabIndex = 43
        Me.gc1.Text = "GaugeControl1"
        '
        'stopImportBtn
        '
        Me.stopImportBtn.Enabled = False
        Me.stopImportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopImportBtn.Location = New System.Drawing.Point(470, 160)
        Me.stopImportBtn.Name = "stopImportBtn"
        Me.stopImportBtn.Size = New System.Drawing.Size(166, 47)
        Me.stopImportBtn.TabIndex = 44
        Me.stopImportBtn.Text = "Stop Import to Excel or DB"
        Me.stopImportBtn.UseVisualStyleBackColor = True
        '
        'machine1IDtxt
        '
        Me.machine1IDtxt.Location = New System.Drawing.Point(328, 99)
        Me.machine1IDtxt.Name = "machine1IDtxt"
        Me.machine1IDtxt.Size = New System.Drawing.Size(100, 22)
        Me.machine1IDtxt.TabIndex = 31
        Me.machine1IDtxt.Text = "10"
        '
        'backLightTimeLbl
        '
        Me.backLightTimeLbl.AutoSize = True
        Me.backLightTimeLbl.Location = New System.Drawing.Point(232, 165)
        Me.backLightTimeLbl.Name = "backLightTimeLbl"
        Me.backLightTimeLbl.Size = New System.Drawing.Size(39, 13)
        Me.backLightTimeLbl.TabIndex = 42
        Me.backLightTimeLbl.Text = "Label5"
        '
        'emsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(713, 544)
        Me.Controls.Add(Me.stopImportBtn)
        Me.Controls.Add(Me.gc1)
        Me.Controls.Add(Me.backLightTimeLbl)
        Me.Controls.Add(Me.Import_Btn)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.mcStatusBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.baud_ComboBox)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "emsform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ems"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.gc1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents sample_Text As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents baud_ComboBox As ComboBox
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents Connect_BTN As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents mcStatusBtn As Button
    Friend WithEvents Import_Btn As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DisconBtn As Button
    Friend WithEvents Timer3 As Timer
    Friend WithEvents mc1Label As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblValueHR As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents mc1lable As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gc1 As DevComponents.Instrumentation.GaugeControl
    Friend WithEvents stopImportBtn As Button
    Friend WithEvents machine1IDtxt As TextBox
    Friend WithEvents backLightTimeLbl As Label
End Class
