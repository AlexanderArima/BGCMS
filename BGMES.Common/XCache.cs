using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BGMES.Common
{
    public class XCache
    {
        public static void Add(string key,object value)
        {
            HttpRuntime.Cache.Add(key, value, null,
                    DateTime.Now.AddMinutes(20),
                    System.Web.Caching.Cache.NoSlidingExpiration,
                    System.Web.Caching.CacheItemPriority.AboveNormal, null);
        }
    }
}
