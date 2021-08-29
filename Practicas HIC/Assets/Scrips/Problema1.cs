using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola mundo Cruel y Despiadado");

        int[] nums = new int[] {8,1,2,3,4};

         Debug.Log("Input: ");
        for(int i=0;i<5;i++)
        {
            Debug.Log(nums[i]);
        }

        Debug.Log("*********************");
        Debug.Log("Output: ");

        int[] result = ItemsLessThanElements(nums);
        for(int i=0;i<5;i++)
        {
            Debug.Log(result[i]);
        }


    }
    

    private int[] ItemsLessThanElements(int[] nums)
    {   /*Inicializamos arreglo auxiliar para guardar los numeros*/
        int[] resultado=new int[] {0,0,0,0,0}; 

        for(int i=0;i<5;i++)
        {
            /*inicilizamos contador cada vez que transcurra un ciclo*/
            int cont=0;

            for(int j=0;j<5;j++)
            {/*Comparamos la  posicion actual del arreglo nums[i] con cada posicion nums[j]*/
                if(nums[j]<nums[i])  /*Comparamos cada  posicion del arreglo nums[j] < con posicion actual nums[i]*/
                    {
                        cont++;/*incrementamos contador cada que sea mayor*/
                        resultado[i]=cont;/*Guardamos resultado en arreglo*/
                    }
                }
            }
            return resultado;/*Retornamos arreglo*/
        }
}
