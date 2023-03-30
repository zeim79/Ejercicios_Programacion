using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere una esfera al inicio con un Rigidbody añadido
    /// </summary>
    public class Ejercicio04 : MonoBehaviour
    {
        private void Awake()
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Rigidbody rb = sphere.AddComponent<Rigidbody>();
        }
    }
}