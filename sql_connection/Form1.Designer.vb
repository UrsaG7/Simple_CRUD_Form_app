<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        text_clientname = New TextBox()
        text_city = New TextBox()
        text_salesid = New TextBox()
        button_add = New Button()
        button_update = New Button()
        button_delete = New Button()
        button_reset = New Button()
        button_print = New Button()
        button_exit = New Button()
        DataGridView1 = New DataGridView()
        ToolTip1 = New ToolTip(components)
        box_search = New TextBox()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        Panel1 = New Panel()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Panel2 = New Panel()
        panel_login = New Panel()
        button_login = New Button()
        Label8 = New Label()
        Label7 = New Label()
        text_password = New TextBox()
        text_employeeid = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        panel_login.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Open Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 26)
        Label2.TabIndex = 0
        Label2.Text = "Client Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Open Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 26)
        Label3.TabIndex = 0
        Label3.Text = "City"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Open Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(29, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 26)
        Label4.TabIndex = 0
        Label4.Text = "Client Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Open Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(28, 279)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 26)
        Label5.TabIndex = 0
        Label5.Text = "Sales Person Id"
        ' 
        ' text_clientname
        ' 
        text_clientname.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        text_clientname.Location = New Point(187, 96)
        text_clientname.Name = "text_clientname"
        text_clientname.Size = New Size(318, 39)
        text_clientname.TabIndex = 1
        ' 
        ' text_city
        ' 
        text_city.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        text_city.Location = New Point(187, 158)
        text_city.Name = "text_city"
        text_city.Size = New Size(318, 39)
        text_city.TabIndex = 1
        ' 
        ' text_salesid
        ' 
        text_salesid.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        text_salesid.Location = New Point(186, 270)
        text_salesid.Name = "text_salesid"
        text_salesid.Size = New Size(318, 39)
        text_salesid.TabIndex = 1
        ' 
        ' button_add
        ' 
        button_add.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button_add.Location = New Point(5, 31)
        button_add.Name = "button_add"
        button_add.Size = New Size(204, 63)
        button_add.TabIndex = 2
        button_add.Text = "Add New"
        ToolTip1.SetToolTip(button_add, "Add")
        button_add.UseVisualStyleBackColor = True
        ' 
        ' button_update
        ' 
        button_update.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button_update.Location = New Point(5, 100)
        button_update.Name = "button_update"
        button_update.Size = New Size(204, 63)
        button_update.TabIndex = 2
        button_update.Text = "Refresh"
        button_update.UseVisualStyleBackColor = True
        ' 
        ' button_delete
        ' 
        button_delete.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button_delete.Location = New Point(5, 169)
        button_delete.Name = "button_delete"
        button_delete.Size = New Size(204, 63)
        button_delete.TabIndex = 2
        button_delete.Text = "Delete"
        ToolTip1.SetToolTip(button_delete, "Delete")
        button_delete.UseVisualStyleBackColor = True
        ' 
        ' button_reset
        ' 
        button_reset.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button_reset.Location = New Point(5, 238)
        button_reset.Name = "button_reset"
        button_reset.Size = New Size(204, 63)
        button_reset.TabIndex = 2
        button_reset.Text = "Reset"
        ToolTip1.SetToolTip(button_reset, "Reset")
        button_reset.UseVisualStyleBackColor = True
        ' 
        ' button_print
        ' 
        button_print.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button_print.Location = New Point(5, 307)
        button_print.Name = "button_print"
        button_print.Size = New Size(204, 63)
        button_print.TabIndex = 2
        button_print.Text = "Print"
        ToolTip1.SetToolTip(button_print, "Print")
        button_print.UseVisualStyleBackColor = True
        ' 
        ' button_exit
        ' 
        button_exit.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        button_exit.Location = New Point(5, 376)
        button_exit.Name = "button_exit"
        button_exit.Size = New Size(204, 63)
        button_exit.TabIndex = 2
        button_exit.Text = "Exit"
        ToolTip1.SetToolTip(button_exit, "Exit")
        button_exit.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 391)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(519, 174)
        DataGridView1.TabIndex = 3
        ' 
        ' box_search
        ' 
        box_search.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        box_search.Location = New Point(556, 40)
        box_search.Name = "box_search"
        box_search.Size = New Size(212, 39)
        box_search.TabIndex = 1
        ToolTip1.SetToolTip(box_search, "Search")
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.UseEXDialog = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(text_salesid)
        Panel1.Controls.Add(text_city)
        Panel1.Controls.Add(text_clientname)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(519, 350)
        Panel1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Open Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Azure
        Label1.Location = New Point(88, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(322, 33)
        Label1.TabIndex = 3
        Label1.Text = "Admin Tools, Client Editor"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Open Sans SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(186, 214)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(318, 41)
        ComboBox1.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(button_exit)
        Panel2.Controls.Add(button_print)
        Panel2.Controls.Add(button_reset)
        Panel2.Controls.Add(button_delete)
        Panel2.Controls.Add(button_update)
        Panel2.Controls.Add(button_add)
        Panel2.Location = New Point(556, 94)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(212, 471)
        Panel2.TabIndex = 5
        ' 
        ' panel_login
        ' 
        panel_login.Controls.Add(button_login)
        panel_login.Controls.Add(Label8)
        panel_login.Controls.Add(Label7)
        panel_login.Controls.Add(text_password)
        panel_login.Controls.Add(text_employeeid)
        panel_login.Location = New Point(3, 12)
        panel_login.Name = "panel_login"
        panel_login.Size = New Size(774, 565)
        panel_login.TabIndex = 6
        ' 
        ' button_login
        ' 
        button_login.Font = New Font("Open Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        button_login.Location = New Point(306, 284)
        button_login.Name = "button_login"
        button_login.Size = New Size(93, 33)
        button_login.TabIndex = 2
        button_login.Text = "Login"
        button_login.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Open Sans SemiBold", 12F, FontStyle.Bold)
        Label8.Location = New Point(196, 236)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 22)
        Label8.TabIndex = 1
        Label8.Text = "Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Open Sans SemiBold", 12F, FontStyle.Bold)
        Label7.Location = New Point(196, 189)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 22)
        Label7.TabIndex = 1
        Label7.Text = "Employee Id"
        ' 
        ' text_password
        ' 
        text_password.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        text_password.Location = New Point(306, 233)
        text_password.Name = "text_password"
        text_password.Size = New Size(261, 29)
        text_password.TabIndex = 0
        ' 
        ' text_employeeid
        ' 
        text_employeeid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        text_employeeid.Location = New Point(306, 186)
        text_employeeid.Name = "text_employeeid"
        text_employeeid.Size = New Size(261, 29)
        text_employeeid.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(780, 577)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(box_search)
        Controls.Add(panel_login)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        panel_login.ResumeLayout(False)
        panel_login.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents text_clientname As TextBox
    Friend WithEvents text_city As TextBox
    Friend WithEvents text_salesid As TextBox
    Friend WithEvents button_add As Button
    Friend WithEvents button_update As Button
    Friend WithEvents button_delete As Button
    Friend WithEvents button_reset As Button
    Friend WithEvents button_print As Button
    Friend WithEvents button_exit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents box_search As TextBox
    Friend WithEvents panel_login As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents text_password As TextBox
    Friend WithEvents text_employeeid As TextBox
    Friend WithEvents button_login As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label

End Class
