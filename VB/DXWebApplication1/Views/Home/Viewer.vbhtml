@Html.DevExpress().WebDocumentViewer(Sub(settings)
    settings.Name = "WebDocumentViewer1"
End Sub).Bind("TestReport").GetHtml()