<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.Btninventory = New System.Windows.Forms.Button()
        Me.BtnSales = New System.Windows.Forms.Button()
        Me.BtnDelivery = New System.Windows.Forms.Button()
        Me.BtnUtang = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chartLowStocks = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblTodaysSales = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPendingDeliveries = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalProducts = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.chartLowStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblTodaysSales.SuspendLayout()
        Me.lblPendingDeliveries.SuspendLayout()
        Me.lblTotalProducts.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnDashboard)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btninventory)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnSales)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnDelivery)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnUtang)
        Me.FlowLayoutPanel1.Controls.Add(Me.BtnLogout)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, -54)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 80, 0, 5)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(191, 720)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.LPG_New_.My.Resources.Resources.Untitled_design__4_
        Me.PictureBox2.Location = New System.Drawing.Point(3, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 56)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Jsjg Lpg Store"
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Location = New System.Drawing.Point(3, 159)
        Me.BtnDashboard.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(177, 59)
        Me.BtnDashboard.TabIndex = 1
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.UseVisualStyleBackColor = True
        '
        'Btninventory
        '
        Me.Btninventory.Location = New System.Drawing.Point(3, 241)
        Me.Btninventory.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.Btninventory.Name = "Btninventory"
        Me.Btninventory.Size = New System.Drawing.Size(175, 57)
        Me.Btninventory.TabIndex = 2
        Me.Btninventory.Text = "Inventory"
        Me.Btninventory.UseVisualStyleBackColor = True
        '
        'BtnSales
        '
        Me.BtnSales.Location = New System.Drawing.Point(3, 321)
        Me.BtnSales.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.BtnSales.Name = "BtnSales"
        Me.BtnSales.Size = New System.Drawing.Size(175, 57)
        Me.BtnSales.TabIndex = 3
        Me.BtnSales.Text = "Sales"
        Me.BtnSales.UseVisualStyleBackColor = True
        '
        'BtnDelivery
        '
        Me.BtnDelivery.Location = New System.Drawing.Point(3, 401)
        Me.BtnDelivery.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.BtnDelivery.Name = "BtnDelivery"
        Me.BtnDelivery.Size = New System.Drawing.Size(175, 54)
        Me.BtnDelivery.TabIndex = 5
        Me.BtnDelivery.Text = "Delivery"
        Me.BtnDelivery.UseVisualStyleBackColor = True
        '
        'BtnUtang
        '
        Me.BtnUtang.Location = New System.Drawing.Point(3, 478)
        Me.BtnUtang.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
        Me.BtnUtang.Name = "BtnUtang"
        Me.BtnUtang.Size = New System.Drawing.Size(175, 58)
        Me.BtnUtang.TabIndex = 6
        Me.BtnUtang.Text = "Utang"
        Me.BtnUtang.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Location = New System.Drawing.Point(3, 639)
        Me.BtnLogout.Margin = New System.Windows.Forms.Padding(3, 100, 3, 3)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(175, 49)
        Me.BtnLogout.TabIndex = 7
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Location = New System.Drawing.Point(191, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1081, 71)
        Me.Panel2.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(984, 26)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(84, 36)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Controls.Add(Me.chartLowStocks)
        Me.Panel3.Controls.Add(Me.lblTodaysSales)
        Me.Panel3.Controls.Add(Me.lblPendingDeliveries)
        Me.Panel3.Controls.Add(Me.lblTotalProducts)
        Me.Panel3.Location = New System.Drawing.Point(191, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1081, 602)
        Me.Panel3.TabIndex = 2
        '
        'chartLowStocks
        '
        Me.chartLowStocks.BorderlineColor = System.Drawing.Color.Silver
        Me.chartLowStocks.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.Name = "ChartArea1"
        Me.chartLowStocks.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartLowStocks.Legends.Add(Legend2)
        Me.chartLowStocks.Location = New System.Drawing.Point(106, 245)
        Me.chartLowStocks.Name = "chartLowStocks"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartLowStocks.Series.Add(Series2)
        Me.chartLowStocks.Size = New System.Drawing.Size(840, 312)
        Me.chartLowStocks.TabIndex = 13
        Me.chartLowStocks.Text = "chartLowStocks"
        '
        'lblTodaysSales
        '
        Me.lblTodaysSales.BackColor = System.Drawing.Color.White
        Me.lblTodaysSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTodaysSales.Controls.Add(Me.Label7)
        Me.lblTodaysSales.Controls.Add(Me.Label6)
        Me.lblTodaysSales.Location = New System.Drawing.Point(765, 69)
        Me.lblTodaysSales.Name = "lblTodaysSales"
        Me.lblTodaysSales.Size = New System.Drawing.Size(271, 149)
        Me.lblTodaysSales.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 57)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "₱5,000"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(54, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 57)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Today's Sales"
        '
        'lblPendingDeliveries
        '
        Me.lblPendingDeliveries.BackColor = System.Drawing.Color.White
        Me.lblPendingDeliveries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPendingDeliveries.Controls.Add(Me.Label5)
        Me.lblPendingDeliveries.Controls.Add(Me.Label2)
        Me.lblPendingDeliveries.Location = New System.Drawing.Point(403, 69)
        Me.lblPendingDeliveries.Name = "lblPendingDeliveries"
        Me.lblPendingDeliveries.Size = New System.Drawing.Size(271, 149)
        Me.lblPendingDeliveries.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 57)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "10"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 57)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Pending Deliveries"
        '
        'lblTotalProducts
        '
        Me.lblTotalProducts.BackColor = System.Drawing.Color.White
        Me.lblTotalProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalProducts.Controls.Add(Me.Label3)
        Me.lblTotalProducts.Controls.Add(Me.Label4)
        Me.lblTotalProducts.Location = New System.Drawing.Point(44, 69)
        Me.lblTotalProducts.Name = "lblTotalProducts"
        Me.lblTotalProducts.Size = New System.Drawing.Size(271, 149)
        Me.lblTotalProducts.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 57)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "150"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 51)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Products"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1275, 672)
        Me.Panel1.TabIndex = 1
        '
        'Dashboard
        '
        Me.ClientSize = New System.Drawing.Size(1271, 665)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Dashboard"
        Me.ShowIcon = False
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.chartLowStocks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblTodaysSales.ResumeLayout(False)
        Me.lblPendingDeliveries.ResumeLayout(False)
        Me.lblTotalProducts.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents Btninventory As Button
    Friend WithEvents BtnSales As Button
    Friend WithEvents BtnDelivery As Button
    Friend WithEvents BtnUtang As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTodaysSales As Panel
    Friend WithEvents lblPendingDeliveries As Panel
    Friend WithEvents lblTotalProducts As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chartLowStocks As DataVisualization.Charting.Chart
    Friend WithEvents btnRefresh As Button
End Class