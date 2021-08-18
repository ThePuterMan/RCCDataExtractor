<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RCCDEMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RCCDEMain))
        Me.mstripMain = New System.Windows.Forms.MenuStrip()
        Me.mnuOpenLastBB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenLastTDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenSavedBB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenSavedTDF = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNameCheck = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mstripMain
        '
        Me.mstripMain.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenLastBB, Me.mnuOpenLastTDF, Me.mnuOpen, Me.mnuNameCheck, Me.mnuSettings})
        Me.mstripMain.Location = New System.Drawing.Point(0, 0)
        Me.mstripMain.Name = "mstripMain"
        Me.mstripMain.Size = New System.Drawing.Size(1264, 33)
        Me.mstripMain.TabIndex = 1
        Me.mstripMain.Text = "Main-Menu"
        '
        'mnuOpenLastBB
        '
        Me.mnuOpenLastBB.Image = Global.RCCDataExtractor.My.Resources.Resources.documents_24
        Me.mnuOpenLastBB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuOpenLastBB.Name = "mnuOpenLastBB"
        Me.mnuOpenLastBB.Size = New System.Drawing.Size(286, 29)
        Me.mnuOpenLastBB.Text = "Open Last Big Boys Scenario"
        Me.mnuOpenLastBB.ToolTipText = "Opens the last Bigs Boys Fashion data settings"
        '
        'mnuOpenLastTDF
        '
        Me.mnuOpenLastTDF.Image = Global.RCCDataExtractor.My.Resources.Resources.documents_24
        Me.mnuOpenLastTDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuOpenLastTDF.Name = "mnuOpenLastTDF"
        Me.mnuOpenLastTDF.Size = New System.Drawing.Size(247, 29)
        Me.mnuOpenLastTDF.Text = "Open Last TDF Scenario"
        Me.mnuOpenLastTDF.ToolTipText = "Opens the last To Die For data settings"
        '
        'mnuOpen
        '
        Me.mnuOpen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenSavedBB, Me.mnuOpenSavedTDF})
        Me.mnuOpen.Image = Global.RCCDataExtractor.My.Resources.Resources.folder_open_24
        Me.mnuOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(94, 29)
        Me.mnuOpen.Text = "Open"
        '
        'mnuOpenSavedBB
        '
        Me.mnuOpenSavedBB.Image = Global.RCCDataExtractor.My.Resources.Resources.disc_media_24
        Me.mnuOpenSavedBB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuOpenSavedBB.Name = "mnuOpenSavedBB"
        Me.mnuOpenSavedBB.Size = New System.Drawing.Size(313, 30)
        Me.mnuOpenSavedBB.Text = "Open Saved Big Boys Data"
        '
        'mnuOpenSavedTDF
        '
        Me.mnuOpenSavedTDF.Image = Global.RCCDataExtractor.My.Resources.Resources.disc_media_24
        Me.mnuOpenSavedTDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuOpenSavedTDF.Name = "mnuOpenSavedTDF"
        Me.mnuOpenSavedTDF.Size = New System.Drawing.Size(313, 30)
        Me.mnuOpenSavedTDF.Text = "Open Saved TDF Data"
        '
        'mnuNameCheck
        '
        Me.mnuNameCheck.Image = Global.RCCDataExtractor.My.Resources.Resources.lc05961
        Me.mnuNameCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuNameCheck.Name = "mnuNameCheck"
        Me.mnuNameCheck.Size = New System.Drawing.Size(171, 29)
        Me.mnuNameCheck.Text = "Check A Name"
        '
        'mnuSettings
        '
        Me.mnuSettings.Image = Global.RCCDataExtractor.My.Resources.Resources.applications_24
        Me.mnuSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(181, 29)
        Me.mnuSettings.Text = "Default Settings"
        '
        'RCCDEMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1264, 650)
        Me.Controls.Add(Me.mstripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mstripMain
        Me.Name = "RCCDEMain"
        Me.Text = "Contacts Data Extractor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mstripMain.ResumeLayout(False)
        Me.mstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mstripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuOpenLastBB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenLastTDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenSavedBB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenSavedTDF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNameCheck As ToolStripMenuItem
End Class
