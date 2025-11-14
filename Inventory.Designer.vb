<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
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

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tblForm = New System.Windows.Forms.TableLayoutPanel()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.numQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.numThreshold = New System.Windows.Forms.NumericUpDown()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.numStock = New System.Windows.Forms.NumericUpDown()
        Me.Lbldate = New System.Windows.Forms.Label()
        Me.Lblprice = New System.Windows.Forms.Label()
        Me.DtpLogDate = New System.Windows.Forms.DateTimePicker()
        Me.NumPrice = New System.Windows.Forms.NumericUpDown()
        Me.tblGrids = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvProducts = New System.Windows.Forms.DataGridView()
        Me.Dgvstocklog = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Txtsearch = New System.Windows.Forms.TextBox()
        Me.Btnsearch = New System.Windows.Forms.Button()
        Me.Nummin = New System.Windows.Forms.NumericUpDown()
        Me.NumMax = New System.Windows.Forms.NumericUpDown()
        Me.CmbCategory = New System.Windows.Forms.ComboBox()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Cmbbrand = New System.Windows.Forms.ComboBox()
        Me.ChkLowstock = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnIncrease = New System.Windows.Forms.Button()
        Me.BtnViewAllLogs = New System.Windows.Forms.Button()
        Me.btnDecrease = New System.Windows.Forms.Button()
        Me.Btnback = New System.Windows.Forms.Button()
        Me.tblMain.SuspendLayout()
        Me.tblForm.SuspendLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblGrids.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgvstocklog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Nummin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblMain
        '
        Me.tblMain.AutoSize = True
        Me.tblMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tblMain.ColumnCount = 1
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1528.0!))
        Me.tblMain.Controls.Add(Me.tblForm, 0, 0)
        Me.tblMain.Controls.Add(Me.tblGrids, 0, 2)
        Me.tblMain.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(0, 0)
        Me.tblMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.tblMain.RowCount = 3
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblMain.Size = New System.Drawing.Size(1542, 552)
        Me.tblMain.TabIndex = 0
        '
        'tblForm
        '
        Me.tblForm.AutoSize = True
        Me.tblForm.ColumnCount = 4
        Me.tblForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tblForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tblForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblForm.Controls.Add(Me.txtProductID, 1, 0)
        Me.tblForm.Controls.Add(Me.lblName, 0, 1)
        Me.tblForm.Controls.Add(Me.txtName, 1, 1)
        Me.tblForm.Controls.Add(Me.lblBrand, 0, 2)
        Me.tblForm.Controls.Add(Me.txtBrand, 1, 2)
        Me.tblForm.Controls.Add(Me.lblSize, 0, 3)
        Me.tblForm.Controls.Add(Me.txtSize, 1, 3)
        Me.tblForm.Controls.Add(Me.lblCategory, 0, 4)
        Me.tblForm.Controls.Add(Me.txtCategory, 1, 4)
        Me.tblForm.Controls.Add(Me.lblRemarks, 0, 5)
        Me.tblForm.Controls.Add(Me.txtRemarks, 1, 5)
        Me.tblForm.Controls.Add(Me.lblID, 0, 0)
        Me.tblForm.Controls.Add(Me.lblQuantity, 2, 4)
        Me.tblForm.Controls.Add(Me.numQuantity, 3, 4)
        Me.tblForm.Controls.Add(Me.lblThreshold, 2, 3)
        Me.tblForm.Controls.Add(Me.numThreshold, 3, 3)
        Me.tblForm.Controls.Add(Me.lblStock, 2, 2)
        Me.tblForm.Controls.Add(Me.numStock, 3, 2)
        Me.tblForm.Controls.Add(Me.Lbldate, 2, 0)
        Me.tblForm.Controls.Add(Me.Lblprice, 2, 1)
        Me.tblForm.Controls.Add(Me.DtpLogDate, 3, 0)
        Me.tblForm.Controls.Add(Me.NumPrice, 3, 1)
        Me.tblForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblForm.Location = New System.Drawing.Point(10, 8)
        Me.tblForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblForm.Name = "tblForm"
        Me.tblForm.RowCount = 6
        Me.tblForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tblForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tblForm.Size = New System.Drawing.Size(1522, 174)
        Me.tblForm.TabIndex = 0
        '
        'txtProductID
        '
        Me.txtProductID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductID.Location = New System.Drawing.Point(101, 3)
        Me.txtProductID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.ReadOnly = True
        Me.txtProductID.Size = New System.Drawing.Size(644, 22)
        Me.txtProductID.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(3, 35)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(44, 16)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(101, 32)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(644, 22)
        Me.txtName.TabIndex = 5
        '
        'lblBrand
        '
        Me.lblBrand.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(3, 64)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(43, 16)
        Me.lblBrand.TabIndex = 8
        Me.lblBrand.Text = "Brand"
        '
        'txtBrand
        '
        Me.txtBrand.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBrand.Location = New System.Drawing.Point(101, 61)
        Me.txtBrand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(644, 22)
        Me.txtBrand.TabIndex = 9
        '
        'lblSize
        '
        Me.lblSize.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(3, 93)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(33, 16)
        Me.lblSize.TabIndex = 12
        Me.lblSize.Text = "Size"
        '
        'txtSize
        '
        Me.txtSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSize.Location = New System.Drawing.Point(101, 90)
        Me.txtSize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(644, 22)
        Me.txtSize.TabIndex = 13
        '
        'lblCategory
        '
        Me.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(3, 122)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(62, 16)
        Me.lblCategory.TabIndex = 14
        Me.lblCategory.Text = "Category"
        '
        'txtCategory
        '
        Me.txtCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCategory.Location = New System.Drawing.Point(101, 119)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(644, 22)
        Me.txtCategory.TabIndex = 15
        '
        'lblRemarks
        '
        Me.lblRemarks.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Location = New System.Drawing.Point(3, 151)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(62, 16)
        Me.lblRemarks.TabIndex = 16
        Me.lblRemarks.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblForm.SetColumnSpan(Me.txtRemarks, 3)
        Me.txtRemarks.Location = New System.Drawing.Point(101, 148)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(1418, 22)
        Me.txtRemarks.TabIndex = 17
        '
        'lblID
        '
        Me.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(3, 6)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(69, 16)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Product ID"
        '
        'lblQuantity
        '
        Me.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(751, 122)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(55, 16)
        Me.lblQuantity.TabIndex = 10
        Me.lblQuantity.Text = "Quantity"
        '
        'numQuantity
        '
        Me.numQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.numQuantity.Location = New System.Drawing.Point(875, 119)
        Me.numQuantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numQuantity.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQuantity.Name = "numQuantity"
        Me.numQuantity.Size = New System.Drawing.Size(107, 22)
        Me.numQuantity.TabIndex = 11
        Me.numQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblThreshold
        '
        Me.lblThreshold.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblThreshold.Location = New System.Drawing.Point(751, 93)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(118, 16)
        Me.lblThreshold.TabIndex = 6
        Me.lblThreshold.Text = "Threshold"
        '
        'numThreshold
        '
        Me.numThreshold.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.numThreshold.Location = New System.Drawing.Point(875, 90)
        Me.numThreshold.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numThreshold.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numThreshold.Name = "numThreshold"
        Me.numThreshold.Size = New System.Drawing.Size(107, 22)
        Me.numThreshold.TabIndex = 7
        '
        'lblStock
        '
        Me.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(751, 64)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(64, 16)
        Me.lblStock.TabIndex = 2
        Me.lblStock.Text = "Stock Qty"
        '
        'numStock
        '
        Me.numStock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.numStock.Location = New System.Drawing.Point(875, 61)
        Me.numStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numStock.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numStock.Name = "numStock"
        Me.numStock.Size = New System.Drawing.Size(107, 22)
        Me.numStock.TabIndex = 3
        '
        'Lbldate
        '
        Me.Lbldate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbldate.AutoSize = True
        Me.Lbldate.Location = New System.Drawing.Point(751, 6)
        Me.Lbldate.Name = "Lbldate"
        Me.Lbldate.Size = New System.Drawing.Size(36, 16)
        Me.Lbldate.TabIndex = 20
        Me.Lbldate.Text = "Date"
        '
        'Lblprice
        '
        Me.Lblprice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lblprice.AutoSize = True
        Me.Lblprice.Location = New System.Drawing.Point(751, 35)
        Me.Lblprice.Name = "Lblprice"
        Me.Lblprice.Size = New System.Drawing.Size(38, 16)
        Me.Lblprice.TabIndex = 18
        Me.Lblprice.Text = "Price"
        '
        'DtpLogDate
        '
        Me.DtpLogDate.Location = New System.Drawing.Point(875, 2)
        Me.DtpLogDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtpLogDate.Name = "DtpLogDate"
        Me.DtpLogDate.Size = New System.Drawing.Size(263, 22)
        Me.DtpLogDate.TabIndex = 21
        '
        'NumPrice
        '
        Me.NumPrice.DecimalPlaces = 2
        Me.NumPrice.Location = New System.Drawing.Point(875, 31)
        Me.NumPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumPrice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.NumPrice.Name = "NumPrice"
        Me.NumPrice.Size = New System.Drawing.Size(107, 22)
        Me.NumPrice.TabIndex = 22
        Me.NumPrice.ThousandsSeparator = True
        '
        'tblGrids
        '
        Me.tblGrids.AutoSize = True
        Me.tblGrids.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tblGrids.ColumnCount = 2
        Me.tblGrids.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.20275!))
        Me.tblGrids.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.79725!))
        Me.tblGrids.Controls.Add(Me.dgvProducts, 0, 0)
        Me.tblGrids.Controls.Add(Me.Dgvstocklog, 1, 0)
        Me.tblGrids.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblGrids.Location = New System.Drawing.Point(10, 298)
        Me.tblGrids.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tblGrids.Name = "tblGrids"
        Me.tblGrids.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.tblGrids.RowCount = 1
        Me.tblGrids.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblGrids.Size = New System.Drawing.Size(1522, 246)
        Me.tblGrids.TabIndex = 2
        '
        'dgvProducts
        '
        Me.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProducts.Location = New System.Drawing.Point(3, 8)
        Me.dgvProducts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.RowHeadersWidth = 62
        Me.dgvProducts.RowTemplate.Height = 24
        Me.dgvProducts.Size = New System.Drawing.Size(773, 236)
        Me.dgvProducts.TabIndex = 0
        '
        'Dgvstocklog
        '
        Me.Dgvstocklog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvstocklog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgvstocklog.Location = New System.Drawing.Point(782, 8)
        Me.Dgvstocklog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgvstocklog.Name = "Dgvstocklog"
        Me.Dgvstocklog.RowHeadersWidth = 62
        Me.Dgvstocklog.RowTemplate.Height = 28
        Me.Dgvstocklog.Size = New System.Drawing.Size(737, 236)
        Me.Dgvstocklog.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AllowDrop = True
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.98398!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.01602!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 186)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(869, 108)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Txtsearch, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Btnsearch, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Nummin, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.NumMax, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CmbCategory, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Btnclear, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Cmbbrand, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ChkLowstock, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 34)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(523, 71)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Txtsearch
        '
        Me.Txtsearch.Location = New System.Drawing.Point(3, 2)
        Me.Txtsearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txtsearch.Name = "Txtsearch"
        Me.Txtsearch.Size = New System.Drawing.Size(133, 22)
        Me.Txtsearch.TabIndex = 13
        '
        'Btnsearch
        '
        Me.Btnsearch.Location = New System.Drawing.Point(3, 37)
        Me.Btnsearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(132, 31)
        Me.Btnsearch.TabIndex = 11
        Me.Btnsearch.Text = "Search"
        Me.Btnsearch.UseVisualStyleBackColor = True
        '
        'Nummin
        '
        Me.Nummin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Nummin.Location = New System.Drawing.Point(270, 47)
        Me.Nummin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Nummin.Name = "Nummin"
        Me.Nummin.Size = New System.Drawing.Size(122, 22)
        Me.Nummin.TabIndex = 10
        '
        'NumMax
        '
        Me.NumMax.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.NumMax.Location = New System.Drawing.Point(270, 11)
        Me.NumMax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NumMax.Name = "NumMax"
        Me.NumMax.Size = New System.Drawing.Size(122, 22)
        Me.NumMax.TabIndex = 9
        '
        'CmbCategory
        '
        Me.CmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CmbCategory.FormattingEnabled = True
        Me.CmbCategory.Location = New System.Drawing.Point(398, 45)
        Me.CmbCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbCategory.Name = "CmbCategory"
        Me.CmbCategory.Size = New System.Drawing.Size(122, 24)
        Me.CmbCategory.TabIndex = 8
        '
        'Btnclear
        '
        Me.Btnclear.Location = New System.Drawing.Point(142, 37)
        Me.Btnclear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(122, 31)
        Me.Btnclear.TabIndex = 12
        Me.Btnclear.Text = "Clear Search"
        Me.Btnclear.UseVisualStyleBackColor = True
        '
        'Cmbbrand
        '
        Me.Cmbbrand.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Cmbbrand.FormattingEnabled = True
        Me.Cmbbrand.Location = New System.Drawing.Point(398, 9)
        Me.Cmbbrand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cmbbrand.Name = "Cmbbrand"
        Me.Cmbbrand.Size = New System.Drawing.Size(122, 24)
        Me.Cmbbrand.TabIndex = 7
        '
        'ChkLowstock
        '
        Me.ChkLowstock.Location = New System.Drawing.Point(142, 2)
        Me.ChkLowstock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkLowstock.Name = "ChkLowstock"
        Me.ChkLowstock.Size = New System.Drawing.Size(118, 30)
        Me.ChkLowstock.TabIndex = 14
        Me.ChkLowstock.Text = "⚠ Check Low"
        Me.ChkLowstock.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(523, 32)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Inventory Search"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Location = New System.Drawing.Point(532, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Inventory Editor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.btnDelete, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnUpdate, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAdd, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnIncrease, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnViewAllLogs, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnDecrease, 3, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(532, 34)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(334, 71)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(116, 2)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(107, 30)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "🗑 Delete"
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = True
        Me.btnUpdate.Location = New System.Drawing.Point(3, 37)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(107, 31)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "✏ Update"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 2)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 30)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "➕ Add"
        '
        'btnIncrease
        '
        Me.btnIncrease.AutoSize = True
        Me.btnIncrease.Location = New System.Drawing.Point(116, 37)
        Me.btnIncrease.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIncrease.Name = "btnIncrease"
        Me.btnIncrease.Size = New System.Drawing.Size(107, 31)
        Me.btnIncrease.TabIndex = 3
        Me.btnIncrease.Text = "➕ Increase"
        '
        'BtnViewAllLogs
        '
        Me.BtnViewAllLogs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnViewAllLogs.AutoEllipsis = True
        Me.BtnViewAllLogs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnViewAllLogs.Location = New System.Drawing.Point(229, 2)
        Me.BtnViewAllLogs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnViewAllLogs.Name = "BtnViewAllLogs"
        Me.BtnViewAllLogs.Size = New System.Drawing.Size(107, 30)
        Me.BtnViewAllLogs.TabIndex = 6
        Me.BtnViewAllLogs.Text = "CheckLog"
        '
        'btnDecrease
        '
        Me.btnDecrease.Location = New System.Drawing.Point(229, 37)
        Me.btnDecrease.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDecrease.Name = "btnDecrease"
        Me.btnDecrease.Size = New System.Drawing.Size(107, 31)
        Me.btnDecrease.TabIndex = 4
        Me.btnDecrease.Text = "➖ Decrease"
        '
        'Btnback
        '
        Me.Btnback.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnback.AutoSize = True
        Me.Btnback.Location = New System.Drawing.Point(1460, 10)
        Me.Btnback.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btnback.Name = "Btnback"
        Me.Btnback.Size = New System.Drawing.Size(67, 26)
        Me.Btnback.TabIndex = 100
        Me.Btnback.Text = "Back"
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1542, 552)
        Me.Controls.Add(Me.tblMain)
        Me.Controls.Add(Me.Btnback)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Inventory"
        Me.Text = "Inventory"
        Me.tblMain.ResumeLayout(False)
        Me.tblMain.PerformLayout()
        Me.tblForm.ResumeLayout(False)
        Me.tblForm.PerformLayout()
        CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblGrids.ResumeLayout(False)
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgvstocklog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Nummin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnback As Button
    Friend WithEvents Dgvstocklog As DataGridView
    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents tblGrids As TableLayoutPanel
    Friend WithEvents tblForm As TableLayoutPanel
    Friend WithEvents lblID As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents lblStock As Label
    Friend WithEvents numStock As NumericUpDown
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblThreshold As Label
    Friend WithEvents numThreshold As NumericUpDown
    Friend WithEvents lblBrand As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents numQuantity As NumericUpDown
    Friend WithEvents lblSize As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Lblprice As Label
    Friend WithEvents Lbldate As Label
    Friend WithEvents DtpLogDate As DateTimePicker
    Friend WithEvents NumPrice As NumericUpDown
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Txtsearch As TextBox
    Friend WithEvents Btnsearch As Button
    Friend WithEvents CmbCategory As ComboBox
    Friend WithEvents Cmbbrand As ComboBox
    Friend WithEvents Btnclear As Button
    Friend WithEvents Nummin As NumericUpDown
    Friend WithEvents NumMax As NumericUpDown
    Friend WithEvents ChkLowstock As CheckBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnIncrease As Button
    Friend WithEvents BtnViewAllLogs As Button
    Friend WithEvents btnDecrease As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
