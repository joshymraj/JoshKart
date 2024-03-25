namespace JoshKart.Data {
    public interface IDataSerializer {
        string Serialize<T>(T instance);
        T Deserialize<T>(string dataString);
    }
}
