Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard

    ' Database connection string (edit this)
    Private connectionString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=LPGSystem;Integrated Security=True"

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardData()
    End Sub

    Private Sub LoadDashboardData()
        Using con As New SqlConnection(connectionString)
            con.Open()

            ' Get total products
            Dim cmdTotal As New SqlCommand("SELECT COUNT(*) FROM Products", con)
            lblTotalProducts.Text = "Total Products: " & cmdTotal.ExecuteScalar().ToString()

            ' Get pending deliveries
            Dim cmdDeliveries As New SqlCommand("SELECT COUNT(*) FROM Deliveries WHERE Status='Pending'", con)
            lblPendingDeliveries.Text = "Pending Deliveries: " & cmdDeliveries.ExecuteScalar().ToString()

            ' Get today's sales
            Dim cmdSales As New SqlCommand("SELECT ISNULL(SUM(Amount),0) FROM Sales WHERE CAST(SaleDate AS DATE) = CAST(GETDATE() AS DATE)", con)
            lblTodaysSales.Text = "Today's Sales: ₱" & cmdSales.ExecuteScalar().ToString()

            ' Load chart data for low stocks
            Dim cmdChart As New SqlCommand("SELECT ProductName, Quantity FROM Products WHERE Quantity <= 10", con)
            Dim reader As SqlDataReader = cmdChart.ExecuteReader()

            'chartProducts.Series.Clear()
            Dim series As New Series("Low Stocks")
            series.ChartType = SeriesChartType.Column

            While reader.Read()
                series.Points.AddXY(reader("ProductName").ToString(), Convert.ToInt32(reader("Quantity")))
            End While

            'chartProducts.Series.Add(series)
        End Using
    End Sub

    'Friend WithEvents btnRefresh As Button
    'Friend WithEvents btnLogout As Button
    'Friend WithEvents btnInventory As Button


    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim invForm As New Inventory
        invForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles lblTodaysSales.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

