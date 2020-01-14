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
            MI_SaveAs_Click(sender, e)  ' 调用【另存为】按钮
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

        If Dialog_OpenFile.ShowDialog() = DialogResult.OK Then  ' 点击文件打开对话框的【打开】按钮
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
            TB_Editor.Text = TB_Editor.Text & buff & vbCrLf  ' 在文本框里逐行写入文件
            Me.currentContent = Me.currentContent & buff & vbCrLf  ' 向原文件缓存内容里写入数据
        Loop
        FileClose(Me.fileNumber)  ' 关闭文件
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
        If Dialog_SaveFile.ShowDialog() = DialogResult.OK Then  ' 点击文件保存对话框的【保存】按钮
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
            MessageBox.Show("文件内容有变更。")
            e.Cancel = True  ' 取消窗口关闭的进程
        Else
            Application.Exit()  ' 关闭窗口，程序结束
        End If
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
End Class
