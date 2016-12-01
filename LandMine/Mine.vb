Public Class clsMine
    Private M, N As Integer
    Private Matrix As List(Of Integer)
    ' k是地雷的个数
    Public Sub New(ByVal m As Integer, ByVal n As Integer, ByVal k As Integer)
        Me.M = m : Me.N = n
        Matrix = New List(Of Integer)
        For i = 0 To m * n - 1
            Matrix.Add(0) '0不是地雷
        Next
        For i = 0 To k - 1
            Dim id As Integer = Rnd() * m * n  'id可能重复
            While id > m * n - 1
                id = Rnd() * m * n
            End While
            Matrix(id) = 1 '1是地雷
        Next
    End Sub

    Function isMine(ByVal i As Integer, ByVal j As Integer) As Boolean
        If i < 0 Or i >= M Then Return False ' 越界
        If j < 0 Or j >= N Then Return False
        Return Matrix(i * N + j) > 0
    End Function

    Function AdjMineCount(ByVal i As Integer, ByVal j As Integer) As Integer
        '越界 ????放在了调用函数中
        Dim count As Integer = 0
        For i1 = i - 1 To i + 1
            For j1 = j - 1 To j + 1
                If isMine(i1, j1) = True Then
                    count += 1
                End If
            Next
        Next
        Return count
    End Function

End Class

