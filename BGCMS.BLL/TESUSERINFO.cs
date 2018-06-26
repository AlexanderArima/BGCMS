using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BGMES.Model;

namespace BGMES.BLL
{
    public class TESUSERINFO
    {
        private static BGMES.DAL.TESUSERINFO _dalTTS0091 = new BGMES.DAL.TESUSERINFO();

        /// <summary>
        /// 读取用户信息
        /// </summary>
        /// <returns></returns>
        public IList<BGMES.Model.TESUSERINFO> GetAll()
        {
            var UserInfo = HttpRuntime.Cache.Get("UserInfo");
            if (UserInfo == null)
            {
                var list = _dalTTS0091.GetAll();
                Common.XCache.Add("UserInfo", list);
                return list;
            }
            else
            {
                return (IList<BGMES.Model.TESUSERINFO>)UserInfo;
            }
        }
    }
}
