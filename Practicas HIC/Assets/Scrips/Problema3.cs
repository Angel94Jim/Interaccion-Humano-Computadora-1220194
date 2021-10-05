using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         int[] nums = new int[] {-2,1,-3,4,-1,2,1,-5,+4};
         int sum=6;

         Debug.Log("**********************"); 

        Debug.Log("Aqui va el problema 3");

        Debug.Log("Sum = " + sum);

        Debug.Log("Input: ");
        for(int i=0;i<9;i++)
        {
            Debug.Log(nums[i]);
        }

        Debug.Log("*********************");
        Debug.Log("Output: ");

        int[] result = Suma(nums,sum);
         
          
    }

    private int[] Suma(int[] nums,int sumX)
    {   
        int[] resultado=new int[] {0,0,0,0,0,0,0,0};
   
        
        return resultado;
    }    
        
}
