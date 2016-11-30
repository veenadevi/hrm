﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.Mapper.Decorators;
    using Frapid.WebsiteBuilder;
    using MixERP.HRM;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/LeaveApplications/Index.cshtml")]
    public partial class _Views_Tasks_LeaveApplications_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_LeaveApplications_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\LeaveApplications\Index.cshtml"
  
    ViewBag.Title = "Leave Applications";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    var employeeId = parseInt(window.getQueryStringByName(\"Employee" +
"Id\") || 0);\r\n    var filters = [];\r\n    filters.push(window.getAjaxColumnFilter(" +
"\"WHERE\", \"user_id\", window.FilterConditions.IsEqualTo, window.userId));\r\n\r\n    v" +
"ar url = \"/api/forms/hrm/employees/get-where/1\";\r\n    var data = JSON.stringify(" +
"filters);\r\n\r\n    var getEmployees = window.getAjaxRequest(url, \"POST\", data);\r\n\r" +
"\n    getEmployees.success(function (msg) {\r\n        if (msg && msg[0]) {\r\n      " +
"      if (employeeId !== msg[0].EmployeeId) {\r\n                window.location =" +
" window.updateQueryString(\"EmployeeId\", \"int\", msg[0].EmployeeId, window.locatio" +
"n.href);\r\n            };\r\n        };\r\n    });\r\n</script>\r\n\r\n<script>\r\n    var sc" +
"rudFactory = new Object();\r\n\r\n    scrudFactory.title = \"My Leave Applications\";\r" +
"\n\r\n    scrudFactory.viewAPI = \"/api/views/hrm/leave-application-scrud-view\";\r\n  " +
"  scrudFactory.viewTableName = \"hrm.leave_application_scrud_view\";\r\n\r\n    scrudF" +
"actory.formAPI = \"/api/forms/hrm/leave-applications\";\r\n    scrudFactory.formTabl" +
"eName = \"hrm.leave_applications\";\r\n\r\n    scrudFactory.excludedColumns = [\"Photo\"" +
"];\r\n    scrudFactory.hiddenColumns = [\"EnteredBy\", \"AppliedOn\", \"EmployeeId\", \"V" +
"erificationStatusId\", \"VerifiedByUserId\", \"VerifiedOn\", \"VerificationReason\"];\r\n" +
"\r\n    scrudFactory.live = \"EmployeeId\";\r\n\r\n    scrudFactory.layout = [\r\n        " +
"{\r\n            tab: \"\",\r\n            fields: [\r\n                [\"LeaveApplicati" +
"onId\", \"LeaveTypeId\"],\r\n                [\"StartDate\", \"EndDate\"],\r\n             " +
"   [\"Reason\"]\r\n            ]\r\n        }\r\n    ];\r\n\r\n    scrudFactory.keys = [\r\n  " +
"      {\r\n            property: \"LeaveTypeId\",\r\n            url: \'/api/forms/hrm/" +
"leave-types/display-fields\',\r\n            data: null,\r\n            valueField: \"" +
"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n            proper" +
"ty: \"EmployeeId\",\r\n            url: \'/api/views/hrm/employee-view/display-fields" +
"\',\r\n            data: null,\r\n            valueField: \"Key\",\r\n            textFie" +
"ld: \"Value\"\r\n        }\r\n    ];\r\n    $.get(\'/ScrudFactory/View.html\', function (v" +
"iew) {\r\n        $.get(\'/ScrudFactory/Form.html\', function (form) {\r\n            " +
"$(\"#ScrudFactoryView\").html(view);\r\n            $(\"#ScrudFactoryForm\").html(form" +
");\r\n            $.cachedScript(\"/assets/js/scrudfactory-view.js\");\r\n            " +
"$.cachedScript(\"/assets/js/scrudfactory-form.js\");\r\n        });\r\n    });\r\n</scri" +
"pt>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>\r\n<script>\r\n    $(document).on(\"formready\", function() {\r\n        $(\"#appl" +
"ied_on\").val(window.today);\r\n        $(\"#entered_by\").val(window.userId);\r\n     " +
"   $(\"#verification_status_id\").val(\"0\");\r\n    });\r\n</script>");

        }
    }
}
#pragma warning restore 1591
