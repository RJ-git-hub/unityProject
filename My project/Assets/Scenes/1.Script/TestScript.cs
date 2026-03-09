using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake 角青");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable 角青");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start 角青");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update 角青");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable 角青");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy 角青");
    }
}
