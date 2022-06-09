Imports System.Data.SqlClient

Public Interface IRepository(Of T)
  'Function getAll(Optional ByVal sqlStr As String = Nothing, Optional ByRef paramList As List(Of SqlParameter) = Nothing) As IEnumerable(Of T)
  Function getAll() As IEnumerable(Of T)
  Function getById(id As Object) As T
  Sub insert(obj)
  Function delete(id As Object)
  Sub save(obj As T)
  'Sub update(obj As T)
End Interface
