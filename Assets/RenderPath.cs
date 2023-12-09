using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderPath : MonoBehaviour
{
    public GameObject player;
    public LineRenderer _line;
    private int point = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    void FixedUpdate()
    {
        _line.SetVertexCount(point + 1);
        Vector3 pos = player.transform.position;
        _line.SetPosition(point, pos);
        point++;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
