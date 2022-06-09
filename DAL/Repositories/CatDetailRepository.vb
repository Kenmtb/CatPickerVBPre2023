﻿Imports System.Data.SqlClient
Imports Models

Public Class CatDetailRepository(Of T)
  Inherits ODBCRep(Of CatDetail)
  Implements IRepository(Of CatDetail)

  Private rec As CatDetail

  Public Sub New()
    conStrName = "CatsContext"
    createSQLstrings("dbo.catDetails")
  End Sub

  Public Sub insert(obj As Object) Implements IRepository(Of CatDetail).insert
    Throw New NotImplementedException()
  End Sub

  Public Sub save(obj As CatDetail) Implements IRepository(Of CatDetail).save
    Throw New NotImplementedException()
  End Sub

  Public Function getAll() As IEnumerable(Of CatDetail) Implements IRepository(Of CatDetail).getAll
    Return getRecords()
  End Function

  Public Function getById(id As Object) As CatDetail Implements IRepository(Of CatDetail).getById
    'return (GetRecords("SELECT * FROM dbo.cats WHERE Id = " + id)).FirstOrDefault();
    ' id = -1 means a New record Is requested for the editor, otherwise return a record

    If id = -1 Then
      rec = New CatDetail()
      'initNewRec(rec)
      Return rec
    Else
      Return getRecordByID(id)
    End If
  End Function

  Public Function delete(id As Object) As Object Implements IRepository(Of CatDetail).delete
    Throw New NotImplementedException()
  End Function
End Class
