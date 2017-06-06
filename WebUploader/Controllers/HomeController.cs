using System.Web;
using System.Web.Mvc;

namespace WebUploader.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddFile(string id, string name, string type, string lastModifiedDate, int size, HttpPostedFileBase file)
        {
            // 处理图片存储
            return Json(new { state = "success", message = "文件地址" });
        }

        public ActionResult DeleteFile(string fullName)
        {
            return Json(new { state = "success", message = "删除成功!" });
        }
    }
}