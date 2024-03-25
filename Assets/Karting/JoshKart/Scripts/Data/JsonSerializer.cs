using UnityEngine;

namespace JoshKart.Data {
    public class JsonSerializer : IDataSerializer {
        public bool beautify = false;

        public string Serialize<T>(T instance) {
           
            return JsonUtility.ToJson(instance, prettyPrint: beautify);
        }

        public T Deserialize<T>(string dataString) {
            return JsonUtility.FromJson<T>(dataString);
        }        
    }
}
