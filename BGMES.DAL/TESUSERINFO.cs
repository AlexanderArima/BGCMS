using BGMES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BGMES.DAL
{
    public class TESUSERINFO
    {

        public IList<Model.TESUSERINFO> GetAll()
        {
            using (BGMESEntities db = new BGMESEntities())
            {
                var query = from a in db.TESUSERINFOes
                            select a;
                return query.ToList();
            }
        }
    }
}
