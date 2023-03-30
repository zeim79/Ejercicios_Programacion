using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>
    public class Ejercicio09 : MonoBehaviour
    {
        private void Awake()
        {
            GameObject[] spheres = new GameObject[12];
            for (int i = 0; i < spheres.Length; i++)
            {
                spheres[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                spheres[i].name = "GameObject" + i;
                if (i > 0)
                {
                    spheres[i].transform.position += new Vector3(0f, spheres[i - 1].transform.position.y+100, 0f);
                    spheres[i].transform.localScale = spheres[i - 1].transform.localScale * 2;
                }
            }
        }
    }
}