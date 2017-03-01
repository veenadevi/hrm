using System.Net;
using System.Web.Mvc;
using System.Web.UI;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Areas.Conventions.Attachments;
using Frapid.Framework.Extensions;
using Frapid.WebsiteBuilder;
using Serilog;
using Frapid.Areas.CSRF;
using Frapid.Areas.Caching;

namespace MixERP.HRM.Controllers.Services
{
    [AntiForgery]
    public class AttachmentController : FrapidController
    {
        [RestrictAnonymous]
        [Route("dashboard/hrm/services/attachments")]
        [HttpPost]
        public ActionResult Post()
        {
            var area = new AreaRegistration();
            var allowed = FrapidConfig.GetAllowedUploadExtensions(this.Tenant);

            var uploader = new Uploader(Log.Logger, area, this.Request.Files, this.Tenant, allowed);

            try
            {
                string fileName = uploader.Upload();

                fileName = "/dashboard/hrm/services/attachments/" + fileName;

                return this.Ok(fileName);
            }
            catch (UploadException ex)
            {
                return this.Failed(ex.Message, HttpStatusCode.BadRequest);
            }
        }

        [RestrictAnonymous]
        [Route("dashboard/hrm/services/attachments/{*path}")]
        [FileOutputCache(ProfileName = "StaticFile.xml", Duration = 60 * 60, Location = OutputCacheLocation.Client)]
        public ActionResult AttachmentResult(string path)
        {
            int width = this.Request.QueryString["width"].To<int>();
            int height = this.Request.QueryString["height"].To<int>();

            path = path.Replace("dashboard/hrm/services/attachments", "");
            var loader = new Deserializer(this.Tenant, new AreaRegistration(), width, height, path);
            var attachment = loader.Get();

            if (attachment == null)
            {
                return this.HttpNotFound();
            }

            return new FileContentResult(attachment, "image/png");
        }
    }
}