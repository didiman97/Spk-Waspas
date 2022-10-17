<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlternatifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenilaianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProsesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaspasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanHasilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.ProsesToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(1104, 46)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlternatifToolStripMenuItem, Me.KriteriaToolStripMenuItem, Me.PenilaianToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(80, 40)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'AlternatifToolStripMenuItem
        '
        Me.AlternatifToolStripMenuItem.Name = "AlternatifToolStripMenuItem"
        Me.AlternatifToolStripMenuItem.Size = New System.Drawing.Size(256, 40)
        Me.AlternatifToolStripMenuItem.Text = "Data Alternatif"
        '
        'KriteriaToolStripMenuItem
        '
        Me.KriteriaToolStripMenuItem.Name = "KriteriaToolStripMenuItem"
        Me.KriteriaToolStripMenuItem.Size = New System.Drawing.Size(256, 40)
        Me.KriteriaToolStripMenuItem.Text = "Data Kriteria"
        '
        'PenilaianToolStripMenuItem
        '
        Me.PenilaianToolStripMenuItem.Name = "PenilaianToolStripMenuItem"
        Me.PenilaianToolStripMenuItem.Size = New System.Drawing.Size(256, 40)
        Me.PenilaianToolStripMenuItem.Text = "Penilaian"
        '
        'ProsesToolStripMenuItem
        '
        Me.ProsesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WaspasToolStripMenuItem})
        Me.ProsesToolStripMenuItem.Name = "ProsesToolStripMenuItem"
        Me.ProsesToolStripMenuItem.Size = New System.Drawing.Size(207, 40)
        Me.ProsesToolStripMenuItem.Text = "Proses WASPAS"
        '
        'WaspasToolStripMenuItem
        '
        Me.WaspasToolStripMenuItem.Name = "WaspasToolStripMenuItem"
        Me.WaspasToolStripMenuItem.Size = New System.Drawing.Size(188, 40)
        Me.WaspasToolStripMenuItem.Text = "WASPAS"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanHasilToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(119, 40)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanHasilToolStripMenuItem
        '
        Me.LaporanHasilToolStripMenuItem.Name = "LaporanHasilToolStripMenuItem"
        Me.LaporanHasilToolStripMenuItem.Size = New System.Drawing.Size(243, 40)
        Me.LaporanHasilToolStripMenuItem.Text = "Laporan Hasil"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(108, 40)
        Me.KeluarToolStripMenuItem.Text = "Logout"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1104, 886)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlternatifToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenilaianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProsesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanHasilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WaspasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
