using UnityEngine;

namespace Kuhpik.DesignPatterns.Creational.Singleton
{
    public class DontDestroySingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; private set; }

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
                DontDestroyOnLoad(gameObject);
            }

            else
            {
                DestroyImmediate(gameObject);
            }
        }

        void Start()
        {
            Debug.Log($"Singleton's {typeof(T).Name} Start() function");
        }
    }
}
