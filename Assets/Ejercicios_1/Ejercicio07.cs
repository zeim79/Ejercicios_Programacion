using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere tres esferas al inicio separadas 100 metros
    /// </summary>
    public class Ejercicio07 : MonoBehaviour
    {
        private void Awake()
        {
            GameObject s1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            s1.name = "Sphere01";
            GameObject s2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            s2.name = "Sphere02";
            s2.transform.position = new Vector3(s1.transform.position.x + 100f, 0f, 0f);
            GameObject s3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            s3.name = "Sphere03";
            s3.transform.position = new Vector3(s2.transform.position.x + 100f, 0f, 0f);

            //❕ CrearEsferas();
        }

        //❕
        void CrearEsferas()
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.name = "Sphere" + string.Format("{0:00}", i+1);
                sphere.transform.position = Vector3.right * i;
            }
        }
    }
}