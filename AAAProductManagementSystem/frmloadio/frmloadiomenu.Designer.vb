<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmloadiomenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmloadiomenu))
        Me.btnloadout = New System.Windows.Forms.Button()
        Me.btnloadin = New System.Windows.Forms.Button()
        Me.ststatus = New System.Windows.Forms.StatusStrip()
        Me.stlabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ststatus.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnloadout
        '
        Me.btnloadout.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnloadout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnloadout.FlatAppearance.BorderSize = 0
        Me.btnloadout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnloadout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnloadout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloadout.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloadout.ForeColor = System.Drawing.Color.White
        Me.btnloadout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnloadout.Location = New System.Drawing.Point(216, 36)
        Me.btnloadout.Name = "btnloadout"
        Me.btnloadout.Size = New System.Drawing.Size(157, 47)
        Me.btnloadout.TabIndex = 7
        Me.btnloadout.Text = "| Load Out  "
        Me.btnloadout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnloadout.UseVisualStyleBackColor = False
        '
        'btnloadin
        '
        Me.btnloadin.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnloadin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnloadin.FlatAppearance.BorderSize = 0
        Me.btnloadin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnloadin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnloadin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnloadin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloadin.ForeColor = System.Drawing.Color.White
        Me.btnloadin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnloadin.Location = New System.Drawing.Point(21, 36)
        Me.btnloadin.Name = "btnloadin"
        Me.btnloadin.Size = New System.Drawing.Size(166, 44)
        Me.btnloadin.TabIndex = 6
        Me.btnloadin.Text = "| Load In     "
        Me.btnloadin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnloadin.UseVisualStyleBackColor = False
        '
        'ststatus
        '
        Me.ststatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ststatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlabel})
        Me.ststatus.Location = New System.Drawing.Point(0, 114)
        Me.ststatus.Name = "ststatus"
        Me.ststatus.Size = New System.Drawing.Size(405, 22)
        Me.ststatus.SizingGrip = False
        Me.ststatus.TabIndex = 8
        Me.ststatus.Text = "StatusStrip1"
        '
        'stlabel
        '
        Me.stlabel.ForeColor = System.Drawing.Color.White
        Me.stlabel.Name = "stlabel"
        Me.stlabel.Size = New System.Drawing.Size(140, 17)
        Me.stlabel.Text = "Amber and Ambrose Ent."
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(231, 38)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmloadiomenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(405, 136)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ststatus)
        Me.Controls.Add(Me.btnloadout)
        Me.Controls.Add(Me.btnloadin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmloadiomenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Load In/Out"
        Me.ststatus.ResumeLayout(False)
        Me.ststatus.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnloadout As Button
    Friend WithEvents btnloadin As Button
    Friend WithEvents ststatus As StatusStrip
    Friend WithEvents stlabel As ToolStripStatusLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
