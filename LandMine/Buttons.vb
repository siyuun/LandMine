Imports System.Windows.Forms

Public Class Buttons
    Private Const MarginX As Integer = 4, MarginY As Integer = 10
    Private w As Integer = 20  ' 方块的宽度
    Private M, N As Integer
    Private MineMatrix As clsMine
    Private Buttons As List(Of Button)
    Private GroupBox As GroupBox
    Public flag As Boolean

    Public Sub New(ByVal m As Integer, ByVal n As Integer)
        flag = True
        Dim MatrixNum As Integer
        MatrixNum = m * n / 10 '将雷数和方格数联系
        MineMatrix = New clsMine(m, n, MatrixNum)
        Buttons = New List(Of Button)
        Me.M = m : Me.N = n
        For i = 0 To m - 1
            For j = 0 To n - 1
                Dim ButtonX As Button = New Button
                With ButtonX
                    .Location = New System.Drawing.Point(MarginX + w * j, MarginY + i * w)
                    .Name = "Button " & i & " " & j  'Button 2 3
                    .Size = New System.Drawing.Size(w, w)
                    .Text = ""
                    .UseVisualStyleBackColor = True
                    AddHandler ButtonX.MouseDown, AddressOf ButtonX_MouseDown
                End With
                Buttons.Add(ButtonX)
            Next
        Next
    End Sub

    Private Sub ButtonX_MouseDown(sender As Object, e As MouseEventArgs)
        If flag = True Then
            Dim ij() As String = sender.name.split(" ")
            Dim i As Integer = ij(1), j As Integer = ij(2) 'Button 2 3
            If e.Button = MouseButtons.Right Then '右击
                If Buttons(i * N + j).BackColor <> Drawing.Color.Silver Then
                    If Buttons(i * N + j).Tag = "flag.jpg" Then '不显示旗子
                        Buttons(i * N + j).Image = Nothing
                        Buttons(i * N + j).Tag = Nothing
                    Else '显示旗子
                        Buttons(i * N + j).Image = System.Drawing.Image.FromFile("flag.jpg")
                        Buttons(i * N + j).Tag = "flag.jpg"
                    End If
                    If CheckGameOver() = True Then
                        flag = False
                        MsgBox("恭喜~\(≧▽≦)/~胜利啦啦啦")
                    End If
                End If
            ElseIf e.Button = MouseButtons.Left Then '左击
                DisplayOneResult（i, j）

            End If
        End If
    End Sub


    Public Sub Display(ByVal gb As GroupBox)
        GroupBox = gb
        For i = 0 To Buttons.Count - 1
            gb.Controls.Add(Buttons(i))
        Next
        gb.ResumeLayout(False) '显示控件
    End Sub

    Public Sub DisplayResult() '显示所有方块的结果
        For i = 0 To M - 1
            For j = 0 To N - 1
                If MineMatrix.isMine(i, j) Then
                    Buttons(i * N + j).Text = ""
                    Buttons(i * N + j).Image = System.Drawing.Image.FromFile("mine.jpg") '显示雷的图片
                    Buttons(i * N + j).FlatStyle = 1
                Else
                    Buttons(i * N + j).Text = MineMatrix.AdjMineCount(i, j) '周围雷的个数
                End If
            Next
        Next
    End Sub

    Function CheckGameOver() '显示游戏结束 true表示win
        For i = 0 To M - 1
            For j = 0 To N - 1
                If MineMatrix.isMine(i, j) Then
                    If Buttons(i * N + j).Tag <> "flag.jpg" Then
                        Return False
                    End If
                Else
                    If Buttons(i * N + j).Tag = "flag.jpg" Then
                        Return False
                    End If
                End If
            Next
        Next
        Return True
    End Function

    Public Sub DisplayOneResult(i As Integer, j As Integer) '显示一个方块的结果
        If MineMatrix.isMine(i, j) Then
            DisplayResult()
            flag = False
            MsgBox("游戏失败了(⊙o⊙) 再加油嗷~") '雷 结束游戏

        ElseIf MineMatrix.AdjMineCount(i, j) = 0 Then '周围都没有雷
            Buttons(i * N + j).Text = ""
            Buttons(i * N + j).Image = Nothing
            Buttons(i * N + j).Tag = Nothing
            For i1 = i - 1 To i + 1
                For j1 = j - 1 To j + 1
                    If (i1 < 0 Or i1 >= M Or j1 < 0 Or j1 >= N) Then '排除越界情况
                    Else
                        If MineMatrix.isMine(i1, j1) Then
                        ElseIf Buttons(i1 * N + j1).BackColor <> Drawing.Color.Silver Then '未点击过
                            Dim a As Integer = MineMatrix.AdjMineCount(i1, j1)
                            Buttons(i1 * N + j1).BackColor = Drawing.Color.Silver
                            If a <> 0 Then
                                Buttons(i1 * N + j1).Text = a '显示周围方块的周围雷数
                                Buttons(i1 * N + j1).Image = Nothing
                                Buttons(i1 * N + j1).Tag = Nothing
                            Else
                                DisplayOneResult(i1, j1) '四周方块的四周
                            End If
                        End If
                    End If
                Next
            Next
        Else '显示周围周围雷数
            Buttons(i * N + j).BackColor = Drawing.Color.Silver
            Buttons(i * N + j).Text = MineMatrix.AdjMineCount(i, j)
            Buttons(i * N + j).Image = Nothing
            Buttons(i * N + j).Tag = Nothing
        End If
    End Sub


    Sub Clear()
        For i = 0 To Buttons.Count - 1
            GroupBox.Controls.Remove(Buttons(i))
        Next
        Buttons.Clear()
        GroupBox.ResumeLayout(False) '不显示控件
    End Sub

End Class
