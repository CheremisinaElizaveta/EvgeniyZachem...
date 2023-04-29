using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace budget_accounting
{
    internal class Json
    {
        public static T Des<T>()
        {
            string json = File.ReadAllText("D:\\ПРАКТОС УЖЕ ВОТ ПЯТЫЙ\\practic no5 col\\practic no5 col\\Resoucres\\MyJson.json", Encoding.UTF8);
            T item = JsonConvert.DeserializeObject<T>(json);
            return item;
        }

        public static void Ser<T>(T item)
        {
            string json = JsonConvert.SerializeObject(item);
            File.WriteAllText("D:\\ПРАКТОС УЖЕ ВОТ ПЯТЫЙ\\practic no5 col\\practic no5 col\\Resoucres\\MyJson.json", json, Encoding.UTF8);
        }
    }
}
