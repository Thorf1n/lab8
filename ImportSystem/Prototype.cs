
namespace ImportSystem
{
    internal class Prototype
    {

        public interface IDataTemplate : ICloneable
        {
            void SetData(string key, object value);
            object GetData(string key);
        }

        public class CsvDataTemplate : IDataTemplate
        {
            private Dictionary<string, object> data = new Dictionary<string, object>();

            public void SetData(string key, object value)
            {
                if (!data.ContainsKey(key))
                {
                    data[key] = value;
                }
            }

            public object GetData(string key)
            {
                return data.ContainsKey(key) ? data[key] : null;
            }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }

        public class XmlDataTemplate : IDataTemplate
        {
            private Dictionary<string, object> data = new Dictionary<string, object>();

            public void SetData(string key, object value)
            {
                if (!data.ContainsKey(key))
                {
                    data[key] = value;
                }
            }

            public object GetData(string key)
            {
                return data.ContainsKey(key) ? data[key] : null;
            }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }

        public class JsonDataTemplate : IDataTemplate
        {
            private Dictionary<string, object> data = new Dictionary<string, object>();

            public void SetData(string key, object value)
            {
                if (!data.ContainsKey(key))
                {
                    data[key] = value;
                }
            }

            public object GetData(string key)
            {
                return data.ContainsKey(key) ? data[key] : null;
            }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }

        public interface IDataAdapter
        {
            IDataTemplate Convert(IDataTemplate sourceTemplate);
        }

        public class DataAdapter : IDataAdapter
        {
            public IDataTemplate Convert(IDataTemplate sourceTemplate)
            {
                return (IDataTemplate)sourceTemplate.Clone();
            }
        }
    }
}
