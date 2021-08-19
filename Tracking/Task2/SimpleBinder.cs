using System;
using System.Collections.Generic;
using System.Reflection;

namespace Task2
{
    public class SimpleBinder
    {
        private static SimpleBinder instance;
        protected SimpleBinder()
        {

        }
        public static SimpleBinder getInstance()
        {
            if(instance == null)
            {
                instance = new SimpleBinder();
            }
            return instance;
        }
        public dynamic Binder(Type type, Dictionary<string,string> list)
        {
            var entity = Activator.CreateInstance(type);

            foreach(string c in list.Keys)
            {
                FieldInfo fi = type.GetField(c, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if(fi != null)
                {
                    if (fi.FieldType.Name == "Int32")
                    {
                        fi.SetValue(entity, int.Parse(list[c]));
                    }
                    if (fi.FieldType.Name == "Double")
                    {
                            fi.SetValue(entity, double.Parse(list[c]));                        
                    }
                    if (fi.FieldType.Name == "String")
                    {
                            fi.SetValue(entity, list[c]);                        
                    }
                }
                char first = char.ToUpper(c[0]);
                string str = string.Empty;
                str += first;
                str += c.Substring(1); 

                PropertyInfo prop = type.GetProperty(str, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (prop != null)
                {
                    if (prop.PropertyType.Name == "Int32")
                    {                        
                            prop.SetValue(entity, int.Parse(list[c]));                        
                    }
                    if (prop.PropertyType.Name == "Double")
                    {                        
                            prop.SetValue(entity, double.Parse(list[c]));                        
                    }
                    if (prop.PropertyType.Name == "String")
                    {                                               
                            prop.SetValue(entity, list[c]);                       
                    }
                }
            }
            return entity;
        }
    }
}
