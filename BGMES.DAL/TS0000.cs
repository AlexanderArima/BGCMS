using BGCMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMES.DAL
{
    public class TS0000
    {
        /// <summary>
        /// 取出未删除的数据
        /// </summary>
        /// <returns></returns>
        public IList<TTS0091> GetAll()
        {
            using(BGMESEntities db = new BGMESEntities())
            {
                var query = from a in db.TTS0091
                            where a.DELETE_FLAG == " "
                            select a;
                return query.ToList();
            }
        }

        /// <summary>
        /// 类别名称去重
        /// </summary>
        /// <returns></returns>
        public IList<string> GetCodeName()
        {
            using (BGMESEntities db = new BGMESEntities())
            {
                var query = from a in db.TTS0091
                            where a.DELETE_FLAG == " "
                            select a.CODE_NAME;
                return query.Distinct().ToList();
            }
        }
    }
}
