using BGMES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGMES.DAL
{
    public class TEPEP03
    {
        public IDictionary<string, object> Get(string Code_Class)
        {
            using(BGMESEntities db = new BGMESEntities())
            {
                var query = from a in db.TEPEP03
                            where a.DELETE_FLAG == " " && a.CODE_CLASS == Code_Class
                            select new
                            {
                                CODE_NAME = a.CODE_NAME,
                                CODE_DESC_1_NAME = a.CODE_DESC_1_NAME
                            };
                IDictionary<string, object> dict = new Dictionary<string, object>();
                foreach (var item in query.ToList())
                {
                    dict.Add(item.CODE_NAME, item.CODE_DESC_1_NAME);
                }
                return dict;
            }
        }
    }
}
