Imports DAL
Imports Models
Imports Globals.Defs
Public Class CatDetailBll
  Dim rep As New CatDetailRepository(Of CatDetail)
  Dim vmRep As New CatDetailVMRepository

  ' Public Property searchParameterList As List(Of SQLParam)

  Public Function getFromSearch(paramList As List(Of SQLParam)) As CatDetailVM
    Return vmRep.getFromSearch(paramList)
  End Function

  Public Function getAll() As CatDetailVM
    Return vmRep.getAll()
  End Function

  Public Function getById(id As Integer) As CatDetailVM
    Return vmRep.getById(id)
  End Function

  Public Sub save(rec As CatDetail)
    rep.save(rec)
  End Sub

  'Public Function getFromFilter(vm As CatDetailVM, paramList As List(Of SQLParam)) As CatDetailVM
  '  Dim cl As List(Of Cat)
  '  cl = vm.catDetailList.Where(Function(x) (x.gender = paramList(0).paramValue And x.breedId = paramList(1).paramValue And x.age <= CInt(paramList(2).paramValue))).ToList()
  '  vm.catDetailList = cl

  '  Return vm
  'End Function
End Class
