<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frminstallment
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
        Me.txtinstype = New System.Windows.Forms.TextBox
        Me.txttocost = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnedit = New System.Windows.Forms.Button
        Me.txtpaidins = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtinscost = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnback = New System.Windows.Forms.Button
        Me.txtpre = New System.Windows.Forms.TextBox
        Me.btnsubmitt = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtcustname = New System.Windows.Forms.TextBox
        Me.txtsid = New System.Windows.Forms.TextBox
        Me.txtiid = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.stdate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtinstype
        '
        Me.txtinstype.Location = New System.Drawing.Point(196, 284)
        Me.txtinstype.Name = "txtinstype"
        Me.txtinstype.Size = New System.Drawing.Size(203, 20)
        Me.txtinstype.TabIndex = 11
        '
        'txttocost
        '
        Me.txttocost.Location = New System.Drawing.Point(196, 249)
        Me.txttocost.Name = "txttocost"
        Me.txttocost.Size = New System.Drawing.Size(203, 20)
        Me.txttocost.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.stdate)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnedit)
        Me.GroupBox1.Controls.Add(Me.txtpaidins)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtinscost)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.btnback)
        Me.GroupBox1.Controls.Add(Me.txtpre)
        Me.GroupBox1.Controls.Add(Me.btnsubmitt)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtinstype)
        Me.GroupBox1.Controls.Add(Me.txttocost)
        Me.GroupBox1.Controls.Add(Me.txtcustname)
        Me.GroupBox1.Controls.Add(Me.txtsid)
        Me.GroupBox1.Controls.Add(Me.txtiid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 441)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(434, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 35)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(434, 249)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(140, 35)
        Me.btnedit.TabIndex = 18
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'txtpaidins
        '
        Me.txtpaidins.Location = New System.Drawing.Point(196, 384)
        Me.txtpaidins.Name = "txtpaidins"
        Me.txtpaidins.Size = New System.Drawing.Size(203, 20)
        Me.txtpaidins.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "paid installment"
        '
        'txtinscost
        '
        Me.txtinscost.Location = New System.Drawing.Point(196, 349)
        Me.txtinscost.Name = "txtinscost"
        Me.txtinscost.Size = New System.Drawing.Size(203, 20)
        Me.txtinscost.TabIndex = 25
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(604, 91)
        Me.DataGridView1.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(32, 353)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 16)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "installment cost"
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(434, 207)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(140, 35)
        Me.btnback.TabIndex = 13
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'txtpre
        '
        Me.txtpre.Location = New System.Drawing.Point(196, 314)
        Me.txtpre.Name = "txtpre"
        Me.txtpre.Size = New System.Drawing.Size(203, 20)
        Me.txtpre.TabIndex = 23
        '
        'btnsubmitt
        '
        Me.btnsubmitt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubmitt.Location = New System.Drawing.Point(434, 158)
        Me.btnsubmitt.Name = "btnsubmitt"
        Me.btnsubmitt.Size = New System.Drawing.Size(140, 31)
        Me.btnsubmitt.TabIndex = 12
        Me.btnsubmitt.Text = "SUBMIT"
        Me.btnsubmitt.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 318)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Premium Installment "
        '
        'txtcustname
        '
        Me.txtcustname.Location = New System.Drawing.Point(196, 185)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(203, 20)
        Me.txtcustname.TabIndex = 8
        '
        'txtsid
        '
        Me.txtsid.Location = New System.Drawing.Point(196, 157)
        Me.txtsid.Name = "txtsid"
        Me.txtsid.Size = New System.Drawing.Size(203, 20)
        Me.txtsid.TabIndex = 7
        '
        'txtiid
        '
        Me.txtiid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtiid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiid.Location = New System.Drawing.Point(196, 125)
        Me.txtiid.Name = "txtiid"
        Me.txtiid.Size = New System.Drawing.Size(203, 22)
        Me.txtiid.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Installment type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sales  id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Installment ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(139, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(435, 38)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "INSTALLMENT DETAILS"
        '
        'stdate
        '
        Me.stdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.stdate.Location = New System.Drawing.Point(196, 218)
        Me.stdate.Name = "stdate"
        Me.stdate.Size = New System.Drawing.Size(203, 20)
        Me.stdate.TabIndex = 32
        '
        'Frminstallment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 531)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Frminstallment"
        Me.Text = "Installments"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsubmitt As System.Windows.Forms.Button
    Friend WithEvents txtinstype As System.Windows.Forms.TextBox
    Friend WithEvents txttocost As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents txtsid As System.Windows.Forms.TextBox
    Friend WithEvents txtiid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpaidins As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtinscost As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtpre As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents stdate As System.Windows.Forms.DateTimePicker
End Class
