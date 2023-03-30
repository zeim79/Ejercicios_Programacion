using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere un GameObject al inicio y trasladarlo a la posicion (111.1, -5, 4.5)
    /// </summary>
    public class Ejercicio02 : MonoBehaviour
    {
        private void Awake()
        {
            GameObject go = new GameObject("Ejercicio02");
            go.transform.position = new Vector3(111.1f, -5f, 4.5f);
        }
    }
}