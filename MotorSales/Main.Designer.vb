<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ms = New System.Windows.Forms.MenuStrip()
        Me.border1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblCylCap = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.pnMotor = New System.Windows.Forms.Panel()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblManageMotor = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.DataGridViewMotor = New System.Windows.Forms.DataGridView()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.txtCylCap = New System.Windows.Forms.TextBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.pnCreateInvoice = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblUnit = New System.Windows.Forms.Label()
        Me.nud = New System.Windows.Forms.NumericUpDown()
        Me.lblNud = New System.Windows.Forms.Label()
        Me.lblTotalMoney = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lvCreateInvoice = New System.Windows.Forms.ListView()
        Me.btnDel2 = New System.Windows.Forms.Button()
        Me.lstSearch = New System.Windows.Forms.ListBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.rtxAddress = New System.Windows.Forms.RichTextBox()
        Me.txtIDC = New System.Windows.Forms.TextBox()
        Me.txtTelNo = New System.Windows.Forms.TextBox()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.lblModel2 = New System.Windows.Forms.Label()
        Me.lblIDC = New System.Windows.Forms.Label()
        Me.lblTelNo = New System.Windows.Forms.Label()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnInvoiceDetail = New System.Windows.Forms.Panel()
        Me.btnPrintInvoice = New System.Windows.Forms.Button()
        Me.btnRs = New System.Windows.Forms.Button()
        Me.gbSearch = New System.Windows.Forms.GroupBox()
        Me.lstSearchBy = New System.Windows.Forms.ListBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblNumText = New System.Windows.Forms.Label()
        Me.mc = New System.Windows.Forms.MonthCalendar()
        Me.cbModel = New System.Windows.Forms.CheckBox()
        Me.cbCustName = New System.Windows.Forms.CheckBox()
        Me.btnSearchBy = New System.Windows.Forms.Button()
        Me.cbOrderID = New System.Windows.Forms.CheckBox()
        Me.txtSearchBy = New System.Windows.Forms.TextBox()
        Me.cbOrderDate = New System.Windows.Forms.CheckBox()
        Me.lblMotorSalesManagement = New System.Windows.Forms.Label()
        Me.btnDelManage = New System.Windows.Forms.Button()
        Me.DataGridViewOI = New System.Windows.Forms.DataGridView()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Clock = New System.Windows.Forms.PictureBox()
        Me.pbSearch = New System.Windows.Forms.PictureBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tsmiInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCreateInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMotor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.XMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOItoXML = New System.Windows.Forms.Button()
        Me.ms.SuspendLayout()
        Me.pnMotor.SuspendLayout()
        CType(Me.DataGridViewMotor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnCreateInvoice.SuspendLayout()
        CType(Me.nud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnInvoiceDetail.SuspendLayout()
        Me.gbSearch.SuspendLayout()
        CType(Me.DataGridViewOI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ms
        '
        Me.ms.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ms.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ms.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiInvoice, Me.border1, Me.tsmiMotor, Me.ToolStripMenuItem1})
        Me.ms.Location = New System.Drawing.Point(0, 0)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(1098, 36)
        Me.ms.TabIndex = 0
        Me.ms.Text = "MenuStrip"
        '
        'border1
        '
        Me.border1.Enabled = False
        Me.border1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.border1.Name = "border1"
        Me.border1.ShowShortcutKeys = False
        Me.border1.Size = New System.Drawing.Size(26, 32)
        Me.border1.Text = "|"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(26, 32)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductID.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblProductID.Location = New System.Drawing.Point(12, 118)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(72, 25)
        Me.lblProductID.TabIndex = 1
        Me.lblProductID.Text = "Mã xe:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblModel.Location = New System.Drawing.Point(323, 118)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(79, 25)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Tên xe:"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblBrand.Location = New System.Drawing.Point(12, 163)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(91, 25)
        Me.lblBrand.TabIndex = 3
        Me.lblBrand.Text = "Hãng xe:"
        '
        'lblCylCap
        '
        Me.lblCylCap.AutoSize = True
        Me.lblCylCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCylCap.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCylCap.Location = New System.Drawing.Point(323, 163)
        Me.lblCylCap.Name = "lblCylCap"
        Me.lblCylCap.Size = New System.Drawing.Size(161, 25)
        Me.lblCylCap.TabIndex = 4
        Me.lblCylCap.Text = "Dung tích xi lanh:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(607, 163)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(84, 25)
        Me.lblPrice.TabIndex = 5
        Me.lblPrice.Text = "Giá tiền:"
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblQty.Location = New System.Drawing.Point(914, 163)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(96, 25)
        Me.lblQty.TabIndex = 6
        Me.lblQty.Text = "Số lượng:"
        '
        'pnMotor
        '
        Me.pnMotor.Controls.Add(Me.cboCategory)
        Me.pnMotor.Controls.Add(Me.lblCategory)
        Me.pnMotor.Controls.Add(Me.lblManageMotor)
        Me.pnMotor.Controls.Add(Me.btnFirst)
        Me.pnMotor.Controls.Add(Me.btnBack)
        Me.pnMotor.Controls.Add(Me.btnNext)
        Me.pnMotor.Controls.Add(Me.btnLast)
        Me.pnMotor.Controls.Add(Me.DataGridViewMotor)
        Me.pnMotor.Controls.Add(Me.btnReset)
        Me.pnMotor.Controls.Add(Me.btnSearch)
        Me.pnMotor.Controls.Add(Me.btnDel)
        Me.pnMotor.Controls.Add(Me.btnUpdate)
        Me.pnMotor.Controls.Add(Me.btnAdd)
        Me.pnMotor.Controls.Add(Me.txtPrice)
        Me.pnMotor.Controls.Add(Me.txtBrand)
        Me.pnMotor.Controls.Add(Me.txtCylCap)
        Me.pnMotor.Controls.Add(Me.txtQty)
        Me.pnMotor.Controls.Add(Me.txtModel)
        Me.pnMotor.Controls.Add(Me.txtProductID)
        Me.pnMotor.Controls.Add(Me.lblProductID)
        Me.pnMotor.Controls.Add(Me.lblQty)
        Me.pnMotor.Controls.Add(Me.lblModel)
        Me.pnMotor.Controls.Add(Me.lblPrice)
        Me.pnMotor.Controls.Add(Me.lblBrand)
        Me.pnMotor.Controls.Add(Me.lblCylCap)
        Me.pnMotor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMotor.ForeColor = System.Drawing.Color.DodgerBlue
        Me.pnMotor.Location = New System.Drawing.Point(0, 36)
        Me.pnMotor.Name = "pnMotor"
        Me.pnMotor.Size = New System.Drawing.Size(1098, 616)
        Me.pnMotor.TabIndex = 7
        '
        'cboCategory
        '
        Me.cboCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(860, 112)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(226, 37)
        Me.cboCategory.TabIndex = 30
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblCategory.Location = New System.Drawing.Point(773, 118)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(81, 25)
        Me.lblCategory.TabIndex = 29
        Me.lblCategory.Text = "Loại xe:"
        '
        'lblManageMotor
        '
        Me.lblManageMotor.AutoSize = True
        Me.lblManageMotor.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManageMotor.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblManageMotor.Location = New System.Drawing.Point(461, 11)
        Me.lblManageMotor.Name = "lblManageMotor"
        Me.lblManageMotor.Size = New System.Drawing.Size(244, 44)
        Me.lblManageMotor.TabIndex = 28
        Me.lblManageMotor.Text = "QUẢN LÝ XE"
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFirst.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnFirst.Location = New System.Drawing.Point(1029, 281)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(57, 40)
        Me.btnFirst.TabIndex = 27
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnBack.Location = New System.Drawing.Point(1029, 368)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(57, 40)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnNext.Location = New System.Drawing.Point(1029, 458)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(57, 40)
        Me.btnNext.TabIndex = 25
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLast.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnLast.Location = New System.Drawing.Point(1029, 548)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(57, 40)
        Me.btnLast.TabIndex = 24
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'DataGridViewMotor
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMotor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewMotor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewMotor.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewMotor.Location = New System.Drawing.Point(17, 281)
        Me.DataGridViewMotor.Name = "DataGridViewMotor"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewMotor.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewMotor.RowHeadersWidth = 51
        Me.DataGridViewMotor.RowTemplate.Height = 24
        Me.DataGridViewMotor.Size = New System.Drawing.Size(993, 307)
        Me.DataGridViewMotor.TabIndex = 18
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btnReset.Location = New System.Drawing.Point(1019, 59)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(67, 32)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Crimson
        Me.btnDel.Location = New System.Drawing.Point(797, 215)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(111, 45)
        Me.btnDel.TabIndex = 15
        Me.btnDel.Text = "XÓA"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.ForestGreen
        Me.btnUpdate.Location = New System.Drawing.Point(490, 215)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(111, 45)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "SỬA"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Blue
        Me.btnAdd.Location = New System.Drawing.Point(206, 215)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(111, 45)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "THÊM"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(697, 157)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(211, 34)
        Me.txtPrice.TabIndex = 12
        '
        'txtBrand
        '
        Me.txtBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.Location = New System.Drawing.Point(109, 157)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(208, 34)
        Me.txtBrand.TabIndex = 11
        '
        'txtCylCap
        '
        Me.txtCylCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCylCap.Location = New System.Drawing.Point(490, 157)
        Me.txtCylCap.Name = "txtCylCap"
        Me.txtCylCap.Size = New System.Drawing.Size(111, 34)
        Me.txtCylCap.TabIndex = 10
        '
        'txtQty
        '
        Me.txtQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.Location = New System.Drawing.Point(1016, 157)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(70, 34)
        Me.txtQty.TabIndex = 9
        '
        'txtModel
        '
        Me.txtModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModel.Location = New System.Drawing.Point(408, 112)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(359, 34)
        Me.txtModel.TabIndex = 8
        '
        'txtProductID
        '
        Me.txtProductID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Location = New System.Drawing.Point(90, 109)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(227, 34)
        Me.txtProductID.TabIndex = 7
        '
        'pnCreateInvoice
        '
        Me.pnCreateInvoice.Controls.Add(Me.txtSearch)
        Me.pnCreateInvoice.Controls.Add(Me.lblUnit)
        Me.pnCreateInvoice.Controls.Add(Me.nud)
        Me.pnCreateInvoice.Controls.Add(Me.lblNud)
        Me.pnCreateInvoice.Controls.Add(Me.lblTotalMoney)
        Me.pnCreateInvoice.Controls.Add(Me.lblTotal)
        Me.pnCreateInvoice.Controls.Add(Me.lvCreateInvoice)
        Me.pnCreateInvoice.Controls.Add(Me.btnDel2)
        Me.pnCreateInvoice.Controls.Add(Me.lstSearch)
        Me.pnCreateInvoice.Controls.Add(Me.btnCreate)
        Me.pnCreateInvoice.Controls.Add(Me.rtxAddress)
        Me.pnCreateInvoice.Controls.Add(Me.txtIDC)
        Me.pnCreateInvoice.Controls.Add(Me.txtTelNo)
        Me.pnCreateInvoice.Controls.Add(Me.txtCustName)
        Me.pnCreateInvoice.Controls.Add(Me.lblNote)
        Me.pnCreateInvoice.Controls.Add(Me.lblModel2)
        Me.pnCreateInvoice.Controls.Add(Me.lblIDC)
        Me.pnCreateInvoice.Controls.Add(Me.lblTelNo)
        Me.pnCreateInvoice.Controls.Add(Me.lblCustName)
        Me.pnCreateInvoice.Controls.Add(Me.lblTitle)
        Me.pnCreateInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnCreateInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnCreateInvoice.ForeColor = System.Drawing.Color.Black
        Me.pnCreateInvoice.Location = New System.Drawing.Point(0, 36)
        Me.pnCreateInvoice.Name = "pnCreateInvoice"
        Me.pnCreateInvoice.Size = New System.Drawing.Size(1098, 616)
        Me.pnCreateInvoice.TabIndex = 31
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(513, 61)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(230, 30)
        Me.txtSearch.TabIndex = 43
        '
        'lblUnit
        '
        Me.lblUnit.AutoSize = True
        Me.lblUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit.Location = New System.Drawing.Point(1020, 61)
        Me.lblUnit.Name = "lblUnit"
        Me.lblUnit.Size = New System.Drawing.Size(72, 25)
        Me.lblUnit.TabIndex = 42
        Me.lblUnit.Text = "(chiếc)"
        '
        'nud
        '
        Me.nud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud.Location = New System.Drawing.Point(946, 59)
        Me.nud.Name = "nud"
        Me.nud.Size = New System.Drawing.Size(68, 30)
        Me.nud.TabIndex = 41
        '
        'lblNud
        '
        Me.lblNud.AutoSize = True
        Me.lblNud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNud.Location = New System.Drawing.Point(855, 61)
        Me.lblNud.Name = "lblNud"
        Me.lblNud.Size = New System.Drawing.Size(96, 25)
        Me.lblNud.TabIndex = 40
        Me.lblNud.Text = "Số lượng:"
        '
        'lblTotalMoney
        '
        Me.lblTotalMoney.AutoSize = True
        Me.lblTotalMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalMoney.Location = New System.Drawing.Point(835, 524)
        Me.lblTotalMoney.Name = "lblTotalMoney"
        Me.lblTotalMoney.Size = New System.Drawing.Size(0, 25)
        Me.lblTotalMoney.TabIndex = 39
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(738, 524)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 25)
        Me.lblTotal.TabIndex = 38
        Me.lblTotal.Text = "Tổng tiền:"
        '
        'lvCreateInvoice
        '
        Me.lvCreateInvoice.FullRowSelect = True
        Me.lvCreateInvoice.GridLines = True
        Me.lvCreateInvoice.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvCreateInvoice.HideSelection = False
        Me.lvCreateInvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lvCreateInvoice.Location = New System.Drawing.Point(12, 198)
        Me.lvCreateInvoice.MultiSelect = False
        Me.lvCreateInvoice.Name = "lvCreateInvoice"
        Me.lvCreateInvoice.Size = New System.Drawing.Size(1074, 317)
        Me.lvCreateInvoice.TabIndex = 37
        Me.lvCreateInvoice.UseCompatibleStateImageBehavior = False
        '
        'btnDel2
        '
        Me.btnDel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel2.ForeColor = System.Drawing.Color.Crimson
        Me.btnDel2.Location = New System.Drawing.Point(743, 558)
        Me.btnDel2.Name = "btnDel2"
        Me.btnDel2.Size = New System.Drawing.Size(170, 45)
        Me.btnDel2.TabIndex = 34
        Me.btnDel2.Text = "XÓA"
        Me.btnDel2.UseVisualStyleBackColor = False
        '
        'lstSearch
        '
        Me.lstSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSearch.ItemHeight = 25
        Me.lstSearch.Location = New System.Drawing.Point(513, 90)
        Me.lstSearch.Name = "lstSearch"
        Me.lstSearch.Size = New System.Drawing.Size(230, 104)
        Me.lstSearch.TabIndex = 0
        Me.lstSearch.Visible = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.Blue
        Me.btnCreate.Location = New System.Drawing.Point(931, 558)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(157, 45)
        Me.btnCreate.TabIndex = 32
        Me.btnCreate.Text = "TẠO MỚI"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'rtxAddress
        '
        Me.rtxAddress.Location = New System.Drawing.Point(755, 97)
        Me.rtxAddress.Name = "rtxAddress"
        Me.rtxAddress.Size = New System.Drawing.Size(331, 95)
        Me.rtxAddress.TabIndex = 11
        Me.rtxAddress.Text = ""
        '
        'txtIDC
        '
        Me.txtIDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDC.Location = New System.Drawing.Point(178, 152)
        Me.txtIDC.Name = "txtIDC"
        Me.txtIDC.Size = New System.Drawing.Size(280, 30)
        Me.txtIDC.TabIndex = 9
        '
        'txtTelNo
        '
        Me.txtTelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelNo.Location = New System.Drawing.Point(178, 106)
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(280, 30)
        Me.txtTelNo.TabIndex = 8
        '
        'txtCustName
        '
        Me.txtCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustName.Location = New System.Drawing.Point(178, 58)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(280, 30)
        Me.txtCustName.TabIndex = 7
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(750, 61)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(77, 25)
        Me.lblNote.TabIndex = 5
        Me.lblNote.Text = "Địa chỉ:"
        '
        'lblModel2
        '
        Me.lblModel2.AutoSize = True
        Me.lblModel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel2.Location = New System.Drawing.Point(464, 61)
        Me.lblModel2.Name = "lblModel2"
        Me.lblModel2.Size = New System.Drawing.Size(43, 25)
        Me.lblModel2.TabIndex = 4
        Me.lblModel2.Text = "Xe:"
        '
        'lblIDC
        '
        Me.lblIDC.AutoSize = True
        Me.lblIDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDC.Location = New System.Drawing.Point(12, 155)
        Me.lblIDC.Name = "lblIDC"
        Me.lblIDC.Size = New System.Drawing.Size(78, 25)
        Me.lblIDC.TabIndex = 3
        Me.lblIDC.Text = "CMND:"
        '
        'lblTelNo
        '
        Me.lblTelNo.AutoSize = True
        Me.lblTelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelNo.Location = New System.Drawing.Point(12, 109)
        Me.lblTelNo.Name = "lblTelNo"
        Me.lblTelNo.Size = New System.Drawing.Size(132, 25)
        Me.lblTelNo.TabIndex = 2
        Me.lblTelNo.Text = "Số điện thoại:"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(12, 63)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(160, 25)
        Me.lblCustName.TabIndex = 1
        Me.lblCustName.Text = "Tên khách hàng:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(400, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(319, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "TẠO MỚI HÓA ĐƠN"
        '
        'pnInvoiceDetail
        '
        Me.pnInvoiceDetail.Controls.Add(Me.btnOItoXML)
        Me.pnInvoiceDetail.Controls.Add(Me.btnPrintInvoice)
        Me.pnInvoiceDetail.Controls.Add(Me.btnRs)
        Me.pnInvoiceDetail.Controls.Add(Me.gbSearch)
        Me.pnInvoiceDetail.Controls.Add(Me.lblMotorSalesManagement)
        Me.pnInvoiceDetail.Controls.Add(Me.btnDelManage)
        Me.pnInvoiceDetail.Controls.Add(Me.DataGridViewOI)
        Me.pnInvoiceDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnInvoiceDetail.Location = New System.Drawing.Point(0, 36)
        Me.pnInvoiceDetail.Name = "pnInvoiceDetail"
        Me.pnInvoiceDetail.Size = New System.Drawing.Size(1098, 616)
        Me.pnInvoiceDetail.TabIndex = 44
        Me.pnInvoiceDetail.Visible = False
        '
        'btnPrintInvoice
        '
        Me.btnPrintInvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintInvoice.ForeColor = System.Drawing.Color.Orange
        Me.btnPrintInvoice.Location = New System.Drawing.Point(19, 504)
        Me.btnPrintInvoice.Name = "btnPrintInvoice"
        Me.btnPrintInvoice.Size = New System.Drawing.Size(262, 45)
        Me.btnPrintInvoice.TabIndex = 28
        Me.btnPrintInvoice.Text = "XEM CHI TIẾT"
        Me.btnPrintInvoice.UseVisualStyleBackColor = False
        '
        'btnRs
        '
        Me.btnRs.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRs.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRs.ForeColor = System.Drawing.Color.PaleGreen
        Me.btnRs.Location = New System.Drawing.Point(17, 441)
        Me.btnRs.Name = "btnRs"
        Me.btnRs.Size = New System.Drawing.Size(127, 45)
        Me.btnRs.TabIndex = 27
        Me.btnRs.Text = "RESET"
        Me.btnRs.UseVisualStyleBackColor = False
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.lstSearchBy)
        Me.gbSearch.Controls.Add(Me.lblNum)
        Me.gbSearch.Controls.Add(Me.lblNumText)
        Me.gbSearch.Controls.Add(Me.mc)
        Me.gbSearch.Controls.Add(Me.cbModel)
        Me.gbSearch.Controls.Add(Me.cbCustName)
        Me.gbSearch.Controls.Add(Me.btnSearchBy)
        Me.gbSearch.Controls.Add(Me.pbSearch)
        Me.gbSearch.Controls.Add(Me.cbOrderID)
        Me.gbSearch.Controls.Add(Me.txtSearchBy)
        Me.gbSearch.Controls.Add(Me.cbOrderDate)
        Me.gbSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSearch.Location = New System.Drawing.Point(19, 48)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(262, 377)
        Me.gbSearch.TabIndex = 26
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Tìm kiếm:"
        '
        'lstSearchBy
        '
        Me.lstSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSearchBy.ItemHeight = 25
        Me.lstSearchBy.Location = New System.Drawing.Point(78, 59)
        Me.lstSearchBy.Name = "lstSearchBy"
        Me.lstSearchBy.Size = New System.Drawing.Size(155, 104)
        Me.lstSearchBy.TabIndex = 47
        Me.lstSearchBy.Visible = False
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.ForeColor = System.Drawing.Color.Black
        Me.lblNum.Location = New System.Drawing.Point(154, 32)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(23, 25)
        Me.lblNum.TabIndex = 46
        Me.lblNum.Text = "0"
        Me.lblNum.Visible = False
        '
        'lblNumText
        '
        Me.lblNumText.AutoSize = True
        Me.lblNumText.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNumText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumText.ForeColor = System.Drawing.Color.Black
        Me.lblNumText.Location = New System.Drawing.Point(12, 32)
        Me.lblNumText.Name = "lblNumText"
        Me.lblNumText.Size = New System.Drawing.Size(139, 25)
        Me.lblNumText.TabIndex = 45
        Me.lblNumText.Text = "Số ngày chọn:"
        Me.lblNumText.Visible = False
        '
        'mc
        '
        Me.mc.Location = New System.Drawing.Point(0, 107)
        Me.mc.MaxSelectionCount = 1000000
        Me.mc.Name = "mc"
        Me.mc.TabIndex = 0
        Me.mc.Visible = False
        '
        'cbModel
        '
        Me.cbModel.AutoSize = True
        Me.cbModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbModel.Location = New System.Drawing.Point(14, 198)
        Me.cbModel.Name = "cbModel"
        Me.cbModel.Size = New System.Drawing.Size(203, 29)
        Me.cbModel.TabIndex = 29
        Me.cbModel.Text = "Theo tên sản phẩm"
        Me.cbModel.UseVisualStyleBackColor = True
        '
        'cbCustName
        '
        Me.cbCustName.AutoSize = True
        Me.cbCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCustName.Location = New System.Drawing.Point(14, 261)
        Me.cbCustName.Name = "cbCustName"
        Me.cbCustName.Size = New System.Drawing.Size(170, 29)
        Me.cbCustName.TabIndex = 30
        Me.cbCustName.Text = "Theo tên khách"
        Me.cbCustName.UseVisualStyleBackColor = True
        '
        'btnSearchBy
        '
        Me.btnSearchBy.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchBy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchBy.ForeColor = System.Drawing.Color.Blue
        Me.btnSearchBy.Location = New System.Drawing.Point(69, 323)
        Me.btnSearchBy.Name = "btnSearchBy"
        Me.btnSearchBy.Size = New System.Drawing.Size(127, 45)
        Me.btnSearchBy.TabIndex = 27
        Me.btnSearchBy.Text = "TÌM KIẾM"
        Me.btnSearchBy.UseVisualStyleBackColor = False
        '
        'cbOrderID
        '
        Me.cbOrderID.AutoSize = True
        Me.cbOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrderID.Location = New System.Drawing.Point(14, 135)
        Me.cbOrderID.Name = "cbOrderID"
        Me.cbOrderID.Size = New System.Drawing.Size(150, 29)
        Me.cbOrderID.TabIndex = 28
        Me.cbOrderID.Text = "Theo mã đơn"
        Me.cbOrderID.UseVisualStyleBackColor = True
        '
        'txtSearchBy
        '
        Me.txtSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBy.Location = New System.Drawing.Point(78, 26)
        Me.txtSearchBy.Name = "txtSearchBy"
        Me.txtSearchBy.Size = New System.Drawing.Size(155, 34)
        Me.txtSearchBy.TabIndex = 19
        '
        'cbOrderDate
        '
        Me.cbOrderDate.AutoSize = True
        Me.cbOrderDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrderDate.Location = New System.Drawing.Point(14, 74)
        Me.cbOrderDate.Name = "cbOrderDate"
        Me.cbOrderDate.Size = New System.Drawing.Size(158, 29)
        Me.cbOrderDate.TabIndex = 27
        Me.cbOrderDate.Text = "Theo thời gian"
        Me.cbOrderDate.UseVisualStyleBackColor = True
        '
        'lblMotorSalesManagement
        '
        Me.lblMotorSalesManagement.AutoSize = True
        Me.lblMotorSalesManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotorSalesManagement.Location = New System.Drawing.Point(401, 7)
        Me.lblMotorSalesManagement.Name = "lblMotorSalesManagement"
        Me.lblMotorSalesManagement.Size = New System.Drawing.Size(350, 38)
        Me.lblMotorSalesManagement.TabIndex = 25
        Me.lblMotorSalesManagement.Text = "QUẢN LÝ ĐƠN HÀNG"
        '
        'btnDelManage
        '
        Me.btnDelManage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelManage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelManage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelManage.ForeColor = System.Drawing.Color.Crimson
        Me.btnDelManage.Location = New System.Drawing.Point(156, 441)
        Me.btnDelManage.Name = "btnDelManage"
        Me.btnDelManage.Size = New System.Drawing.Size(125, 45)
        Me.btnDelManage.TabIndex = 22
        Me.btnDelManage.Text = "XÓA"
        Me.btnDelManage.UseVisualStyleBackColor = False
        '
        'DataGridViewOI
        '
        Me.DataGridViewOI.AllowUserToAddRows = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewOI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewOI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOI.Location = New System.Drawing.Point(292, 58)
        Me.DataGridViewOI.MultiSelect = False
        Me.DataGridViewOI.Name = "DataGridViewOI"
        Me.DataGridViewOI.RowHeadersWidth = 51
        Me.DataGridViewOI.RowTemplate.Height = 24
        Me.DataGridViewOI.Size = New System.Drawing.Size(794, 546)
        Me.DataGridViewOI.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(1006, 5)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(48, 25)
        Me.lblTime.TabIndex = 35
        Me.lblTime.Text = "time"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDate.Location = New System.Drawing.Point(913, 5)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 25)
        Me.lblDate.TabIndex = 36
        Me.lblDate.Text = "date"
        '
        'Clock
        '
        Me.Clock.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Clock.Image = Global.MotorSales.My.Resources.Resources.clock
        Me.Clock.Location = New System.Drawing.Point(881, 5)
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(26, 25)
        Me.Clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Clock.TabIndex = 45
        Me.Clock.TabStop = False
        '
        'pbSearch
        '
        Me.pbSearch.Image = Global.MotorSales.My.Resources.Resources.search
        Me.pbSearch.Location = New System.Drawing.Point(14, 26)
        Me.pbSearch.Name = "pbSearch"
        Me.pbSearch.Size = New System.Drawing.Size(48, 34)
        Me.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSearch.TabIndex = 27
        Me.pbSearch.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.MotorSales.My.Resources.Resources.search
        Me.btnSearch.Location = New System.Drawing.Point(931, 59)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(67, 32)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'tsmiInvoice
        '
        Me.tsmiInvoice.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCreateInvoice})
        Me.tsmiInvoice.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiInvoice.Image = Global.MotorSales.My.Resources.Resources.sale
        Me.tsmiInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsmiInvoice.Name = "tsmiInvoice"
        Me.tsmiInvoice.Size = New System.Drawing.Size(151, 32)
        Me.tsmiInvoice.Text = "ĐƠN HÀNG"
        '
        'tsmiCreateInvoice
        '
        Me.tsmiCreateInvoice.Name = "tsmiCreateInvoice"
        Me.tsmiCreateInvoice.Size = New System.Drawing.Size(169, 32)
        Me.tsmiCreateInvoice.Text = "Tạo mới"
        '
        'tsmiMotor
        '
        Me.tsmiMotor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiInventory, Me.XMLToolStripMenuItem})
        Me.tsmiMotor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmiMotor.Image = Global.MotorSales.My.Resources.Resources.Xe
        Me.tsmiMotor.Name = "tsmiMotor"
        Me.tsmiMotor.Size = New System.Drawing.Size(68, 32)
        Me.tsmiMotor.Text = "XE"
        '
        'tsmiInventory
        '
        Me.tsmiInventory.Name = "tsmiInventory"
        Me.tsmiInventory.Size = New System.Drawing.Size(224, 32)
        Me.tsmiInventory.Text = "Kiểm kê"
        '
        'XMLToolStripMenuItem
        '
        Me.XMLToolStripMenuItem.Name = "XMLToolStripMenuItem"
        Me.XMLToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.XMLToolStripMenuItem.Text = "XML"
        '
        'btnOItoXML
        '
        Me.btnOItoXML.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnOItoXML.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOItoXML.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOItoXML.ForeColor = System.Drawing.Color.Black
        Me.btnOItoXML.Location = New System.Drawing.Point(19, 558)
        Me.btnOItoXML.Name = "btnOItoXML"
        Me.btnOItoXML.Size = New System.Drawing.Size(262, 45)
        Me.btnOItoXML.TabIndex = 29
        Me.btnOItoXML.Text = "XML"
        Me.btnOItoXML.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 652)
        Me.Controls.Add(Me.Clock)
        Me.Controls.Add(Me.pnInvoiceDetail)
        Me.Controls.Add(Me.pnCreateInvoice)
        Me.Controls.Add(Me.pnMotor)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ms)
        Me.MainMenuStrip = Me.ms
        Me.Name = "Main"
        Me.Text = "Quản lí bán xe máy"
        Me.ms.ResumeLayout(False)
        Me.ms.PerformLayout()
        Me.pnMotor.ResumeLayout(False)
        Me.pnMotor.PerformLayout()
        CType(Me.DataGridViewMotor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnCreateInvoice.ResumeLayout(False)
        Me.pnCreateInvoice.PerformLayout()
        CType(Me.nud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnInvoiceDetail.ResumeLayout(False)
        Me.pnInvoiceDetail.PerformLayout()
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        CType(Me.DataGridViewOI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ms As MenuStrip
    Friend WithEvents tsmiInvoice As ToolStripMenuItem
    Friend WithEvents tsmiCreateInvoice As ToolStripMenuItem
    Friend WithEvents border1 As ToolStripMenuItem
    Friend WithEvents tsmiMotor As ToolStripMenuItem
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblCylCap As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents pnMotor As Panel
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtCylCap As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents DataGridViewMotor As DataGridView
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblManageMotor As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents pnCreateInvoice As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents btnDel2 As Button
    Friend WithEvents lstSearch As ListBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents rtxAddress As RichTextBox
    Friend WithEvents txtIDC As TextBox
    Friend WithEvents txtTelNo As TextBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblNote As Label
    Friend WithEvents lblModel2 As Label
    Friend WithEvents lblIDC As Label
    Friend WithEvents lblTelNo As Label
    Friend WithEvents lblCustName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents lvCreateInvoice As ListView
    Friend WithEvents lblTotalMoney As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents nud As NumericUpDown
    Friend WithEvents lblNud As Label
    Friend WithEvents lblUnit As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnInvoiceDetail As Panel
    Friend WithEvents DataGridViewOI As DataGridView
    Friend WithEvents pbSearch As PictureBox
    Friend WithEvents gbSearch As GroupBox
    Friend WithEvents lblMotorSalesManagement As Label
    Friend WithEvents btnDelManage As Button
    Friend WithEvents txtSearchBy As TextBox
    Friend WithEvents mc As MonthCalendar
    Friend WithEvents btnSearchBy As Button
    Friend WithEvents cbModel As CheckBox
    Friend WithEvents cbCustName As CheckBox
    Friend WithEvents cbOrderID As CheckBox
    Friend WithEvents cbOrderDate As CheckBox
    Friend WithEvents btnRs As Button
    Friend WithEvents lblNum As Label
    Friend WithEvents lblNumText As Label
    Friend WithEvents lstSearchBy As ListBox
    Friend WithEvents btnPrintInvoice As Button
    Friend WithEvents tsmiInventory As ToolStripMenuItem
    Friend WithEvents Clock As PictureBox
    Friend WithEvents XMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnOItoXML As Button
End Class
