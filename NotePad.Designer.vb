<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NotePad
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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Menu1 = New System.Windows.Forms.MenuStrip()
        Me.Menu_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Create = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Find = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Replace = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Now = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Format = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_AutoWrapped = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Font = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_View = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_Zoom = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_ZoomUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_ZoomDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_ZoomDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.MI_AboutNotePad = New System.Windows.Forms.ToolStripMenuItem()
        Me.TB_Editor = New System.Windows.Forms.TextBox()
        Me.CMS_PopupMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PMenu_Undo = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMenu_Cut = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMenu_Copy = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMenu_Paste = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMenu_Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMenu_Find = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMenu_Replace = New System.Windows.Forms.ToolStripMenuItem()
        Me.PMenu_SelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.Dialog_SaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.Dialog_OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.Dialog_Font = New System.Windows.Forms.FontDialog()
        Me.Menu1.SuspendLayout()
        Me.CMS_PopupMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu1
        '
        Me.Menu1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_File, Me.Menu_Edit, Me.Menu_Format, Me.Menu_View, Me.Menu_Help})
        Me.Menu1.Location = New System.Drawing.Point(0, 0)
        Me.Menu1.Name = "Menu1"
        Me.Menu1.Size = New System.Drawing.Size(800, 28)
        Me.Menu1.TabIndex = 0
        Me.Menu1.Text = "MenuStrip1"
        '
        'Menu_File
        '
        Me.Menu_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_Create, Me.MI_Open, Me.MI_Save, Me.MI_SaveAs, Me.MI_Exit})
        Me.Menu_File.Name = "Menu_File"
        Me.Menu_File.Size = New System.Drawing.Size(66, 24)
        Me.Menu_File.Text = "文件(&F)"
        '
        'MI_Create
        '
        Me.MI_Create.Name = "MI_Create"
        Me.MI_Create.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.MI_Create.Size = New System.Drawing.Size(240, 24)
        Me.MI_Create.Text = "新建(&N)"
        '
        'MI_Open
        '
        Me.MI_Open.Name = "MI_Open"
        Me.MI_Open.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.MI_Open.Size = New System.Drawing.Size(240, 24)
        Me.MI_Open.Text = "打开(&O)"
        '
        'MI_Save
        '
        Me.MI_Save.Name = "MI_Save"
        Me.MI_Save.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MI_Save.Size = New System.Drawing.Size(240, 24)
        Me.MI_Save.Text = "保存(&S)"
        '
        'MI_SaveAs
        '
        Me.MI_SaveAs.Name = "MI_SaveAs"
        Me.MI_SaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.MI_SaveAs.Size = New System.Drawing.Size(240, 24)
        Me.MI_SaveAs.Text = "另存为（&A)"
        '
        'MI_Exit
        '
        Me.MI_Exit.Name = "MI_Exit"
        Me.MI_Exit.Size = New System.Drawing.Size(240, 24)
        Me.MI_Exit.Text = "退出(&X)"
        '
        'Menu_Edit
        '
        Me.Menu_Edit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_Undo, Me.MI_Cut, Me.MI_Copy, Me.MI_Paste, Me.MI_Delete, Me.MI_Find, Me.MI_Replace, Me.MI_SelectAll, Me.MI_Now})
        Me.Menu_Edit.Name = "Menu_Edit"
        Me.Menu_Edit.Size = New System.Drawing.Size(67, 24)
        Me.Menu_Edit.Text = "编辑(&E)"
        '
        'MI_Undo
        '
        Me.MI_Undo.Name = "MI_Undo"
        Me.MI_Undo.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.MI_Undo.Size = New System.Drawing.Size(185, 24)
        Me.MI_Undo.Text = "撤销(&U)"
        '
        'MI_Cut
        '
        Me.MI_Cut.Name = "MI_Cut"
        Me.MI_Cut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.MI_Cut.Size = New System.Drawing.Size(185, 24)
        Me.MI_Cut.Text = "剪切(&T)"
        '
        'MI_Copy
        '
        Me.MI_Copy.Name = "MI_Copy"
        Me.MI_Copy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.MI_Copy.Size = New System.Drawing.Size(185, 24)
        Me.MI_Copy.Text = "复制(&C)"
        '
        'MI_Paste
        '
        Me.MI_Paste.Name = "MI_Paste"
        Me.MI_Paste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.MI_Paste.Size = New System.Drawing.Size(185, 24)
        Me.MI_Paste.Text = "粘贴(&P)"
        '
        'MI_Delete
        '
        Me.MI_Delete.Name = "MI_Delete"
        Me.MI_Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.MI_Delete.Size = New System.Drawing.Size(185, 24)
        Me.MI_Delete.Text = "删除(&L)"
        '
        'MI_Find
        '
        Me.MI_Find.Name = "MI_Find"
        Me.MI_Find.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.MI_Find.Size = New System.Drawing.Size(185, 24)
        Me.MI_Find.Text = "查找(&F)"
        '
        'MI_Replace
        '
        Me.MI_Replace.Name = "MI_Replace"
        Me.MI_Replace.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.MI_Replace.Size = New System.Drawing.Size(185, 24)
        Me.MI_Replace.Text = "替换(&R)"
        '
        'MI_SelectAll
        '
        Me.MI_SelectAll.Name = "MI_SelectAll"
        Me.MI_SelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.MI_SelectAll.Size = New System.Drawing.Size(185, 24)
        Me.MI_SelectAll.Text = "全选(&A)"
        '
        'MI_Now
        '
        Me.MI_Now.Name = "MI_Now"
        Me.MI_Now.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.MI_Now.Size = New System.Drawing.Size(185, 24)
        Me.MI_Now.Text = "时间/日期(&D)"
        '
        'Menu_Format
        '
        Me.Menu_Format.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_AutoWrapped, Me.MI_Font})
        Me.Menu_Format.Name = "Menu_Format"
        Me.Menu_Format.Size = New System.Drawing.Size(70, 24)
        Me.Menu_Format.Text = "格式(O)"
        '
        'MI_AutoWrapped
        '
        Me.MI_AutoWrapped.Checked = True
        Me.MI_AutoWrapped.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MI_AutoWrapped.Name = "MI_AutoWrapped"
        Me.MI_AutoWrapped.Size = New System.Drawing.Size(158, 24)
        Me.MI_AutoWrapped.Text = "自动换行(&W)"
        '
        'MI_Font
        '
        Me.MI_Font.Name = "MI_Font"
        Me.MI_Font.Size = New System.Drawing.Size(158, 24)
        Me.MI_Font.Text = "字体(&F)"
        '
        'Menu_View
        '
        Me.Menu_View.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_Zoom})
        Me.Menu_View.Name = "Menu_View"
        Me.Menu_View.Size = New System.Drawing.Size(68, 24)
        Me.Menu_View.Text = "查看(V)"
        '
        'MI_Zoom
        '
        Me.MI_Zoom.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_ZoomUp, Me.MI_ZoomDown, Me.MI_ZoomDefault})
        Me.MI_Zoom.Name = "MI_Zoom"
        Me.MI_Zoom.Size = New System.Drawing.Size(125, 24)
        Me.MI_Zoom.Text = "缩放(&Z)"
        '
        'MI_ZoomUp
        '
        Me.MI_ZoomUp.Name = "MI_ZoomUp"
        Me.MI_ZoomUp.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.MI_ZoomUp.Size = New System.Drawing.Size(212, 24)
        Me.MI_ZoomUp.Text = "放大(&I)"
        '
        'MI_ZoomDown
        '
        Me.MI_ZoomDown.Name = "MI_ZoomDown"
        Me.MI_ZoomDown.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.MI_ZoomDown.Size = New System.Drawing.Size(212, 24)
        Me.MI_ZoomDown.Text = "缩小(&O)"
        '
        'MI_ZoomDefault
        '
        Me.MI_ZoomDefault.Name = "MI_ZoomDefault"
        Me.MI_ZoomDefault.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.MI_ZoomDefault.Size = New System.Drawing.Size(212, 24)
        Me.MI_ZoomDefault.Text = "恢复默认缩放"
        '
        'Menu_Help
        '
        Me.Menu_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MI_AboutNotePad})
        Me.Menu_Help.Name = "Menu_Help"
        Me.Menu_Help.Size = New System.Drawing.Size(70, 24)
        Me.Menu_Help.Text = "帮助(H)"
        '
        'MI_AboutNotePad
        '
        Me.MI_AboutNotePad.Name = "MI_AboutNotePad"
        Me.MI_AboutNotePad.Size = New System.Drawing.Size(168, 24)
        Me.MI_AboutNotePad.Text = "关于记事本(&A)"
        '
        'TB_Editor
        '
        Me.TB_Editor.AcceptsReturn = True
        Me.TB_Editor.AcceptsTab = True
        Me.TB_Editor.ContextMenuStrip = Me.CMS_PopupMenu
        Me.TB_Editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TB_Editor.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TB_Editor.Location = New System.Drawing.Point(0, 28)
        Me.TB_Editor.Multiline = True
        Me.TB_Editor.Name = "TB_Editor"
        Me.TB_Editor.Size = New System.Drawing.Size(800, 422)
        Me.TB_Editor.TabIndex = 1
        '
        'CMS_PopupMenu
        '
        Me.CMS_PopupMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PMenu_Undo, Me.PMenu_Cut, Me.PMenu_Copy, Me.PMenu_Paste, Me.PMenu_Delete, Me.PMenu_Find, Me.PMenu_Replace, Me.PMenu_SelectAll})
        Me.CMS_PopupMenu.Name = "CMS_PopupMenu"
        Me.CMS_PopupMenu.Size = New System.Drawing.Size(126, 180)
        '
        'PMenu_Undo
        '
        Me.PMenu_Undo.Name = "PMenu_Undo"
        Me.PMenu_Undo.Size = New System.Drawing.Size(125, 22)
        Me.PMenu_Undo.Text = "撤销(&U）"
        '
        'PMenu_Cut
        '
        Me.PMenu_Cut.Name = "PMenu_Cut"
        Me.PMenu_Cut.Size = New System.Drawing.Size(125, 22)
        Me.PMenu_Cut.Text = "剪切(&T)"
        '
        'PMenu_Copy
        '
        Me.PMenu_Copy.Name = "PMenu_Copy"
        Me.PMenu_Copy.Size = New System.Drawing.Size(125, 22)
        Me.PMenu_Copy.Text = "复制(&C)"
        '
        'PMenu_Paste
        '
        Me.PMenu_Paste.Name = "PMenu_Paste"
        Me.PMenu_Paste.Size = New System.Drawing.Size(125, 22)
        Me.PMenu_Paste.Text = "粘贴(&T)"
        '
        'PMenu_Delete
        '
        Me.PMenu_Delete.Name = "PMenu_Delete"
        Me.PMenu_Delete.Size = New System.Drawing.Size(125, 22)
        Me.PMenu_Delete.Text = "删除(&D)"
        '
        'PMenu_Find
        '
        Me.PMenu_Find.Name = "PMenu_Find"
        Me.PMenu_Find.Size = New System.Drawing.Size(125, 22)
        Me.PMenu_Find.Text = "查找(&F)"
        '
        'PMenu_Replace
        '
        Me.PMenu_Replace.Name = "PMenu_Replace"
        Me.PMenu_Replace.Size = New System.Drawing.Size(125, 22)
        Me.PMenu_Replace.Text = "替换(&R)"
        '
        'PMenu_SelectAll
        '
        Me.PMenu_SelectAll.Name = "PMenu_SelectAll"
        Me.PMenu_SelectAll.Size = New System.Drawing.Size(125, 22)
        Me.PMenu_SelectAll.Text = "全选(&A)"
        '
        'Dialog_SaveFile
        '
        Me.Dialog_SaveFile.DefaultExt = "txt"
        Me.Dialog_SaveFile.Filter = "文本文件(*.txt)|*.txt"
        '
        'Dialog_OpenFile
        '
        Me.Dialog_OpenFile.FileName = "OpenFileDialog1"
        Me.Dialog_OpenFile.Filter = "文本文件(*.txt)|*.txt"
        '
        'Dialog_Font
        '
        Me.Dialog_Font.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '
        'NotePad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TB_Editor)
        Me.Controls.Add(Me.Menu1)
        Me.MainMenuStrip = Me.Menu1
        Me.Name = "NotePad"
        Me.Text = "记事本"
        Me.Menu1.ResumeLayout(False)
        Me.Menu1.PerformLayout()
        Me.CMS_PopupMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu1 As MenuStrip
    Friend WithEvents Menu_File As ToolStripMenuItem
    Friend WithEvents Menu_Edit As ToolStripMenuItem
    Friend WithEvents Menu_Format As ToolStripMenuItem
    Friend WithEvents Menu_View As ToolStripMenuItem
    Friend WithEvents Menu_Help As ToolStripMenuItem
    Friend WithEvents MI_Create As ToolStripMenuItem
    Friend WithEvents MI_Open As ToolStripMenuItem
    Friend WithEvents MI_Save As ToolStripMenuItem
    Friend WithEvents MI_SaveAs As ToolStripMenuItem
    Friend WithEvents MI_Exit As ToolStripMenuItem
    Friend WithEvents MI_Undo As ToolStripMenuItem
    Friend WithEvents MI_Cut As ToolStripMenuItem
    Friend WithEvents MI_Copy As ToolStripMenuItem
    Friend WithEvents MI_Paste As ToolStripMenuItem
    Friend WithEvents MI_Delete As ToolStripMenuItem
    Friend WithEvents MI_Find As ToolStripMenuItem
    Friend WithEvents MI_Replace As ToolStripMenuItem
    Friend WithEvents MI_SelectAll As ToolStripMenuItem
    Friend WithEvents MI_Now As ToolStripMenuItem
    Friend WithEvents MI_AutoWrapped As ToolStripMenuItem
    Friend WithEvents MI_Font As ToolStripMenuItem
    Friend WithEvents MI_Zoom As ToolStripMenuItem
    Friend WithEvents MI_AboutNotePad As ToolStripMenuItem
    Friend WithEvents TB_Editor As TextBox
    Friend WithEvents Dialog_SaveFile As SaveFileDialog
    Friend WithEvents Dialog_OpenFile As OpenFileDialog
    Friend WithEvents Dialog_Font As FontDialog
    Friend WithEvents MI_ZoomUp As ToolStripMenuItem
    Friend WithEvents MI_ZoomDown As ToolStripMenuItem
    Friend WithEvents MI_ZoomDefault As ToolStripMenuItem
    Friend WithEvents CMS_PopupMenu As ContextMenuStrip
    Friend WithEvents PMenu_Undo As ToolStripMenuItem
    Friend WithEvents PMenu_Cut As ToolStripMenuItem
    Friend WithEvents PMenu_Copy As ToolStripMenuItem
    Friend WithEvents PMenu_Paste As ToolStripMenuItem
    Friend WithEvents PMenu_Delete As ToolStripMenuItem
    Friend WithEvents PMenu_Find As ToolStripMenuItem
    Friend WithEvents PMenu_Replace As ToolStripMenuItem
    Friend WithEvents PMenu_SelectAll As ToolStripMenuItem
End Class
