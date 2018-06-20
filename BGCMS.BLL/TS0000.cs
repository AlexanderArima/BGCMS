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
        public Dictionary<string, object> GetAll(int count)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("TTS0091", _dal.GetAll(count));
            dict.Add("Count", _dal.Count());
            return dict;
        }

        /// <summary>
        /// 代码列表
        /// </summary>
        /// <returns></returns>
        public IList<TTS0091> Get(int count,int index)
        {
            return _dal.GetAll(count, index);
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
