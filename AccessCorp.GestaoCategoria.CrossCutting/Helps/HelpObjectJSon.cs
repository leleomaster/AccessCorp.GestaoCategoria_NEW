using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace AccessCorp.GestaoCategoria.CrossCutting.Helps
{
    public static class HelpObjectJSon<T> where T : class
    {
        public static T Deserialize(string dataJson)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            T obj = jss.Deserialize<T>(dataJson);

            return obj;
        }

        public static string Serialize(T obj)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string objJSon = jss.Serialize(obj);

            return objJSon;
        }
    }
}
