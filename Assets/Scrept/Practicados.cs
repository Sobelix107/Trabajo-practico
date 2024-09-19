using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practicados : MonoBehaviour
{
     public string EvaluarValores(int valor1, int valor2, int valor3) // indicamos los 3 valores con una fincion int
    {
        // Usamos Mathf.Max y Mathf.Min para encontrar el mayor y el menor valor
        int mayor = Mathf.Max(valor1, valor2, valor3);
        int menor = Mathf.Min(valor1, valor2, valor3);

        // Condición si el mayor valor es mayor a 100
        if (mayor > 100)
        {
            return "Mayor fuera de rango";
        }

        // Condición si el menor valor es menor a 0
        if (menor < 0)
        {
            return "Menor fuera de rango";
        }

        // Si ninguno está fuera de los rangos, calculamos el valor promedio
        float promedio = (valor1 + valor2 + valor3) / 3; // no pongo int porque puede dar decimal
        return "El valor promedio es: " + promedio;
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
