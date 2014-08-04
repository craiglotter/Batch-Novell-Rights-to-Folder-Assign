<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.startAsyncButton = New System.Windows.Forms.Button
        Me.Status_Textbox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FullErrors_Checkbox = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.InputTargetUserType_Textbox = New System.Windows.Forms.TextBox
        Me.InputTargetIOType_Textbox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.EffectiveRights_Textbox = New System.Windows.Forms.TextBox
        Me.Rights6_Checkbox = New System.Windows.Forms.CheckBox
        Me.Rights5_Checkbox = New System.Windows.Forms.CheckBox
        Me.Rights8_Checkbox = New System.Windows.Forms.CheckBox
        Me.Rights7_Checkbox = New System.Windows.Forms.CheckBox
        Me.Rights2_Checkbox = New System.Windows.Forms.CheckBox
        Me.Rights1_Checkbox = New System.Windows.Forms.CheckBox
        Me.Rights3_Checkbox = New System.Windows.Forms.CheckBox
        Me.Rights4_Checkbox = New System.Windows.Forms.CheckBox
        Me.Browse5_Button = New System.Windows.Forms.Button
        Me.InputTargetIOShort_Textbox = New System.Windows.Forms.TextBox
        Me.Browse4_Button = New System.Windows.Forms.Button
        Me.Browse3_Button = New System.Windows.Forms.Button
        Me.Browse2_Button = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.InputTargetUser_Textbox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.InputTargetIO_Textbox = New System.Windows.Forms.TextBox
        Me.Browse1_Button = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.cancelAsyncButton = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lastinputline_label = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.datelaunched_label = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.inputlines_label = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.StatusResults_RichtextBox = New System.Windows.Forms.RichTextBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'startAsyncButton
        '
        Me.startAsyncButton.Location = New System.Drawing.Point(67, 423)
        Me.startAsyncButton.Name = "startAsyncButton"
        Me.startAsyncButton.Size = New System.Drawing.Size(112, 23)
        Me.startAsyncButton.TabIndex = 15
        Me.startAsyncButton.Text = "Update"
        Me.startAsyncButton.UseVisualStyleBackColor = True
        '
        'Status_Textbox
        '
        Me.Status_Textbox.BackColor = System.Drawing.SystemColors.Control
        Me.Status_Textbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Status_Textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Status_Textbox.Location = New System.Drawing.Point(12, 12)
        Me.Status_Textbox.Name = "Status_Textbox"
        Me.Status_Textbox.ReadOnly = True
        Me.Status_Textbox.Size = New System.Drawing.Size(599, 10)
        Me.Status_Textbox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(614, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "20060331.1"
        Me.ToolTip1.SetToolTip(Me.Label1, "Application Build Number")
        '
        'FullErrors_Checkbox
        '
        Me.FullErrors_Checkbox.AutoSize = True
        Me.FullErrors_Checkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullErrors_Checkbox.Location = New System.Drawing.Point(684, 8)
        Me.FullErrors_Checkbox.Name = "FullErrors_Checkbox"
        Me.FullErrors_Checkbox.Size = New System.Drawing.Size(15, 14)
        Me.FullErrors_Checkbox.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.FullErrors_Checkbox, "Check to enable full error processing mode.")
        Me.FullErrors_Checkbox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(597, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Batch Novell Rights to Folder Assign is used to assign novell user objects specif" & _
            "ied access rights to specified folders and files."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.InputTargetUserType_Textbox)
        Me.GroupBox1.Controls.Add(Me.InputTargetIOType_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.EffectiveRights_Textbox)
        Me.GroupBox1.Controls.Add(Me.Rights6_Checkbox)
        Me.GroupBox1.Controls.Add(Me.Rights5_Checkbox)
        Me.GroupBox1.Controls.Add(Me.Rights8_Checkbox)
        Me.GroupBox1.Controls.Add(Me.Rights7_Checkbox)
        Me.GroupBox1.Controls.Add(Me.Rights2_Checkbox)
        Me.GroupBox1.Controls.Add(Me.Rights1_Checkbox)
        Me.GroupBox1.Controls.Add(Me.Rights3_Checkbox)
        Me.GroupBox1.Controls.Add(Me.Rights4_Checkbox)
        Me.GroupBox1.Controls.Add(Me.Browse5_Button)
        Me.GroupBox1.Controls.Add(Me.InputTargetIOShort_Textbox)
        Me.GroupBox1.Controls.Add(Me.Browse4_Button)
        Me.GroupBox1.Controls.Add(Me.Browse3_Button)
        Me.GroupBox1.Controls.Add(Me.Browse2_Button)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.InputTargetUser_Textbox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.InputTargetIO_Textbox)
        Me.GroupBox1.Controls.Add(Me.Browse1_Button)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(17, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 189)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'InputTargetUserType_Textbox
        '
        Me.InputTargetUserType_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.InputTargetUserType_Textbox.Location = New System.Drawing.Point(657, 85)
        Me.InputTargetUserType_Textbox.Name = "InputTargetUserType_Textbox"
        Me.InputTargetUserType_Textbox.ReadOnly = True
        Me.InputTargetUserType_Textbox.Size = New System.Drawing.Size(15, 20)
        Me.InputTargetUserType_Textbox.TabIndex = 49
        Me.InputTargetUserType_Textbox.Visible = False
        '
        'InputTargetIOType_Textbox
        '
        Me.InputTargetIOType_Textbox.BackColor = System.Drawing.SystemColors.Window
        Me.InputTargetIOType_Textbox.Location = New System.Drawing.Point(657, 19)
        Me.InputTargetIOType_Textbox.Name = "InputTargetIOType_Textbox"
        Me.InputTargetIOType_Textbox.ReadOnly = True
        Me.InputTargetIOType_Textbox.Size = New System.Drawing.Size(15, 20)
        Me.InputTargetIOType_Textbox.TabIndex = 48
        Me.InputTargetIOType_Textbox.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Effective Rights:"
        '
        'EffectiveRights_Textbox
        '
        Me.EffectiveRights_Textbox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EffectiveRights_Textbox.Location = New System.Drawing.Point(50, 152)
        Me.EffectiveRights_Textbox.Name = "EffectiveRights_Textbox"
        Me.EffectiveRights_Textbox.ReadOnly = True
        Me.EffectiveRights_Textbox.Size = New System.Drawing.Size(267, 20)
        Me.EffectiveRights_Textbox.TabIndex = 46
        Me.EffectiveRights_Textbox.Text = "[]"
        '
        'Rights6_Checkbox
        '
        Me.Rights6_Checkbox.AutoSize = True
        Me.Rights6_Checkbox.Location = New System.Drawing.Point(484, 155)
        Me.Rights6_Checkbox.Name = "Rights6_Checkbox"
        Me.Rights6_Checkbox.Size = New System.Drawing.Size(57, 17)
        Me.Rights6_Checkbox.TabIndex = 45
        Me.Rights6_Checkbox.Text = "Modify"
        Me.Rights6_Checkbox.UseVisualStyleBackColor = True
        '
        'Rights5_Checkbox
        '
        Me.Rights5_Checkbox.AutoSize = True
        Me.Rights5_Checkbox.Location = New System.Drawing.Point(484, 132)
        Me.Rights5_Checkbox.Name = "Rights5_Checkbox"
        Me.Rights5_Checkbox.Size = New System.Drawing.Size(70, 17)
        Me.Rights5_Checkbox.TabIndex = 44
        Me.Rights5_Checkbox.Text = "File Scan"
        Me.Rights5_Checkbox.UseVisualStyleBackColor = True
        '
        'Rights8_Checkbox
        '
        Me.Rights8_Checkbox.AutoSize = True
        Me.Rights8_Checkbox.Location = New System.Drawing.Point(560, 155)
        Me.Rights8_Checkbox.Name = "Rights8_Checkbox"
        Me.Rights8_Checkbox.Size = New System.Drawing.Size(97, 17)
        Me.Rights8_Checkbox.TabIndex = 43
        Me.Rights8_Checkbox.Text = "Access Control"
        Me.Rights8_Checkbox.UseVisualStyleBackColor = True
        '
        'Rights7_Checkbox
        '
        Me.Rights7_Checkbox.AutoSize = True
        Me.Rights7_Checkbox.Location = New System.Drawing.Point(560, 132)
        Me.Rights7_Checkbox.Name = "Rights7_Checkbox"
        Me.Rights7_Checkbox.Size = New System.Drawing.Size(76, 17)
        Me.Rights7_Checkbox.TabIndex = 42
        Me.Rights7_Checkbox.Text = "Supervisor"
        Me.Rights7_Checkbox.UseVisualStyleBackColor = True
        '
        'Rights2_Checkbox
        '
        Me.Rights2_Checkbox.AutoSize = True
        Me.Rights2_Checkbox.Location = New System.Drawing.Point(338, 155)
        Me.Rights2_Checkbox.Name = "Rights2_Checkbox"
        Me.Rights2_Checkbox.Size = New System.Drawing.Size(52, 17)
        Me.Rights2_Checkbox.TabIndex = 41
        Me.Rights2_Checkbox.Text = "Read"
        Me.Rights2_Checkbox.UseVisualStyleBackColor = True
        '
        'Rights1_Checkbox
        '
        Me.Rights1_Checkbox.AutoSize = True
        Me.Rights1_Checkbox.Location = New System.Drawing.Point(337, 132)
        Me.Rights1_Checkbox.Name = "Rights1_Checkbox"
        Me.Rights1_Checkbox.Size = New System.Drawing.Size(51, 17)
        Me.Rights1_Checkbox.TabIndex = 40
        Me.Rights1_Checkbox.Text = "Write"
        Me.Rights1_Checkbox.UseVisualStyleBackColor = True
        '
        'Rights3_Checkbox
        '
        Me.Rights3_Checkbox.AutoSize = True
        Me.Rights3_Checkbox.Location = New System.Drawing.Point(411, 132)
        Me.Rights3_Checkbox.Name = "Rights3_Checkbox"
        Me.Rights3_Checkbox.Size = New System.Drawing.Size(57, 17)
        Me.Rights3_Checkbox.TabIndex = 39
        Me.Rights3_Checkbox.Text = "Create"
        Me.Rights3_Checkbox.UseVisualStyleBackColor = True
        '
        'Rights4_Checkbox
        '
        Me.Rights4_Checkbox.AutoSize = True
        Me.Rights4_Checkbox.Location = New System.Drawing.Point(411, 155)
        Me.Rights4_Checkbox.Name = "Rights4_Checkbox"
        Me.Rights4_Checkbox.Size = New System.Drawing.Size(53, 17)
        Me.Rights4_Checkbox.TabIndex = 38
        Me.Rights4_Checkbox.Text = "Erase"
        Me.Rights4_Checkbox.UseVisualStyleBackColor = True
        '
        'Browse5_Button
        '
        Me.Browse5_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse5_Button.Location = New System.Drawing.Point(487, 85)
        Me.Browse5_Button.Name = "Browse5_Button"
        Me.Browse5_Button.Size = New System.Drawing.Size(82, 23)
        Me.Browse5_Button.TabIndex = 37
        Me.Browse5_Button.Text = "Single Target"
        Me.Browse5_Button.UseVisualStyleBackColor = True
        '
        'InputTargetIOShort_Textbox
        '
        Me.InputTargetIOShort_Textbox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.InputTargetIOShort_Textbox.Location = New System.Drawing.Point(124, 19)
        Me.InputTargetIOShort_Textbox.Name = "InputTargetIOShort_Textbox"
        Me.InputTargetIOShort_Textbox.ReadOnly = True
        Me.InputTargetIOShort_Textbox.Size = New System.Drawing.Size(261, 20)
        Me.InputTargetIOShort_Textbox.TabIndex = 36
        '
        'Browse4_Button
        '
        Me.Browse4_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse4_Button.Location = New System.Drawing.Point(397, 16)
        Me.Browse4_Button.Name = "Browse4_Button"
        Me.Browse4_Button.Size = New System.Drawing.Size(82, 23)
        Me.Browse4_Button.TabIndex = 35
        Me.Browse4_Button.Text = "Folder Target"
        Me.Browse4_Button.UseVisualStyleBackColor = True
        '
        'Browse3_Button
        '
        Me.Browse3_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse3_Button.Location = New System.Drawing.Point(487, 16)
        Me.Browse3_Button.Name = "Browse3_Button"
        Me.Browse3_Button.Size = New System.Drawing.Size(82, 23)
        Me.Browse3_Button.TabIndex = 34
        Me.Browse3_Button.Text = "File Target"
        Me.Browse3_Button.UseVisualStyleBackColor = True
        '
        'Browse2_Button
        '
        Me.Browse2_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse2_Button.Location = New System.Drawing.Point(575, 85)
        Me.Browse2_Button.Name = "Browse2_Button"
        Me.Browse2_Button.Size = New System.Drawing.Size(82, 23)
        Me.Browse2_Button.TabIndex = 33
        Me.Browse2_Button.Text = "List of Targets"
        Me.Browse2_Button.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Target User Accounts:"
        '
        'InputTargetUser_Textbox
        '
        Me.InputTargetUser_Textbox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.InputTargetUser_Textbox.Location = New System.Drawing.Point(136, 90)
        Me.InputTargetUser_Textbox.Name = "InputTargetUser_Textbox"
        Me.InputTargetUser_Textbox.ReadOnly = True
        Me.InputTargetUser_Textbox.Size = New System.Drawing.Size(345, 20)
        Me.InputTargetUser_Textbox.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Target File/Directory:"
        '
        'InputTargetIO_Textbox
        '
        Me.InputTargetIO_Textbox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.InputTargetIO_Textbox.Location = New System.Drawing.Point(19, 46)
        Me.InputTargetIO_Textbox.Name = "InputTargetIO_Textbox"
        Me.InputTargetIO_Textbox.ReadOnly = True
        Me.InputTargetIO_Textbox.Size = New System.Drawing.Size(638, 20)
        Me.InputTargetIO_Textbox.TabIndex = 24
        '
        'Browse1_Button
        '
        Me.Browse1_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Browse1_Button.Location = New System.Drawing.Point(575, 16)
        Me.Browse1_Button.Name = "Browse1_Button"
        Me.Browse1_Button.Size = New System.Drawing.Size(82, 23)
        Me.Browse1_Button.TabIndex = 25
        Me.Browse1_Button.Text = "List of Targets"
        Me.Browse1_Button.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(18, 465)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(97, 13)
        Me.LinkLabel1.TabIndex = 40
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "[Open Activity Log]"
        Me.LinkLabel1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 494)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(672, 23)
        Me.ProgressBar1.TabIndex = 39
        '
        'cancelAsyncButton
        '
        Me.cancelAsyncButton.Enabled = False
        Me.cancelAsyncButton.Location = New System.Drawing.Point(203, 423)
        Me.cancelAsyncButton.Name = "cancelAsyncButton"
        Me.cancelAsyncButton.Size = New System.Drawing.Size(119, 23)
        Me.cancelAsyncButton.TabIndex = 38
        Me.cancelAsyncButton.Text = "Cancel"
        Me.cancelAsyncButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lastinputline_label)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.datelaunched_label)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.inputlines_label)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(17, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 156)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation Status"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(15, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Last User Account Affected:"
        '
        'lastinputline_label
        '
        Me.lastinputline_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lastinputline_label.Location = New System.Drawing.Point(15, 76)
        Me.lastinputline_label.Name = "lastinputline_label"
        Me.lastinputline_label.Size = New System.Drawing.Size(322, 23)
        Me.lastinputline_label.TabIndex = 20
        Me.lastinputline_label.Text = "(no result)"
        Me.lastinputline_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(14, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Operational Time:"
        '
        'datelaunched_label
        '
        Me.datelaunched_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.datelaunched_label.Location = New System.Drawing.Point(15, 117)
        Me.datelaunched_label.Name = "datelaunched_label"
        Me.datelaunched_label.Size = New System.Drawing.Size(322, 23)
        Me.datelaunched_label.TabIndex = 23
        Me.datelaunched_label.Text = "(no result)"
        Me.datelaunched_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(15, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 13)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Number of Rights Adjusted:"
        '
        'inputlines_label
        '
        Me.inputlines_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inputlines_label.Location = New System.Drawing.Point(15, 36)
        Me.inputlines_label.Name = "inputlines_label"
        Me.inputlines_label.Size = New System.Drawing.Size(322, 23)
        Me.inputlines_label.TabIndex = 25
        Me.inputlines_label.Text = "(no result)"
        Me.inputlines_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Status_Textbox)
        Me.Panel1.Controls.Add(Me.FullErrors_Checkbox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 526)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 31)
        Me.Panel1.TabIndex = 42
        '
        'StatusResults_RichtextBox
        '
        Me.StatusResults_RichtextBox.BackColor = System.Drawing.SystemColors.Control
        Me.StatusResults_RichtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StatusResults_RichtextBox.ContextMenuStrip = Me.ContextMenuStrip1
        Me.StatusResults_RichtextBox.ForeColor = System.Drawing.Color.CadetBlue
        Me.StatusResults_RichtextBox.Location = New System.Drawing.Point(397, 244)
        Me.StatusResults_RichtextBox.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.StatusResults_RichtextBox.Name = "StatusResults_RichtextBox"
        Me.StatusResults_RichtextBox.ReadOnly = True
        Me.StatusResults_RichtextBox.Size = New System.Drawing.Size(292, 234)
        Me.StatusResults_RichtextBox.TabIndex = 43
        Me.StatusResults_RichtextBox.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(152, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem1.Text = "Clear Window"
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(705, 556)
        Me.Controls.Add(Me.StatusResults_RichtextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cancelAsyncButton)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.startAsyncButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(713, 590)
        Me.MinimumSize = New System.Drawing.Size(713, 590)
        Me.Name = "Main_Screen"
        Me.Text = "Batch Novell Rights to Folder Assign"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startAsyncButton As System.Windows.Forms.Button
    Friend WithEvents Status_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FullErrors_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Browse2_Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InputTargetUser_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents InputTargetIO_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Browse1_Button As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents cancelAsyncButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents lastinputline_label As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents datelaunched_label As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents inputlines_label As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents InputTargetIOShort_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Browse4_Button As System.Windows.Forms.Button
    Friend WithEvents Browse3_Button As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Rights3_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Rights4_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Browse5_Button As System.Windows.Forms.Button
    Friend WithEvents Rights6_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Rights5_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Rights8_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Rights7_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Rights2_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents Rights1_Checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents EffectiveRights_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StatusResults_RichtextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents InputTargetUserType_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents InputTargetIOType_Textbox As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
