Imports Models

Public Class CatVMRepository

  Private vm As CatVM
  Private rep As CatRepository(Of Cat)
  Private detailsRep As CatDetailRepository(Of CatDetail)

  Public Sub New()
    'Dim catRep = New CatRepository(Of Cat)
    'Dim detailsRep = New CatDetailRepository(Of CatDetail)

    'Instantiate models
    'vm = New CatVM()
    'vm.catList = (New CatRepository(Of Cat)).getAll().ToList()
    'vm.catBreedList = (New CatBreedRepository(Of CatBreed)).getAll.ToList()
  End Sub

  Public Function getAll() As CatVM
    vm = New CatVM()
    vm.catList = (New CatRepository(Of Cat)).getAll().ToList()
    vm.catBreedList = (New CatBreedRepository(Of CatBreed)).getAll.ToList()
    Return vm
  End Function

  Public Function getById(id As Integer) As CatVM

    Return vm
  End Function

End Class
