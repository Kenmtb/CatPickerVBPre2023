Imports BLL
Imports Models
Public Class detailController
  ' The controller's job is to join a form with it's data source VM
  Dim bll As New CatDetailBll
  Dim vm As New CatDetailVM
  Dim view As ViewShowCatDetail

  'Dim frm As IFormView(Of CatVM)

  'Public Sub New(frm As IFormView(Of CatVM))
  '  Me.frm = frm
  'End Sub

  Public Sub New()
    'default form
    view = New ViewShowCatDetail()
    view.frm = New frmShowCatDetail
    view.vm = vm
  End Sub

  Public Sub ShowForm(vm As CatDetailVM)
    'fill the startup VM
    'vm = bll.getAll()

    view.frm.initForm(vm)
    view.frm.Show()
  End Sub


  Public Sub ShowForm(id As Integer)
    'get by ID
    vm = bll.getById(id)

    view.frm.initForm(vm)
    view.frm.Show()
  End Sub


  Public Sub UpdateForm(id As Integer)
    vm = bll.getById(id)
    view.frm.initForm(vm)
  End Sub


  'Public Sub ShowSelected(vm As CatDetailVM)

  '  Dim model As List(Of CatDetail) = vm.catDetailList
  '  Dim selCats = From x In model Where x.selected = True

  '  'create a vm with selCats
  '  Dim catvm As New CatDetailVM
  '  catvm.catList = selCats.ToList()

  '  view.frm.initForm(catvm)
  '  view.frm.Show()

  'End Sub

  'Public Sub ShowEditor(vm As CatDetailVM)

  '  'get the form
  '  ViewEditCat = New ViewEditCat()
  '  ViewEditCat.frm = New frmEditCat
  '  ViewEditCat.vm = vm

  '  'fill the VM
  '  vm = bll.getAll()

  '  ViewEditCat.frm.initForm(vm)
  '  ViewEditCat.frm.Show()
  'End Sub

End Class
