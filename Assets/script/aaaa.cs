using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaa : MonoBehaviour
{
    // Start is called before the first frame update
      int Multiply(int a, int b)
    {
        return a * b;
    }
    void Start()
    {
    //     int playerLives =3;
    //   while (playerLives >0)
    //   {
    //     if (playerLives == 3)Debug.Log("Many lives");
    //   else if (playerLives == 1)Debug.Log("The last life");
     
    // playerLives--;
    //   }
            
    //      Debug.Log("Game Over");
 int number=5;
    string Summ=null;
   

   int i=1;
        for ( ; i <= 10; i++)
        {
            Summ+=i+"x"+number+"="+(Sum(i,number));
           
    
 Summ+=",   ";
 Debug.Log(Sum(i,number));
        }
   Debug.Log(Summ);

           
          
    }

 private int Sum(int num1,int num2){
    return num1*num2;
    
 }

    // Update is called once per frame
    void Update()
    {
        
    }
}
