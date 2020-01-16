Public Class FindDialog
    Private MainPad As NotePad  ' 主窗口
    Private MainContent As String  ' 主窗口的文本内容
    Private FindContent As String  ' 要查询的文本内容
    Private StartIndex As Integer   ' 开始查询的下标
    Private TargetIndex As Integer  ' 查询到的下标

    Public Sub New(mainPad As NotePad)
        Me.MainPad = mainPad
    End Sub

    ' 查找内容
    Private Sub LB_FindContent_Click(sender As Object, e As EventArgs) Handles LB_FindContent.Click
        TB_FindContent.SelectAll()
    End Sub

    ' 查找下一个
    Private Sub BTN_Next_Click(sender As Object, e As EventArgs) Handles BTN_Next.Click
        FindCaseLoopDown()
        Me.MainPad.TB_Editor.Focus()
    End Sub

    ' 取消
    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        Me.Close()
    End Sub

    ' 【查找内容】文本框的内容改变事件
    Private Sub TB_FindContent_TextChanged(sender As Object, e As EventArgs) Handles TB_FindContent.TextChanged
        ' 根据【查找内容】文本框变更【查找下一个】按键的可用属性
        BTN_Next.Enabled = Not (TB_FindContent.Text = Nothing)
    End Sub

    ' 执行查找
    Private Sub Find(
        isCaseSensitive As Boolean,  ' 区分大小写
        isLoop As Boolean,  ' 循环
        isUp As Boolean  ' 向上
        )

    End Sub

    ' 区分大小写，循环，向下查询
    Private Sub FindCaseLoopDown()
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗口文本
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart
        Me.MainContent = Me.MainContent.Substring(Me.StartIndex)
        Me.TargetIndex = Me.MainContent.IndexOf(Me.FindContent)
        If Me.TargetIndex < 0 Then
            MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
        Else
            SelectText(Me.StartIndex + Me.TargetIndex, Me.FindContent.Length)
        End If
    End Sub

    ' 选中文本
    Private Sub SelectText(start As Integer, length As Integer)
        Me.MainPad.TB_Editor.Select(start, length)
    End Sub


End Class