Imports Models
Imports Globals
Imports Globals.Defs

Public Class frmEditCat
  Implements Globals.IFormView(Of CatVM)
  Dim bll As New BLL.CatBLL
  Dim catList = New List(Of Cat)
  Dim frm As Form1
  Dim ctrl As CatController

  Dim vm As CatVM

  'move to resource file
  'Dim imageDir As String = "C:\Users\Ken\source\repos\CatPicker\CatPicker\Images\Cats\"

  'get the form data
  'Public Property vm As CatVM

  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()
    frm = New Form1()
    'ctrl = New CatController
  End Sub

  Public Sub initForm(vm As CatVM) Implements IFormView(Of CatVM).initForm

    Me.vm = vm
    catList = vm.catList

    Dim bs As New BindingSource()
    bs.DataSource = catList
    dgv.DataSource = catList

    'Move to resource file
    Dim img As Image

    'Format
    For Each col As DataGridViewColumn In dgv.Columns
      col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    Next

    dgv.RowTemplate.Height = 80
    dgv.CellBorderStyle = DataGridViewCellBorderStyle.None

    Dim imageCol As DataGridViewImageColumn = dgv.Columns("image")
    imageCol.Width = 150
    imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom

    dgv.Columns("Image").DisplayIndex = 0
    dgv.Columns("image").HeaderText = "Picture"
    dgv.Columns("name").HeaderText = "Name"
    dgv.Columns("age").HeaderText = "Age"
    dgv.Columns("gender").HeaderText = "Gender"
    dgv.Columns("mainColor").HeaderText = "Main Color"
    dgv.Columns("secondColor").HeaderText = "Second Color"
    dgv.Columns("thirdColor").HeaderText = "Third Color"
    dgv.Columns("arrivalDate").HeaderText = "Arrival Date"

    'Hide
    dgv.Columns("Id").Visible = False
    dgv.Columns("breedId").Visible = False
    dgv.Columns("detailsId").Visible = False
    dgv.Columns("pic").Visible = False


    'ADD images to columns
    For Each row As DataGridViewRow In dgv.Rows

      'dirImg = imageDir + row.Cells("pic").Value.ToString()

      'get the stored image
      img = Image.FromFile(imageDir + row.Cells("pic").Value.ToString())
      'update the image control
      row.Cells("image").Value = img

    Next
  End Sub

  Private Sub IFormView_Show() Implements IFormView(Of CatVM).Show
    Throw New NotImplementedException()
  End Sub

  Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    'bll.save(vm.catList)
  End Sub
End Class