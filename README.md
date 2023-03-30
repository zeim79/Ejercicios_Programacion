# Ejercicios Programación

## Instrucciones
1. Crea un fork de este repositorio
2. Clona ese fork en la carpeta que desees
3. Abre el proyecto desde Unity

Cada vez que vayas a empezar un grupo de ejercicios:
- Crea una carpeta con el esquema ```Ejercicios_x```, donde x es el número de la sección
- Crea un script nuevo por cada ejercicio de la sección
- Recuerda colocar todas las clases bajo el espacio de nombres ```Ejercicios_x```

## Ejercicios_1
1. Crear un script que genere un GameObject al inicio cuyo nombre sea "Ejercicio01"
2. Crear un script que genere un GameObject al inicio y trasladarlo a la posicion (111.1, -5, 4.5)
3. Crear un script que genere un cubo al inicio y duplique su escala
4. Crear un script que genere una esfera al inicio con un Rigidbody añadido
5. Crear un script que genere 30 GameObjects al inicio
6. Crear un script que genere dos esferas al inicio separadas 100 metros
7. Crear un script que genere tres esferas al inicio separadas 100 metros
8. Crear un script que genere tres cubos cada uno el doble de grande que el anterior
9. Crear un script que genere 12 esferas cada una el doble de grande que la anterior
10. Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este

## Glosario
Crear GameObject
```cs
GameObject go1 = new GameObject();
GameObject go2 = new GameObject("Nombre");
```

Crear primitivas
```cs
GameObject.CreatePrimitive(PrimitiveType.Cube);
GameObject.CreatePrimitive(PrimitiveType.Sphere);
```

Añadir componentes
```cs
BoxCollider box = gameObject.AddComponent<BoxCollider>();
Rigidbody body = gameObject.AddComponent<Rigidbody>();
```

Recuperar componentes
```cs
BoxCollider box = gameObject.GetComponent<BoxCollider>();
Rigidbody body = gameObject.GetComponent<Rigidbody>();
```

Encontrar objetos en la escena
```cs
GameObject go1 = GameObject.Find("Nombre");
GameObject go2 = GameObject.FindWithTag("Etiqueta");
Rididbody body = GameObject.FindObjectOfType<Rigidbody>();
BoxCollider[] boxes = GameObject.FindObjectsOfType<BoxCollider>()
```

Cambiar la posición de un objeto
```cs
gameObject.transform.position = new Vector3(5f, 1f, -2f);
gameObject.transform.position = Vector3.zero;
gameObject.transform.position = Vector3.up * 10f;
```

Cambiar la escala de un objeto
```cs
gameObject.transform.localScale = new Vector3(2f, 1f, 1f);
gameObject.transform.localScale = Vector3.one * 2f;
```

Cambiar la rotación de un objeto
```cs
gameObject.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
gameObject.transform.rotation = Quaternion.identity;
gameObject.transform.rotation = Quaternion.AngleAxis(45f, Vector3.up);
```
