Imports System
Imports System.IO
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms


Public Class Main_Screen


    Private lastinputline As String = ""
    Private inputlines As Long = 0
    Private statusmessage As String = ""
    Private statusresults As String = ""
    Private highestPercentageReached As Integer = 0
    Private inputlinesprecount As Long = 0
    Private datelaunched As Date = Now()
    Private pretestdone As Boolean = False
    




    Private Sub Error_Handler(ByVal ex As Exception, Optional ByVal identifier_msg As String = "")
        Try
            If ex.Message.IndexOf("Thread was being aborted") < 0 Then
                Dim Display_Message1 As New Display_Message()
                If FullErrors_Checkbox.Checked = True Then
                    Display_Message1.Message_Textbox.Text = "The Application encountered the following problem: " & vbCrLf & identifier_msg & ":" & ex.ToString
                Else
                    Display_Message1.Message_Textbox.Text = "The Application encountered the following problem: " & vbCrLf & identifier_msg & ":" & ex.Message.ToString
                End If
                Display_Message1.Timer1.Interval = 1000
                Display_Message1.ShowDialog()
                Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
                If dir.Exists = False Then
                    dir.Create()
                End If
                dir = Nothing
                Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs\" & Format(Now(), "yyyyMMdd") & "_Error_Log.txt", True)
                filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & identifier_msg & ":" & ex.ToString)
                filewriter.Flush()
                filewriter.Close()
                filewriter = Nothing
            End If
        Catch exc As Exception
            MsgBox("An error occurred in the application's error handling routine. The application will try to recover from this serious error.", MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub


    Private Sub Activity_Handler(ByVal Message As String)
        Try
            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs")
            If dir.Exists = False Then
                dir.Create()
            End If
            dir = Nothing
            Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt", True)
            filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & Message)
            filewriter.Flush()
            filewriter.Close()
            filewriter = Nothing
        Catch ex As Exception
            Error_Handler(ex, "Activity_Logger")
        End Try
    End Sub

    Private Sub Status_Handler(ByVal Message As String)
        Try
            Status_Textbox.Text = Message.ToUpper
            Status_Textbox.Select(0, 0)
        Catch ex As Exception
            Error_Handler(ex, "Status_Handler")
        End Try
    End Sub


    Private Sub Status_Results_Handler(ByVal Message As String)
        Try
            If Message.Length > 0 Then
                StatusResults_RichtextBox.AppendText(Message & vbCrLf)
                Status_Textbox.Select(StatusResults_RichtextBox.Text.Length, 0)
            End If
        Catch ex As Exception
            Error_Handler(ex, "Status_Results_Handler")
        End Try
    End Sub

    'Private Sub InputFolder_Textbox_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputTargetIO_Textbox.DragEnter, InputTargetUser_Textbox.DragEnter
    '    Try
    '        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
    '            e.Effect = DragDropEffects.All
    '        End If
    '    Catch ex As Exception
    '        Error_Handler(ex)
    '    End Try
    'End Sub

    'Private Sub InputFolder_Textbox_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputTargetIO_Textbox.DragDrop, InputTargetUser_Textbox.DragDrop
    '    Try

    '        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
    '            Dim MyFiles() As String
    '            ' Assign the files to an array.
    '            MyFiles = e.Data.GetData(DataFormats.FileDrop)
    '            ' Loop through the array and add the files to the list.
    '            'For i = 0 To MyFiles.Length - 1
    '            If MyFiles.Length > 0 Then
    '                Dim dinfo As FileInfo = New FileInfo(MyFiles(0))
    '                If dinfo.Exists = True Then

    '                    If sender.Equals(InputTargetUser_Textbox) = True Then
    '                        InputTargetUser_Textbox.Text = (MyFiles(0))
    '                    End If
    '                    If sender.Equals(InputTargetIO_Textbox) = True Then
    '                        InputTargetIO_Textbox.Text = (MyFiles(0))
    '                    End If
    '                End If
    '                dinfo = Nothing
    '            End If
    '            'Next
    '        End If
    '    Catch ex As Exception
    '        Error_Handler(ex, "InputFolder_Textbox DragDrop")
    '    End Try
    'End Sub


    Private Sub Browse1_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse1_Button.Click
        Status_Handler("Selecting Folder/File List Input File")
        Try
            OpenFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
            OpenFileDialog1.FileName = ""
            If InputTargetIOType_Textbox.Text = "3" Then
                If File_Exists(InputTargetIO_Textbox.Text) = True Then
                    OpenFileDialog1.FileName = InputTargetIO_Textbox.Text
                End If
            End If

            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                InputTargetIO_Textbox.Text = OpenFileDialog1.FileName
            End If
            InputTargetIOType_Textbox.Text = "3"
        Catch ex As Exception
            Error_Handler(ex, "Browse1_Button_Click")
        End Try
        Status_Handler("Folder/File List Input File Selected")
    End Sub

    Private Sub Browse2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse2_Button.Click
        Status_Handler("Selecting User Accounts Input File")
        Try
            OpenFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
            OpenFileDialog1.FileName = ""
            If InputTargetUserType_Textbox.Text = "2" Then
                If File_Exists(InputTargetUser_Textbox.Text) = True Then
                    OpenFileDialog1.FileName = InputTargetUser_Textbox.Text
                End If
            End If

            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                InputTargetUser_Textbox.Text = OpenFileDialog1.FileName
            End If
            InputTargetUserType_Textbox.Text = "2"
        Catch ex As Exception
            Error_Handler(ex, "Browse2_Button")
        End Try
        Status_Handler("User Accounts Input File Selected")
    End Sub

    Private Function File_Exists(ByVal file_path As String) As Boolean
        Dim result As Boolean = False
        Try
            If Not file_path = "" And Not file_path Is Nothing Then
                Dim dinfo As FileInfo = New FileInfo(file_path)
                If dinfo.Exists = False Then
                    result = False
                Else
                    result = True
                End If
                dinfo = Nothing
            End If
        Catch ex As Exception
            Error_Handler(ex, "File_Exists")
        End Try
        Return result
    End Function

    Private Function Directory_Exists(ByVal directory_path As String) As Boolean
        Dim result As Boolean = False
        Try
            If Not directory_path = "" And Not directory_path Is Nothing Then
                Dim dinfo As DirectoryInfo = New DirectoryInfo(directory_path)
                If dinfo.Exists = False Then
                    result = False
                Else
                    result = True
                End If
                dinfo = Nothing
            End If
        Catch ex As Exception
            Error_Handler(ex, "Directory_Exists")
        End Try
        Return result
    End Function


    Private Sub Main_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            InputTargetIOShort_Textbox.Text = My.Settings.InputTargetIOShort_Textbox
            InputTargetIOShort_Textbox.Select(0, 0)

            InputTargetIO_Textbox.Text = My.Settings.InputTargetIO_Textbox
            InputTargetIO_Textbox.Select(0, 0)

            InputTargetUser_Textbox.Text = My.Settings.InputTargetUser_Textbox
            InputTargetUser_Textbox.Select(0, 0)

            InputTargetIOType_Textbox.Text = My.Settings.InputTargetIOType_Textbox
            InputTargetIOType_Textbox.Select(0, 0)

            InputTargetUserType_Textbox.Text = My.Settings.InputTargetUserType_Textbox
            InputTargetUserType_Textbox.Select(0, 0)

            Select Case My.Settings.FullErrors_Checkbox
                Case True
                    FullErrors_Checkbox.Checked = True
                    Exit Select
                Case False
                    FullErrors_Checkbox.Checked = False
                    Exit Select
                Case Else
                    FullErrors_Checkbox.Checked = True
                    Exit Select
            End Select


        Catch ex As Exception
            Error_Handler(ex, "Main_Screen_Load")
        End Try
    End Sub

    Private Sub Main_Screen_Close(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            My.Settings.FullErrors_Checkbox = FullErrors_Checkbox.Checked

            My.Settings.InputTargetIOShort_Textbox = InputTargetIOShort_Textbox.Text
            My.Settings.InputTargetIO_Textbox = InputTargetIO_Textbox.Text
            My.Settings.InputTargetUser_Textbox = InputTargetUser_Textbox.Text
            My.Settings.InputTargetIOType_Textbox = InputTargetIOType_Textbox.Text
            My.Settings.InputTargetUserType_Textbox = InputTargetUserType_Textbox.Text
            
            My.Settings.Save()
        Catch ex As Exception
            Error_Handler(ex, "Main_Screen_Close")
        End Try

    End Sub






    Private Sub Rights_Checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rights1_Checkbox.CheckedChanged, Rights2_Checkbox.CheckedChanged, Rights3_Checkbox.CheckedChanged, Rights4_Checkbox.CheckedChanged, Rights5_Checkbox.CheckedChanged, Rights6_Checkbox.CheckedChanged, Rights7_Checkbox.CheckedChanged, Rights8_Checkbox.CheckedChanged
        Try
            Dim result As String = "["
            If Rights1_Checkbox.Checked = True Then
                result = result & "W"
            End If
            If Rights2_Checkbox.Checked = True Then
                result = result & "R"
            End If
            If Rights3_Checkbox.Checked = True Then
                result = result & "C"
            End If
            If Rights4_Checkbox.Checked = True Then
                result = result & "E"
            End If
            If Rights5_Checkbox.Checked = True Then
                result = result & "F"
            End If
            If Rights6_Checkbox.Checked = True Then
                result = result & "M"
            End If
            If Rights7_Checkbox.Checked = True Then
                result = result & "S"
            End If
            If Rights8_Checkbox.Checked = True Then
                result = result & "A"
            End If
            result = result & "]"
            EffectiveRights_Textbox.Text = result
        Catch ex As Exception
            Error_Handler(ex, "Rights_Checkbox_CheckedChanged")
        End Try
    End Sub

    Private Sub InputTargetIO_Textbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputTargetIO_Textbox.TextChanged
        Try
            InputTargetIOShort_Textbox.Text = (InputTargetIO_Textbox.Text.Substring(InputTargetIO_Textbox.Text.LastIndexOf("\"), InputTargetIO_Textbox.Text.Length - InputTargetIO_Textbox.Text.LastIndexOf("\"))).Substring(1)
        Catch ex As Exception
            Error_Handler(ex, "InputTargetIO_Textbox_TextChanged")
        End Try
    End Sub

    Private Sub Browse5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse5_Button.Click
        Status_Handler("Selecting User Account to Alter")
        Try
            Dim inputrequest As Text_Input_Dialog = New Text_Input_Dialog
            If InputTargetUserType_Textbox.Text = "1" Then
                If Not InputTargetUser_Textbox.Text = "" Then
                    inputrequest.UserInput.Text = InputTargetUser_Textbox.Text
                Else
                    inputrequest.UserInput.Text = "E.g.: .A-TEMP001.Students.com.main.uct"
                End If
            Else
                inputrequest.UserInput.Text = "E.g.: .A-TEMP001.Students.com.main.uct"
            End If
            Dim result As DialogResult = inputrequest.ShowDialog
            If result = Windows.Forms.DialogResult.OK Then
                InputTargetUser_Textbox.Text = inputrequest.UserInput.Text
            End If
            inputrequest = Nothing
            InputTargetUserType_Textbox.Text = "1"
        Catch ex As Exception
            Error_Handler(ex, "Browse5_Button_Click")
        End Try
        Status_Handler("User Account to Alter Selected")
    End Sub


    Private Sub EffectiveRights_Textbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EffectiveRights_Textbox.TextChanged
        Status_Handler("Effective Rights to Apply Altered")
    End Sub

    Private Sub FullErrors_Checkbox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullErrors_Checkbox.CheckedChanged
        Status_Handler("Error Level Reporting Altered")
    End Sub

    Private Sub Browse3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse3_Button.Click
        Status_Handler("Selecting Target File")
        Try
            OpenFileDialog1.Filter = "All Files|*.*"
            OpenFileDialog1.FileName = ""
            If InputTargetIOType_Textbox.Text = "2" Then
                If File_Exists(InputTargetIO_Textbox.Text) = True Then
                    OpenFileDialog1.FileName = InputTargetIO_Textbox.Text
                End If
            End If

            Dim result As DialogResult = OpenFileDialog1.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                InputTargetIO_Textbox.Text = OpenFileDialog1.FileName
            End If
            InputTargetIOType_Textbox.Text = "2"
        Catch ex As Exception
            Error_Handler(ex, "Browse3_Button_Click")
        End Try
        Status_Handler("Target File Selected")
    End Sub

    Private Sub Browse4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse4_Button.Click
        Status_Handler("Selecting Target Folder")
        Try
            FolderBrowserDialog1.ShowNewFolderButton = True
            FolderBrowserDialog1.Description = "Select Folder"

            If InputTargetIOType_Textbox.Text = "1" Then
                If Directory_Exists(InputTargetIO_Textbox.Text) = True Then
                    FolderBrowserDialog1.SelectedPath = InputTargetIO_Textbox.Text
                End If
            End If

            Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then
                InputTargetIO_Textbox.Text = FolderBrowserDialog1.SelectedPath
            End If
            InputTargetIOType_Textbox.Text = "1"
        Catch ex As Exception
            Error_Handler(ex, "Browse4_Button_Click")
        End Try
        Status_Handler("Target Folder Selected")
    End Sub


    Private Sub startAsyncButton_Click(ByVal sender As System.Object, _
     ByVal e As System.EventArgs) _
     Handles startAsyncButton.Click

        Try
            statusmessage = "Initializing Application for Operation Launch"
            Status_Handler(statusmessage)

            ' Reset the text in the result label.

            inputlines_label.Text = [String].Empty
            lastinputline_label.Text = [String].Empty
            datelaunched_label.Text = [String].Empty


            inputlines = 0
            lastinputline = ""
            statusmessage = ""
            highestPercentageReached = 0
            inputlinesprecount = 0
            datelaunched = Now()
            pretestdone = False


            Controls_Enabler("run")


            ' Start the asynchronous operation.
            Me.LinkLabel1.Visible = True
            BackgroundWorker1.RunWorkerAsync(InputTargetUser_Textbox.Text)

        Catch ex As Exception
            Error_Handler(ex, "startAsyncButton_Click")
        End Try
    End Sub 'startAsyncButton_Click


    Private Sub cancelAsyncButton_Click( _
    ByVal sender As System.Object, _
    ByVal e As System.EventArgs) _
    Handles cancelAsyncButton.Click

        ' Cancel the asynchronous operation.
        Me.backgroundWorker1.CancelAsync()

        ' Disable the Cancel button.
        cancelAsyncButton.Enabled = False

    End Sub 'cancelAsyncButton_Click

    ' This event handler is where the actual work is done.
    Private Sub backgroundWorker1_DoWork( _
    ByVal sender As Object, _
    ByVal e As DoWorkEventArgs) _
    Handles BackgroundWorker1.DoWork

        ' Get the BackgroundWorker object that raised this event.
        Dim worker As BackgroundWorker = _
            CType(sender, BackgroundWorker)

        ' Assign the result of the computation
        ' to the Result property of the DoWorkEventArgs
        ' object. This is will be available to the 
        ' RunWorkerCompleted eventhandler.
        e.Result = MainWorkerFunction(worker, e)
    End Sub 'backgroundWorker1_DoWork

    ' This event handler deals with the results of the
    ' background operation.
    Private Sub backgroundWorker1_RunWorkerCompleted( _
    ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) _
    Handles BackgroundWorker1.RunWorkerCompleted

        ' First, handle the case where an exception was thrown.
        If Not (e.Error Is Nothing) Then
            Error_Handler(e.Error, "backgroundWorker1_RunWorkerCompleted")
        ElseIf e.Cancelled Then
            ' Next, handle the case where the user canceled the 
            ' operation.
            ' Note that due to a race condition in 
            ' the DoWork event handler, the Cancelled
            ' flag may not have been set, even though
            ' CancelAsync was called.
            Me.ProgressBar1.Value = 0
            inputlines_label.Text = "Cancelled"
            lastinputline_label.Text = "Cancelled"
            datelaunched_label.Text = "Cancelled"
            statusmessage = "Operation Cancelled"
        Else
            ' Finally, handle the case where the operation succeeded.

            Status_Handler(e.Result)

            Me.ProgressBar1.Value = 100
            Me.inputlines_label.Text = inputlines
            Me.lastinputline_label.Text = lastinputline
            Me.datelaunched_label.Text = Format(datelaunched, "yyyy/MM/dd HH:mm:ss") & " - " & Format(Now, "yyyy/MM/dd HH:mm:ss") & " (" & Now.Subtract(Me.datelaunched).TotalSeconds() & " s)"
            Me.LinkLabel1.Visible = True
            statusmessage = "Operation Completed"
        End If

        Status_Handler(statusmessage)
        Controls_Enabler("stop")

    End Sub 'backgroundWorker1_RunWorkerCompleted

    Private Sub Controls_Enabler(ByVal action As String)
        Select Case action.ToLower
            Case "run"
                Me.InputTargetIOShort_Textbox.Enabled = False
                Me.InputTargetIO_Textbox.Enabled = False
                Me.InputTargetUser_Textbox.Enabled = False
                Me.InputTargetIOType_Textbox.Enabled = False
                Me.InputTargetUserType_Textbox.Enabled = False

                Me.Browse1_Button.Enabled = False
                Me.Browse2_Button.Enabled = False
                Me.Browse3_Button.Enabled = False
                Me.Browse4_Button.Enabled = False
                Me.Browse5_Button.Enabled = False

                Rights1_Checkbox.Enabled = False
                Rights2_Checkbox.Enabled = False
                Rights3_Checkbox.Enabled = False
                Rights4_Checkbox.Enabled = False
                Rights5_Checkbox.Enabled = False
                Rights6_Checkbox.Enabled = False
                Rights7_Checkbox.Enabled = False
                Rights8_Checkbox.Enabled = False

                Me.startAsyncButton.Enabled = False
                Me.LinkLabel1.Enabled = False
                ' Disable the Cancel button.
                Me.cancelAsyncButton.Enabled = True
                Exit Select
            Case "stop"
                Me.InputTargetIOShort_Textbox.Enabled = True
                Me.InputTargetIO_Textbox.Enabled = True
                Me.InputTargetUser_Textbox.Enabled = True
                Me.InputTargetIOType_Textbox.Enabled = True
                Me.InputTargetUserType_Textbox.Enabled = True


                Me.Browse1_Button.Enabled = True
                Me.Browse2_Button.Enabled = True
                Me.Browse3_Button.Enabled = True
                Me.Browse4_Button.Enabled = True
                Me.Browse5_Button.Enabled = True

                Rights1_Checkbox.Enabled = True
                Rights2_Checkbox.Enabled = True
                Rights3_Checkbox.Enabled = True
                Rights4_Checkbox.Enabled = True
                Rights5_Checkbox.Enabled = True
                Rights6_Checkbox.Enabled = True
                Rights7_Checkbox.Enabled = True
                Rights8_Checkbox.Enabled = True

                Me.startAsyncButton.Enabled = True
                Me.LinkLabel1.Enabled = True
                ' Disable the Cancel button.
                Me.cancelAsyncButton.Enabled = False
                Exit Select
            Case Else
                Me.InputTargetIOShort_Textbox.Enabled = False
                Me.InputTargetIO_Textbox.Enabled = False
                Me.InputTargetUser_Textbox.Enabled = False
                Me.InputTargetIOType_Textbox.Enabled = False
                Me.InputTargetUserType_Textbox.Enabled = False


                Me.Browse1_Button.Enabled = False
                Me.Browse2_Button.Enabled = False
                Me.Browse3_Button.Enabled = False
                Me.Browse4_Button.Enabled = False
                Me.Browse5_Button.Enabled = False

                Rights1_Checkbox.Enabled = False
                Rights2_Checkbox.Enabled = False
                Rights3_Checkbox.Enabled = False
                Rights4_Checkbox.Enabled = False
                Rights5_Checkbox.Enabled = False
                Rights6_Checkbox.Enabled = False
                Rights7_Checkbox.Enabled = False
                Rights8_Checkbox.Enabled = False

                Me.startAsyncButton.Enabled = False
                Me.LinkLabel1.Enabled = False
                ' Disable the Cancel button.
                Me.cancelAsyncButton.Enabled = True
                Exit Select
        End Select


    End Sub

    ' This event handler updates the progress bar.
    Private Sub backgroundWorker1_ProgressChanged( _
    ByVal sender As Object, ByVal e As ProgressChangedEventArgs) _
    Handles BackgroundWorker1.ProgressChanged

        Me.ProgressBar1.Value = e.ProgressPercentage
        inputlines_label.Text = inputlines
        lastinputline_label.Text = lastinputline

        datelaunched_label.Text = Format(datelaunched, "yyyy/MM/dd HH:mm:ss") & " - " & Format(Now, "yyyy/MM/dd HH:mm:ss") & " (" & Now.Subtract(Me.datelaunched).TotalSeconds() & " s)"
        If statusresults.Length > 0 Then
            Status_Results_Handler(statusresults)
        End If
        If statusmessage.Length > 0 Then
            Status_Handler(statusmessage)
        End If
        statusresults = ""
        statusmessage = ""
    End Sub

    ' This is the method that does the actual work. 
    Function MainWorkerFunction(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As String

        Dim result As String = ""

        ' Abort the operation if the user has canceled.
        ' Note that a call to CancelAsync may have set 
        ' CancellationPending to true just after the
        ' last invocation of this method exits, so this 
        ' code will not have the opportunity to set the 
        ' DoWorkEventArgs.Cancel flag to true. This means
        ' that RunWorkerCompletedEventArgs.Cancelled will
        ' not be set to true in your RunWorkerCompleted
        ' event handler. This is a race condition.
        If worker.CancellationPending Then
            e.Cancel = True
        End If

        If Me.pretestdone = False Then
            statusmessage = "Calculating Operation Parameters"
            worker.ReportProgress(0)
            PreCount_Function()
            Me.pretestdone = True

        End If

        If worker.CancellationPending Then
            e.Cancel = True
        End If


        Dim usercount As Long = 1
        Dim users As ArrayList = New ArrayList
        Select Case InputTargetUserType_Textbox.Text
            Case "1"
                users.Add(InputTargetUser_Textbox.Text)
                usercount = 1
                Exit Select
            Case "2"
                If File_Exists(InputTargetUser_Textbox.Text) = True Then
                    Dim filereader As StreamReader = New StreamReader(InputTargetUser_Textbox.Text)
                    While filereader.Peek > -1
                        Dim lineread As String
                        lineread = filereader.ReadLine
                        If lineread.Length > 0 Then
                            users.Add(lineread)
                            usercount = usercount + 1
                        End If
                    End While
                    filereader.Close()
                End If
                Exit Select
        End Select

        For Each useracc As String In users
            useracc = ("." & useracc).Replace("..", ".")
            lastinputline = useracc
            If worker.CancellationPending Then
                e.Cancel = True
                users.Clear()
                users = Nothing
                Exit For
            End If

            Dim targets As ArrayList = New ArrayList
            Dim targetcount As Long = 1
            Select Case InputTargetIOType_Textbox.Text
                Case "1"
                    targetcount = 1
                    targets.Add(InputTargetIO_Textbox.Text)
                    Exit Select
                Case "2"
                    targetcount = 1
                    targets.Add(InputTargetIO_Textbox.Text)
                    Exit Select
                Case "3"
                    If File_Exists(InputTargetIO_Textbox.Text) = True Then
                        Dim filereader As StreamReader = New StreamReader(InputTargetIO_Textbox.Text)
                        While filereader.Peek > -1
                            Dim lineread As String
                            lineread = filereader.ReadLine
                            If lineread.Length > 0 Then
                                targets.Add(lineread)
                                targetcount = targetcount + 1
                            End If
                        End While
                        filereader.Close()
                    End If
                    Exit Select
            End Select
            For Each targetacc As String In targets
                If worker.CancellationPending Then
                    e.Cancel = True
                    targets.Clear()
                    targets = Nothing
                    Exit For
                End If
                If File_Exists((Application.StartupPath & "\SETTRUST.exe").Replace("\\", "\")) = True Then

                    Dim apptorun As String = """" & (Application.StartupPath & "\SETTRUST.exe").Replace("\\", "\") & """"
                    Dim apptorunArgs As String = """" & targetacc & """ " & EffectiveRights_Textbox.Text & " " & useracc
                    statusresults = ApplicationLauncher(apptorun, apptorunArgs).Trim.Replace(vbCrLf, " ")
                    Activity_Handler(statusresults.Trim.Trim.Replace(vbCrLf, " "))
                    inputlines = inputlines + 1
                End If
                ' Report progress as a percentage of the total task.
                Dim percentComplete As Integer = 0
                If inputlinesprecount > 0 Then
                    percentComplete = CSng(inputlines) / CSng(inputlinesprecount) * 100
                Else
                    percentComplete = 100
                End If

                If percentComplete > highestPercentageReached Then
                    highestPercentageReached = percentComplete
                    statusmessage = "Assigning Rights"
                    worker.ReportProgress(percentComplete)
                End If

            Next
            targets.Clear()
            targets = Nothing
        Next
        users.Clear()
        users = Nothing

     



   




        Return result

    End Function

    Private Sub PreCount_Function()
        Try
            Dim targetcount As Long = 1
            Select Case InputTargetIOType_Textbox.Text
                Case "1"
                    targetcount = 1
                    Exit Select
                Case "2"
                    targetcount = 1
                    Exit Select
                Case "3"
                    If File_Exists(InputTargetIO_Textbox.Text) = True Then
                        Dim filereader As StreamReader = New StreamReader(InputTargetIO_Textbox.Text)
                        While filereader.Peek > -1
                            Dim lineread As String
                            lineread = filereader.ReadLine
                            If lineread.Length > 0 Then
                                targetcount = targetcount + 1
                            End If
                        End While
                        filereader.Close()
                    End If
                    Exit Select
            End Select


            Dim usercount As Long = 1
            Select Case InputTargetUserType_Textbox.Text
                Case "1"
                    usercount = 1
                    Exit Select
                Case "2"
                    If File_Exists(InputTargetUser_Textbox.Text) = True Then
                        Dim filereader As StreamReader = New StreamReader(InputTargetUser_Textbox.Text)
                        While filereader.Peek > -1
                            Dim lineread As String
                            lineread = filereader.ReadLine
                            If lineread.Length > 0 Then
                                usercount = usercount + 1
                            End If
                        End While
                        filereader.Close()
                    End If
                    Exit Select
            End Select

            inputlinesprecount = usercount * targetcount


        Catch ex As Exception
            Error_Handler(ex, "PreCount_Function")
        End Try
    End Sub






    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            If File_Exists((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt") = True Then
                Dim systemDirectory As String
                systemDirectory = System.Environment.SystemDirectory
                Dim finfo As FileInfo = New FileInfo((systemDirectory & "\notepad.exe").Replace("\\", "\"))
                If finfo.Exists = True Then
                    Dim apptorun As String
                    apptorun = """" & (systemDirectory & "\notepad.exe").Replace("\\", "\") & """ """ & (Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt" & """"
                    Dim procID As Integer = Shell(apptorun, AppWinStyle.NormalFocus, False)
                End If
                finfo = Nothing
            End If
        Catch ex As Exception
            Error_Handler(ex, "LinkLabel1_LinkClicked")
        End Try
    End Sub










    Private Function DosShellCommand(ByVal AppToRun As String) As String
        Dim s As String = ""
        Try
            Dim myProcess As Process = New Process

            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False


            Dim sErr As StreamReader
            Dim sOut As StreamReader
            Dim sIn As StreamWriter


            myProcess.StartInfo.CreateNoWindow = True

            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.StartInfo.RedirectStandardError = True

            'myProcess.StartInfo.FileName = AppToRun

            myProcess.Start()
            sIn = myProcess.StandardInput
            sIn.AutoFlush = True

            sOut = myProcess.StandardOutput()
            sErr = myProcess.StandardError

            sIn.Write(AppToRun & System.Environment.NewLine)
            sIn.Write("exit" & System.Environment.NewLine)
            s = sOut.ReadToEnd()

            If Not myProcess.HasExited Then
                myProcess.Kill()
            End If



            sIn.Close()
            sOut.Close()
            sErr.Close()
            myProcess.Close()


        Catch ex As Exception
            Error_Handler(ex, "DosShellCommand")
        End Try

        Return s
    End Function

    Private Function ApplicationLauncher(ByVal AppToRun As String, ByVal apptorunArgs As String) As String
        Dim s As String = ""
        Try
            Dim myProcess As Process = New Process


            myProcess.StartInfo.UseShellExecute = False


            Dim sErr As StreamReader
            Dim sOut As StreamReader
            Dim sIn As StreamWriter


            myProcess.StartInfo.CreateNoWindow = True

            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.StartInfo.RedirectStandardError = True

            myProcess.StartInfo.FileName = AppToRun
            myProcess.StartInfo.Arguments = apptorunArgs

            myProcess.Start()
            sIn = myProcess.StandardInput
            sIn.AutoFlush = True

            sOut = myProcess.StandardOutput()
            sErr = myProcess.StandardError

            sIn.Write(AppToRun & System.Environment.NewLine)
            sIn.Write("exit" & System.Environment.NewLine)
            s = sOut.ReadToEnd()

            If Not myProcess.HasExited Then
                myProcess.Kill()
            End If

            sIn.Close()
            sOut.Close()
            sErr.Close()
            myProcess.Close()


        Catch ex As Exception
            Error_Handler(ex, "ApplicationLauncher")
        End Try
        Return s
    End Function


    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        StatusResults_RichtextBox.Clear()
    End Sub
End Class
