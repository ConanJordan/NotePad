Public Class FindDialog
    Private MainPad As NotePad  ' 主窗体
    Private MainContent As String  ' 主窗体的文本内容
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
        Find(CB_IsCaseSensitive.Checked, CB_IsLoop.Checked, RD_Up.Checked)
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
        If isCaseSensitive Then  ' 区分大小写
            If isLoop Then  ' 循环
                If isUp Then  ' 向上查询
                    Find_CaseLoopUp()
                Else  ' 向下查询
                    Find_CaseLoopDown()
                End If
            Else  ' 不循环
                If isUp Then  ' 向上查询
                    Find_CaseNotLoopUp()
                Else  ' 向下查询
                    Find_CaseNotLoopDown()
                End If
            End If
        Else  ' 不区分大小写
            If isLoop Then  ' 循环
                If isUp Then  ' 向上查询
                    Find_NotCaseLoopUp()
                Else  ' 向下查询
                    Find_NotCaseLoopDown()
                End If
            Else  ' 不循环
                If isUp Then  ' 向上查询
                    Find_NotCaseNotLoopUp()
                Else  ' 向下查询
                    Find_NotCaseNotLoopDown()
                End If
            End If
        End If
    End Sub

    ' 区分大小写，不循环，向下查找
    Private Sub Find_CaseNotLoopDown()
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体文本
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的对象文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart + Me.MainPad.TB_Editor.SelectionLength  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(Me.StartIndex)  ' 获取查找源文本
        Me.TargetIndex = Me.MainContent.IndexOf(Me.FindContent)  ' 获取查找到的目标下标
        If Me.TargetIndex < 0 Then  ' 没查找到
            MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
        Else  ' 查找到了
            SelectText(Me.StartIndex + Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 区分大小写，不循环，向上查找
    Private Sub Find_CaseNotLoopUp()
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体文本
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的对象文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(0, Me.StartIndex)  ' 获取查找源文本
        Me.TargetIndex = Me.MainContent.LastIndexOf(Me.FindContent)  ' 获取查找到的目标下标

        If Me.TargetIndex < 0 Then  ' 没查找到
            MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
        Else  ' 查找到了
            SelectText(Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 不区分大小写，不循环，向下查找
    Private Sub Find_NotCaseNotLoopDown()
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体文本
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的对象文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart + Me.MainPad.TB_Editor.SelectionLength  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(Me.StartIndex)  ' 获取查找源文本
        Me.TargetIndex = Me.MainContent.ToUpper.IndexOf(Me.FindContent.ToUpper)  ' 获取查找到的目标下标(不区分大小写，所以把文本全部转换成大写)
        If Me.TargetIndex < 0 Then  ' 没查找到
            MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
        Else  ' 查找到了
            SelectText(Me.StartIndex + Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 不区分大小写，不循环，向上查找
    Private Sub Find_NotCaseNotLoopUp()
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体文本
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的对象文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(0, Me.StartIndex)  ' 获取查找源文本
        Me.TargetIndex = Me.MainContent.ToUpper.LastIndexOf(Me.FindContent.ToUpper)  ' 获取查找到的目标下标(不区分大小写，所以把文本全部转换成大写)

        If Me.TargetIndex < 0 Then  ' 没查找到
            MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
        Else  ' 查找到了
            SelectText(Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 区分大小写，循环，向下查找
    Private Sub Find_CaseLoopDown()
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体文本
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的对象文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart + Me.MainPad.TB_Editor.SelectionLength  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(Me.StartIndex)  ' 获取查找源文本
        Me.TargetIndex = Me.MainContent.IndexOf(Me.FindContent)  ' 获取查找到的目标下标

        If Me.TargetIndex < 0 Then  ' 没查找到
            ' 从开头开始循环查找
            Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取查找源文本
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

    ' 区分大小写，循环，向上查找
    Private Sub Find_CaseLoopUp()
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体文本
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的对象文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(0, Me.StartIndex)  ' 获取查找源文本
        Me.TargetIndex = Me.MainContent.LastIndexOf(Me.FindContent)  ' 获取查找到的目标下标

        If Me.TargetIndex < 0 Then  ' 没查找到
            ' 从末尾开始循环查找
            Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取查找源文本
            Me.TargetIndex = Me.MainContent.LastIndexOf(Me.FindContent)  ' 获取查找到的目标下标
            If Me.TargetIndex < 0 Then  ' 
                MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
            Else  ' 查找到了
                SelectText(Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
            End If
        Else  ' 查找到了
            SelectText(Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 不区分大小写，循环，向下查找
    Private Sub Find_NotCaseLoopDown()
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体文本
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的对象文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart + Me.MainPad.TB_Editor.SelectionLength  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(Me.StartIndex)  ' 获取查找源文本
        Me.TargetIndex = Me.MainContent.ToUpper.IndexOf(Me.FindContent.ToUpper)  ' 获取查找到的目标下标(不区分大小写，所以把文本全部转换成大写)

        If Me.TargetIndex < 0 Then  ' 没查找到
            ' 从开头开始循环查找
            Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取查找源文本
            Me.TargetIndex = Me.MainContent.ToUpper.IndexOf(Me.FindContent.ToUpper)  ' 获取查找到的目标下标
            If Me.TargetIndex < 0 Then  ' 没查找到
                MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
            Else  ' 查找到了
                SelectText(Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
            End If
        Else  ' 查找到了
            SelectText(Me.StartIndex + Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本(不区分大小写，所以把文本全部转换成大写)
        End If
    End Sub

    ' 不区分大小写，循环，向上查找
    Private Sub Find_NotCaseLoopUp()
        Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取主窗体文本
        Me.FindContent = TB_FindContent.Text  ' 获取要查找的对象文本

        Me.StartIndex = Me.MainPad.TB_Editor.SelectionStart  ' 获取查找的起始下标
        Me.MainContent = Me.MainContent.Substring(0, Me.StartIndex)  ' 获取查找源文本
        Me.TargetIndex = Me.MainContent.ToUpper.LastIndexOf(Me.FindContent.ToUpper)  ' 获取查找到的目标下标(不区分大小写，所以把文本全部转换成大写)

        If Me.TargetIndex < 0 Then  ' 没查找到
            ' 从末尾开始循环查找
            Me.MainContent = Me.MainPad.TB_Editor.Text  ' 获取查找的起始下标
            Me.TargetIndex = Me.MainContent.ToUpper.LastIndexOf(Me.FindContent.ToUpper)  ' 获取查找到的目标下标(不区分大小写，所以把文本全部转换成大写)
            If Me.TargetIndex < 0 Then  ' 
                MessageBox.Show("找不到" & Chr(34) & Me.FindContent & Chr(34))
            Else  ' 查找到了
                SelectText(Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
            End If
        Else  ' 查找到了
            SelectText(Me.TargetIndex, Me.FindContent.Length)  ' 选中查找到的文本
        End If
    End Sub

    ' 选中文本
    Private Sub SelectText(start As Integer, length As Integer)
        Me.MainPad.TB_Editor.Select(start, length)
    End Sub

End Class
