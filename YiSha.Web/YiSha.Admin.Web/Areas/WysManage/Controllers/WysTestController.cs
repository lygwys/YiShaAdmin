using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Entity;
using YiSha.Model;
using YiSha.Admin.Web.Controllers;
using YiSha.Entity.WysManage;
using YiSha.Business.WysManage;
using YiSha.Model.Param.WysManage;

namespace YiSha.Admin.Web.Areas.WysManage.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2021-03-25 15:54
    /// 描 述：控制器类
    /// </summary>
    [Area("WysManage")]
    public class WysTestController :  BaseController
    {
        private WysTestBLL wysTestBLL = new WysTestBLL();

        #region 视图功能
        [AuthorizeFilter("wys:wystest:view")]
        public ActionResult WysTestIndex()
        {
            return View();
        }

        public ActionResult WysTestForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("wys:wystest:search")]
        public async Task<ActionResult> GetListJson(WysTestListParam param)
        {
            TData<List<WysTestEntity>> obj = await wysTestBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("wys:wystest:search")]
        public async Task<ActionResult> GetPageListJson(WysTestListParam param, Pagination pagination)
        {
            TData<List<WysTestEntity>> obj = await wysTestBLL.GetPageList(param, pagination);
            return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<WysTestEntity> obj = await wysTestBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("wys:wystest:add,wys:wystest:edit")]
        public async Task<ActionResult> SaveFormJson(WysTestEntity entity)
        {
            TData<string> obj = await wysTestBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("wys:wystest:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await wysTestBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
