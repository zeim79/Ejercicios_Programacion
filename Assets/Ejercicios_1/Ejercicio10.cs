using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    /// </summary>
    public class Ejercicio10 : MonoBehaviour
    {
        private void Start()
        {
            RenameAllGameObjects("Objecto");
        }
        public static GameObject[] RenameAllObjects(string nameBase)
        {
            GameObject[] gObs = GameObject.FindObjectsByType<GameObject>(FindObjectsSortMode.InstanceID); ;
            for (int i=0; i< gObs.Length;i++)
            {
                gObs[i].name = nameBase + "0" + i;
            }
            return gObs;
        }
        public static GameObject[] RenameAllGameObjects(string nameBase)
        {
            GameObject[] gObs = GameObject.FindObjectsByType<GameObject>(FindObjectsSortMode.InstanceID); ;
            for (int i = 0; i < gObs.Length; i++)
            {
                if (gObs[i].name.Contains("GameObject"))
                {
                    gObs[i].name = nameBase + "0" + i;
                }
            }
            return gObs;
        }
    }
}