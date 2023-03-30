using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres cubos cada uno el doble de grande que el anterior
    /// </summary>
    public class Ejercicio08 : MonoBehaviour
    {
        private void Awake()
        {
            GameObject c1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            c1.name = "cube01";
            GameObject c2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            c2.name = "cube02";
            c2.transform.position = new Vector3(c1.transform.position.x + 2f, 0f, 0f);
            c2.transform.localScale = c1.transform.localScale * 2;
            GameObject c3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            c3.name = "cube03";
            c3.transform.position = new Vector3(c2.transform.position.x + 4f, 0f, 0f);
            c3.transform.localScale = c2.transform.localScale * 2;
        }
    }
}