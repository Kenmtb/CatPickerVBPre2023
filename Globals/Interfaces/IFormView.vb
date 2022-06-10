Public Interface IFormView(Of T)
  Sub initForm(vm As T)
  Sub Show() ' can be an overloaded method or the base Show()
End Interface
