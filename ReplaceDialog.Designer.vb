<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReplaceDialog
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub InitializeComponent()
        Me.LB_FindContent = New System.Windows.Forms.Label()
        Me.LB_ReplaceContent = New System.Windows.Forms.Label()
        Me.TB_FindContent = New System.Windows.Forms.TextBox()
        Me.TB_ReplaceContent = New System.Windows.Forms.TextBox()
        Me.BTN_Next = New System.Windows.Forms.Button()
        Me.BTN_Replace = New System.Windows.Forms.Button()
        Me.BTN_ReplaceAll = New System.Windows.Forms.Button()
        Me.BTN_Cancel = New System.Windows.Forms.Button()
        Me.CB_IsCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.CB_IsLoop = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LB_FindContent
        '
        Me.LB_FindContent.AutoSize = True
        Me.LB_FindContent.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_FindContent.Location = New System.Drawing.Point(0, 21)
        Me.LB_FindContent.Name = "LB_FindContent"
        Me.LB_FindContent.Size = New System.Drawing.Size(93, 13)
        Me.LB_FindContent.TabIndex = 0
        Me.LB_FindContent.Text = "查找内容(&N)："
        '
        'LB_ReplaceContent
        '
        Me.LB_ReplaceContent.AutoSize = True
        Me.LB_ReplaceContent.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_ReplaceContent.Location = New System.Drawing.Point(0, 63)
        Me.LB_ReplaceContent.Name = "LB_ReplaceContent"
        Me.LB_ReplaceContent.Size = New System.Drawing.Size(80, 13)
        Me.LB_ReplaceContent.TabIndex = 1
        Me.LB_ReplaceContent.Text = "替换为(&P)："
        '
        'TB_FindContent
        '
        Me.TB_FindContent.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_FindContent.Location = New System.Drawing.Point(99, 19)
        Me.TB_FindContent.Name = "TB_FindContent"
        Me.TB_FindContent.Size = New System.Drawing.Size(250, 22)
        Me.TB_FindContent.TabIndex = 2
        '
        'TB_ReplaceContent
        '
        Me.TB_ReplaceContent.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_ReplaceContent.Location = New System.Drawing.Point(99, 60)
        Me.TB_ReplaceContent.Name = "TB_ReplaceContent"
        Me.TB_ReplaceContent.Size = New System.Drawing.Size(250, 22)
        Me.TB_ReplaceContent.TabIndex = 3
        '
        'BTN_Next
        '
        Me.BTN_Next.Location = New System.Drawing.Point(364, 12)
        Me.BTN_Next.Name = "BTN_Next"
        Me.BTN_Next.Size = New System.Drawing.Size(108, 26)
        Me.BTN_Next.TabIndex = 4
        Me.BTN_Next.Text = "查找下一个(&F)"
        Me.BTN_Next.UseVisualStyleBackColor = True
        '
        'BTN_Replace
        '
        Me.BTN_Replace.Location = New System.Drawing.Point(364, 52)
        Me.BTN_Replace.Name = "BTN_Replace"
        Me.BTN_Replace.Size = New System.Drawing.Size(108, 26)
        Me.BTN_Replace.TabIndex = 5
        Me.BTN_Replace.Text = "替换(&R)"
        Me.BTN_Replace.UseVisualStyleBackColor = True
        '
        'BTN_ReplaceAll
        '
        Me.BTN_ReplaceAll.Location = New System.Drawing.Point(364, 92)
        Me.BTN_ReplaceAll.Name = "BTN_ReplaceAll"
        Me.BTN_ReplaceAll.Size = New System.Drawing.Size(108, 26)
        Me.BTN_ReplaceAll.TabIndex = 6
        Me.BTN_ReplaceAll.Text = "全部替换(&A)"
        Me.BTN_ReplaceAll.UseVisualStyleBackColor = True
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.Location = New System.Drawing.Point(364, 132)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(108, 26)
        Me.BTN_Cancel.TabIndex = 7
        Me.BTN_Cancel.Text = "取消"
        Me.BTN_Cancel.UseVisualStyleBackColor = True
        '
        'CB_IsCaseSensitive
        '
        Me.CB_IsCaseSensitive.AutoSize = True
        Me.CB_IsCaseSensitive.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CB_IsCaseSensitive.Location = New System.Drawing.Point(12, 154)
        Me.CB_IsCaseSensitive.Name = "CB_IsCaseSensitive"
        Me.CB_IsCaseSensitive.Size = New System.Drawing.Size(112, 17)
        Me.CB_IsCaseSensitive.TabIndex = 8
        Me.CB_IsCaseSensitive.Text = "区分大小写(&C)"
        Me.CB_IsCaseSensitive.UseVisualStyleBackColor = True
        '
        'CB_IsLoop
        '
        Me.CB_IsLoop.AutoSize = True
        Me.CB_IsLoop.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CB_IsLoop.Location = New System.Drawing.Point(12, 187)
        Me.CB_IsLoop.Name = "CB_IsLoop"
        Me.CB_IsLoop.Size = New System.Drawing.Size(73, 17)
        Me.CB_IsLoop.TabIndex = 9
        Me.CB_IsLoop.Text = "循环(&R)"
        Me.CB_IsLoop.UseVisualStyleBackColor = True
        '
        'ReplaceDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 211)
        Me.Controls.Add(Me.CB_IsLoop)
        Me.Controls.Add(Me.CB_IsCaseSensitive)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Controls.Add(Me.BTN_ReplaceAll)
        Me.Controls.Add(Me.BTN_Replace)
        Me.Controls.Add(Me.BTN_Next)
        Me.Controls.Add(Me.TB_ReplaceContent)
        Me.Controls.Add(Me.TB_FindContent)
        Me.Controls.Add(Me.LB_ReplaceContent)
        Me.Controls.Add(Me.LB_FindContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReplaceDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "替换"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_FindContent As Label
    Friend WithEvents LB_ReplaceContent As Label
    Friend WithEvents TB_FindContent As TextBox
    Friend WithEvents TB_ReplaceContent As TextBox
    Friend WithEvents BTN_Next As Button
    Friend WithEvents BTN_Replace As Button
    Friend WithEvents BTN_ReplaceAll As Button
    Friend WithEvents BTN_Cancel As Button
    Friend WithEvents CB_IsCaseSensitive As CheckBox
    Friend WithEvents CB_IsLoop As CheckBox
End Class
