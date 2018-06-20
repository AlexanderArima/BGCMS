using BGMES.Model;
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
        public IList<TTS0091> GetAll(int count)
        {
            using(BGMESEntities db = new BGMESEntities())
            {
                var query = from a in db.TTS0091
                            where a.DELETE_FLAG == " "
                            select a;
                if(count == 0)
                {
                    return query.ToList();
                }
                else if(count > 0)
                {
                    return query.Take(count).ToList();
                }
                else
                {
                    throw new ArgumentException("返回行数不能小于0");
                }
            }
        }

        /// <summary>
        /// 取出未删除的数据
        /// </summary>
        /// <returns></returns>
        public IList<TTS0091> GetAll(int count,int index)
        {
            using (BGMESEntities db = new BGMESEntities())
            {
                var query = from a in db.TTS0091
                            where a.DELETE_FLAG == " "
                            select a;
                if (count == 0)
                {
                    return query.ToList();
                }
                else if (count > 0)
                {
                    return query.OrderBy(n => n.REC_ID).Skip(index * count).Take(count).ToList();
                }
                else
                {
                    throw new ArgumentException("返回行数不能小于0");
                }
            }
        }

        /// <summary>
        /// 返回结果总行数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            using (BGMESEntities db = new BGMESEntities())
            {
                var query = from a in db.TTS0091
                            where a.DELETE_FLAG == " "
                            select a;
                return query.Count();
            }
        }
    }
}
