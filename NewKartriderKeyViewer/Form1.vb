Imports System.Net.NetworkInformation
Imports System.Diagnostics
Imports System.Threading

Public Class Form1

    Public key_location As String = "dirkey"
    Public remove_border As Boolean = False
    Public always_wtop As Boolean = False
    Public bool As Boolean = False
    Public backTr As Boolean = False
    Public allTr As Boolean = False
    Public opty As Integer = 100
    Public respL As String = "Left"
    Public respR As String = "Right"
    Public respU As String = "Up"
    Public respD As String = "Down"
    Public respS As String = "ShiftKey"
    Public respC As String = "ControlKey"
    Public respA As String = "Menu"
    Public respZ As String = "Z"
    Public respRk As String = "R"
    Public shiftResp As Boolean = False
    Public keyMode = "speed"

    Dim resKeys(9) As String
    Dim tick As Integer = 0

    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If bool = True Then
            Dim sw As New Stopwatch

            sw.Start()
            My.Computer.Network.Ping("216.58.221.227")
            sw.Stop()

            info.Text = "Ping : " & sw.ElapsedMilliseconds & "ms"
        ElseIf bool = False Then
            info.Text = ""
        End If

    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim leftKey As Boolean
        Dim rightKey As Boolean
        Dim upKey As Boolean
        Dim downKey As Boolean
        Dim shiftKey As Boolean
        Dim ctrlKey As Boolean
        Dim altKey As Boolean
        Dim zKey As Boolean
        Dim rKey As Boolean

        Dim kc As KeysConverter = New KeysConverter()

        leftKey = GetAsyncKeyState(kc.ConvertFromString(respL))
        rightKey = GetAsyncKeyState(kc.ConvertFromString(respR))
        upKey = GetAsyncKeyState(kc.ConvertFromString(respU))
        downKey = GetAsyncKeyState(kc.ConvertFromString(respD))
        shiftKey = GetAsyncKeyState(kc.ConvertFromString(respS))
        ctrlKey = GetAsyncKeyState(kc.ConvertFromString(respC))
        altKey = GetAsyncKeyState(kc.ConvertFromString(respA))
        zKey = GetAsyncKeyState(kc.ConvertFromString(respZ))
        rKey = GetAsyncKeyState(kc.ConvertFromString(respRk))

        If leftKey Then
            left.Image = My.Resources.key_left_pressed
        End If
        If upKey Then
            up.Image = My.Resources.key_up_pressed
        End If
        If rightKey Then
            right.Image = My.Resources.key_right_pressed
        End If
        If downKey Then
            down.Image = My.Resources.key_down_pressed
        End If
        If shiftKey Then
            shift.Image = My.Resources.key_shift_pressed
        End If
        If ctrlKey Then
            ctrl.Image = My.Resources.key_ctrl_pressed
        End If
        If altKey Then
            alt.Image = My.Resources.key_alt_pressed
        End If
        If leftKey = False Then
            left.Image = My.Resources.key_left_normal
        End If
        If upKey = False Then
            up.Image = My.Resources.key_up_normal
        End If
        If rightKey = False Then
            right.Image = My.Resources.key_right_normal
        End If
        If downKey = False Then
            down.Image = My.Resources.key_down_normal
        End If
        If shiftKey = False Then
            shift.Image = My.Resources.key_shift_normal
        End If
        If ctrlKey = False Then
            ctrl.Image = My.Resources.key_ctrl_normal
        End If
        If altKey = False Then
            alt.Image = My.Resources.key_alt_normal
        End If

        If keyMode = "item" Then

            If zKey Then
                keyZ.Image = My.Resources.key_z_pressed
            End If
            If zKey = False Then
                keyZ.Image = My.Resources.key_z_normal
            End If

            If rKey Then
                keyR.Image = My.Resources.key_r_pressed
            End If
            If rKey = False Then
                keyR.Image = My.Resources.key_r_normal
            End If

        End If

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Menu Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim path As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath(), "keyResponse.txt")

        If System.IO.File.Exists(path) Then
            Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(path)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")
                While Not MyReader.EndOfData
                    Try
                        resKeys = MyReader.ReadFields()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "오류")
                    End Try
                End While

                Try
                    respL = New String(resKeys(0))
                    respR = New String(resKeys(1))
                    respU = New String(resKeys(2))
                    respD = New String(resKeys(3))
                    respS = New String(resKeys(4))
                    respC = New String(resKeys(5))
                    respA = New String(resKeys(6))
                    respZ = New String(resKeys(7))
                    respRk = New String(resKeys(8))
                    keyMode = New String(resKeys(9))
                Catch exc As IndexOutOfRangeException
                    MsgBox("이전 버전의 키뷰어 입니다. 기존의 keyResponse.txt 파일을 삭제해 주세요.", MsgBoxStyle.Critical, "오류")
                End Try

            End Using
        End If

        If key_location = "dirkey" Then
            left.Location = New Point(209, 95)
            up.Location = New Point(265, 39)
            right.Location = New Point(321, 95)
            down.Location = New Point(265, 95)
        End If

        If key_location = "numberpad" Then
            left.Location = New Point(213, 68)
            up.Location = New Point(262, 18)
            right.Location = New Point(311, 67)
            down.Location = New Point(263, 111)
        End If

        If keyMode = "speed" Then
            keyZ.Visible = False
            keyR.Visible = False
        ElseIf keyMode = "item" Then
            keyZ.Visible = True
            keyR.Visible = True
        End If

        If remove_border = True Then
            Me.FormBorderStyle = FormBorderStyle.None
        Else
            Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        End If

        If always_wtop = True Then
            Me.TopMost = True
        ElseIf always_wtop = False Then
            Me.TopMost = False
        End If

        Me.Activate()

    End Sub

    ' // Move Form By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Private Sub up_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles up.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim cms = New ContextMenuStrip
            Dim item1 = cms.Items.Add("설정")
            item1.Tag = 1
            AddHandler item1.Click, AddressOf menuChoice
            cms.Show(Me, e.Location)
        End If
    End Sub

    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)

        If selection = 1 Then
            Settings.Show()
        End If

    End Sub

    Public Sub MoveForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left And Me.FormBorderStyle = FormBorderStyle.None Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
End Class

