using BGMES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BGMES.DAL
{
    public class TTS0091
    {
        /// <summary>
        /// 取出未删除的数据
        /// </summary>
        /// <returns></returns>
        public IList<Model.TTS0091> GetAll<TKey>(int count, Func<Model.TTS0091, bool> predicate,Func<Model.TTS0091,TKey> order)
        {
            return GetAll(count, -1, predicate, order);
        }

        /// <summary>
        /// 取出未删除的数据
        /// </summary>
        /// <returns></returns>
        public IList<Model.TTS0091> GetAll<TKey>(int count,int index, Func<Model.TTS0091, bool> predicate, Func<Model.TTS0091, TKey> order)
        {
            using (BGMESEntities db = new BGMESEntities())
            {
                var query = db.TTS0091.Where(predicate).Select(m => m);
                if (count == 0)
                {
                    return query.ToList();
                }
                else if (count > 0)
                {
                    if(index != -1)
                    {
                        return query.OrderBy(n => n.REC_ID).OrderBy(order).Skip(index * count).Take(count).ToList();
                    }
                    else
                    {
                        return query.OrderBy(n => n.REC_ID).OrderBy(order).Take(count).ToList();
                    }
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
        public int Count(Func<Model.TTS0091, bool> predicate)
        {
            using (BGMESEntities db = new BGMESEntities())
            {
                var query = db.TTS0091.Where(predicate).Select(m => m);
                return query.Count();
            }
        }
    }
}
