Public Class FindDialog
    Private MainPad As NotePad  ' 主窗口
    Private MainContent As String  ' 主窗口的文本内容
    Private FindContent As String  ' 要查询的文本内容
    Private Index As Integer   ' 查询到的下标

    Public Sub New(mainPad As NotePad)
        Me.MainPad = mainPad
    End Sub

    ' 查找内容
    Private Sub LB_FindContent_Click(sender As Object, e As EventArgs) Handles LB_FindContent.Click
        TB_FindContent.SelectAll()
    End Sub

    ' 查找下一个
    Private Sub BTN_Next_Click(sender As Object, e As EventArgs) Handles BTN_Next.Click

    End Sub

    ' 取消
    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        Me.Close()
    End Sub

    ' 【查找内容】文本框的内容改变事件
    Private Sub TB_FindContent_TextChanged(sender As Object, e As EventArgs) Handles TB_FindContent.TextChanged
        BTN_Next.Enabled = Not (TB_FindContent.Text = Nothing)
    End Sub
End Class