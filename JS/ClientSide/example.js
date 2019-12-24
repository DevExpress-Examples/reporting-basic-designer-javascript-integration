"use strict"

const host = 'http://localhost:54114/',
    reportUrl = "Products",
    designerOptions = {
        reportUrl: reportUrl, // The URL of a report that is opened in the Report Designer when the application starts.  
        requestOptions: { // Options for processing requests from the Report Designer. 
            host: host, // URI of your backend project. 
            invokeAction: "/WebDocumentViewer/Invoke", // Action to enable CORS.
            getDesignerModelAction: "/ReportDesigner/GetReportDesignerModel" // Action that returns the Report Designer model. 
        }
    }

ko.applyBindings({ designerOptions });
