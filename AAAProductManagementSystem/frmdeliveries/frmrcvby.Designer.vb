<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrcvby
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
        Me.cbrcv = New System.Windows.Forms.ComboBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnrcv = New System.Windows.Forms.Button()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblflash = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbrcv
        '
        Me.cbrcv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbrcv.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbrcv.FormattingEnabled = True
        Me.cbrcv.Items.AddRange(New Object() {"--select--"})
        Me.cbrcv.Location = New System.Drawing.Point(126, 23)
        Me.cbrcv.Name = "cbrcv"
        Me.cbrcv.Size = New System.Drawing.Size(199, 27)
        Me.cbrcv.TabIndex = 11
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(125, 98)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(200, 27)
        Me.txtpassword.TabIndex = 9
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(22, 98)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(104, 27)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Password"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(22, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(104, 27)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Rcv by"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnrcv
        '
        Me.btnrcv.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrcv.Location = New System.Drawing.Point(126, 140)
        Me.btnrcv.Name = "btnrcv"
        Me.btnrcv.Size = New System.Drawing.Size(86, 33)
        Me.btnrcv.TabIndex = 12
        Me.btnrcv.Text = "Recieved"
        Me.btnrcv.UseVisualStyleBackColor = True
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(125, 65)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(200, 27)
        Me.txtusername.TabIndex = 13
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(22, 65)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(103, 27)
        Me.label2.TabIndex = 14
        Me.label2.Text = "Username"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblflash
        '
        Me.lblflash.AutoSize = True
        Me.lblflash.BackColor = System.Drawing.SystemColors.Control
        Me.lblflash.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblflash.Location = New System.Drawing.Point(79, 65)
        Me.lblflash.Name = "lblflash"
        Me.lblflash.Size = New System.Drawing.Size(215, 37)
        Me.lblflash.TabIndex = 15
        Me.lblflash.Text = "Please wait...."
        Me.lblflash.Visible = False
        '
        'frmrcvby
        '
        Me.AcceptButton = Me.btnrcv
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(352, 184)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnrcv)
        Me.Controls.Add(Me.cbrcv)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.lblflash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrcvby"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recieved"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbrcv As ComboBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents btnrcv As Button
    Friend WithEvents txtusername As TextBox
    Friend WithEvents label2 As Label
    Friend WithEvents lblflash As Label
End Class
