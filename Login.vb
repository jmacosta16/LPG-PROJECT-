Imports System.Data.SqlClient
Imports ADODB
Public Class Login
    Dim rs As New ADODB.Recordset

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtusername.AutoSize = False
        Txtusername.Size = New Size(100, 25) ' Width = 100px, Height = 25px

        Txtpassword.AutoSize = False
        Txtpassword.Size = New Size(100, 25)

        Btnlogin.AutoSize = False
        Btnlogin.Size = New Size(100, 25)


        Btnlogin.FlatStyle = FlatStyle.Flat
        Btnlogin.BackColor = Color.SteelBlue
        Btnlogin.ForeColor = Color.White
        Btnlogin.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        OpenConnection()

        Dim cmd As New ADODB.Command()
        Dim rs As ADODB.Recordset = Nothing

        Try
            ' Bind the command to the open ADODB connection
            cmd.ActiveConnection = conn
            cmd.CommandText = "SELECT * FROM Users WHERE Username = ? AND [Password] = ?"
            cmd.CommandType = ADODB.CommandTypeEnum.adCmdText

            cmd.Parameters.Append(cmd.CreateParameter("p1", ADODB.DataTypeEnum.adVarWChar, ADODB.ParameterDirectionEnum.adParamInput, 50, Txtusername.Text.Trim()))
            cmd.Parameters.Append(cmd.CreateParameter("p2", ADODB.DataTypeEnum.adVarWChar, ADODB.ParameterDirectionEnum.adParamInput, 50, Txtpassword.Text))

            ' Execute and get a Recordset
            rs = cmd.Execute()

            If Not rs.EOF Then
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim dash As New Dashboard()
                dash.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Finally
            ' Close + release recordset safely
            If Not rs Is Nothing Then
                If rs.State = ADODB.ObjectStateEnum.adStateOpen Then rs.Close()
                rs = Nothing
            End If
        End Try
    End Sub

    ' Removes the placeholder txt 
    Private Sub Txtusername_Enter(sender As Object, e As EventArgs) Handles Txtusername.Enter
        If Txtusername.ForeColor = Color.Gray AndAlso Txtusername.Text = "Enter Username" Then
            Txtusername.Text = ""
            Txtusername.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TxtUsername_Leave(sender As Object, e As EventArgs) Handles Txtusername.Leave
        If String.IsNullOrWhiteSpace(Txtusername.Text) Then
            Txtusername.Text = "Enter Username"
            Txtusername.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TxtPassword_Enter(sender As Object, e As EventArgs) Handles Txtpassword.Enter
        If Txtpassword.ForeColor = Color.Gray AndAlso Txtpassword.Text = "Enter Password" Then
            Txtpassword.Text = ""
            Txtpassword.ForeColor = Color.Black
            Txtpassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub TxtPassword_Leave(sender As Object, e As EventArgs) Handles Txtpassword.Leave
        If String.IsNullOrWhiteSpace(Txtpassword.Text) Then
            Txtpassword.UseSystemPasswordChar = False
            Txtpassword.Text = "Enter Password"
            Txtpassword.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If conn.State = ObjectStateEnum.adStateOpen Then
            conn.Close()
        End If
    End Sub

End Class
