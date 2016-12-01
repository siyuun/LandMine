<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTest
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gboxGame = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.flPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.flPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.flPanel1.SuspendLayout()
        Me.flPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboxGame
        '
        Me.gboxGame.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gboxGame.CausesValidation = False
        Me.gboxGame.Location = New System.Drawing.Point(4, 4)
        Me.gboxGame.Margin = New System.Windows.Forms.Padding(4)
        Me.gboxGame.Name = "gboxGame"
        Me.gboxGame.Padding = New System.Windows.Forms.Padding(4)
        Me.gboxGame.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.gboxGame.Size = New System.Drawing.Size(478, 328)
        Me.gboxGame.TabIndex = 1
        Me.gboxGame.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(120, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "            等待游戏开始"
        '
        'Timer1
        '
        '
        'flPanel1
        '
        Me.flPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.flPanel1.Controls.Add(Me.Label1)
        Me.flPanel1.Controls.Add(Me.txtM)
        Me.flPanel1.Controls.Add(Me.Label2)
        Me.flPanel1.Controls.Add(Me.txtN)
        Me.flPanel1.Controls.Add(Me.Button1)
        Me.flPanel1.Controls.Add(Me.Button2)
        Me.flPanel1.Controls.Add(Me.Button3)
        Me.flPanel1.Location = New System.Drawing.Point(33, 339)
        Me.flPanel1.Name = "flPanel1"
        Me.flPanel1.Size = New System.Drawing.Size(420, 92)
        Me.flPanel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "行数："
        '
        'txtM
        '
        Me.txtM.Location = New System.Drawing.Point(72, 4)
        Me.txtM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtM.Name = "txtM"
        Me.txtM.Size = New System.Drawing.Size(117, 28)
        Me.txtM.TabIndex = 2
        Me.txtM.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "列数："
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(265, 4)
        Me.txtN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(122, 28)
        Me.txtN.TabIndex = 2
        Me.txtN.Text = "10"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 40)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "start game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 40)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 40)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(276, 40)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 40)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "result"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'flPanel
        '
        Me.flPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.flPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.flPanel.Controls.Add(Me.gboxGame)
        Me.flPanel.Controls.Add(Me.flPanel1)
        Me.flPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flPanel.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.flPanel.Location = New System.Drawing.Point(39, 64)
        Me.flPanel.Name = "flPanel"
        Me.flPanel.Size = New System.Drawing.Size(495, 456)
        Me.flPanel.TabIndex = 7
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(603, 617)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.flPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmTest"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "踩地雷"
        Me.flPanel1.ResumeLayout(False)
        Me.flPanel1.PerformLayout()
        Me.flPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gboxGame As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents flPanel1 As FlowLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtM As TextBox
    Friend WithEvents txtN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents flPanel As FlowLayoutPanel
End Class
