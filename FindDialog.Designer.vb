<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindDialog
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.TB_FindContent = New System.Windows.Forms.TextBox()
        Me.BTN_Next = New System.Windows.Forms.Button()
        Me.BTN_Cancel = New System.Windows.Forms.Button()
        Me.CB_IsCaseSensitive = New System.Windows.Forms.CheckBox()
        Me.CB_IsLoop = New System.Windows.Forms.CheckBox()
        Me.GB_Direction = New System.Windows.Forms.GroupBox()
        Me.RD_Down = New System.Windows.Forms.RadioButton()
        Me.RD_Up = New System.Windows.Forms.RadioButton()
        Me.GB_Direction.SuspendLayout()
        Me.SuspendLayout()
        '
        'LB_FindContent
        '
        Me.LB_FindContent.AutoSize = True
        Me.LB_FindContent.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LB_FindContent.Location = New System.Drawing.Point(1, 18)
        Me.LB_FindContent.Name = "LB_FindContent"
        Me.LB_FindContent.Size = New System.Drawing.Size(93, 13)
        Me.LB_FindContent.TabIndex = 0
        Me.LB_FindContent.Text = "查找内容(&N)："
        '
        'TB_FindContent
        '
        Me.TB_FindContent.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_FindContent.Location = New System.Drawing.Point(88, 12)
        Me.TB_FindContent.Name = "TB_FindContent"
        Me.TB_FindContent.Size = New System.Drawing.Size(200, 22)
        Me.TB_FindContent.TabIndex = 1
        '
        'BTN_Next
        '
        Me.BTN_Next.Enabled = False
        Me.BTN_Next.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_Next.Location = New System.Drawing.Point(306, 12)
        Me.BTN_Next.Name = "BTN_Next"
        Me.BTN_Next.Size = New System.Drawing.Size(116, 23)
        Me.BTN_Next.TabIndex = 2
        Me.BTN_Next.Text = "查找下一个(&F)"
        Me.BTN_Next.UseVisualStyleBackColor = True
        '
        'BTN_Cancel
        '
        Me.BTN_Cancel.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BTN_Cancel.Location = New System.Drawing.Point(306, 51)
        Me.BTN_Cancel.Name = "BTN_Cancel"
        Me.BTN_Cancel.Size = New System.Drawing.Size(116, 23)
        Me.BTN_Cancel.TabIndex = 3
        Me.BTN_Cancel.Text = "取消"
        Me.BTN_Cancel.UseVisualStyleBackColor = True
        '
        'CB_IsCaseSensitive
        '
        Me.CB_IsCaseSensitive.AutoSize = True
        Me.CB_IsCaseSensitive.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CB_IsCaseSensitive.Location = New System.Drawing.Point(16, 86)
        Me.CB_IsCaseSensitive.Name = "CB_IsCaseSensitive"
        Me.CB_IsCaseSensitive.Size = New System.Drawing.Size(112, 17)
        Me.CB_IsCaseSensitive.TabIndex = 4
        Me.CB_IsCaseSensitive.Text = "区分大小写(&C)"
        Me.CB_IsCaseSensitive.UseVisualStyleBackColor = True
        '
        'CB_IsLoop
        '
        Me.CB_IsLoop.AutoSize = True
        Me.CB_IsLoop.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CB_IsLoop.Location = New System.Drawing.Point(16, 123)
        Me.CB_IsLoop.Name = "CB_IsLoop"
        Me.CB_IsLoop.Size = New System.Drawing.Size(73, 17)
        Me.CB_IsLoop.TabIndex = 5
        Me.CB_IsLoop.Text = "循环(&R)"
        Me.CB_IsLoop.UseVisualStyleBackColor = True
        '
        'GB_Direction
        '
        Me.GB_Direction.Controls.Add(Me.RD_Down)
        Me.GB_Direction.Controls.Add(Me.RD_Up)
        Me.GB_Direction.Location = New System.Drawing.Point(152, 86)
        Me.GB_Direction.Name = "GB_Direction"
        Me.GB_Direction.Size = New System.Drawing.Size(211, 65)
        Me.GB_Direction.TabIndex = 6
        Me.GB_Direction.TabStop = False
        Me.GB_Direction.Text = "方向"
        '
        'RD_Down
        '
        Me.RD_Down.AutoSize = True
        Me.RD_Down.Checked = True
        Me.RD_Down.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RD_Down.Location = New System.Drawing.Point(106, 20)
        Me.RD_Down.Name = "RD_Down"
        Me.RD_Down.Size = New System.Drawing.Size(72, 17)
        Me.RD_Down.TabIndex = 1
        Me.RD_Down.TabStop = True
        Me.RD_Down.Text = "向下(&D)"
        Me.RD_Down.UseVisualStyleBackColor = True
        '
        'RD_Up
        '
        Me.RD_Up.AutoSize = True
        Me.RD_Up.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RD_Up.Location = New System.Drawing.Point(6, 20)
        Me.RD_Up.Name = "RD_Up"
        Me.RD_Up.Size = New System.Drawing.Size(72, 17)
        Me.RD_Up.TabIndex = 0
        Me.RD_Up.Text = "向上(&U)"
        Me.RD_Up.UseVisualStyleBackColor = True
        '
        'FindDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 161)
        Me.Controls.Add(Me.GB_Direction)
        Me.Controls.Add(Me.CB_IsLoop)
        Me.Controls.Add(Me.CB_IsCaseSensitive)
        Me.Controls.Add(Me.BTN_Cancel)
        Me.Controls.Add(Me.BTN_Next)
        Me.Controls.Add(Me.TB_FindContent)
        Me.Controls.Add(Me.LB_FindContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查找"
        Me.GB_Direction.ResumeLayout(False)
        Me.GB_Direction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_FindContent As Label
    Friend WithEvents TB_FindContent As TextBox
    Friend WithEvents BTN_Next As Button
    Friend WithEvents BTN_Cancel As Button
    Friend WithEvents CB_IsCaseSensitive As CheckBox
    Friend WithEvents CB_IsLoop As CheckBox
    Friend WithEvents GB_Direction As GroupBox
    Friend WithEvents RD_Up As RadioButton
    Friend WithEvents RD_Down As RadioButton
End Class
