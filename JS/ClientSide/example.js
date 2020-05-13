"use strict"

const host = 'http://localhost:60614/',
    reportUrl = "TestReport",
    designerOptions = {
        reportUrl: reportUrl, // The URL of a report that is opened in the Report Designer when the application starts.  
        requestOptions: { // Options for processing requests from the Report Designer. 
            host: host, // URI of your backend project. 
            invokeAction: "/ReportDesigner/Invoke", // Action to enable CORS.
            getDesignerModelAction: "/ReportDesigner/GetReportDesignerModel" // Action that returns the Report Designer model. 
        }
    }

ko.applyBindings({ designerOptions });
