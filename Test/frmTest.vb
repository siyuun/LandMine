Imports LandMine

Public Class frmTest
    Dim Buttons As Buttons
    Dim t_now As Date
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m As Integer = txtM.Text, n As Integer = txtN.Text
        If Buttons IsNot Nothing Then
            Buttons.Clear()
        End If
        Buttons = New Buttons(m, n)
        Buttons.Display(gboxGame)

        gboxGame.Width = 20 * n + 10
        gboxGame.Height = 20 * m + 10
        If gboxGame.Width < 270 Then
            flPanel.Width = 270
        Else
            flPanel.Width = gboxGame.Width + 10
        End If
        flPanel.Height = gboxGame.Height + flPanel1.Height + 10
        Me.Width = flPanel.Width + 100
        Me.Height = flPanel.Height + 100
        t_now = Now
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Buttons.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Buttons.DisplayResult()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick, Button1.Click
        Dim i As Integer, h As Integer, m As Integer, s As Integer
        i = DateDiff("s", t_now, Now)
        Label3.Text = "游戏已经开始" & i + 1 & "秒啦~\(≧▽≦)/~"
        If Buttons.flag = False Then
            Timer1.Enabled = False '计时暂停
            Label3.Text = "游戏进行了" & i + 1 & "秒 再来一局吗？？"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub flPanel1_Paint(sender As Object, e As PaintEventArgs) Handles flPanel1.Paint

    End Sub
End Class
