﻿Imports DevExpress.Web.Mvc.Controllers
Imports System.Web.Mvc

Namespace DXWebApplication1.Controllers
    Public Class WebDocumentViewerController
        Inherits WebDocumentViewerApiControllerBase

        '
        ' GET: /WebDocumentViewer/

        Public Overrides Function Invoke() As ActionResult
            Dim result = MyBase.Invoke()
            ' Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*")
            Return result
        End Function

    End Class
End Namespace