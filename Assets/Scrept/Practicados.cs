using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practicados : MonoBehaviour
{

      private bool bandera = false; // inicio la bandera en falso
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


    int[] numeros = { 97, -64, -3, -58, -15, 58, 51, 38, -31, -37 };

    // Variable para el temporizador
    private float timer = 0f;
    // Tiempo en segundos que debe esperar antes de ejecutar la función
    private float tiempoEspera = 4.5f;

    void ModificarArray()
    {
        for (int i = 0; i < numeros.Length; i++) // que recorra toda la array

        {
            if (numeros[i] % 2 == 0) // Si el número es par
            {
                numeros[i] *= 2; // Duplicar el valor
            }
        }

        // Imprimir el array modificado en la consola
        Debug.Log("Array modificado: " + string.Join(", ", numeros));

        bandera = true; //pasa a true porque ya modifico array

    }

          

    // Start is called before the first frame update
    void Start()
    {
        {

            int valor1 = Random.Range(-100, 100); // genera los nuemero aleatorios  
            int valor2 = Random.Range(-100, 100);
            int valor3 = Random.Range(-100, 100);


            string resultado = EvaluarValores(valor1, valor2, valor3); // ejecuta la funcion    


            Debug.Log("Valores generados: " + valor1 + ", " + valor2 + ", " + valor3); // la consola
            Debug.Log("Resultado: " + resultado);
        }

        Debug.Log("Array original: " + string.Join(", ", numeros)); //vas a mostrar Array original
    }

    // Update is called once per frame
    void Update()
    {
          if (bandera) return;  // condicional para ejecutar de nuevo el codigo
        timer += Time.deltaTime;

        // Si han pasado más de 4.5 segundos
        if (timer >= tiempoEspera)
        {
            // Llamar a la función que modifica el array
            ModificarArray();

            // Reiniciar el temporizador para evitar que la función se ejecute múltiples veces
            timer = 0f;

        }
    }

}
