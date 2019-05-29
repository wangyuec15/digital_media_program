using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw : MonoBehaviour {



    public static Material lineMaterial;
    public List<Vector3> links, anylink;


    Camera myCamera;
    public GameObject panel;

	// Use this for initialization
	void Start () {
        myCamera = gameObject.GetComponent<Camera>();
        //panel = GameObject.Find("peoples(Clone)");
        SetMaterial();
	}
	
	// Update is called once per frame
	void Update () {
        links = new List<Vector3>();
        anylink = new List<Vector3>();
        for (int i = 0; i < panel.transform.childCount-1;i++){
            for (int j = i+1; j < panel.transform.childCount;j++){
                anylink.Add(panel.transform.GetChild(i).position);
                anylink.Add(panel.transform.GetChild(j).position);
            
                if(panel.transform.GetChild(i).GetComponent<force>().linked.Contains(panel.transform.GetChild(j))&&panel.transform.GetChild(i).GetComponent<dragpeople>().drawme==true){
                    links.Add(panel.transform.GetChild(i).position);
                    links.Add(panel.transform.GetChild(j).position);
                }
            }
        }


	}


    public void OnPostRender()
    {
        //Debug.Log("0");
        if (!lineMaterial) { SetMaterial(); Debug.Log(lineMaterial); }
        lineMaterial.SetPass(0);
        //DrawQuads(links, Color.yellow);
        //DrawQuads(anylink, Color.white);

        //if (Camera.main.GetComponent<main_controller>().panel4.active == false)
        //{
        //    DrawLines(anylink, Color.white);
        //}
       
            DrawLines(links, Color.yellow);


    }
    //public void DrawQuads(List<Vector3> lines, Color color)
    //{
    //    GL.Begin(GL.QUADS);
    //    GL.Color(color);

    //    for (int i = 0; i < lines.Count; i += 4)
    //    {
    //        GL.Vertex(lines[i]);
    //        GL.Vertex(lines[i + 1]);
    //        GL.Vertex(lines[i + 2]);
    //        GL.Vertex(lines[i + 3]);
    //    }

    //    GL.End();
    //}

    void DrawLines(List<Vector3> lines, Color color)
    {
        GL.Begin(GL.LINES);
        GL.Color(color);

        for (int i = 0; i < lines.Count; i += 2)
        {
            GL.Vertex(lines[i]);
            GL.Vertex(lines[i + 1]);
        }

        GL.End();
    }

    void SetMaterial()
    {
        if (lineMaterial == null)
        {
            lineMaterial = new Material(Shader.Find("Custom/Lines"));
        }
    }



}
