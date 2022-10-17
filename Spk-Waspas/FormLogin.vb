Imports System.Data.OleDb

Public Class FormLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String = "Select * from Login where Username='" & TextBox1.Text & _
           "' and password='" & TextBox2.Text & "'"
        Dim dr As OleDbDataReader = New OleDbCommand(sql, Cn).ExecuteReader
        If dr.HasRows Then
            MsgBox("Login Berhasil", MsgBoxStyle.Information, "Login")
            FormMenu.Show()
            'Me.Close()
            Me.Hide()
        Else
            MsgBox("Login Gagal", MsgBoxStyle.Critical, "Login")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()
        End If
        dr.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BukaKoneksi()

    End Sub
End Class