using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.WysManage;
using YiSha.Model.Param.WysManage;
using YiSha.Service.WysManage;

namespace YiSha.Business.WysManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2021-03-25 15:54
    /// 描 述：业务类
    /// </summary>
    public class WysTestBLL
    {
        private WysTestService wysTestService = new WysTestService();

        #region 获取数据
        public async Task<TData<List<WysTestEntity>>> GetList(WysTestListParam param)
        {
            TData<List<WysTestEntity>> obj = new TData<List<WysTestEntity>>();
            obj.Data = await wysTestService.GetList(param);
            obj.Total = obj.Data.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<WysTestEntity>>> GetPageList(WysTestListParam param, Pagination pagination)
        {
            TData<List<WysTestEntity>> obj = new TData<List<WysTestEntity>>();
            obj.Data = await wysTestService.GetPageList(param, pagination);
            obj.Total = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<WysTestEntity>> GetEntity(long id)
        {
            TData<WysTestEntity> obj = new TData<WysTestEntity>();
            obj.Data = await wysTestService.GetEntity(id);
            if (obj.Data != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(WysTestEntity entity)
        {
            TData<string> obj = new TData<string>();
            await wysTestService.SaveForm(entity);
            obj.Data = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await wysTestService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
