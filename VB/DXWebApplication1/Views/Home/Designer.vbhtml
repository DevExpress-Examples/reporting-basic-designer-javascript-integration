@Html.DevExpress().ReportDesigner(Sub(settings)
    settings.Name = "ReportDesigner1"
End Sub).BindToUrl("TestReport").GetHtml()