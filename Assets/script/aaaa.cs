using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaa : MonoBehaviour
{
    // Start is called before the first frame update
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
    for (int num1 = 5; num1 <=5; num1++)
    {
      for (int num2 = 1; num2 <= 10; num2++)
      {int sum=num1*num2;
        Debug.Log(num1+"*"+num2+"="+sum);
        Debug.Log("sum:"+sum);
      }
    }   
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
