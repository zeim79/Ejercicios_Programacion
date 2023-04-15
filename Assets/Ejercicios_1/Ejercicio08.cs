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

            //❕ CreatePrimitives(PrimitiveType.Cube, 3);
        }

        //❕
        public static void CreatePrimitives(PrimitiveType primitiveType, int amount, float separation = 0f)
        {
            float x = -0.5f; //Para que el primero se dibuje en (0, 0, 0)
            for (int i = 0; i < amount; i++)
            {
                GameObject go = GameObject.CreatePrimitive(primitiveType);
                float size = Mathf.Pow(2f, i); //1, 2, 4, 8, 16
                go.transform.localScale = Vector3.one * size;
                x += size/2f; //Empujamos el punto de creación la mitad del tamaño que tiene
                go.transform.position = new Vector3(x, 0f, 0f);
                x += size/2f; //Empujamos la otra mitad para retomar desde ahí en el próximo
                x += separation; //Añadimos la separación que queremos entre cubos
            }
        }  
    }
}