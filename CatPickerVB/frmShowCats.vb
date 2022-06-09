
Imports Models
Imports Globals
Imports Globals.Defs
Imports Globals.Utilities

Public Class frmShowCats
  Implements Globals.IFormView(Of CatVM)
  Dim bll As New BLL.CatBLL
  Public catList = New List(Of Cat)
  Dim frm As Form1
  Dim ctrl As CatController
  Dim vm As CatVM
  Dim rec As Cat
  Dim recIndex As Integer
  Dim bs As BindingSource

  'move to resource file
  'dim imageDir As String = "C:\Users\Ken\source\repos\CatPicker\CatPicker\Images\Cats\"
  'get the form data
  'Public Property vm As CatVM

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    frm = New Form1()
    'ctrl = New CatController
  End Sub


  Private Sub bindControls()

  End Sub

  Private Sub setUpForm(vm As CatVM)

  End Sub


  'Private Sub ClearAllBindings()
  '  Dim c As Control
  '  For Each c In Me.Controls
  '    c.DataBindings.Clear()
  '    If c.HasChildren Then
  '      For Each cc In c.Controls
  '        cc.DataBindings.Clear()
  '      Next cc
  '    End If
  '  Next c

  'End Sub

  Public Sub initForm(vm As CatVM) Implements IFormView(Of CatVM).initForm
    ' Add any initialization after the InitializeComponent() call.
    Me.vm = vm
    catList = vm.catList


    bs = New BindingSource()
    bs.Filter = "gender ='Male'"
    bs.DataSource = catList
    dgvShowCats.DataSource = catList

    'Move to resource file
    Dim img As Image

    'Format
    For Each col As DataGridViewColumn In dgvShowCats.Columns
      col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    Next

    dgvShowCats.RowTemplate.Height = 40 '80
    dgvShowCats.CellBorderStyle = DataGridViewCellBorderStyle.None

    Dim imageCol As DataGridViewImageColumn = dgvShowCats.Columns("image")
    imageCol.Width = 150
    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom

    dgvShowCats.Columns("Image").DisplayIndex = 0
    dgvShowCats.Columns("image").HeaderText = "Picture"
    dgvShowCats.Columns("name").HeaderText = "Name"
    dgvShowCats.Columns("age").HeaderText = "Age"
    dgvShowCats.Columns("gender").HeaderText = "Gender"
    dgvShowCats.Columns("mainColor").HeaderText = "Main Color"
    dgvShowCats.Columns("secondColor").HeaderText = "Second Color"
    dgvShowCats.Columns("thirdColor").HeaderText = "Third Color"
    dgvShowCats.Columns("arrivalDate").HeaderText = "Arrival Date"

    'bind data grid to editor controls   *moved to sep. sub

    ClearFormBindings(Me)
    txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs.DataSource, "name", True))
    txtAge.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs.DataSource, "age", True))
    'txtGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs.DataSource, "gender", True))
    cmbGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs.DataSource, "gender", True))
    'cmbBreed.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs.DataSource, "breedId", True))
    txtArrivalDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs.DataSource, "arrivalDate", True))
    txtCatPicName.DataBindings.Add(New System.Windows.Forms.Binding("Text", bs.DataSource, "pic", True))

    'Hide
    dgvShowCats.Columns("Id").Visible = False
    'dgvShowCats.Columns("breedId").Visible = False
    dgvShowCats.Columns("detailsId").Visible = False
    dgvShowCats.Columns("pic").Visible = False
    'dgvShowCats.Columns("selected").Visible = False

    'ADD images to columns
    For Each row As DataGridViewRow In dgvShowCats.Rows

      'get the stored image
      img = Image.FromFile(imageDir + row.Cells("pic").Value.ToString())
      'update the image control
      row.Cells("image").Value = img

    Next

    'Initialize data
    dlgPictures.InitialDirectory = imageDir
    radEdit.Checked = True
    'add a wildcard
    vm.catBreedList.Add(New CatBreed() With {.breedName = wildCardText, .Id = -1})
    vm.catBreedList = vm.catBreedList.OrderBy((Function(x) x.Id)).ToList()
    'debind 
    cmbBreed.DataSource = vm.catBreedList.ToList() 'converting to list seems to break the implicit binding of the control's datasource which itself is bound to a dgv
    cmbBreed.DisplayMember = "breedName"
    cmbBreed.ValueMember = "Id"


    cmbSearchBreed.DataSource = vm.catBreedList
    cmbSearchBreed.DisplayMember = "breedName"
    cmbSearchBreed.ValueMember = "Id"
    cmbSearchGender.SelectedIndex = 0



