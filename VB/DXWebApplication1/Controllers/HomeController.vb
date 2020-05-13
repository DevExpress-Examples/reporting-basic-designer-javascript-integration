Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function


    Function Designer() As ActionResult
        Dim model As New Models.ReportsModel()
        Return View(model)
    End Function

    Function Viewer() As ActionResult
        Return View()
    End Function
End Class