Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private num As Integer = 0


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (num Mod 2 = 0) Then
            Label1.Visible = True
            Label2.Visible = False
        Else
            Label2.Visible = True
            Label1.Visible = False

        End If

        num = num + 1

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Timer1.Enabled = True
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Text = TimeOfDay

    End Sub
End Class
