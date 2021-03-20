<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmstocks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnedit = New System.Windows.Forms.Button
        Me.txtcomname = New System.Windows.Forms.TextBox
        Me.btnclear = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.stdate = New System.Windows.Forms.DateTimePicker
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnback = New System.Windows.Forms.Button
        Me.txtprost = New System.Windows.Forms.TextBox
        Me.btnsubmit = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txttotsold = New System.Windows.Forms.TextBox
        Me.txttotqun = New System.Windows.Forms.TextBox
        Me.txticode = New System.Windows.Forms.TextBox
        Me.txtsid = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(434, 166)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(175, 29)
        Me.btnedit.TabIndex = 22
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'txtcomname
        '
        Me.txtcomname.Location = New System.Drawing.Point(196, 324)
        Me.txtcomname.Name = "txtcomname"
        Me.txtcomname.Size = New System.Drawing.Size(203, 20)
        Me.txtcomname.TabIndex = 25
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(434, 207)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(175, 29)
        Me.btnclear.TabIndex = 22
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.stdate)
        Me.GroupBox2.Controls.Add(Me.btnclear)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Controls.Add(Me.txtcomname)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnback)
        Me.GroupBox2.Controls.Add(Me.txtprost)
        Me.GroupBox2.Controls.Add(Me.btnsubmit)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txttotsold)
        Me.GroupBox2.Controls.Add(Me.txttotqun)
        Me.GroupBox2.Controls.Add(Me.txticode)
        Me.GroupBox2.Controls.Add(Me.txtsid)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(651, 403)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        '
        'stdate
        '
        Me.stdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.stdate.Location = New System.Drawing.Point(196, 215)
        Me.stdate.Name = "stdate"
        Me.stdate.Size = New System.Drawing.Size(200, 20)
        Me.stdate.TabIndex = 26
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(23, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(604, 91)
        Me.DataGridView2.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(32, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Company name"
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(434, 246)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(175, 29)
        Me.btnback.TabIndex = 13
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'txtprost
        '
        Me.txtprost.Location = New System.Drawing.Point(196, 286)
        Me.txtprost.Name = "txtprost"
        Me.txtprost.Size = New System.Drawing.Size(203, 20)
        Me.txtprost.TabIndex = 23
        '
        'btnsubmit
        '
        Me.btnsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmit.Location = New System.Drawing.Point(434, 129)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(175, 31)
        Me.btnsubmit.TabIndex = 12
        Me.btnsubmit.Text = "SUBMIT"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Problem stock"
        '
        'txttotsold
        '
        Me.txttotsold.Location = New System.Drawing.Point(196, 249)
        Me.txttotsold.Name = "txttotsold"
        Me.txttotsold.Size = New System.Drawing.Size(203, 20)
        Me.txttotsold.TabIndex = 10
        '
        'txttotqun
        '
        Me.txttotqun.Location = New System.Drawing.Point(196, 185)
        Me.txttotqun.Name = "txttotqun"
        Me.txttotqun.Size = New System.Drawing.Size(203, 20)
        Me.txttotqun.TabIndex = 8
        '
        'txticode
        '
        Me.txticode.Location = New System.Drawing.Point(196, 157)
        Me.txticode.Name = "txticode"
        Me.txticode.Size = New System.Drawing.Size(203, 20)
        Me.txticode.TabIndex = 7
        '
        'txtsid
        '
        Me.txtsid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsid.Location = New System.Drawing.Point(196, 125)
        Me.txtsid.Name = "txtsid"
        Me.txtsid.Size = New System.Drawing.Size(203, 22)
        Me.txtsid.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(31, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 16)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Total sold"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Date"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(31, 189)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 16)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Total  quantity "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(31, 158)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 16)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Item code"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(31, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Stock id"
        '
        'Frmstocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 460)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frmstocks"
        Me.Text = "STOCKS DETAILS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents txtcomname As System.Windows.Forms.TextBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents txtprost As System.Windows.Forms.TextBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txttotsold As System.Windows.Forms.TextBox
    Friend WithEvents txttotqun As System.Windows.Forms.TextBox
    Friend WithEvents txticode As System.Windows.Forms.TextBox
    Friend WithEvents txtsid As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents stdate As System.Windows.Forms.DateTimePicker
End Class
