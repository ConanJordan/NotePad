Public Class ReplaceDialog
    Private MainPad As NotePad  ' 主窗体
    Private MainContent As String  ' 主窗体的文本内容(查找用)
    Private FindContent As String  ' 要查找的文本内容
    Private ReplaceContent As String  ' 要替换的文本内容
    Private StartIndex As Integer  ' 开始查找的小标
    Private TargetIndex As Integer  ' 查找到的下标

    Public Sub New(mainPad As NotePad)
        Me.MainPad = mainPad
    End Sub

    ' 监听键盘的按键
    Private Sub KeysClick(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then  ' 【回车键】被按下时

        End If
    End Sub

    ' 查找内容
    Private Sub LB_FindContent_Click(sender As Object, e As EventArgs) Handles LB_FindContent.Click
        TB_FindContent.SelectAll()
    End Sub

    ' 替换为
    Private Sub LB_ReplaceContent_Click(sender As Object, e As EventArgs) Handles LB_ReplaceContent.Click
        TB_ReplaceContent.SelectAll()
    End Sub

    ' 执行查找
    Private Sub Find(
        isCaseSensitive As Boolean,  ' 区分大小写
        isLoop As Boolean  ' 循环
        )
        If isCaseSensitive Then  ' 区分大小写
            If isLoop Then  ' 循环
                Find_CaseLoop()
            Else  ' 不循环
                Find_CaseNotLoop()
            End If
        Else  ' 不区分大小写
            If isLoop Then  ' 循环
                Find_NotCaseLoop()
            Else  ' 不循环
                Find_NotCaseNotLoop()
            End If
        End If

    End Sub

    ' 区分大小写，不循环查找
    Private Sub Find_CaseNotLoop()
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的文本
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体的文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart + Me.MainPad.TB_Editor.SelectionLength  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(Me.StartIndex)  ' 获取查找的源文本
        Me.TargetIndex = Me.MainContent.IndexOf(Me.FindContent)  ' 获取查找到的目标下标

        If Me.TargetIndex < 0 Then  ' 没查找到
            MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
        Else  ' 查找到了
            SelectText(Me.StartIndex + Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 区分大小写，循环查找
    Private Sub Find_CaseLoop()
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的文本
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体的文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart + Me.MainPad.TB_Editor.SelectionLength  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(Me.StartIndex)  ' 获取查找的源文本
        Me.TargetIndex = Me.MainContent.IndexOf(Me.FindContent)  ' 获取查找到的目标下标

        If Me.TargetIndex < 0 Then  ' 没查找到
            ' 从开头开始循环查找
            Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取查找的源文本
            Me.TargetIndex = Me.MainContent.IndexOf(Me.FindContent)  ' 获取查找到的目标下标
            If Me.TargetIndex < 0 Then  ' 没查找到
                MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
            Else  ' 查找到了
                SelectText(Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
            End If
        Else  ' 查找到了
            SelectText(Me.StartIndex + Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 不区分大小写，不循环查找
    Private Sub Find_NotCaseNotLoop()
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的文本
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体的文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart + Me.MainPad.TB_Editor.SelectionLength  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(Me.StartIndex)  ' 获取查找的源文本
        Me.TargetIndex = Me.MainContent.ToUpper.IndexOf(Me.FindContent.ToUpper)  ' 获取查找到的目标下标(不区分大小写，所以把文本全部转换成大写)

        If Me.TargetIndex < 0 Then  ' 没查找到
            MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
        Else  ' 查找到了
            SelectText(Me.StartIndex + Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 不区分大小写，循环查找
    Private Sub Find_NotCaseLoop()
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的文本
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体的文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart + Me.MainPad.TB_Editor.SelectionLength  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(Me.StartIndex)  ' 获取查找的源文本
        Me.TargetIndex = Me.MainContent.ToUpper.IndexOf(Me.FindContent.ToUpper)  ' 获取查找到的目标下标

        If Me.TargetIndex < 0 Then  ' 没查找到
            ' 从开头开始循环查找
            Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取查找的源文本
            Me.TargetIndex = Me.MainContent.ToUpper.IndexOf(Me.FindContent.ToUpper)  ' 获取查找到的目标下标
            If Me.TargetIndex < 0 Then  ' 没查找到
                MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
            Else  ' 查找到了
                SelectText(Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
            End If
        Else  ' 查找到了
            SelectText(Me.StartIndex + Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 选中文本
    Private Sub SelectText(start As Integer, length As Integer)
        Me.MainPad.TB_Editor.Select(start, length)
    End Sub

    ' 查找下一个
    Private Sub BTN_Next_Click(sender As Object, e As EventArgs) Handles BTN_Next.Click
        Find(CB_IsCaseSensitive.Checked, CB_IsLoop.Checked)
    End Sub

    ' 取消
    Private Sub BTN_Cancel_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        Me.Close()
    End Sub

    ' 替换
    Private Sub BTN_Replace_Click(sender As Object, e As EventArgs) Handles BTN_Replace.Click

    End Sub

    ' 【查找内容】文本框
    Private Sub TB_FindContent_TextChanged(sender As Object, e As EventArgs) Handles TB_FindContent.TextChanged
        If TB_FindContent.Text = Nothing Then  ' 【查找内容】文本框内容为空
            BTN_Next.Enabled = False  ' 【查找下一个】不可用
            BTN_Replace.Enabled = False  ' 【替换】不可用
            BTN_ReplaceAll.Enabled = False  ' 【全部替换】不可用
        Else
            BTN_Next.Enabled = True  ' 【查找下一个】可用
            BTN_Replace.Enabled = True  ' 【替换】可用
            BTN_ReplaceAll.Enabled = True  ' 【全部替换】可用
        End If
    End Sub

End Class
