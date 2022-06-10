<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShowCatDetail
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
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.txtLocation = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtPersonality = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.pnlDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDetails
        '
        Me.pnlDetails.Controls.Add(Me.txtLocation)
        Me.pnlDetails.Controls.Add(Me.Label12)
        Me.pnlDetails.Controls.Add(Me.Label13)
        Me.pnlDetails.Controls.Add(Me.Label14)
        Me.pnlDetails.Controls.Add(Me.Label15)
        Me.pnlDetails.Controls.Add(Me.TextBox6)
        Me.pnlDetails.Controls.Add(Me.txtState)
        Me.pnlDetails.Controls.Add(Me.txtCity)
        Me.pnlDetails.Controls.Add(Me.txtPersonality)
        Me.pnlDetails.Controls.Add(Me.txtWeight)
        Me.pnlDetails.Controls.Add(Me.txtDescription)
        Me.pnlDetails.Location = New System.Drawing.Point(12, 12)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(493, 318)
        Me.pnlDetails.TabIndex = 20
        '
        'txtLocation
        '
        Me.txtLocation.AutoSize = True
        Me.txtLocation.Location = New System.Drawing.Point(29, 242)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(48, 13)
        Me.txtLocation.TabIndex = 23
        Me.txtLocation.Text = "Location"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Personality"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 298)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "City"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 213)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Weight"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(29, 271)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "State"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(109, 239)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(352, 20)
        Me.TextBox6.TabIndex = 5
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(109, 267)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(109, 293)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 3
        '
        'txtPersonality
        '
        Me.txtPersonality.Location = New System.Drawing.Point(109, 187)
        Me.txtPersonality.Name = "txtPersonality"
        Me.txtPersonality.Size = New System.Drawing.Size(352, 20)
        Me.txtPersonality.TabIndex = 2
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(109, 213)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 1
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(32, 15)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(429, 163)
        Me.txtDescription.TabIndex = 0
        '
        'frmShowCatDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 336)
        Me.Controls.Add(Me.pnlDetails)
        Me.Name = "frmShowCatDetail"
        Me.Text = "frmShowDetails"
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDetails As Panel
    Friend WithEvents txtLocation As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtPersonality As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtDescription As TextBox
End Class
