Imports DAL
Imports Models
Imports Globals.Defs
Public Class CatBLL

  Dim rep As New CatRepository(Of Cat)
  Dim vmRep As New CatVMRepository()

  ' Public Property searchParameterList As List(Of SQLParam)

  Public Function getFromSearch(paramList As List(Of SQLParam)) As CatVM
    Return vmRep.getFromSearch(paramList)
  End Function

  Public Function getAll() As CatVM
    Return vmRep.getAll()
  End Function

  Public Sub save(rec As Cat)
    rep.save(rec)
  End Sub

  Public Function getFromFilter(vm As CatVM, paramList As List(Of SQLParam)) As CatVM
    Dim cl As List(Of Cat)
    cl = vm.catList.Where(Function(x) (x.gender = paramList(0).paramValue And x.breedId = paramList(1).paramValue And x.age <= CInt(paramList(2).paramValue))).ToList()
    vm.catList = cl

    Return vm
  End Function
End Class
