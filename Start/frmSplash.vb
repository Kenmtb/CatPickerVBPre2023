
Imports Controlers
Imports CatPickerVB



Public Class frmSplash
  Dim controller As CatController

  Public Sub New()

    ' This call is required by the designer.
    InitializeComponent()
    Me.WindowState = FormWindowState.Minimized

    ' Add any initialization after the InitializeComponent() call.

  End Sub




  Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'controller = New CatController(New frmShowCats)
    controller = New CatController()
    controller.startForm()
  End Sub

End Class
