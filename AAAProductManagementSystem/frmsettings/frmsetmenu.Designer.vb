<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsetmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsetmenu))
        Me.ststatus = New System.Windows.Forms.StatusStrip()
        Me.stlabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnaddemployee = New System.Windows.Forms.Button()
        Me.btnaddproducts = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ststatus.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ststatus
        '
        Me.ststatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ststatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlabel})
        Me.ststatus.Location = New System.Drawing.Point(0, 114)
        Me.ststatus.Name = "ststatus"
        Me.ststatus.Size = New System.Drawing.Size(405, 22)
        Me.ststatus.SizingGrip = False
        Me.ststatus.TabIndex = 2
        Me.ststatus.Text = "StatusStrip1"
        '
        'stlabel
        '
        Me.stlabel.ForeColor = System.Drawing.Color.White
        Me.stlabel.Name = "stlabel"
        Me.stlabel.Size = New System.Drawing.Size(140, 17)
        Me.stlabel.Text = "Amber and Ambrose Ent."
        '
        'btnaddemployee
        '
        Me.btnaddemployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddemployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddemployee.FlatAppearance.BorderSize = 0
        Me.btnaddemployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddemployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddemployee.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddemployee.ForeColor = System.Drawing.Color.White
        Me.btnaddemployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddemployee.Location = New System.Drawing.Point(21, 36)
        Me.btnaddemployee.Name = "btnaddemployee"
        Me.btnaddemployee.Size = New System.Drawing.Size(166, 44)
        Me.btnaddemployee.TabIndex = 4
        Me.btnaddemployee.Text = "| Add Employee"
        Me.btnaddemployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddemployee.UseVisualStyleBackColor = False
        '
        'btnaddproducts
        '
        Me.btnaddproducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddproducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddproducts.FlatAppearance.BorderSize = 0
        Me.btnaddproducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddproducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnaddproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddproducts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddproducts.ForeColor = System.Drawing.Color.White
        Me.btnaddproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddproducts.Location = New System.Drawing.Point(216, 36)
        Me.btnaddproducts.Name = "btnaddproducts"
        Me.btnaddproducts.Size = New System.Drawing.Size(157, 47)
        Me.btnaddproducts.TabIndex = 5
        Me.btnaddproducts.Text = "| Add Products"
        Me.btnaddproducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnaddproducts.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(223, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'frmsetmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(405, 136)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnaddproducts)
        Me.Controls.Add(Me.btnaddemployee)
        Me.Controls.Add(Me.ststatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmsetmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ststatus.ResumeLayout(False)
        Me.ststatus.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ststatus As StatusStrip
    Friend WithEvents stlabel As ToolStripStatusLabel
    Friend WithEvents btnaddemployee As Button
    Friend WithEvents btnaddproducts As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
