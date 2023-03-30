using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere dos esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio06 : MonoBehaviour
    {
        private void Awake()
        {
            GameObject s1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            s1.name = "Sphere01";
            GameObject s2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            s2.name = "Sphere02";
            s2.transform.position = new Vector3(s1.transform.position.x + 100f, 0f, 0f);
        }
    }
}