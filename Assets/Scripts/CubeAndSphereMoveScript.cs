using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody), typeof(Collider))]
public class CubeAndSphereMoveScript : MonoBehaviour
{
    
    
    private void Start()
    {
       
        StartCoroutine(bulletDestroyCoroutine());
    }

    IEnumerator bulletDestroyCoroutine()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

  //  private void OnTriggerEnter(Collider collider)
  //  {
      //  if (collider.tag == "DestroyedFigure")
      //  {
         //   Destroy(collider.gameObject);//видимо, не так)
         //   Destroy(gameObject);//
    //    }
  //  }
}
