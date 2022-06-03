Imports BLL
Imports Models
Imports Globals
Imports CatPickerVB

Imports System.Windows.Forms

Public Class CatController
  Dim bll As New CatBLL
  Dim vm As New CatVM
  Dim viewShowCats As ViewShowCats
  Dim viewEditCat As ViewEditCat
  'Dim frm As IFormView(Of CatVM)

  'Public Sub New(frm As IFormView(Of CatVM))
  '  Me.frm = frm
  'End Sub

  Public Sub New()
    'default form
    viewShowCats = New ViewShowCats()
    viewShowCats.frm = New frmShowCats
    viewShowCats.vm = vm
  End Sub

  Public Sub startForm()
    'fill the startup VM
    vm = bll.getAll()

    viewShowCats.frm.initForm(vm)
    viewShowCats.frm.Show()
  End Sub

  Public Sub ShowSelected(vm As CatVM)

    Dim model As List(Of Cat) = vm.catList
    Dim selCats = From x In model Where x.selected = True

    'create a vm with selCats
    Dim catvm As New CatVM
    catvm.catList = selCats.ToList()

    viewShowCats.frm.initForm(catvm)
    viewShowCats.frm.Show()

  End Sub

  Public Sub ShowEditor(vm As CatVM)

    'get the form
    viewEditCat = New ViewEditCat()
    viewEditCat.frm = New frmEditCat
    viewEditCat.vm = vm

    'fill the VM
    vm = bll.getAll()

    viewEditCat.frm.initForm(vm)
    viewEditCat.frm.Show()


  End Sub


End Class
