using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 0.5f;
        human.transform.position = new Vector3(value-41.66747f, -2.12f, 58.93457f);
    }

    public void MoveRight()
    {
        value = value + 0.5f;
        human.transform.position = new Vector3(value-41.66747f, -2.12f, 58.93457f);
    }

    public void ResetPosition()
    {
        human.transform.position = new Vector3(-41.66747f, -2.12f, 58.93457f);
        human.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        human.transform.localScale = new Vector3(1, 1, 1);
    }

    public void RotateLeft()
    {
        human.transform.Rotate(0f, 20f, 0f);
    }

    public void Grow()
    {
        human.transform.localScale += 0.1f * sizeChange;
    }
  
    public void GetSmall()
    {
        human.transform.localScale -= 0.1f * sizeChange;
    }



}