using inventory_management_system.DAL;
using inventory_management_system.models;
using Microsoft.AspNetCore.Mvc;

namespace inventory_management_system.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class vendorController : Controller
    {
        main_DAL _dal = new main_DAL();
        [HttpGet("get_vendor")]
        public JsonResult get_vendor()
        {
            List<vendor> vendor = _dal.get_all_vendor();
            return Json(vendor);
        }

        [HttpPost("Add_vendor")]
        public JsonResult create_vendor(vendor _vendor)
        {
            bool id = _dal.createnewvendor(_vendor);
            if (id == true)
            {
                return Json(new { message = "success", code = 200 });
            }
            else
            {
                return Json(new { message = "Failed" });
            }
        }
        [HttpDelete("DeleteVendor/{id}")]
        public JsonResult delete_vendor(int id)
        {
            bool i_d = _dal.deletevendor(id);
            if (i_d == true)
            {
                JsonResult response = get_vendor();
                return Json(new { data = response, message = "successfully deleted element" });
            }
            else
            {
                return Json(new { message = "Failed" });
            }

        }
        [HttpPut("updateVendor")]
        public JsonResult updateVendor(vendor _vendor)
        {
            bool id = _dal.updateVendor(_vendor);
            if (id == true)
            {
                return Json(new { message = "success", code = 200 });
            }
            else
            {
                return Json(new { message = "Failed" });
            }

        }
    }
}
