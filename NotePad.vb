Public Class NotePad

    Private fileName As String  ' 当前文件的文件名(具体路径)
    Private fileNumber As Integer  ' 当前文件的文件号码

    ' 保存文件
    Private Sub MI_Save_Click(sender As Object, e As EventArgs) Handles MI_Save.Click

        If Dialog_SaveFile.ShowDialog() = DialogResult.OK Then  ' 点击文件保存对话框的【保存按钮】
            Me.fileName = Dialog_SaveFile.FileName  ' 获取文件名
        Else
            Exit Sub
        End If

        Me.fileNumber = FreeFile()  ' 获取文件号码
        FileOpen(Me.fileNumber, Me.fileName, OpenMode.Output)  ' 以写入模式打开文件
        PrintLine(Me.fileNumber, TB_Editor.Text)  ' 把文本框的内容换行写入文件
        FileClose(Me.fileNumber)  ' 关闭文件
    End Sub

    ' 打开文件
    Private Sub MI_Open_Click(sender As Object, e As EventArgs) Handles MI_Open.Click
        Dim buff As String

        If Dialog_OpenFile.ShowDialog() = DialogResult.OK Then  ' 点击文件打开对话框的【打开】按钮
            Me.fileName = Dialog_OpenFile.FileName
        Else
            Exit Sub
        End If

        fileNumber = FreeFile()  ' 取得文件号码
        FileOpen(Me.fileNumber, Me.fileName, OpenMode.Input)  ' 已读取模式打开文件
        Do Until EOF(Me.fileNumber)
            buff = LineInput(Me.fileNumber)  ' 逐行读取文件
            TB_Editor.Text = TB_Editor.Text & buff & vbCrLf  ' 在文本框里逐行写入文件
        Loop
        FileClose(Me.fileNumber)  ' 关闭文件
    End Sub

    ' 退出
    Private Sub MI_Exit_Click(sender As Object, e As EventArgs) Handles MI_Exit.Click
        Application.Exit()
    End Sub
End Class
