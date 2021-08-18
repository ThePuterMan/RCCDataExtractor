<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactQuery
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstText = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SecondText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OptBoth = New System.Windows.Forms.RadioButton()
        Me.OptOneOrOther = New System.Windows.Forms.RadioButton()
        Me.OptFirstButNotSecond = New System.Windows.Forms.RadioButton()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.OptFirstOnly = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1198, 317)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1. Enter the name or part name or other text, email or part email to find."
        '
        'FirstText
        '
        Me.FirstText.Location = New System.Drawing.Point(500, 16)
        Me.FirstText.MaxLength = 50
        Me.FirstText.Name = "FirstText"
        Me.FirstText.Size = New System.Drawing.Size(284, 24)
        Me.FirstText.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(818, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(Max 50 characters)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(818, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "(Max 50 characters)"
        '
        'SecondText
        '
        Me.SecondText.Location = New System.Drawing.Point(500, 77)
        Me.SecondText.MaxLength = 50
        Me.SecondText.Name = "SecondText"
        Me.SecondText.Size = New System.Drawing.Size(284, 24)
        Me.SecondText.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(472, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "2. Enter the name or part name or other text, email or part email to find."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(365, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "YOU CAN ADD ANOTHER TEXT FOR THE SEARCH"
        '
        'OptBoth
        '
        Me.OptBoth.AutoSize = True
        Me.OptBoth.Location = New System.Drawing.Point(500, 50)
        Me.OptBoth.Name = "OptBoth"
        Me.OptBoth.Size = New System.Drawing.Size(113, 22)
        Me.OptBoth.TabIndex = 8
        Me.OptBoth.Text = "Also includes"
        Me.OptBoth.UseVisualStyleBackColor = True
        '
        'OptOneOrOther
        '
        Me.OptOneOrOther.AutoSize = True
        Me.OptOneOrOther.Location = New System.Drawing.Point(619, 50)
        Me.OptOneOrOther.Name = "OptOneOrOther"
        Me.OptOneOrOther.Size = New System.Drawing.Size(98, 22)
        Me.OptOneOrOther.TabIndex = 9
        Me.OptOneOrOther.Text = "Or has this"
        Me.OptOneOrOther.UseVisualStyleBackColor = True
        '
        'OptFirstButNotSecond
        '
        Me.OptFirstButNotSecond.AutoSize = True
        Me.OptFirstButNotSecond.Location = New System.Drawing.Point(723, 50)
        Me.OptFirstButNotSecond.Name = "OptFirstButNotSecond"
        Me.OptFirstButNotSecond.Size = New System.Drawing.Size(242, 22)
        Me.OptFirstButNotSecond.TabIndex = 10
        Me.OptFirstButNotSecond.Text = "Has the first but NOT the second"
        Me.OptFirstButNotSecond.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Image = Global.RCCDataExtractor.My.Resources.Resources.lc05961
        Me.SearchButton.Location = New System.Drawing.Point(1048, 20)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(127, 80)
        Me.SearchButton.TabIndex = 11
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'OptFirstOnly
        '
        Me.OptFirstOnly.AutoSize = True
        Me.OptFirstOnly.Checked = True
        Me.OptFirstOnly.Location = New System.Drawing.Point(405, 50)
        Me.OptFirstOnly.Name = "OptFirstOnly"
        Me.OptFirstOnly.Size = New System.Drawing.Size(89, 22)
        Me.OptFirstOnly.TabIndex = 12
        Me.OptFirstOnly.TabStop = True
        Me.OptFirstOnly.Text = "First Only"
        Me.OptFirstOnly.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(97, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1005, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "The search matches text in the first and last names, the town, the postcode, phon" &
    "e fields or the email address. All the address fields including telephone number" &
    "s and DOB are returned."
        '
        'ContactQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1198, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.OptFirstOnly)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.OptFirstButNotSecond)
        Me.Controls.Add(Me.OptOneOrOther)
        Me.Controls.Add(Me.OptBoth)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SecondText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FirstText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ContactQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Query Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents FirstText As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SecondText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OptBoth As RadioButton
    Friend WithEvents OptOneOrOther As RadioButton
    Friend WithEvents OptFirstButNotSecond As RadioButton
    Friend WithEvents SearchButton As Button
    Friend WithEvents OptFirstOnly As RadioButton
    Friend WithEvents Label6 As Label
End Class
