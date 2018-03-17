using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec23 : MonoBehaviour
{
    public bool crear;
    public bool crearnegras;
    public bool dest;
    int coller = 1;
    public GameObject bolas;
    // cal y cal2 son para el random de los for
    public int cal;
    public int cal2;
    public GameObject[,] mat;
    void Start(){}
    void Creacion()  // este es el metodo que me crea la matriz con el game objet bolas
    {
        /*este es el ramdom que me controla las filas y las columnas
        el para dentro de otro para para crear las filas y las columnas que se generaran con el objeto vacio.*/
        cal = (Random.Range(3, 12));
        cal2 = (Random.Range(3, 12));
        // esta es la matriz que sera llenada por cal y cal2 
        mat = new GameObject[cal,cal2];
        // estos son los 2 paras que me llenaran la matriz 
        for (int i = 0; i < cal; i++)
        {
            for (int j = 0; j < cal2; j++)
            {
                // esta parte es la que me crea las esferas y la posicion en la que se va a ubicar. 
                GameObject bolas = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                bolas.transform.position = new Vector3(i * 1.2f, j * 1.2f, 0f);
                mat[i,j] = bolas;
                // bolas.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
                // color = new Color(Random.value, Random.value, Random.value, 1.0f);
                // este es un ramdom para el caso de los colores  
                coller = Random.Range(1, 4);
                // este es un caso que le da los colores del gameobjet 
                switch (coller)
                {
                    case 1:
                        bolas.GetComponent<MeshRenderer>().material.color = Color.red;
                        break;
                    case 2:
                        bolas.GetComponent<MeshRenderer>().material.color = Color.yellow;
                        break;
                    case 3:
                        bolas.GetComponent<MeshRenderer>().material.color = Color.green;
                        break;
                    case 4:
                        bolas.GetComponent<MeshRenderer>().material.color = Color.blue;
                        break;
                }
            }
        }
    }
    void Update()
    {
    	// esta es una condicion boleana que al ser verdadera me creara la matriz
        if (crear == true)
        {
            crear = false;
            Creacion();
        }
        // esta es una condicion boleana que me comparara los colores y los pone negros 
        if (crearnegras == true)
        {
            crearnegras = false;
            comp();
            
        }
        // este es una condicion boleana que al ser verdadera me destruye la matriz 
        if (dest == true)
        {
            dest = false;
            destruir();
            
        }
    }
    // este es un metodo que me compara todas las posiciones de la matriz 
    void comp() // este es el metrodo que me compara las posociones de la matriz 
    {
        try
        { 
            for (int i = 0; i < cal ; i++)
            {
                for (int j = 0; j < cal2 ; j++)
                {
                    if (i > 0)
                    {
                        if (mat[i,j].GetComponent<MeshRenderer>().material.color == mat[i-1,j].GetComponent<MeshRenderer>().material.color)
                        {
                            mat[i,j].GetComponent<MeshRenderer>().material.color = Color.black;
                            mat[i-1,j].GetComponent<MeshRenderer>().material.color = Color.black;
                        }
                    }
                }
            }
        } catch { }

    }
    // este es el metodo que me destruye la matriz recorriendola y  destruyendola
    void destruir()
    {
        for (int i = 0; i < cal; i++)
        {
            for (int j = 0; j < cal2; j++)
            {
                Destroy(mat[i,j]);
            }
        }
    }
}
 