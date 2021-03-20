<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmvat
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
        Me.btnclear = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.btnsubmit = New System.Windows.Forms.Button
        Me.txtvatdesc = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnback = New System.Windows.Forms.Button
        Me.txtpervat = New System.Windows.Forms.TextBox
        Me.txtvattype = New System.Windows.Forms.TextBox
        Me.txtvatid = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(23, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(604, 91)
        Me.DataGridView2.TabIndex = 14
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
        'txtvatdesc
        '
        Me.txtvatdesc.Location = New System.Drawing.Point(196, 216)
        Me.txtvatdesc.Multiline = True
        Me.txtvatdesc.Name = "txtvatdesc"
        Me.txtvatdesc.Size = New System.Drawing.Size(203, 93)
        Me.txtvatdesc.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnclear)
        Me.GroupBox2.Controls.Add(Me.btnedit)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.btnback)
        Me.GroupBox2.Controls.Add(Me.btnsubmit)
        Me.GroupBox2.Controls.Add(Me.txtvatdesc)
        Me.GroupBox2.Controls.Add(Me.txtpervat)
        Me.GroupBox2.Controls.Add(Me.txtvattype)
        Me.GroupBox2.Controls.Add(Me.txtvatid)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(644, 340)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(434, 246)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(175, 29)
        Me.btnback.TabIndex = 13
        Me.btnback.Text = "CLOSE"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'txtpervat
        '
        Me.txtpervat.Location = New System.Drawing.Point(196, 185)
        Me.txtpervat.Name = "txtpervat"
        Me.txtpervat.Size = New System.Drawing.Size(203, 20)
        Me.txtpervat.TabIndex = 8
        '
        'txtvattype
        '
        Me.txtvattype.Location = New System.Drawing.Point(195, 157)
        Me.txtvattype.Name = "txtvattype"
        Me.txtvattype.Size = New System.Drawing.Size(203, 20)
        Me.txtvattype.TabIndex = 7
        '
        'txtvatid
        '
        Me.txtvatid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvatid.Location = New System.Drawing.Point(196, 125)
        Me.txtvatid.Name = "txtvatid"
        Me.txtvatid.Size = New System.Drawing.Size(203, 22)
        Me.txtvatid.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "VAT Description"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(31, 189)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 16)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Per  VAT"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(31, 158)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 16)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "VAT type"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(31, 129)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 16)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "VAT id"
        '
        'Frmvat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 413)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frmvat"
        Me.Text = "VAT MASTER"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents txtvatdesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents txtpervat As System.Windows.Forms.TextBox
    Friend WithEvents txtvattype As System.Windows.Forms.TextBox
    Friend WithEvents txtvatid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
End Class
