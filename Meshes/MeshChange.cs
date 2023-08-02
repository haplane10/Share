using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshChange : MonoBehaviour
{
    public MeshFilter bodyMeshFilter;
    public MeshFilter clotheMeshFilter;
    public List<Mesh> bodyMeshes;
    public List<Mesh> clotheMeshes;

    int idx = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPlayButtonClick()
    {
        StartCoroutine("PlayMeshChange");
    }

    public void OnStopButtonClick()
    {
        StopCoroutine("PlayMeshChange");
    }

    IEnumerator PlayMeshChange()
    {
        while (true)
        {
            bodyMeshFilter.mesh = bodyMeshes[idx];
            clotheMeshFilter.mesh = clotheMeshes[idx];

            yield return new WaitForSeconds(0.1f);

            idx++;

            if (idx >= bodyMeshes.Count)
            {
                idx = 0;
            }
        }
    }
}
