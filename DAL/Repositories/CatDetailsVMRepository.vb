Imports Models
Imports Globals.Defs
Imports Globals.Utilities
Public Class CatDetailVMRepository
  Private vm As CatDetailVM
  Private rep As CatDetailRepository(Of CatDetail)


  Public Sub New()

  End Sub

  Public Function getAll() As CatDetailVM
    '  vm = New CatDetailVM()
    '  vm.catDetailList = (New CatDetailRepository(Of CatDetail)).getAll().ToList()

    '  Return vm
    Return Nothing
  End Function

  Public Function getFromSearch(paramList As List(Of SQLParam))
    '  vm = New CatDetailVM()
    '  vm.catDetailList = (New CatDetailRepository(Of CatDetail)).getFromSearch(paramList)

    '  Return vm
    Return Nothing
  End Function

  Public Function getById(id As Integer) As CatDetailVM
    vm = New CatDetailVM()
    vm.catDetail = (New CatDetailRepository(Of CatDetail)).getById(id)

    'TEMP- replace with repo as a data source!
    Dim dt As New DataTable
    dt = SQLLookup("CatsContext", "select personalityType from dbo.catPersonality where id = " + CStr(vm.catDetail.personalityId))
    vm.personality = dt.Rows(0).ItemArray(0)

    Return vm
  End Function
End Class
