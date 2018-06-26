using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BGMES.Model;

namespace BGMES.BLL
{
    public class TS0000
    {
        private static BGMES.DAL.TTS0091 _dalTTS0091 = new BGMES.DAL.TTS0091();
        private static BGMES.DAL.TTS0092 _dalTTS0092 = new BGMES.DAL.TTS0092();
        private static BGMES.DAL.TEPEP03 _dalTEPEP03 = new BGMES.DAL.TEPEP03();
        private static BGMES.BLL.TESUSERINFO _bllTESUSERINFO = new TESUSERINFO();

        public TS0000()
        {
            if(_dalTTS0091 == null)
            {
                _dalTTS0091 = new BGMES.DAL.TTS0091();
            }
        }

        /// <summary>
        /// 代码列表
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetAll(int count)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            var TTS0091 = _dalTTS0091.GetAll(count);
            TTS0091 = ConvertUserAndTime(TTS0091);
            dict.Add("TTS0091", TTS0091);
            dict.Add("Count", _dalTTS0091.Count());
            return dict;
        }

        /// <summary>
        /// 获取所有的TTS0092
        /// </summary>
        /// <param name="CodeClass"></param>
        /// <returns></returns>
        public IList<TTS0092> GetTTS0092(string CodeClass)
        {
            return _dalTTS0092.GetAll(CodeClass);
        }

        /// <summary>
        /// 代码列表
        /// </summary>
        /// <returns></returns>
        public IList<TTS0091> Get(int count,int index)
        {
            var TTS0091 = _dalTTS0091.GetAll(count, index);
            TTS0091 = ConvertUserAndTime(TTS0091);
            return TTS0091;
        }

        /// <summary>
        /// 转换用户名和添加，修改时间
        /// </summary>
        /// <param name="TTS0091"></param>
        /// <returns></returns>
        private IList<TTS0091> ConvertUserAndTime(IList<TTS0091> TTS0091)
        {
            var UserInfo = _bllTESUSERINFO.GetAll();
            for (int i = 0; i < TTS0091.Count; i++)
            {
                //用户名
                for (int j = 0; j < UserInfo.Count; j++)
                {
                    int flag = 2;
                    if (TTS0091[i].REC_CREATOR == UserInfo[j].ENAME)
                    {
                        TTS0091[i].REC_CREATOR = UserInfo[j].CNAME;
                        flag--;
                    }
                    if (TTS0091[i].REC_REVISOR == UserInfo[j].ENAME)
                    {
                        TTS0091[i].REC_REVISOR = UserInfo[j].CNAME;
                        flag--;
                    }
                    if (flag == 0)
                        break;
                }
                //新增，修改时间
                TTS0091[i].REC_CREATE_TIME = TTS0091[i].REC_CREATE_TIME.Insert(4, "-").Insert(7, "-").Insert(10," ").Insert(13,":").Insert(16,":");
                TTS0091[i].REC_REVISE_TIME = TTS0091[i].REC_REVISE_TIME.Insert(4, "-").Insert(7, "-").Insert(10, " ").Insert(13, ":").Insert(16, ":");
            }
            return TTS0091;
        }
        

        /// <summary>
        /// 下拉菜单的大类列表
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> GetCodeName()
        {
            var TS01 = HttpRuntime.Cache.Get("TS01");
            if (TS01 == null)
            {
                var dict = _dalTEPEP03.Get("TS01");
                Common.XCache.Add("TS01", dict);
                return dict;
            }
            else
            {
                return (IDictionary<string, object>)TS01;
            }
        }
    }
}
