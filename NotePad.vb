Imports System.IO

Public Class NotePad

    Private filePath As String = Nothing  ' 当前文件具体路径
    Private fileName As String = Nothing  ' 当前文件的文件名
    Private fileNumber As Integer  ' 当前文件的文件号码
    Private currentContent As String  ' 原文件缓存内容：用于比较当前文本框内容和文件内容是否一致
    Private isEdited As Boolean = False  ' 文件内容变更标识符

    Private Const NOTE_PAD As String = " - 记事本"  ' 记事本
    Private Const ASTER As String = "*"  ' 星号：用来提示文本内容发生变化
    Private Const NO_TITLE As String = "无标题"  ' 无标题

    ' 保存文件
    Private Sub MI_Save_Click(sender As Object, e As EventArgs) Handles MI_Save.Click

        If Me.filePath = Nothing Then  ' 当前文件未被保存
            MI_SaveAs_Click(sender, e)  ' 调用【另存为】按键
        Else
            Me.fileNumber = FreeFile()  ' 获取文件号码
            FileOpen(Me.fileNumber, filePath, OpenMode.Output)  ' 以写入模式打开文件
            PrintLine(Me.fileNumber, TB_Editor.Text)  ' 把文本框的内容逐行写入文件
            FileClose(Me.fileNumber)  ' 关闭文件
            Me.isEdited = False

            ' 变更窗口的标题内容
            Me.fileName = Path.GetFileName(Me.filePath)  ' 获取当前文件的文件名(含扩展名，不含路径)
            Me.Text = Me.fileName & NOTE_PAD

            ' 重置文本内容和文本内容变更标识符
            Me.currentContent = TB_Editor.Text
            Me.isEdited = False
        End If

    End Sub

    ' 打开文件
    Private Sub MI_Open_Click(sender As Object, e As EventArgs) Handles MI_Open.Click
        Dim buff As String

        If Dialog_OpenFile.ShowDialog() = DialogResult.OK Then  ' 点击文件打开对话框的【打开】按键
            Me.filePath = Dialog_OpenFile.FileName  ' 获取文件路径
        Else
            Exit Sub
        End If

        fileNumber = FreeFile()  ' 取得文件号码
        TB_Editor.Text = ""  ' 清空文本框内容
        Me.currentContent = ""  ' 清空原文件缓存内容
        FileOpen(Me.fileNumber, Me.filePath, OpenMode.Input)  ' 已读取模式打开文件
        Do Until EOF(Me.fileNumber)
            buff = LineInput(Me.fileNumber)  ' 逐行读取文件
            'TB_Editor.Text = TB_Editor.Text & buff & vbCrLf  ' 在文本框里逐行写入文件
            Me.currentContent = Me.currentContent & buff & vbCrLf  ' 向原文件缓存内容里写入数据
        Loop
        FileClose(Me.fileNumber)  ' 关闭文件

        ' 去掉文本末尾的换行符
        Me.currentContent = Me.currentContent.Substring(0, Me.currentContent.Length - 1)
        TB_Editor.Text = Me.currentContent
        Me.isEdited = False

        ' 变更窗口的标题内容
        Me.fileName = Path.GetFileName(Me.filePath)  ' 获取当前文件的文件名(含扩展名，不含路径)
        Me.Text = Me.fileName & NOTE_PAD
    End Sub

    ' 退出
    Private Sub MI_Exit_Click(sender As Object, e As EventArgs) Handles MI_Exit.Click
        Application.Exit()
    End Sub

    ' 另存为
    Private Sub MI_SaveAs_Click(sender As Object, e As EventArgs) Handles MI_SaveAs.Click
        If Dialog_SaveFile.ShowDialog() = DialogResult.OK Then  ' 点击文件保存对话框的【保存】按键
            Me.filePath = Dialog_SaveFile.FileName  ' 获取文件路径
        Else
            Exit Sub
        End If

        Me.fileNumber = FreeFile()  ' 获取文件号码
        FileOpen(Me.fileNumber, Me.filePath, OpenMode.Output)  ' 以写入模式打开文件
        PrintLine(Me.fileNumber, TB_Editor.Text)  ' 把文本框的内容逐行写入文件
        FileClose(Me.fileNumber)  ' 关闭文件
        Me.isEdited = False

        ' 变更窗口的标题内容
        Me.fileName = Path.GetFileName(Me.filePath)  ' 获取当前文件的文件名(含扩展名，不含路径)
        Me.Text = Me.fileName & NOTE_PAD
    End Sub

    ' 新建
    Private Sub MI_Create_Click(sender As Object, e As EventArgs) Handles MI_Create.Click
        Dim newPad As NotePad = New NotePad
        newPad.Show()
    End Sub

    ' 窗口加载事件
    Private Sub NotePad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.filePath = Nothing Then
            Me.Text = NO_TITLE & NOTE_PAD
        End If
    End Sub

    ' 窗口关闭事件
    Private Sub NotePad_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If Me.isEdited Then  ' 文件内容有变更的话
            Dim selectResult As Integer  ' 选择框的选择结果
            If Me.filePath = Nothing Then  ' 文件不存在的话
                selectResult = MessageBox.Show(
                    "你需要保存文件吗？", "记事本", MessageBoxButtons.YesNoCancel)  ' 获取选择框的选择结果
                If selectResult = DialogResult.Yes Then  ' 选择【是】
                    MI_SaveAs_Click(sender, e)  ' 调用【另存为】按键
                    ' 关闭窗口，程序结束
                ElseIf selectResult = DialogResult.No Then  '选择【否】
                    ' 关闭窗口，程序结束
                ElseIf selectResult = DialogResult.Cancel Then  '选择【取消】
                    e.Cancel = True  ' 结束关闭主窗口的进程
                    Exit Sub  ' 关闭对话框，回到主窗口
                End If
            Else  ' 文件存在的话
                selectResult = MessageBox.Show(
                    "你需要保存文件到" & vbCrLf &
                    Me.filePath & vbCrLf &
                    "吗？",
                    "记事本",
                    MessageBoxButtons.YesNoCancel)  ' 获取选择框的选择结果
                If selectResult = DialogResult.Yes Then  ' 选择【是】
                    MI_Save_Click(sender, e)  ' 调用【保存】按键
                    ' 关闭窗口，程序结束
                ElseIf selectResult = DialogResult.No Then  ' 选择【否】
                    ' 关闭窗口，程序结束
                ElseIf selectResult = DialogResult.Cancel Then  ' 选择【取消】
                    e.Cancel = True  ' 结束关闭主窗口的进程
                    Exit Sub  ' 关闭对话框，回到主窗口
                End If
            End If
        End If

        ' 文件内容没有变更
        ' 关闭窗口，程序结束
    End Sub

    ' 文本框内容改变事件
    Private Sub TB_Editor_TextChanged(sender As Object, e As EventArgs) Handles TB_Editor.TextChanged
        If Equals(currentContent, TB_Editor.Text) = False Then  ' 文本框内容有变更的话
            Me.isEdited = True

            ' 变更窗口的标题内容
            If Me.filePath = Nothing Then
                Me.Text = ASTER & NO_TITLE & NOTE_PAD
            Else
                Me.Text = ASTER & Me.fileName & NOTE_PAD
            End If
        End If
    End Sub

    Private Sub MI_Now_Click(sender As Object, e As EventArgs) Handles MI_Now.Click

    End Sub

    ' 剪切
    Private Sub MI_Cut_Click(sender As Object, e As EventArgs) Handles MI_Cut.Click
        TB_Editor.Cut()
    End Sub

    ' 粘贴
    Private Sub MI_Paste_Click(sender As Object, e As EventArgs) Handles MI_Paste.Click
        TB_Editor.Paste()
    End Sub

    ' 复制
    Private Sub MI_Copy_Click(sender As Object, e As EventArgs) Handles MI_Copy.Click
        TB_Editor.Copy()
    End Sub

    ' 全选
    Private Sub MI_SelectAll_Click(sender As Object, e As EventArgs) Handles MI_SelectAll.Click
        TB_Editor.SelectAll()
    End Sub

    ' 删除
    Private Sub MI_Delete_Click(sender As Object, e As EventArgs) Handles MI_Delete.Click
        Dim text As String = TB_Editor.Text
        text = text.Remove(TB_Editor.SelectionStart, TB_Editor.SelectionLength)  ' 删除选中的文本内容
        TB_Editor.Text = text
    End Sub

    ' 撤销
    Private Sub MI_Undo_Click(sender As Object, e As EventArgs) Handles MI_Undo.Click
        TB_Editor.Undo()
    End Sub

    ' 自动换行
    Private Sub MI_AutoWrapped_Click(sender As Object, e As EventArgs) Handles MI_AutoWrapped.Click
        MI_AutoWrapped.Checked = Not MI_AutoWrapped.Checked  ' 设置【自动换行】按键的选中标识
        TB_Editor.WordWrap = MI_AutoWrapped.Checked  ' 设置文本框的【文字换行】属性
    End Sub

    ' 字体
    Private Sub MI_Font_Click(sender As Object, e As EventArgs) Handles MI_Font.Click
        If Dialog_Font.ShowDialog() = DialogResult.OK Then
            TB_Editor.Font = Dialog_Font.Font
        End If
    End Sub

    ' 缩放：放大
    Private Sub MI_ZoomUp_Click(sender As Object, e As EventArgs) Handles MI_ZoomUp.Click
        Dim font As Font = New Font(
            TB_Editor.Font.Name,
            TB_Editor.Font.Size + 1,  ' 字体放大一号
            TB_Editor.Font.Style,
            TB_Editor.Font.Unit,
            TB_Editor.Font.GdiCharSet
        )
        TB_Editor.Font = font  ' 设置新字体
    End Sub

    ' 缩放：缩小
    Private Sub MI_ZoomDown_Click(sender As Object, e As EventArgs) Handles MI_ZoomDown.Click
        Dim font As Font = New Font(
            TB_Editor.Font.Name,
            IIf(TB_Editor.Font.Size - 1 > 0.0!, TB_Editor.Font.Size - 1, TB_Editor.Font.Size),  ' 字体缩小一号
            TB_Editor.Font.Style,
            TB_Editor.Font.Unit,
            TB_Editor.Font.GdiCharSet
        )
        TB_Editor.Font = font  ' 设置新字体
    End Sub

    ' 缩放：恢复默认缩放
    Private Sub MI_ZoomDefault_Click(sender As Object, e As EventArgs) Handles MI_ZoomDefault.Click
        ' 默认的缩放大小保存在字体对话框中，所以从那么读取
        TB_Editor.Font = Dialog_Font.Font
    End Sub

    ' 关于记事本
    Private Sub MI_AboutNotePad_Click(sender As Object, e As EventArgs) Handles MI_AboutNotePad.Click
        MessageBox.Show(
            "这是一个记事本软件。已实现Windows自带记事本软件的核心内容。" & vbCrLf &
            "@Author 李敦煌",
            "记事本",
            MessageBoxButtons.OK)
    End Sub

    Private Sub CMS_PopupMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CMS_PopupMenu.Opening

    End Sub

    ' 上下文目录【撤销】
    Private Sub PMenu_Undo_Click(sender As Object, e As EventArgs) Handles PMenu_Undo.Click
        MI_Undo_Click(sender, e)
    End Sub

    ' 上下文目录【剪切】
    Private Sub PMenu_Cut_Click(sender As Object, e As EventArgs) Handles PMenu_Cut.Click
        MI_Cut_Click(sender, e)
    End Sub

    ' 上下文目录【复制】
    Private Sub PMenu_Copy_Click(sender As Object, e As EventArgs) Handles PMenu_Copy.Click
        MI_Copy_Click(sender, e)
    End Sub

    ' 上下文目录【粘贴】
    Private Sub PMenu_Paste_Click(sender As Object, e As EventArgs) Handles PMenu_Paste.Click
        MI_Paste_Click(sender, e)
    End Sub

    ' 上下文目录【删除】
    Private Sub PMenu_Delete_Click(sender As Object, e As EventArgs) Handles PMenu_Delete.Click
        MI_Delete_Click(sender, e)
    End Sub

    ' 上下文目录【全选】
    Private Sub PMenu_SelectAll_Click(sender As Object, e As EventArgs) Handles PMenu_SelectAll.Click
        MI_SelectAll_Click(sender, e)
    End Sub
End Class
