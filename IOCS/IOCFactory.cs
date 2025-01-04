using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IOCS.IOCS
{
    //IOC factory
    //1.create instances
    //2.save instances
    //3.get instances
    //4.depent injection
    //5.filter the objects.
    public class IOCFactory
    {
        private Dictionary<string, object> IOCS = new Dictionary<string, object>();
        public IOCFactory() 
        { 

            // use relfection
            Assembly assembly = Assembly.Load("IOCS");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types) 
            {

                IOCService iOCService = type.GetCustomAttribute<IOCService>();
                if (iOCService != null) 
                {
                    object _object = Activator.CreateInstance(type);

                    PropertyInfo[] propertyInfos = type.GetProperties();
                    foreach (PropertyInfo property in propertyInfos)
                    {
                        foreach (var type1 in types)
                        {
                            if (property.PropertyType.Equals(type1))
                            {
                                object _objectvalue = Activator.CreateInstance(type1);
                                property.SetValue(_object, _objectvalue);
                            }
                        }
                    }

                    // save instances
                    IOCS.Add(type.FullName, _object);
                }
            }
        }
        public object GetObject(string FullName) 
        {
            return IOCS[FullName];
        }
    }
}
