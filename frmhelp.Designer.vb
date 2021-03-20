<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhelp))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.txtmaster = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtinventory = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txtreport = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.txtstocks = New System.Windows.Forms.TextBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.txtcomplaint = New System.Windows.Forms.TextBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.txtinstallment = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(695, 536)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtmaster)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(687, 510)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "MASTER"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtmaster
        '
        Me.txtmaster.Location = New System.Drawing.Point(14, 18)
        Me.txtmaster.Multiline = True
        Me.txtmaster.Name = "txtmaster"
        Me.txtmaster.Size = New System.Drawing.Size(657, 473)
        Me.txtmaster.TabIndex = 0
        Me.txtmaster.Text = resources.GetString("txtmaster.Text")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtinventory)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(687, 510)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INVENTORY"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtinventory
        '
        Me.txtinventory.Location = New System.Drawing.Point(16, 10)
        Me.txtinventory.Multiline = True
        Me.txtinventory.Name = "txtinventory"
        Me.txtinventory.Size = New System.Drawing.Size(651, 484)
        Me.txtinventory.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtreport)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(687, 510)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "REPORTS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtreport
        '
        Me.txtreport.Location = New System.Drawing.Point(12, 16)
        Me.txtreport.Multiline = True
        Me.txtreport.Name = "txtreport"
        Me.txtreport.Size = New System.Drawing.Size(663, 479)
        Me.txtreport.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtstocks)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(687, 510)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "STOCKS"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txtstocks
        '
        Me.txtstocks.Location = New System.Drawing.Point(13, 12)
        Me.txtstocks.Multiline = True
        Me.txtstocks.Name = "txtstocks"
        Me.txtstocks.Size = New System.Drawing.Size(655, 484)
        Me.txtstocks.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtcomplaint)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(687, 510)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "COMPLAINTS"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'txtcomplaint
        '
        Me.txtcomplaint.Location = New System.Drawing.Point(15, 13)
        Me.txtcomplaint.Multiline = True
        Me.txtcomplaint.Name = "txtcomplaint"
        Me.txtcomplaint.Size = New System.Drawing.Size(658, 482)
        Me.txtcomplaint.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.txtinstallment)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(687, 510)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "INSTALLMENTS"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'txtinstallment
        '
        Me.txtinstallment.Location = New System.Drawing.Point(15, 9)
        Me.txtinstallment.Multiline = True
        Me.txtinstallment.Name = "txtinstallment"
        Me.txtinstallment.Size = New System.Drawing.Size(656, 488)
        Me.txtinstallment.TabIndex = 0
        '
        'frmhelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 560)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmhelp"
        Me.Text = "HELP"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtmaster As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents txtinventory As System.Windows.Forms.TextBox
    Friend WithEvents txtreport As System.Windows.Forms.TextBox
    Friend WithEvents txtstocks As System.Windows.Forms.TextBox
    Friend WithEvents txtcomplaint As System.Windows.Forms.TextBox
    Friend WithEvents txtinstallment As System.Windows.Forms.TextBox
End Class
