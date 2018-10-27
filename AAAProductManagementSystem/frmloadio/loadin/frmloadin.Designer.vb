<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmloadin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmloadin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbsalesman = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblstocks = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbltotalprice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblproduct = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lvproductsinfo = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lblsalesman = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.lbltotalNumberOfProducts = New System.Windows.Forms.Label()
        Me.lbltotalamount = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnvalidate = New System.Windows.Forms.Button()
        Me.psave = New System.Windows.Forms.PictureBox()
        Me.splash = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.psave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbsalesman)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'cbsalesman
        '
        Me.cbsalesman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsalesman.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsalesman.FormattingEnabled = True
        Me.cbsalesman.Location = New System.Drawing.Point(64, 56)
        Me.cbsalesman.Name = "cbsalesman"
        Me.cbsalesman.Size = New System.Drawing.Size(378, 34)
        Me.cbsalesman.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(221, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Salesman"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox5.Location = New System.Drawing.Point(1, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(536, 33)
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblstocks)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lbltotalprice)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblprice)
        Me.GroupBox2.Controls.Add(Me.lblproduct)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblcode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 289)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'lblstocks
        '
        Me.lblstocks.BackColor = System.Drawing.Color.White
        Me.lblstocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblstocks.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblstocks.Location = New System.Drawing.Point(187, 145)
        Me.lblstocks.Name = "lblstocks"
        Me.lblstocks.Size = New System.Drawing.Size(328, 43)
        Me.lblstocks.TabIndex = 28
        Me.lblstocks.Text = "Stocks Available"
        Me.lblstocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(17, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 43)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Stocks:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltotalprice
        '
        Me.lbltotalprice.BackColor = System.Drawing.Color.White
        Me.lbltotalprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotalprice.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbltotalprice.Location = New System.Drawing.Point(187, 231)
        Me.lbltotalprice.Name = "lbltotalprice"
        Me.lbltotalprice.Size = New System.Drawing.Size(328, 43)
        Me.lbltotalprice.TabIndex = 26
        Me.lbltotalprice.Text = "Total Price"
        Me.lbltotalprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(17, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 43)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Total Price:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblprice
        '
        Me.lblprice.BackColor = System.Drawing.Color.White
        Me.lblprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprice.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblprice.Location = New System.Drawing.Point(187, 188)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(328, 43)
        Me.lblprice.TabIndex = 24
        Me.lblprice.Text = "Price"
        Me.lblprice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblproduct
        '
        Me.lblproduct.BackColor = System.Drawing.Color.White
        Me.lblproduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblproduct.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblproduct.Location = New System.Drawing.Point(187, 104)
        Me.lblproduct.Name = "lblproduct"
        Me.lblproduct.Size = New System.Drawing.Size(328, 41)
        Me.lblproduct.TabIndex = 23
        Me.lblproduct.Text = "Product"
        Me.lblproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(17, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 43)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Price:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcode
        '
        Me.lblcode.BackColor = System.Drawing.Color.White
        Me.lblcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcode.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcode.Location = New System.Drawing.Point(187, 64)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(328, 40)
        Me.lblcode.TabIndex = 21
        Me.lblcode.Text = "Product Code"
        Me.lblcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 40)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Product Code:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(17, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 41)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Product:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(199, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Load in Information"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(1, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(536, 33)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtqty)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 417)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(537, 70)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 26)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Quantity:"
        '
        'txtqty
        '
        Me.txtqty.Enabled = False
        Me.txtqty.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(129, 22)
        Me.txtqty.MaxLength = 5
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(145, 33)
        Me.txtqty.TabIndex = 2
        '
        'txtcode
        '
        Me.txtcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtcode.Enabled = False
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.ForeColor = System.Drawing.Color.White
        Me.txtcode.Location = New System.Drawing.Point(14, 534)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.ShortcutsEnabled = False
        Me.txtcode.Size = New System.Drawing.Size(538, 47)
        Me.txtcode.TabIndex = 1
        Me.txtcode.WordWrap = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblstatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 610)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1102, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblstatus
        '
        Me.lblstatus.ForeColor = System.Drawing.Color.White
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(140, 17)
        Me.lblstatus.Text = "Amber and Ambrose Ent."
        '
        'lvproductsinfo
        '
        Me.lvproductsinfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3})
        Me.lvproductsinfo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvproductsinfo.FullRowSelect = True
        Me.lvproductsinfo.GridLines = True
        Me.lvproductsinfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvproductsinfo.Location = New System.Drawing.Point(565, 18)
        Me.lvproductsinfo.Name = "lvproductsinfo"
        Me.lvproductsinfo.Size = New System.Drawing.Size(525, 469)
        Me.lvproductsinfo.TabIndex = 30
        Me.lvproductsinfo.UseCompatibleStateImageBehavior = False
        Me.lvproductsinfo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Code"
        Me.ColumnHeader1.Width = 104
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Products"
        Me.ColumnHeader2.Width = 169
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "QTY"
        Me.ColumnHeader4.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Price"
        Me.ColumnHeader3.Width = 120
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(456, 495)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(94, 33)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Enabled = False
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(12, 495)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(93, 33)
        Me.btnadd.TabIndex = 3
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lblsalesman
        '
        Me.lblsalesman.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsalesman.Location = New System.Drawing.Point(656, 502)
        Me.lblsalesman.Name = "lblsalesman"
        Me.lblsalesman.Size = New System.Drawing.Size(74, 15)
        Me.lblsalesman.TabIndex = 34
        Me.lblsalesman.Text = "#"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(575, 502)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Salesman:"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(575, 531)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(177, 19)
        Me.label13.TabIndex = 35
        Me.label13.Text = "Total Number of Products:"
        '
        'lbltotalNumberOfProducts
        '
        Me.lbltotalNumberOfProducts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalNumberOfProducts.Location = New System.Drawing.Point(760, 531)
        Me.lbltotalNumberOfProducts.Name = "lbltotalNumberOfProducts"
        Me.lbltotalNumberOfProducts.Size = New System.Drawing.Size(74, 15)
        Me.lbltotalNumberOfProducts.TabIndex = 36
        Me.lbltotalNumberOfProducts.Text = "#"
        '
        'lbltotalamount
        '
        Me.lbltotalamount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamount.Location = New System.Drawing.Point(680, 559)
        Me.lbltotalamount.Name = "lbltotalamount"
        Me.lbltotalamount.Size = New System.Drawing.Size(74, 15)
        Me.lbltotalamount.TabIndex = 38
        Me.lbltotalamount.Text = "#"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(575, 559)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 19)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Total Amount:"
        '
        'btnvalidate
        '
        Me.btnvalidate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvalidate.Location = New System.Drawing.Point(12, 495)
        Me.btnvalidate.Name = "btnvalidate"
        Me.btnvalidate.Size = New System.Drawing.Size(93, 33)
        Me.btnvalidate.TabIndex = 39
        Me.btnvalidate.Text = "Validate"
        Me.btnvalidate.UseVisualStyleBackColor = True
        '
        'psave
        '
        Me.psave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psave.Image = CType(resources.GetObject("psave.Image"), System.Drawing.Image)
        Me.psave.Location = New System.Drawing.Point(983, 493)
        Me.psave.Name = "psave"
        Me.psave.Size = New System.Drawing.Size(107, 107)
        Me.psave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.psave.TabIndex = 40
        Me.psave.TabStop = False
        '
        'splash
        '
        Me.splash.BackColor = System.Drawing.SystemColors.Control
        Me.splash.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.splash.Location = New System.Drawing.Point(387, 236)
        Me.splash.Name = "splash"
        Me.splash.Size = New System.Drawing.Size(365, 96)
        Me.splash.TabIndex = 41
        Me.splash.Text = "Please wait...."
        Me.splash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.splash.Visible = False
        '
        'frmloadin
        '
        Me.AcceptButton = Me.btnvalidate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1102, 632)
        Me.Controls.Add(Me.splash)
        Me.Controls.Add(Me.psave)
        Me.Controls.Add(Me.lbltotalamount)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbltotalNumberOfProducts)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.lblsalesman)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.lvproductsinfo)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnvalidate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmloadin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Load In"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.psave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbsalesman As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblprice As Label
    Friend WithEvents lblproduct As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblcode As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltotalprice As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents txtcode As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblstatus As ToolStripStatusLabel
    Friend WithEvents lvproductsinfo As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btncancel As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lblsalesman As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents label13 As Label
    Friend WithEvents lbltotalNumberOfProducts As Label
    Friend WithEvents lbltotalamount As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblstocks As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnvalidate As Button
    Friend WithEvents psave As PictureBox
    Friend WithEvents splash As Label
End Class
