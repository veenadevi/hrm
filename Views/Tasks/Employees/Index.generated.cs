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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Employees/Index.cshtml")]
    public partial class _Views_Tasks_Employees_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Employees_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\Employees\Index.cshtml"
  
    ViewBag.Title = "Employees";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"Emp" +
"loyees\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/hrm/employee-view\";\r\n    scru" +
"dFactory.viewTableName = \"hrm.employee_view\";\r\n\r\n    scrudFactory.formAPI = \"/ap" +
"i/forms/hrm/employees\";\r\n    scrudFactory.formTableName = \"hrm.employees\";\r\n\r\n  " +
"  scrudFactory.excludedColumns = [\"AuditUserId\", \"AuditTs\"];\r\n    scrudFactory.r" +
"eadonlyColumns = [\"EmployeeName\"];\r\n    scrudFactory.hiddenColumns = [\"Status\", " +
"\"ServiceEndedOn\"];\r\n\r\n    scrudFactory.allowDelete = true;\r\n    scrudFactory.all" +
"owEdit = true;\r\n    scrudFactory.viewUrl = \"/dashboard/hrm/tasks/employee-info/{" +
"Key}\";\r\n\r\n    scrudFactory.live = \"EmployeeName\";\r\n    scrudFactory.layout = [\r\n" +
"        {\r\n            tab: \"personal\",\r\n            fields: [\r\n                " +
"[\"Photo\"],\r\n                [\"EmployeeId\"],\r\n                [\"EmployeeName\", \"E" +
"mployeeCode\"],\r\n                [\"FirstName\", \"MiddleName\", \"LastName\", \"GenderC" +
"ode\"],\r\n                [\"MaritalStatusId\", \"NationalityCode\"],\r\n               " +
" [\"DateOfBirth\", \"\"]\r\n            ]\r\n        },\r\n        {\r\n            tab: \"em" +
"ployment\",\r\n            fields: [\r\n                [\"UserId\", \"OfficeId\"],\r\n    " +
"            [\"JoinedOn\", \"EmployeeTypeId\"],\r\n                [\"CurrentDepartment" +
"Id\", \"CurrentRoleId\"],\r\n                [\"CurrentEmploymentStatusId\", \"CurrentJo" +
"bTitleId\"],\r\n                [\"CurrentPayGradeId\", \"CurrentShiftId\"]\r\n          " +
"  ]\r\n        },\r\n        {\r\n            tab: \"bank\",\r\n            fields: [\r\n   " +
"             [\"BankAccountNumber\", \"BankName\"],\r\n                [\"BankBranchNam" +
"e\", \"BankReferenceNumber\"]\r\n            ]\r\n        },\r\n        {\r\n            ta" +
"b: \"address\",\r\n            fields: [\r\n                [\"ZipCode\", \"\", \"\", \"\"],\r\n" +
"                [\"AddressLine1\"],\r\n                [\"AddressLine2\"],\r\n          " +
"      [\"Street\", \"City\"],\r\n                [\"CountryCode\", \"State\"],\r\n          " +
"      [\"Phone\", \"Fax\"],\r\n                [\"Cell\", \"Email\"],\r\n                [\"U" +
"rl\", \"\"]\r\n            ]\r\n        },\r\n        {\r\n            tab: \"contact\",\r\n   " +
"         fields: [\r\n                [\"PhoneHome\", \"PhoneCell\"],\r\n               " +
" [\"PhoneOfficeExtension\", \"\"],\r\n                [\"PhoneEmergency\", \"PhoneEmergen" +
"cy2\"],\r\n                [\"EmailAddress\", \"Website\"],\r\n                [\"Blog\", \"" +
"\"]\r\n            ]\r\n        },\r\n        {\r\n            tab: \"other\",\r\n           " +
" fields: [\r\n                [\"IsSmoker\", \"IsAlcoholic\"],\r\n                [\"With" +
"Disabilities\", \"LowVision\"],\r\n                [\"UsesWheelchair\", \"HardOfHearing\"" +
"],\r\n                [\"IsAphonic\", \"IsCognitivelyDisabled\"],\r\n                [\"I" +
"sAutistic\", \"\"]\r\n            ]\r\n        }\r\n    ];\r\n\r\n    scrudFactory.tabs = [\r\n" +
"        {\r\n            sort: 0,\r\n            id: \"personal\",\r\n            name: " +
"\"Peronsal Information\",\r\n            active: true\r\n        },\r\n        {\r\n      " +
"      sort: 1,\r\n            id: \"employment\",\r\n            name: \"Employment Inf" +
"ormation\"\r\n        },\r\n        {\r\n            sort: 2,\r\n            id: \"bank\",\r" +
"\n            name: \"Bank Details\"\r\n        },\r\n        {\r\n            sort: 3,\r\n" +
"            id: \"address\",\r\n            name: \"Address Information\"\r\n        },\r" +
"\n        {\r\n            sort: 4,\r\n            id: \"contact\",\r\n            name: " +
"\"Contact Information\"\r\n        },\r\n        {\r\n            sort: 5,\r\n            " +
"id: \"other\",\r\n            name: \"Other Details\"\r\n        }\r\n    ];\r\n\r\n    scrudF" +
"actory.returnUrl = \"../Employees.mix\";\r\n    scrudFactory.queryStringKey = \"Emplo" +
"yeeId\";\r\n    scrudFactory.uploadHanlder = \"/dashboard/hrm/services/attachments\";" +
"\r\n\r\n    scrudFactory.keys = [\r\n        {\r\n            property: \"GenderCode\",\r\n " +
"           url: \'/api/forms/core/genders/lookup-fields\',\r\n            data: null" +
",\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n " +
"       {\r\n            property: \"MaritalStatusId\",\r\n            url: \'/api/forms" +
"/core/marital-statuses/display-fields\',\r\n            data: null,\r\n            va" +
"lueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n       " +
"     property: \"OfficeId\",\r\n            url: \'/api/forms/core/offices/display-fi" +
"elds\',\r\n            data: null,\r\n            valueField: \"Key\",\r\n            tex" +
"tField: \"Value\"\r\n        },\r\n        {\r\n            property: \"UserId\",\r\n       " +
"     url: \'/api/views/account/user-selector-view/display-fields\',\r\n            d" +
"ata: null,\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n    " +
"    },\r\n        {\r\n            property: \"EmployeeTypeId\",\r\n            url: \'/a" +
"pi/forms/hrm/employee-types/display-fields\',\r\n            data: null,\r\n         " +
"   valueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n  " +
"          property: \"CurrentDepartmentId\",\r\n            url: \'/api/forms/hrm/dep" +
"artments/display-fields\',\r\n            data: null,\r\n            valueField: \"Key" +
"\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n            property:" +
" \"CurrentRoleId\",\r\n            url: \'/api/forms/hrm/roles/display-fields\',\r\n    " +
"        data: null,\r\n            valueField: \"Key\",\r\n            textField: \"Val" +
"ue\"\r\n        },\r\n        {\r\n            property: \"CurrentEmploymentStatusId\",\r\n" +
"            url: \'/api/forms/hrm/employment-statuses/display-fields\',\r\n         " +
"   data: null,\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n" +
"        },\r\n        {\r\n            property: \"CurrentJobTitleId\",\r\n            u" +
"rl: \'/api/forms/hrm/job-titles/display-fields\',\r\n            data: null,\r\n      " +
"      valueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r" +
"\n            property: \"CurrentPayGradeId\",\r\n            url: \'/api/forms/hrm/pa" +
"y-grades/display-fields\',\r\n            data: null,\r\n            valueField: \"Key" +
"\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n            property:" +
" \"CurrentShiftId\",\r\n            url: \'/api/forms/hrm/shifts/display-fields\',\r\n  " +
"          data: null,\r\n            valueField: \"Key\",\r\n            textField: \"V" +
"alue\"\r\n        },\r\n        {\r\n            property: \"NationalityCode\",\r\n        " +
"    url: \'/api/forms/hrm/nationalities/lookup-fields\',\r\n            data: null,\r" +
"\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n   " +
"     {\r\n            property: \"CountryCode\",\r\n            url: \'/api/forms/core/" +
"countries/lookup-fields\',\r\n            data: null,\r\n            valueField: \"Key" +
"\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n            property:" +
" \"StateId\",\r\n            url: \'/api/forms/core/states/display-fields\',\r\n        " +
"    data: null,\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r" +
"\n        }\r\n    ];\r\n\r\n\r\n    $.get(\'/ScrudFactory/View.html\', function (view) {\r\n" +
"        $.get(\'/ScrudFactory/Form.html\', function (form) {\r\n            $(\"#Scru" +
"dFactoryView\").html(view);\r\n            $(\"#ScrudFactoryForm\").html(form);\r\n    " +
"        $.cachedScript(\"/assets/js/scrudfactory-view.js\");\r\n            $.cached" +
"Script(\"/assets/js/scrudfactory-form.js\");\r\n        });\r\n    });\r\n</script>\r\n\r\n<" +
"div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral(@"></div>

<script>
    $(document).on(""formready"", function() {
        initialize();
    });


    function initialize() {
        $(""#status"").dropdown(""set selected"", ""yes"");
        var firstName = $(""#first_name"");
        var middleName = $(""#middle_name"");
        var lastName = $(""#last_name"");
        var employeeName = $(""#employee_name"");

        function displayEmployeeName() {
            var f = (firstName.val() || """");
            var m = (middleName.val() || """");
            var l = (lastName.val() || """");

            var name = f + "" "" + m;
            if (l) {
                name = l.trim() + "", "" + f + "" "" + m;
            };


            employeeName.val(name.trim());

            employeeName.trigger(""keyup"");
        };


        firstName.keyup(function () { displayEmployeeName(); });
        middleName.keyup(function () { displayEmployeeName(); });
        lastName.keyup(function () { displayEmployeeName(); });

    };


</script>

");

        }
    }
}
#pragma warning restore 1591
