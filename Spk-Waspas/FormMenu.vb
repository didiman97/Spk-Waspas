Public Class FormMenu

    Private Sub AlternatifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlternatifToolStripMenuItem.Click
        FormDataAlternatif.Show()

    End Sub

    Private Sub KriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KriteriaToolStripMenuItem.Click
        FormKriteria.Show()

    End Sub

    Private Sub PenilaianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenilaianToolStripMenuItem.Click
        FormPenilaian.Show()


    End Sub

    Private Sub WeightProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormProsesWASPAS.Show()

    End Sub

    Private Sub LaporanHasilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanHasilToolStripMenuItem.Click
        ' FormLaporan.Show()

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End

    End Sub

    Private Sub FormMenu_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End

    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WaspasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaspasToolStripMenuItem.Click
        FormProsesWASPAS.Show()


    End Sub

End Class