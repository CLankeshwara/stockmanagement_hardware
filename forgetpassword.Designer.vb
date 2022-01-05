<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgetpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgetpassword))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtverify = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Btnfinal = New System.Windows.Forms.Button()
        Me.Btnmsubmit = New System.Windows.Forms.Button()
        Me.Lbltest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Type your verification code"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Input your E-mail here"
        '
        'txtverify
        '
        Me.txtverify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtverify.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtverify.Location = New System.Drawing.Point(311, 193)
        Me.txtverify.Name = "txtverify"
        Me.txtverify.Size = New System.Drawing.Size(300, 29)
        Me.txtverify.TabIndex = 9
        '
        'txtemail
        '
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(311, 73)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(300, 29)
        Me.txtemail.TabIndex = 8
        '
        'Btnfinal
        '
        Me.Btnfinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfinal.Location = New System.Drawing.Point(373, 245)
        Me.Btnfinal.Name = "Btnfinal"
        Me.Btnfinal.Size = New System.Drawing.Size(119, 33)
        Me.Btnfinal.TabIndex = 7
        Me.Btnfinal.Text = "Verify"
        Me.Btnfinal.UseVisualStyleBackColor = True
        '
        'Btnmsubmit
        '
        Me.Btnmsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmsubmit.Location = New System.Drawing.Point(373, 126)
        Me.Btnmsubmit.Name = "Btnmsubmit"
        Me.Btnmsubmit.Size = New System.Drawing.Size(119, 34)
        Me.Btnmsubmit.TabIndex = 6
        Me.Btnmsubmit.Text = "Submit"
        Me.Btnmsubmit.UseVisualStyleBackColor = True
        '
        'Lbltest
        '
        Me.Lbltest.AutoSize = True
        Me.Lbltest.Location = New System.Drawing.Point(611, 397)
        Me.Lbltest.Name = "Lbltest"
        Me.Lbltest.Size = New System.Drawing.Size(38, 13)
        Me.Lbltest.TabIndex = 12
        Me.Lbltest.Text = "Lbltest"
        '
        'forgetpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(661, 419)
        Me.Controls.Add(Me.Lbltest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtverify)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Btnfinal)
        Me.Controls.Add(Me.Btnmsubmit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "forgetpassword"
        Me.Text = "Forget Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtverify As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Btnfinal As Button
    Friend WithEvents Btnmsubmit As Button
    Friend WithEvents Lbltest As Label
End Class
