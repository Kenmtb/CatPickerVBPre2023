Imports DAL
Imports Models
Public Class CatBLL
  Dim rep As New CatRepository(Of Cat)
  Dim vmRep As New CatVMRepository()

  Public Function getAll() As CatVM
    Return vmRep.getAll()
  End Function

  Public Sub save(rec As Cat)
    rep.save(rec)
  End Sub

End Class
