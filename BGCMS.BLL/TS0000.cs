using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGCMS.BLL
{
    public class TS0000
    {
        private static TS0000 _dal = new TS0000();

        public TS0000()
        {
            if(_dal == null)
            {
                _dal = new TS0000();
            }
        }

        /// <summary>
        /// 代码列表
        /// </summary>
        /// <returns></returns>
        public IList<TS0000> GetAll()
        {
            //加入过滤条件，返回列表
            return _dal.GetAll();
        }

        /// <summary>
        /// 下拉菜单的大类列表
        /// </summary>
        /// <returns></returns>
        public IList<string> GetCodeName()
        {
            return _dal.GetCodeName();
        }
    }
}
