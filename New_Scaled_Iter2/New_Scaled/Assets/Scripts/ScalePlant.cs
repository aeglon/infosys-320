using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalePlant : MonoBehaviour
{

    public void TaskOnClick()
    {
        transform.localScale += new Vector3(0, 2, 0);
    }

    public void TaskOffClick()
    {
        transform.localScale -= new Vector3(0, 2, 0);
    }
}
