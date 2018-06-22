using BGMES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMES.DAL
{
    public class TTS0092
    {
        /// <summary>
        /// 取出未删除的数据
        /// </summary>
        /// <returns></returns>
        public IList<Model.TTS0092> GetAll(string CodeClass)
        {
            using (BGMESEntities db = new BGMESEntities())
            {
                var query = from a in db.TTS0092
                            where a.DELETE_FLAG == " " && a.CODE_CLASS == CodeClass
                            select a;
                return query.ToList();
                //if (count == 0)
                //{
                //    return query.ToList();
                //}
                //else if (count > 0)
                //{
                //    return query.Take(count).ToList();
                //}
                //else
                //{
                //    throw new ArgumentException("返回行数不能小于0");
                //}
            }
        }
    }
}
