const host = 'https://localhost:5001/',
    reportUrl = "TestReport",
    designerOptions = {
        reportUrl: reportUrl, // The URL of a report that the Report Designer loads when the application starts.  
        requestOptions: { // Options for processing requests from the Report Designer. 
            host: host, // URI of your backend project.
            // If you use the ASP.NET Core backend:
            getDesignerModelAction: "/DXXRD/GetDesignerModel"
            // If you use the ASP.NET MVC backend:
            // invokeAction: "/ReportDesigner/Invoke", // Action to enable CORS.
            // getDesignerModelAction: "/ReportDesigner/GetReportDesignerModel"; 
        }
    }

new DevExpress.Reporting.Designer.DxReportDesigner(document.getElementById("designer"), designerOptions).render();