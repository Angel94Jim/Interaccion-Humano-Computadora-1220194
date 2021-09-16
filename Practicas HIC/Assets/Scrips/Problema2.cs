using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         int[] nums = new int[] {2,7,11,15,1};
         int target=16;

         Debug.Log("**********************"); 

        Debug.Log("Aqui va el problema 2");

        Debug.Log("Target = " + target);

        Debug.Log("Input: ");
        for(int i=0;i<5;i++)
        {
            Debug.Log(nums[i]);
        }

        Debug.Log("*********************");
        Debug.Log("Output: ");

        int[] result = SumaDos(nums,target);
         
         for(int i=0;i<2;i++)
        {
            Debug.Log(result[i]);
        }   
            Debug.Log("*********************");     
    }

    private int[] SumaDos(int[] nums,int target)
    {   
        int[] resultado=new int[] {0,0,0,0,0};
        int i,j;
        for(i=0;i<4;i++)
        {
            for(j=i+1;j<5;j++)
            {
                if(nums[i]+nums[j]==target) //comparamos suma de posicion actual+posicion siguiente=al numero que se busca
                {
                    resultado[0]=i; //guardamos dentro del arreglo los valores de los indices
                    resultado[1]=j;
                    break;
                }
            }
            
        }
        return resultado;
    }    
        
}
