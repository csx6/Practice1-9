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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.chkMem = New System.Windows.Forms.CheckBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.chkBirth = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(101, 352)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(188, 58)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "計算"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'chkMem
        '
        Me.chkMem.AutoSize = True
        Me.chkMem.Location = New System.Drawing.Point(101, 225)
        Me.chkMem.Name = "chkMem"
        Me.chkMem.Size = New System.Drawing.Size(253, 43)
        Me.chkMem.TabIndex = 1
        Me.chkMem.Text = "会員（2割引）"
        Me.chkMem.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(268, 95)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(192, 46)
        Me.txtPrice.TabIndex = 2
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(101, 98)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(77, 39)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "単価"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(429, 359)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(192, 46)
        Me.txtTotal.TabIndex = 2
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(101, 158)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(77, 39)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "個数"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(268, 155)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(192, 46)
        Me.txtNum.TabIndex = 2
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(312, 362)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(107, 39)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "値段："
        '
        'chkBirth
        '
        Me.chkBirth.AutoSize = True
        Me.chkBirth.Location = New System.Drawing.Point(101, 274)
        Me.chkBirth.Name = "chkBirth"
        Me.chkBirth.Size = New System.Drawing.Size(283, 43)
        Me.chkBirth.TabIndex = 1
        Me.chkBirth.Text = "誕生月（1割引）"
        Me.chkBirth.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 699)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.chkBirth)
        Me.Controls.Add(Me.chkMem)
        Me.Controls.Add(Me.btnCalc)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalc As Button
    Friend WithEvents chkMem As CheckBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents chkBirth As CheckBox
End Class
