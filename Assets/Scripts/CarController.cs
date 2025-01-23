using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public void Move(float directon)
    {
        transform.Translate(Vector3.right * directon * Time.deltaTime);
    }
}
