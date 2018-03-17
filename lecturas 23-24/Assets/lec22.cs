using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lec22 : MonoBehaviour 
{
    // definicion de las variables 
	public float a;
	string saludo;
	int num1=2,num2=2,num3=1,num4=5,num5=10,num6=15,num7=20,num8=32,num9=12,num10=1;
	public float s;
	float p1=5f,p2=8f,p3=6f,p4=10f,p5=15f,sumval,pro;
	float n1=13.8f,n2=23.7f,n3=15.4f,n4=1.1f,n5=7.8f,n6=90.6f,n7=103.9f,n8=11.7f,n9=22.9f,n10=100.1f;
	public float sum2c;
	public float promm;
	void Start () 
	{
		// 1- imprimir hola mundo
		saludo = ("hola_mundo");   // saludo es un string que me imprimira el hola mundo
        Debug.Log ("punto 1:"); Debug.Log (saludo);  // deubg.log es la manera de inprimir en c# 
		// 2-suma el valor de 2 numeros 
		a= (5f + 8f);  // a es la variable que toma el valor que se le fue asignado que en este caso es 5+8
        Debug.Log ("punto 2:"); Debug.Log (a);
		// 3- sumar 10 variables
		s = (num1+num2+num3+num4+num5+num6+num7+num8+num9+num10); 
		Debug.Log ("punto 3:"); Debug.Log (s);
		// 4- imprime el promedio de 5 literales
		sumval = (p1+p2+p3+p4+p5);     // suma de los valores 
        pro = (sumval / 5);            // pro es la suma de los valores de sumval y dividirlos por 5
		Debug.Log ("punto 4:"); Debug.Log (pro);
		// 5- imprime prmedio de 12 variables decimales flota o double
		sum2c = (n1+n2+n3+n4+n5+n6+n7+n8+n9+n10); // suman de valores 
		promm = (sum2c / 10);                     // promedio de la suma dividido  10
		Debug.Log ("punto 5:"); Debug.Log (promm);
	}
	void Update () {}
}
