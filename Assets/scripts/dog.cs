using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog : MonoBehaviour
{
  private int speed = 3;
    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1)*Time.deltaTime *speed);
    }
}
