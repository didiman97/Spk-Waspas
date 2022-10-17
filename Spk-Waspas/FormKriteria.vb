Imports System.Data.OleDb

Public Class FormKriteria
    'Algoritma 1 = Menginput Nilai Kriteria
    Sub TampilData()
        Using koneksi As New OleDbConnection(Database)
            Using cmd As New OleDbCommand("select * from Kriteria order by KodeKriteria asc", koneksi)
                koneksi.Open()
                Using Data As OleDbDataReader = cmd.ExecuteReader
                    Dim x As Integer = 0
                    ListView1.Items.Clear()
                    While Data.Read
                        ListView1.Items.Add(x + 1)
                        ListView1.Items(x).SubItems.Add(Data("KodeKriteria"))
                        ListView1.Items(x).SubItems.Add(Data("NamaKriteria"))
                        ListView1.Items(x).SubItems.Add(Data("Bobot"))
                        ListView1.Items(x).SubItems.Add(Data("Keterangan"))
                        x = x + 1
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If IsNumeric(e.KeyChar) = True OrElse e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub FormKriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox4.Enabled = False
        Call TampilData()

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        On Error Resume Next
        TextBox4.Text = ListView1.SelectedItems(0).SubItems(1).Text.ToString
        TextBox1.Text = ListView1.SelectedItems(0).SubItems(2).Text.ToString
        TextBox2.Text = ListView1.SelectedItems(0).SubItems(3).Text.ToString
        ComboBox2.Text = ListView1.SelectedItems(0).SubItems(4).Text.ToString


    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

End Class