Imports Models
Imports Globals
Imports Globals.Defs
Public Class CatPersonalityRepository
  Inherits ODBCRep(Of CatPersonality)
  Implements IRepository(Of CatPersonality)

  Dim rec As CatPersonality

  Public Sub New()
    MyBase.conStrName = "CatsContext"
    MyBase.createSQLstrings("dbo.cats")
  End Sub

  Public Sub insert(obj As Object) Implements IRepository(Of CatPersonality).insert
    Throw New NotImplementedException()
  End Sub

  Public Sub save(obj As CatPersonality) Implements IRepository(Of CatPersonality).save
    Try
      saveRecords(obj, obj.Id)
    Catch ex As Exception
      Throw New Exception("Save failed. Changes are not saved ex:")
    End Try
  End Sub

  Public Function MockgetAll() As List(Of CatPersonality)

    'Dim testList = New List(Of CatPersonality)()
    'Dim cat1 As New CatPersonality
    'cat1.name = "Joey"
    'cat1.age = 2

    'testList.Add(cat1)

    'Return testList
    Return Nothing

  End Function

  Public Function getFromSearch(paramList As List(Of SQLParam))
    Return getRecords(paramList)
  End Function

  Public Function getAll() As IEnumerable(Of CatPersonality) Implements IRepository(Of CatPersonality).getAll
    Return getRecords()
  End Function

  Public Overrides Function populateRecord(dr As DataRow) As CatPersonality
    'Return MyBase.populateRecord(dr)
    Dim catRec = New CatPersonality()
    catRec.Id = dr("Id")
    catRec.personalityRank = dr("personalityRank")
    catRec.personalityType = If(Not IsDBNull(dr("personalityType")), DirectCast(dr("personalityType"), Nullable(Of Integer)), Nothing)

    Return catRec
  End Function



  Public Overrides Function populateDataRow(datarec As CatPersonality, dr As DataRow) As DataRow
    Dim ds As New DataSet()

    dr("Id") = datarec.Id
    dr("personalityRank") = datarec.personalityRank
    dr("personalityType") = datarec.personalityType
    Return dr

  End Function

  Public Function getById(id As Object) As CatPersonality Implements IRepository(Of CatPersonality).getById
    'return (GetRecords("SELECT * FROM dbo.cats WHERE Id = " + id)).FirstOrDefault();
    ' id = -1 means a New record Is requested for the editor, otherwise return a record

    If id = -1 Then
      rec = New CatPersonality()
      initNewRec(rec)
      Return rec
    Else
      Return getRecordByID(id)

    End If
  End Function

  Public Function delete(id As Object) As Object Implements IRepository(Of CatPersonality).delete
    Throw New NotImplementedException()
  End Function


  Private Function initNewRec(rec As CatPersonality) As CatPersonality
    'Initialize record with default data
    rec.personalityRank = "N/A"
    rec.personalityType = "N/A"
    Return rec
  End Function
End Class
