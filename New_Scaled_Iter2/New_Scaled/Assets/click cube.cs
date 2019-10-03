using UnityEngine;
using System.Collections;

public class Onclick : MonoBehaviour
{

    public GameObject Anything;

    int Cube = 10;

    private void OnMouseDown()
    {
        if (Cube == 10)
        {
            Anything.transform.Translate(-6, 0, 10);
            Cube = 11;
        }
        else
        {
            Anything.transform.Translate(-30, 0, 10);
            Cube = 10;
        }
    }
}

