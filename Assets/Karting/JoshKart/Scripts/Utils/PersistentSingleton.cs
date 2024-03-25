using UnityEngine;

public class PersistentSingleton<T> : MonoBehaviour where T : Component {
    public static T Current => instance;

    protected static T instance;

    public static T Instance {
        get {
            if (instance == null) {
                instance = FindObjectOfType<T>();
                if (instance == null) {
                    GameObject obj = new GameObject();
                    obj.name = typeof(T).Name + "AutoCreated";
                    instance = obj.AddComponent<T>();
                }
            }

            return instance;
        }
    }

    protected virtual void Awake() => InitializeSingleton();

    protected virtual void InitializeSingleton() {
        if (!Application.isPlaying) {
            return;
        }

        if (instance == null) {
            instance = this as T;
            DontDestroyOnLoad(transform.gameObject);
            enabled = true;
        } else {
            if (this != instance) {
                Destroy(this.gameObject);
            }
        }
    }
}
