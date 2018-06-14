using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BGMES.Model;

namespace BGMES.BLL
{
    public class TS0000
    {
        private static BGMES.DAL.TS0000 _dal = new BGMES.DAL.TS0000();
        private static BGMES.DAL.TEPEP03 _dalTEPEP03 = new BGMES.DAL.TEPEP03();

        public TS0000()
        {
            if(_dal == null)
            {
                _dal = new BGMES.DAL.TS0000();
            }
        }

        /// <summary>
        /// 代码列表
        /// </summary>
        /// <returns></returns>
        public IList<BGMES.Model.TTS0091> GetAll()
        {
            //加入过滤条件，返回列表
            return _dal.GetAll();
        }

        /// <summary>
        /// 下拉菜单的大类列表
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetCodeName()
        {
             return _dalTEPEP03.Get("TS01");
        }
    }
}