bypass:
  End Sub


  Private Function getImageFromStringPathName(imagePathName As String) As Image
    Return Image.FromFile(imagePathName)
  End Function

  Private Sub catDetails(img As Image, name As String)
    picCatPic.Image = img
    txtCatPicName.Text = name
  End Sub

  Private Sub dgvShowCats_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvShowCats.RowEnter


    If e.RowIndex > -1 Then
      recIndex = e.RowIndex
      Dim cells As DataGridViewCellCollection = dgvShowCats.Rows(recIndex).Cells

      '  'catDetails(Image.FromFile(imageDir + dgvShowCats.Rows(row).Cells("pic").Value), dgvShowCats.Rows(row).Cells("name").Value)
      '  'Not sure why this is a composite object, my try breaking into a pic box and text box
      'catDetails(Image.FromFile(imageDir + cells("pic").Value), cells("pic").Value)
      picCatPic.Image = Image.FromFile(imageDir + cells("pic").Value)

      'editor controls
      Dim breeds As List(Of CatBreed) = vm.catBreedList
      Dim breedNames = From brd In breeds
                       Where brd.Id = cells("breedId").Value

      cmbBreed.Text = breedNames(0).breedName '"Mixed" 'add a dlookup to get the breedName from the Id


      '  txtAge.Text = cells("age").Value
      '  txtGender.Text = cells("gender").Value
      '  txtArrivalDate.Text = cells("arrivalDate").Value

    End If
  End Sub

  Private Sub updateViewModel()

  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    If Not frm.Visible Then
      'frm = New Form1()
      frm.Show()
    End If

    frm.Show()
    frm.TextBox1.Text = txtCatPicName.Text
    txtCatPicName.Text = frm.sayHi() + " " + txtCatPicName.Text
  End Sub

  Private Sub IFormView_Show() Implements IFormView(Of CatVM).Show
    'this overloads the the interface's base class Form.Show()
    Me.Show()
  End Sub

  Private Sub btnShowSelected_Click(sender As Object, e As EventArgs) Handles btnShowSelected.Click

    Dim vm As New CatVM
    vm.catList = catList
    ctrl = New CatController
    ctrl.ShowSelected(vm)
  End Sub

  Private Sub btnShowEditor_Click(sender As Object, e As EventArgs) Handles btnShowEditor.Click
    Dim vm As New CatVM
    vm.catList = catList
    ctrl = New CatController
    ctrl.ShowEditor(vm)
  End Sub

  Private Sub txtSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


    rec = catList(recIndex)

    'Handle unbound controls
    rec.breedId = cmbBreed.SelectedItem.Id


    bll.save(rec)

    dgvShowCats.DataSource = Nothing
    vm = bll.getAll()

    'vm.catList = catList
    initForm(vm)
    'dgvShowCats.Update()
    'dgvShowCats.RefreshEdit()
  End Sub

  Private Sub frmShowCats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub picCatPic_Click(sender As Object, e As EventArgs) Handles picCatPic.Click

    dlgPictures.ShowDialog()

    'txtCatPicName.Select()
    txtCatPicName.Text = System.IO.Path.GetFileName(dlgPictures.FileName)
    txtCatPicName.DataBindings("Text").WriteValue() ' required to programatically update controls because ms is to stupid to make it simple

    picCatPic.Image = Image.FromFile(dlgPictures.FileName)

    'btnSave.Select()
    bs.EndEdit()

  End Sub

  Private Sub radEdit_CheckedChanged(sender As Object, e As EventArgs) Handles radEdit.CheckedChanged
    If radEdit.Checked Then
      pnlSearch.Visible = False
      'pnlEdit.BringToFront()
      pnlEdit.Visible = True
    End If
  End Sub

  Private Sub radSearch_CheckedChanged(sender As Object, e As EventArgs) Handles radSearch.CheckedChanged
    If radSearch.Checked Then
      pnlEdit.Visible = False
      pnlSearch.Visible = True
      'pnlSearch.BringToFront()
    End If

  End Sub

  Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
    Dim paramList As List(Of SQLParam) = buildParameterList()
    initForm(bll.getFromSearch(paramList))
  End Sub

  Private Function buildParameterList() As List(Of SQLParam)
    'Build sql search parameter list from search controls.
    'paramName used in search but not needed for filtering
    'paramOperator not used
    Dim paramList As New List(Of SQLParam)
    paramList.Add(New SQLParam With {.paramName = "gender", .parameterOperator = "=", .paramValue = cmbSearchGender.Text})
    paramList.Add(New SQLParam With {.paramName = "breedId", .parameterOperator = "=", .paramValue = cmbSearchBreed.SelectedValue})
    paramList.Add(New SQLParam With {.paramName = "age", .parameterOperator = "<=", .paramValue = txtSearchAge.Text})
    Return paramList
  End Function

  Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
    'Store the orig vm
    Dim origList As New List(Of Cat)
    origList = vm.catList

    Dim paramList As List(Of SQLParam) = buildParameterList()
    initForm(bll.getFromFilter(vm, paramList))

    'restore the original vm
    vm.catList = origList

  End Sub

  Private Sub grpMenu_Enter(sender As Object, e As EventArgs) Handles grpMenu.Enter

  End Sub
End Class
