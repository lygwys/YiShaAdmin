using System;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Data;
using YiSha.Data.Repository;
using YiSha.Entity.WysManage;
using YiSha.Model.Param.WysManage;

namespace YiSha.Service.WysManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2021-03-25 15:54
    /// 描 述：服务类
    /// </summary>
    public class WysTestService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<WysTestEntity>> GetList(WysTestListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<WysTestEntity>> GetPageList(WysTestListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<WysTestEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<WysTestEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(WysTestEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                await entity.Create();
                await this.BaseRepository().Insert(entity);
            }
            else
            {
                await entity.Modify();
                await this.BaseRepository().Update(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<WysTestEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<WysTestEntity, bool>> ListFilter(WysTestListParam param)
        {
            var expression = LinqExtensions.True<WysTestEntity>();
            if (param != null)
            {
            }
            return expression;
        }
        #endregion
    }
}
