Imports DAL
Imports Models
Imports Globals.Defs
Public Class CatDetailsRepository(Of t)
  Inherits ODBCRep(Of CatDetail)
  Implements IRepository(Of CatDetail)

  Dim rec As CatDetail

  Public Sub New()
    MyBase.conStrName = "CatsContext"
    MyBase.createSQLstrings("dbo.catsDetails")
  End Sub

  Public Sub insert(obj As Object) Implements IRepository(Of CatDetail).insert
    Throw New NotImplementedException()
  End Sub

  Public Sub save(obj As CatDetail) Implements IRepository(Of CatDetail).save
    Try
      saveRecords(obj, obj.id)
    Catch ex As Exception
      Throw New Exception("Save failed. Changes are not saved ex:")
    End Try
  End Sub

  Public Function MockgetAll() As List(Of CatDetail)

    Dim testList = New List(Of CatDetail)()
    Dim cat1 As New CatDetail


    testList.Add(cat1)

    Return testList
  End Function

  Public Function getFromSearch(paramList As List(Of SQLParam))
    Return getRecords(paramList)
  End Function

  Public Function getAll() As IEnumerable(Of CatDetail) Implements IRepository(Of CatDetail).getAll
    Return getRecords()
  End Function

  Public Overrides Function populateRecord(dr As DataRow) As CatDetail
    'Return MyBase.populateRecord(dr)
    Dim catRec = New CatDetail()
    catRec.Id = dr("ID")
    catRec.descriptions = dr("descriptions")
    catRec.weight = If(Not IsDBNull(dr("weight")), DirectCast(dr("weight"), Nullable(Of Integer)), Nothing)
    catRec.locationId = If(Not IsDBNull(dr("locationId")), DirectCast(dr("locationId"), Nullable(Of Integer)), Nothing)
    catRec.stateId = If(Not IsDBNull(dr("stateId")), DirectCast(dr("stateId"), Nullable(Of Integer)), Nothing)
    catRec.cityId = If(Not IsDBNull(dr("cityId")), DirectCast(dr("cityId"), Nullable(Of Integer)), Nothing)
    catRec.personalityId = If(Not IsDBNull(dr("personalityId")), DirectCast(dr("personalityId"), Nullable(Of Integer)), Nothing)
    catRec.detailPicId = If(Not IsDBNull(dr("detailPicId")), DirectCast(dr("detailPicId"), Nullable(Of Integer)), Nothing)
    Return catRec
  End Function



  Public Overrides Function populateDataRow(datarec As CatDetail, dr As DataRow) As DataRow
    Dim ds As New DataSet()

    dr("descriptions") = datarec.descriptions
    dr("weight") = datarec.weight
    dr("locationId") = datarec.locationId
    dr("stateId") = datarec.stateId
    dr("cityId") = datarec.cityId
    dr("personalityId") = datarec.personalityId
    dr("detailPicId") = datarec.detailPicId
    Return dr

  End Function

  Public Function getById(id As Object) As CatDetail Implements IRepository(Of CatDetail).getById
    'return (GetRecords("SELECT * FROM dbo.cats WHERE Id = " + id)).FirstOrDefault();
    ' id = -1 means a New record Is requested for the editor, otherwise return a record

    If id = -1 Then
      rec = New CatDetail()
      initNewRec(rec)
      Return rec
    Else
      Return getRecordByID(id)

    End If
  End Function

  Public Function delete(id As Object) As Object Implements IRepository(Of CatDetail).delete
    Throw New NotImplementedException()
  End Function


  Private Function initNewRec(rec As CatDetail) As CatDetail
    'Initialize record with default data
    rec.descriptions = "N/A"
    rec.weight = 0
    rec.locationId = 0
    rec.stateId = 0
    rec.cityId = 0
    rec.personalityId = 0
    rec.detailPicId = 0
    Return rec
  End Function
End Class
