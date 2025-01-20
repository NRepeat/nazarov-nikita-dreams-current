using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [SerializeField] private int _number_test;

    [SerializeField] private int _number_test2;

    [ContextMenu("Add")]
    private void Add()


    {

        Debug.Log(this._number_test + this._number_test2);
    }
}
