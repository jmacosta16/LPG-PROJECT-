<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnlogin
        '
        Me.Btnlogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btnlogin.Location = New System.Drawing.Point(74, 174)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(100, 25)
        Me.Btnlogin.TabIndex = 5
        Me.Btnlogin.Text = "Login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Btnlogin.UseVisualStyleBackColor = True
        Me.Btnlogin.UseWaitCursor = True
        '
        'Txtpassword
        '
        Me.Txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Txtpassword.ForeColor = System.Drawing.Color.Gray
        Me.Txtpassword.Location = New System.Drawing.Point(74, 128)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(100, 26)
        Me.Txtpassword.TabIndex = 4
        Me.Txtpassword.Text = "Enter Password"
        Me.Txtpassword.UseWaitCursor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Txtusername)
        Me.Panel1.Controls.Add(Me.Lbltitle)
        Me.Panel1.Controls.Add(Me.Txtpassword)
        Me.Panel1.Controls.Add(Me.Btnlogin)
        Me.Panel1.Location = New System.Drawing.Point(638, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 300)
        Me.Panel1.TabIndex = 5
        Me.Panel1.UseWaitCursor = True
        '
        'Txtusername
        '
        Me.Txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusername.ForeColor = System.Drawing.Color.Gray
        Me.Txtusername.Location = New System.Drawing.Point(74, 87)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(100, 26)
        Me.Txtusername.TabIndex = 3
        Me.Txtusername.Text = "Enter Username"
        Me.Txtusername.UseWaitCursor = True
        '
        'Lbltitle
        '
        Me.Lbltitle.AutoSize = True
        Me.Lbltitle.BackColor = System.Drawing.Color.Transparent
        Me.Lbltitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(106, 19)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(78, 32)
        Me.Lbltitle.TabIndex = 2
        Me.Lbltitle.Text = "Login"
        Me.Lbltitle.UseWaitCursor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuText
        Me.BackgroundImage = Global.LPG_New_.My.Resources.Resources._8d57f1b875eea6afd6a4a26f5cd45d892
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1001, 545)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "SignIn"
        Me.UseWaitCursor = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btnlogin As Button
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbltitle As Label
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents ImageList1 As ImageList
End Class
