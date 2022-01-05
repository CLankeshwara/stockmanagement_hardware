<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(deleteuser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comusername = New System.Windows.Forms.ComboBox()
        Me.btndeleteuser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type your Username"
        '
        'comusername
        '
        Me.comusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comusername.FormattingEnabled = True
        Me.comusername.Location = New System.Drawing.Point(254, 44)
        Me.comusername.Name = "comusername"
        Me.comusername.Size = New System.Drawing.Size(186, 28)
        Me.comusername.TabIndex = 1
        '
        'btndeleteuser
        '
        Me.btndeleteuser.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteuser.Location = New System.Drawing.Point(254, 90)
        Me.btndeleteuser.Name = "btndeleteuser"
        Me.btndeleteuser.Size = New System.Drawing.Size(107, 41)
        Me.btndeleteuser.TabIndex = 2
        Me.btndeleteuser.Text = "Delete"
        Me.btndeleteuser.UseVisualStyleBackColor = True
        '
        'deleteuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 160)
        Me.Controls.Add(Me.btndeleteuser)
        Me.Controls.Add(Me.comusername)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "deleteuser"
        Me.Text = "Delete User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents comusername As ComboBox
    Friend WithEvents btndeleteuser As Button
End Class
