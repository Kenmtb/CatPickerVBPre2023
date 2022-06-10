Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Globals.Defs

Public NotInheritable Class Utilities
  Dim fd As OpenFileDialog = New OpenFileDialog()
  Dim strFileName As String

  Public Sub fileDialogBox()

    fd.Title = "Open File Dialog"
    fd.InitialDirectory = imageDir
    fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
    fd.FilterIndex = 2
    fd.RestoreDirectory = True

    If fd.ShowDialog() = DialogResult.OK Then
      strFileName = fd.FileName
    End If
  End Sub

  Public Shared Sub ClearFormBindings(frm As Form)
    'Clears all form controls binding for one container level drill down.
    Dim c, cc, ccc As Control
    For Each c In frm.Controls
      c.DataBindings.Clear()
      If c.HasChildren Then
        For Each cc In c.Controls
          cc.DataBindings.Clear()
          If cc.HasChildren Then
            For Each ccc In cc.Controls
              ccc.DataBindings.Clear()
            Next ccc
          End If
        Next cc
      End If
    Next c
  End Sub

  Public Shared Function SQLLookup(configFileConnectionStringName As String, sqlstr As String) As DataTable

    'configFileConnectionStringName:  config files <connectionStrings>  name

    'Look for the name in the connection string section
    Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings(configFileConnectionStringName)

    Dim dt As New DataTable
    Using cnn As New SqlConnection(settings.ConnectionString)
      cnn.Open()
      Using dad As New SqlDataAdapter(sqlstr, cnn)
        dad.Fill(dt)
      End Using
      cnn.Close()
    End Using

    Return dt

  End Function

End Class
