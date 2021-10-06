using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Problema3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = new int[] {-2,1,-3,4,-1,2,-5,-4};
        int sum=0;

        Debug.Log("**********************");
        Debug.Log("Aqui va el problema 3");

        Debug.Log("Input: ");
        for(int i=0;i<7;i++)
        {
            Debug.Log(nums[i]);
        }

        Debug.Log("*********************");
        Debug.Log("Output: ");

        sum=Suma(nums);

        Debug.Log("Suma = " + sum);
           
    }

    public int Suma(int[] nums) //tiempo O(N) : algoritmo Kadanes
    {   
        int sum=nums[0]; //Inicalizamos sum con el primer valor del arreglo.
        int GSum=sum; //Inicializamos suma mayor con el valor de sum.

        for(int i=1;i<8;i++) //Empezamos en 1 por que ya tenemos el primer valor del array guardado.
        {
            sum=Math.Max(nums[i], nums[i] + sum); //Guardamos en sum el num. mayor entre la pos. actual del arreglo y el valor del pos. actual mas la suma del val ant. de sum.
            GSum=Math.Max(sum, GSum); //Guardamos en Gsum el num mayor dado entre sum y el valor de Gsum
            /*/
                Math.max() es una función que devuelve el valor mayor 
                de una lista de valores numéricos pasados como parámetros.  x=Math.max(1,4), x=4
                sum=-2,Gsum=-2.
                i=1; sum=1, Gsum=1;
                i=2; sum=-2, Gusm=1;
                i=3; sum=4, Gsum=4;
                i=4; sum=3, Gsum=4;
                i=5; sum=5, Gsum=5;
                i=6; sum=0, Gsum=5;
                i=7; sum=-4, Gsum=5;
            /*/
        }
        return GSum;//Retornamos el Gsum como num mayor
    }    

    
        
}
