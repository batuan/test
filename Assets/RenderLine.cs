using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderLine : MonoBehaviour {

    public LineRenderer lineRenderer;

    public void RenderMyLine(Vector3 a, Vector3 b){
        Vector3[] list = { a, b };
        lineRenderer.SetPositions(list);
    }
}
