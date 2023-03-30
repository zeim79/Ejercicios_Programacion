using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere un GameObject al inicio cuyo nombre sea "Ejercicio01"
    /// </summary>
    public class Ejercicio01 : MonoBehaviour
    {
        private void Awake()
        {
            GameObject go = new GameObject("Ejercicio01");
        }
    } 
}
