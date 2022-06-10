<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShowCats
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
        Me.dgvShowCats = New System.Windows.Forms.DataGridView()
        Me.picCatPic = New System.Windows.Forms.PictureBox()
        Me.txtCatPicName = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnShowSelected = New System.Windows.Forms.Button()
        Me.btnShowEditor = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtArrivalDate = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dlgPictures = New System.Windows.Forms.OpenFileDialog()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbBreed = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSearchBreed = New System.Windows.Forms.ComboBox()
        Me.cmbSearchGender = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSearchAge = New System.Windows.Forms.TextBox()
        Me.radEdit = New System.Windows.Forms.RadioButton()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.radDetails = New System.Windows.Forms.RadioButton()
        Me.radSearch = New System.Windows.Forms.RadioButton()
        Me.CatBreedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvShowCats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCatPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEdit.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.grpMenu.SuspendLayout()
        CType(Me.CatBreedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvShowCats
        '
        Me.dgvShowCats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShowCats.Location = New System.Drawing.Point(12, 12)
        Me.dgvShowCats.Name = "dgvShowCats"
        Me.dgvShowCats.ReadOnly = True
        Me.dgvShowCats.Size = New System.Drawing.Size(1347, 493)
        Me.dgvShowCats.TabIndex = 0
        Me.dgvShowCats.VirtualMode = True
        '
        'picCatPic
        '
        Me.picCatPic.Location = New System.Drawing.Point(13, 62)
        Me.picCatPic.Name = "picCatPic"
        Me.picCatPic.Size = New System.Drawing.Size(237, 222)
        Me.picCatPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCatPic.TabIndex = 1
        Me.picCatPic.TabStop = False
        '
        'txtCatPicName
        '
        Me.txtCatPicName.Location = New System.Drawing.Point(13, 290)
        Me.txtCatPicName.Name = "txtCatPicName"
        Me.txtCatPicName.Size = New System.Drawing.Size(237, 20)
        Me.txtCatPicName.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 711)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnShowSelected
        '
        Me.btnShowSelected.Location = New System.Drawing.Point(23, 527)
        Me.btnShowSelected.Name = "btnShowSelected"
        Me.btnShowSelected.Size = New System.Drawing.Size(88, 40)
        Me.btnShowSelected.TabIndex = 4
        Me.btnShowSelected.Text = "Selected Cats"
        Me.btnShowSelected.UseVisualStyleBackColor = True
        '
        'btnShowEditor
        '
        Me.btnShowEditor.Enabled = False
        Me.btnShowEditor.Location = New System.Drawing.Point(23, 751)
        Me.btnShowEditor.Name = "btnShowEditor"
        Me.btnShowEditor.Size = New System.Drawing.Size(88, 40)
        Me.btnShowEditor.TabIndex = 5
        Me.btnShowEditor.Text = "Edit Cat"
        Me.btnShowEditor.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(329, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 20)
        Me.txtName.TabIndex = 6
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(329, 88)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(40, 20)
        Me.txtAge.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(256, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Arrival Date"
        '
        'txtArrivalDate
        '
        Me.txtArrivalDate.Location = New System.Drawing.Point(329, 173)
        Me.txtArrivalDate.Name = "txtArrivalDate"
        Me.txtArrivalDate.Size = New System.Drawing.Size(76, 20)
        Me.txtArrivalDate.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(329, 199)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 40)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dlgPictures
        '
        Me.dlgPictures.FileName = "OpenFileDialog1"
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.Label10)
        Me.pnlEdit.Controls.Add(Me.cmbBreed)
        Me.pnlEdit.Controls.Add(Me.cmbGender)
        Me.pnlEdit.Controls.Add(Me.Label5)
        Me.pnlEdit.Controls.Add(Me.picCatPic)
        Me.pnlEdit.Controls.Add(Me.btnSave)
        Me.pnlEdit.Controls.Add(Me.Label1)
        Me.pnlEdit.Controls.Add(Me.txtAge)
        Me.pnlEdit.Controls.Add(Me.txtCatPicName)
        Me.pnlEdit.Controls.Add(Me.txtName)
        Me.pnlEdit.Controls.Add(Me.Label4)
        Me.pnlEdit.Controls.Add(Me.Label2)
        Me.pnlEdit.Controls.Add(Me.Label3)
        Me.pnlEdit.Controls.Add(Me.txtArrivalDate)
        Me.pnlEdit.Location = New System.Drawing.Point(141, 511)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(493, 318)
        Me.pnlEdit.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(256, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Breed"
        '
        'cmbBreed
        '
        Me.cmbBreed.FormattingEnabled = True
        Me.cmbBreed.Location = New System.Drawing.Point(329, 119)
        Me.cmbBreed.Name = "cmbBreed"
        Me.cmbBreed.Size = New System.Drawing.Size(141, 21)
        Me.cmbBreed.TabIndex = 17
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(329, 146)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(76, 21)
        Me.cmbGender.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(210, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Editor"
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.btnFilter)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.Label9)
        Me.pnlSearch.Controls.Add(Me.Label8)
        Me.pnlSearch.Controls.Add(Me.Label7)
        Me.pnlSearch.Controls.Add(Me.cmbSearchBreed)
        Me.pnlSearch.Controls.Add(Me.cmbSearchGender)
        Me.pnlSearch.Controls.Add(Me.Label6)
        Me.pnlSearch.Controls.Add(Me.txtSearchAge)
        Me.pnlSearch.Location = New System.Drawing.Point(141, 511)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(493, 318)
        Me.pnlSearch.TabIndex = 16
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(14, 144)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 24
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(14, 115)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 23
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(288, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Age"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(151, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Breed"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Gender"
        '
        'cmbSearchBreed
        '
        Me.cmbSearchBreed.FormattingEnabled = True
        Me.cmbSearchBreed.Location = New System.Drawing.Point(154, 83)
        Me.cmbSearchBreed.Name = "cmbSearchBreed"
        Me.cmbSearchBreed.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchBreed.TabIndex = 18
        '
        'cmbSearchGender
        '
        Me.cmbSearchGender.FormattingEnabled = True
        Me.cmbSearchGender.Items.AddRange(New Object() {"Any", "Male", "Female"})
        Me.cmbSearchGender.Location = New System.Drawing.Point(14, 83)
        Me.cmbSearchGender.Name = "cmbSearchGender"
        Me.cmbSearchGender.Size = New System.Drawing.Size(121, 21)
        Me.cmbSearchGender.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Search"
        '
        'txtSearchAge
        '
        Me.txtSearchAge.Location = New System.Drawing.Point(291, 84)
        Me.txtSearchAge.Name = "txtSearchAge"
        Me.txtSearchAge.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchAge.TabIndex = 0
        '
        'radEdit
        '
        Me.radEdit.AutoSize = True
        Me.radEdit.Location = New System.Drawing.Point(17, 19)
        Me.radEdit.Name = "radEdit"
        Me.radEdit.Size = New System.Drawing.Size(43, 17)
        Me.radEdit.TabIndex = 17
        Me.radEdit.TabStop = True
        Me.radEdit.Text = "Edit"
        Me.radEdit.UseVisualStyleBackColor = True
        '
        'grpMenu
        '
        Me.grpMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpMenu.Controls.Add(Me.radDetails)
        Me.grpMenu.Controls.Add(Me.radSearch)
        Me.grpMenu.Controls.Add(Me.radEdit)
        Me.grpMenu.Location = New System.Drawing.Point(23, 576)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(80, 102)
        Me.grpMenu.TabIndex = 18
        Me.grpMenu.TabStop = False
        '
        'radDetails
        '
        Me.radDetails.AutoSize = True
        Me.radDetails.Location = New System.Drawing.Point(17, 42)
        Me.radDetails.Name = "radDetails"
        Me.radDetails.Size = New System.Drawing.Size(57, 17)
        Me.radDetails.TabIndex = 19
        Me.radDetails.TabStop = True
        Me.radDetails.Text = "Details"
        Me.radDetails.UseVisualStyleBackColor = True
        '
        'radSearch
        '
        Me.radSearch.AutoSize = True
        Me.radSearch.Location = New System.Drawing.Point(17, 65)
        Me.radSearch.Name = "radSearch"
        Me.radSearch.Size = New System.Drawing.Size(59, 17)
        Me.radSearch.TabIndex = 18
        Me.radSearch.TabStop = True
        Me.radSearch.Text = "Search"
        Me.radSearch.UseVisualStyleBackColor = True
        '
        'CatBreedBindingSource
        '
        Me.CatBreedBindingSource.DataSource = GetType(Models.CatBreed)
        '
        'frmShowCats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 830)
        Me.Controls.Add(Me.pnlEdit)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.grpMenu)
        Me.Controls.Add(Me.dgvShowCats)
        Me.Controls.Add(Me.btnShowSelected)
        Me.Controls.Add(Me.btnShowEditor)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmShowCats"
        Me.Text = "Form1"
        CType(Me.dgvShowCats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCatPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.grpMenu.ResumeLayout(False)
        Me.grpMenu.PerformLayout()
        CType(Me.CatBreedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvShowCats As DataGridView
    Friend WithEvents picCatPic As PictureBox
    Friend WithEvents txtCatPicName As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnShowSelected As Button
    Friend WithEvents btnShowEditor As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtArrivalDate As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dlgPictures As OpenFileDialog
    Friend WithEvents pnlEdit As Panel
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents radEdit As RadioButton
    Friend WithEvents grpMenu As GroupBox
    Friend WithEvents radSearch As RadioButton
    Friend WithEvents txtSearchAge As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSearchBreed As ComboBox
    Friend WithEvents cmbSearchGender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbBreed As ComboBox
    Friend WithEvents CatBreedBindingSource As BindingSource
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnFilter As Button
    Friend WithEvents radDetails As RadioButton
End Class
