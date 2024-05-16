Public Class Form1
    Dim checkForXor0 As Boolean = False
    Dim addOneToScore As Integer = 0

    Sub buttonsEnableFalse()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Sub CheckForwin()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            MessageBox.Show("Winner Is player X", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label0.Text)
            Label0.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            MessageBox.Show("Winner Is player X", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label0.Text)
            Label0.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            Button7.BackColor = Color.Red
            Button8.BackColor = Color.Red
            Button9.BackColor = Color.Red
            MessageBox.Show("Winner Is player X", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label0.Text)
            Label0.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            Button1.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button7.BackColor = Color.Red
            MessageBox.Show("Winner Is player X", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label0.Text)
            Label0.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            Button2.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button8.BackColor = Color.Red
            MessageBox.Show("Winner Is player X", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label0.Text)
            Label0.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            Button3.BackColor = Color.Red
            Button6.BackColor = Color.Red
            Button9.BackColor = Color.Red
            MessageBox.Show("Winner Is player X", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label0.Text)
            Label0.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()


        End If
        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            Button1.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button9.BackColor = Color.Red
            MessageBox.Show("Winner Is player X", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label0.Text)
            Label0.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            Button3.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button7.BackColor = Color.Red
            MessageBox.Show("Winner Is player X", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label0.Text)
            Label0.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If

        '0 combinations
        If Button1.Text = "0" And Button2.Text = "0" And Button3.Text = "0" Then
            Button1.BackColor = Color.Red
            Button2.BackColor = Color.Red
            Button3.BackColor = Color.Red
            MessageBox.Show("Winner Is player 0", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label3.Text)
            Label3.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button4.Text = "0" And Button5.Text = "0" And Button6.Text = "0" Then
            Button4.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button6.BackColor = Color.Red
            MessageBox.Show("Winner Is player 0", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label3.Text)
            Label3.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button7.Text = "0" And Button8.Text = "0" And Button9.Text = "0" Then
            Button7.BackColor = Color.Red
            Button8.BackColor = Color.Red
            Button9.BackColor = Color.Red
            MessageBox.Show("Winner Is player 0", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label3.Text)
            Label3.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button1.Text = "0" And Button4.Text = "0" And Button7.Text = "0" Then
            Button1.BackColor = Color.Red
            Button4.BackColor = Color.Red
            Button7.BackColor = Color.Red
            MessageBox.Show("Winner Is player 0", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label3.Text)
            Label3.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button2.Text = "0" And Button5.Text = "0" And Button8.Text = "0" Then
            Button2.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button8.BackColor = Color.Red
            MessageBox.Show("Winner Is player 0", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label3.Text)
            Label3.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button3.Text = "0" And Button5.Text = "0" And Button9.Text = "0" Then
            Button3.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button9.BackColor = Color.Red
            MessageBox.Show("Winner Is player 0", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label3.Text)
            Label3.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button1.Text = "0" And Button5.Text = "0" And Button9.Text = "0" Then
            Button1.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button9.BackColor = Color.Red
            MessageBox.Show("Winner Is player 0", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label3.Text)
            Label3.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
        If Button3.Text = "0" And Button5.Text = "0" And Button7.Text = "0" Then
            Button3.BackColor = Color.Red
            Button5.BackColor = Color.Red
            Button7.BackColor = Color.Red
            MessageBox.Show("Winner Is player 0", "TIC_TAC_TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt32(Label3.Text)
            Label3.Text = Convert.ToString(addOneToScore + 1)
            buttonsEnableFalse()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label0.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button_click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        Dim b As Button = sender
        If checkForXor0 = False Then
            b.Text = "X"
        Else
            b.Text = "0"
        End If
        checkForXor0 = Not checkForXor0 ' Toggle the variable to alternate turns
        CheckForwin()
        b.Enabled = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button8.BackColor = Color.White
        Button9.BackColor = Color.White
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim checkforexit As DialogResult
        checkforexit = MessageBox.Show("Are you sure you want to exit the Game?", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (checkforexit = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

End Class
