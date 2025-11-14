
Imports LPG_New_.LPG_New.Data.Transfer

Public Class Inventory

    Private inv As New InventoryManager()

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductsGrid()
        LoadCategoryFilter()
        LoadBrandFilter()
    End Sub

    Private Sub LoadProductsGrid()
        Dim rs As ADODB.Recordset = Nothing
        Try
            rs = inv.GetAllProducts()
            Dim dt As DataTable = adohelp.RecordsetToDataTable(rs)
            dgvProducts.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("LoadProductsGrid error: " & ex.Message)
        Finally
            Try
                If rs IsNot Nothing AndAlso rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
            Catch
            End Try
            DBConnection.CloseConnection()
        End Try
    End Sub

    Private Sub LoadCategoryFilter()
        Dim rs As ADODB.Recordset = inv.GetAllProducts
        Dim dt As DataTable = adohelp.RecordsetToDataTable(rs)
        Dim dtCopy As DataTable = dt.Copy()

        CmbCategory.Items.Clear()
        CmbCategory.Items.Add("All")

        Dim categories = dt.AsEnumerable().
                      Select(Function(r) r.Field(Of String)("Category")).
                      Distinct().
                      ToList()

        For Each cat In categories
            If Not String.IsNullOrWhiteSpace(cat) Then
                CmbCategory.Items.Add(cat)
            End If
        Next

        CmbCategory.SelectedIndex = 0
    End Sub

    Private Sub LoadBrandFilter()
        Dim rs As ADODB.Recordset = inv.GetAllProducts()
        Dim dt As DataTable = adohelp.RecordsetToDataTable(rs)
        Dim dtCopy As DataTable = dt.Copy()
        Cmbbrand.Items.Clear()
        Cmbbrand.Items.Add("All")

        Dim brands = dt.AsEnumerable().
                     Select(Function(r) r.Field(Of String)("Brand")).
                     Distinct().
                     ToList()

        For Each br In brands
            If Not String.IsNullOrWhiteSpace(br) Then
                Cmbbrand.Items.Add(br)
            End If
        Next

        Cmbbrand.SelectedIndex = 0
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim A As New AddProduct With {
            .ProductName = txtName.Text.Trim(),
            .Brand = txtBrand.Text.Trim(),
            .Size = txtSize.Text.Trim(),
            .Category = txtCategory.Text.Trim(),
            .Price = CDec(NumPrice.Value),
            .LowThreshold = CInt(numThreshold.Value),
            .Remarks = "Initial stock on product creation"
            }
        LoadProductsGrid()
        ClearInputs()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As Integer
        If Integer.TryParse(txtProductID.Text, id) Then
            Dim U As New UpdateProduct With {
            .ProductID = id,
            .ProductName = txtName.Text.Trim(),
            .Brand = txtBrand.Text.Trim(),
            .Size = txtSize.Text.Trim(),
            .Category = txtCategory.Text.Trim(),
            .Price = CDec(NumPrice.Value),
            .LowThreshold = CInt(numThreshold.Value),
            .Remarks = "Updated stock"
            }

            inv.UpdateProduct(U)

            LoadProductsGrid()
            ClearInputs()
        Else
            MessageBox.Show("Select a product first.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim id As Integer
        If Integer.TryParse(txtProductID.Text, id) Then
            If MessageBox.Show("Delete product ID " & id & "?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                inv.DeleteProduct(id)
                LoadProductsGrid()
                ClearInputs()
            End If
        Else
            MessageBox.Show("Select a product first.")
        End If
    End Sub

    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        Dim id As Integer
        If Integer.TryParse(txtProductID.Text, id) Then
            Dim remarks As String
            If txtRemarks IsNot Nothing AndAlso txtRemarks.Visible AndAlso Not String.IsNullOrWhiteSpace(txtRemarks.Text) Then
                remarks = txtRemarks.Text.Trim()
            Else
                remarks = "Manual increase"
            End If
            inv.IncreaseStock(id, CInt(numQuantity.Value), remarks)
            LoadProductsGrid()
        Else
            MessageBox.Show("Select a product first.")
        End If
    End Sub

    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click
        Dim id As Integer
        If Integer.TryParse(txtProductID.Text, id) Then
            Dim remarks As String
            If txtRemarks IsNot Nothing AndAlso txtRemarks.Visible AndAlso Not String.IsNullOrWhiteSpace(txtRemarks.Text) Then
                remarks = txtRemarks.Text.Trim()
            Else
                remarks = "Manual decrease"
            End If
            inv.DecreaseStock(id, CInt(numQuantity.Value), remarks)
            LoadProductsGrid()
        Else
            MessageBox.Show("Select a product first.")
        End If
    End Sub

    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)
            txtProductID.Text = If(row.Cells("ProductID").Value IsNot Nothing, row.Cells("ProductID").Value.ToString(), "")
            txtName.Text = If(row.Cells("Name").Value IsNot Nothing, row.Cells("Name").Value.ToString(), "")
            txtBrand.Text = If(row.Cells("Brand").Value IsNot Nothing, row.Cells("Brand").Value.ToString(), "")
            txtSize.Text = If(row.Cells("Size").Value IsNot Nothing, row.Cells("Size").Value.ToString(), "")
            txtCategory.Text = If(row.Cells("Category").Value IsNot Nothing, row.Cells("Category").Value.ToString(), "")
            Dim stockVal = row.Cells("StockQty").Value
            If stockVal IsNot Nothing AndAlso IsNumeric(stockVal) Then numStock.Value = Convert.ToDecimal(stockVal)
            Dim thVal = row.Cells("LowStockThreshold").Value
            If thVal IsNot Nothing AndAlso IsNumeric(thVal) Then numThreshold.Value = Convert.ToDecimal(thVal)
            Dim PVal = row.Cells("Price").Value
            If PVal IsNot Nothing AndAlso IsNumeric(PVal) Then NumPrice.Value = Convert.ToDecimal(PVal)
            Dim DVal = row.Cells("LogDate").Value
            If DVal IsNot Nothing AndAlso IsDate(DVal) Then DtpLogDate.Value = Convert.ToDateTime(DVal)
            ' --- load stock log for selected product ---
            Dim id As Integer
                If Integer.TryParse(txtProductID.Text, id) Then
                    LoadStockLogGrid(id)
                Else
                    ' Clear log grid if no product selected
                    Dgvstocklog.DataSource = Nothing
                End If
            End If
    End Sub

    Private Sub ClearInputs()
        txtProductID.Clear()
        txtName.Clear()
        txtBrand.Clear()
        txtSize.Clear()
        txtCategory.Clear()
        numStock.Value = 0
        numThreshold.Value = 0
        NumPrice.Value = 0
        numQuantity.Value = 1
        txtRemarks.Clear()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        Txtsearch.Clear()
        CmbCategory.SelectedIndex = 0
        Cmbbrand.SelectedIndex = 0
        Nummin.Value = 0
        NumMax.Value = 0
        ChkLowstock.Checked = False

        LoadProductsGrid()
    End Sub


    Private Sub Inventoryform_closong(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dash = New Dashboard()
        dash.Show()
        Me.Hide()
    End Sub
    Private Sub Btnback_Click(sender As Object, e As EventArgs) Handles Btnback.Click
        Dim dash = New Dashboard()
        dash.Show()
        Me.Hide()
    End Sub


    ' ---------- Load stock log for a specific product ----------
    Private Sub LoadStockLogGrid(productID As Integer)
        Try
            Dim dt As DataTable = inv.GetStockLogDataTable(productID)
            Dgvstocklog.DataSource = dt

            ' UI niceties
            dgvStockLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvStockLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvStockLog.MultiSelect = False
            dgvStockLog.ReadOnly = True

            ' Format columns if present
            If dt.Columns.Contains("ChangeDate") Then
                dgvStockLog.Columns("ChangeDate").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm"
            End If
            If dt.Columns.Contains("Quantity") Then
                dgvStockLog.Columns("Quantity").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Catch ex As Exception
            MessageBox.Show("LoadStockLogGrid error: " & ex.Message)
        End Try
    End Sub

    ' ---------- Load all logs ----------
    Private Sub LoadAllStockLogs()
        Try
            Dim dt As DataTable = inv.GetAllStockLogDataTable()
            Dgvstocklog.DataSource = dt

            dgvStockLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvStockLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgvStockLog.MultiSelect = False
            dgvStockLog.ReadOnly = True

            If dt.Columns.Contains("ChangeDate") Then
                dgvStockLog.Columns("ChangeDate").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm"
            End If
        Catch ex As Exception
            MessageBox.Show("LoadAllStockLogs error: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnViewAllLogs_Click(sender As Object, e As EventArgs) Handles BtnViewAllLogs.Click
        LoadAllStockLogs()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles Btnsearch.Click

        Dim keyword As String = Txtsearch.Text.Trim()
        Dim category As String = CmbCategory.Text
        Dim brand As String = Cmbbrand.Text
        Dim pmin As Decimal = Nummin.Value
        Dim pmax As Decimal = NumMax.Value
        Dim lowStock As Boolean = ChkLowstock.Checked

        dgvProducts.DataSource = inv.AdvancedSearch(keyword, category, brand, pmin, pmax, lowStock)
    End Sub
End Class
