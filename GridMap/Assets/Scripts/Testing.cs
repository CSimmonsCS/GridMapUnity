using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    private Grid<bool> grid;

    private void Start()
    {
        grid = new Grid<bool>(20, 10, 6f, Vector3.zero);
    }

    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        //}

        //if (Input.GetMouseButtonDown(1))
        //{
        //    Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        //}
    }
}
