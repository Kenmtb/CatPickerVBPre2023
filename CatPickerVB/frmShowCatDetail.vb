Imports Models
Imports Globals
Imports Globals.Defs
Imports Globals.Utilities
Public Class frmShowCatDetail
  Implements Globals.IFormView(Of CatDetailVM)
  Dim bll As New BLL.CatDetailBll
  Public detailList = New List(Of CatDetail)
  Dim frm As Form1
  Dim ctrl As CatController
  Dim vm As CatDetailVM
  Dim rec As CatDetail
  Dim recIndex As Integer
  Dim bs As BindingSource


  Public Sub New()
    ' This call is required by the designer.
    InitializeComponent()

  End Sub

  Public Sub initForm(vm As CatDetailVM) Implements IFormView(Of CatDetailVM).initForm
    Me.vm = vm
    txtDescription.Text = vm.catDetail.description
    txtWeight.Text = vm.catDetail.weight
    txtWeight.Text = vm.catDetail.weight
    txtPersonality.Text = vm.personality
  End Sub

  Private Sub IFormView_Show() Implements IFormView(Of CatDetailVM).Show
    Throw New NotImplementedException()
  End Sub
End Class