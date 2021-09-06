Public Class Settings


    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Form1.key_location = "numberpad" Then
            radio_num.Checked = True
        ElseIf Form1.key_location = "dirkey" Then
            radio_dir.Checked = True
        End If

        If Form1.keyMode = "speed" Then
            speedMode.Checked = True
        ElseIf Form1.keyMode = "item" Then
            itemMode.Checked = True
        End If

        If Form1.remove_border = True Then
            remove_border.Checked = True
        ElseIf Form1.remove_border = False Then
            remove_border.Checked = False
        End If

        If Form1.always_wtop = True Then
            always_top.Checked = True
        ElseIf Form1.always_wtop = False Then
            always_top.Checked = False
        End If

        If Form1.bool = True Then
            showPing.Checked = True
        ElseIf Form1.bool = False Then
            showPing.Checked = False
        End If

        If Form1.shift.Visible = False Then
            hideSC.Checked = True
        ElseIf Form1.shift.Visible = True Then
            hideSC.Checked = False
        End If

        defaultWindow.Checked = True

        If Form1.backTr = True Then
            back_tr.Checked = True
        End If

        If Form1.allTr = True Then
            all_Tr.Checked = True
        End If

        leftBox.Text = Form1.respL
        rightBox.Text = Form1.respR
        upBox.Text = Form1.respU
        downBox.Text = Form1.respD
        shiftBox.Text = Form1.respS
        ctrlBox.Text = Form1.respC
        altBox.Text = Form1.respA
        zBox.Text = Form1.respZ
        rBox.Text = Form1.respRk

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click

        If radio_num.Checked = True And radio_dir.Checked = False Then
            Form1.key_location = "numberpad"
            Form1.keyZ.Location = New Point(145, 9)
            Form1.keyR.Location = New Point(201, 9)
        ElseIf radio_dir.Checked = True And radio_num.Checked = False Then
            Form1.key_location = "dirkey"
            Form1.keyZ.Location = New Point(145, 39)
            Form1.keyR.Location = New Point(201, 39)
        End If

        If speedMode.Checked = True And itemMode.Checked = False Then
            Form1.keyMode = "speed"
            Form1.keyZ.Visible = False
            Form1.keyR.Visible = False
        ElseIf itemMode.Checked = True And speedMode.Checked = False Then
            Form1.keyMode = "item"
            Form1.keyZ.Visible = True
            Form1.keyR.Visible = True
        End If

        If remove_border.Checked = True Then
            Form1.remove_border = True
        ElseIf remove_border.Checked = False Then
            Form1.remove_border = False
        End If

        If always_top.Checked = True Then
            Form1.always_wtop = True
        ElseIf always_top.Checked = False Then
            Form1.always_wtop = False
        End If

        If Form1.key_location = "dirkey" Then
            Form1.left.Location = New Point(209, 95)
            Form1.up.Location = New Point(265, 39)
            Form1.right.Location = New Point(321, 95)
            Form1.down.Location = New Point(265, 95)
        End If

        If Form1.key_location = "numberpad" Then
            Form1.left.Location = New Point(213, 68)
            Form1.up.Location = New Point(262, 18)
            Form1.right.Location = New Point(311, 67)
            Form1.down.Location = New Point(263, 111)
        End If

        If Form1.remove_border = True Then
            Form1.FormBorderStyle = FormBorderStyle.None
        Else
            Form1.FormBorderStyle = FormBorderStyle.FixedToolWindow
        End If

        If Form1.always_wtop = True Then
            Form1.TopMost = True
        ElseIf Form1.always_wtop = False Then
            Form1.TopMost = False

        End If

        If defaultWindow.Checked = True Then
            Form1.BackColor = Color.WhiteSmoke
            Form1.TransparencyKey = Color.Silver
            Form1.backTr = False
            Form1.allTr = False
            Form1.info.Visible = True
        End If

        If back_tr.Checked = True Then
            Form1.BackColor = Color.WhiteSmoke
            Form1.TransparencyKey = Color.WhiteSmoke
            Form1.backTr = True
            Form1.allTr = False
            Form1.info.Visible = False
        End If

        If all_Tr.Checked = True Then
            Form1.BackColor = Color.FromArgb(215, 215, 215)
            Form1.TransparencyKey = Color.FromArgb(215, 215, 215)
            Form1.backTr = False
            Form1.allTr = True
            Form1.info.Visible = False
        End If

        If showPing.Checked = True Then
            Form1.bool = True
        ElseIf showPing.Checked = False Then
            Form1.bool = False
        End If

        If hideSC.Checked = True Then
            Form1.shift.Visible = False
            Form1.ctrl.Visible = False
            Form1.alt.Visible = False
        ElseIf hideSC.Checked = False Then
            Form1.shift.Visible = True
            Form1.ctrl.Visible = True
            Form1.alt.Visible = True
        End If

        Dim str As String = leftBox.Text & "," & rightBox.Text & "," & upBox.Text & "," & downBox.Text & "," & shiftBox.Text & "," & ctrlBox.Text & "," & altBox.Text & "," & zBox.Text & "," & rBox.Text & "," & Form1.keyMode

        My.Computer.FileSystem.WriteAllText(System.IO.Path.Combine(My.Application.Info.DirectoryPath(), "keyResponse.txt"), str, False)

        Form1.respL = leftBox.Text
        Form1.respR = rightBox.Text
        Form1.respU = upBox.Text
        Form1.respD = downBox.Text
        Form1.respS = shiftBox.Text
        Form1.respC = ctrlBox.Text

        Me.Close()

    End Sub

    Private Sub leftBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles leftBox.KeyDown
        Dim kc As New KeysConverter
        e.SuppressKeyPress = True
        leftBox.Text = kc.ConvertToString(e.KeyCode)
    End Sub

    Private Sub rightBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles rightBox.KeyDown
        Dim kc As New KeysConverter
        e.SuppressKeyPress = True
        rightBox.Text = kc.ConvertToString(e.KeyCode)
    End Sub

    Private Sub upBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles upBox.KeyDown
        Dim kc As New KeysConverter
        e.SuppressKeyPress = True
        upBox.Text = kc.ConvertToString(e.KeyCode)
    End Sub

    Private Sub downBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles downBox.KeyDown
        Dim kc As New KeysConverter
        e.SuppressKeyPress = True
        downBox.Text = kc.ConvertToString(e.KeyCode)
    End Sub

    Private Sub shiftBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles shiftBox.KeyDown
        Dim kc As New KeysConverter
        e.SuppressKeyPress = True
        shiftBox.Text = kc.ConvertToString(e.KeyCode)
    End Sub

    Private Sub ctrlBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ctrlBox.KeyDown
        Dim kc As New KeysConverter
        e.SuppressKeyPress = True
        ctrlBox.Text = kc.ConvertToString(e.KeyCode)
    End Sub

    Private Sub altBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles altBox.KeyDown
        Dim kc As New KeysConverter
        e.SuppressKeyPress = True
        altBox.Text = kc.ConvertToString(e.KeyCode)
    End Sub

    Private Sub zBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles zBox.KeyDown
        Dim kc As New KeysConverter
        e.SuppressKeyPress = True
        zBox.Text = kc.ConvertToString(e.KeyCode)
    End Sub

    Private Sub rBox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles rBox.KeyDown
        Dim kc As New KeysConverter
        e.SuppressKeyPress = True
        rBox.Text = kc.ConvertToString(e.KeyCode)
    End Sub

    Private Sub developer_Click(sender As System.Object, e As System.EventArgs) Handles developer.Click
        Process.Start("http://blog.naver.com/fbtkdqja112")
    End Sub
End Class