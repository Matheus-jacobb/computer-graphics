using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLDraw : MonoBehaviour
{
    public Material mat;

    private void OnPostRender()
    {
        GL.PushMatrix();
        mat.SetPass(0);
        GL.Begin(GL.LINES);

        //REGION SHAPES 1
        //SQUARE
        /*
        GL.Vertex(new Vector3(0,0,0));
        GL.Vertex(new Vector3(5,0,0));

        GL.Vertex(new Vector3(5, 0, 0));
        GL.Vertex(new Vector3(5, 5, 0));

        GL.Vertex(new Vector3(5, 5, 0));
        GL.Vertex(new Vector3(0, 5, 0));

        GL.Vertex(new Vector3(0, 5, 0));
        GL.Vertex(new Vector3(0, 0, 0));
        */

        //TRIANGLE
        /*
        GL.Vertex(new Vector3(0, 0, 0));
        GL.Vertex(new Vector3(5, 0, 0));

        GL.Vertex(new Vector3(5, 0, 0));
        GL.Vertex(new Vector3((float)2.50, 5, 0));

        GL.Vertex(new Vector3((float)2.5, 5, 0));
        GL.Vertex(new Vector3(0, 0, 0));
        */

        //HEXAGON
        /*
        GL.Vertex(new Vector3(-1, 2, 0));
        GL.Vertex(new Vector3(0, 0, 0));

        GL.Vertex(new Vector3(0, 0, 0));
        GL.Vertex(new Vector3(2, 0, 0));

        GL.Vertex(new Vector3(2, 0, 0));
        GL.Vertex(new Vector3(3, 2, 0));

        GL.Vertex(new Vector3(3, 2, 0));
        GL.Vertex(new Vector3(2, 4, 0));

        GL.Vertex(new Vector3(2, 4, 0));
        GL.Vertex(new Vector3(0, 4, 0));

        GL.Vertex(new Vector3(0, 4, 0));
        GL.Vertex(new Vector3(-1, 2, 0));
        */

        //SQUARE WITH LINES
        /*
        GL.Vertex(new Vector3(0, 0, 0));
        GL.Vertex(new Vector3(6, 0, 0));

        GL.Vertex(new Vector3(6, 0, 0));
        GL.Vertex(new Vector3(6, 6, 0));

        GL.Vertex(new Vector3(6, 6, 0));
        GL.Vertex(new Vector3(0, 6, 0));

        GL.Vertex(new Vector3(0, 6, 0));
        GL.Vertex(new Vector3(0, 0, 0));

        GL.Vertex(new Vector3(1, 0, 0));
        GL.Vertex(new Vector3(1, 6, 0));

        GL.Vertex(new Vector3(0, 5, 0));
        GL.Vertex(new Vector3(6, 5, 0));
        */

        // X
        /*
        GL.Vertex(new Vector3(0, 1, 0));
        GL.Vertex(new Vector3(1, 0, 0));

        GL.Vertex(new Vector3(1, 0, 0));
        GL.Vertex(new Vector3(2, 1, 0));

        GL.Vertex(new Vector3(2, 1, 0));
        GL.Vertex(new Vector3(3, 0, 0));

        GL.Vertex(new Vector3(3, 0, 0));
        GL.Vertex(new Vector3(4, 1, 0));

        GL.Vertex(new Vector3(4, 1, 0));
        GL.Vertex(new Vector3(3, 2, 0));

        GL.Vertex(new Vector3(3, 2, 0));
        GL.Vertex(new Vector3(4, 3, 0));

        GL.Vertex(new Vector3(4, 3, 0));
        GL.Vertex(new Vector3(3, 4, 0));

        GL.Vertex(new Vector3(3, 4, 0));
        GL.Vertex(new Vector3(2, 3, 0));

        GL.Vertex(new Vector3(2, 3, 0));
        GL.Vertex(new Vector3(1, 4, 0));

        GL.Vertex(new Vector3(1, 4, 0));
        GL.Vertex(new Vector3(0, 3, 0));

        GL.Vertex(new Vector3(0, 3, 0));
        GL.Vertex(new Vector3(1, 2, 0));

        GL.Vertex(new Vector3(1, 2, 0));
        GL.Vertex(new Vector3(0, 1, 0));
        */

        // ARROW
        /*
        GL.Vertex(new Vector3(0, 1, 0));
        GL.Vertex(new Vector3(3, 1, 0));

        GL.Vertex(new Vector3(3, 1, 0));
        GL.Vertex(new Vector3(3, 0, 0));

        GL.Vertex(new Vector3(3, 0, 0));
        GL.Vertex(new Vector3(4, (float)1.5, 0));

        GL.Vertex(new Vector3(4, (float)1.5, 0));
        GL.Vertex(new Vector3(3, 3, 0));

        GL.Vertex(new Vector3(3, 3, 0));
        GL.Vertex(new Vector3(3, 2, 0));

        GL.Vertex(new Vector3(3, 2, 0));
        GL.Vertex(new Vector3(0, 2, 0));

        GL.Vertex(new Vector3(0, 2, 0));
        GL.Vertex(new Vector3(0, 1, 0));
        */

        //TOP-LEFT SQUARE
        /*
        GL.Vertex(new Vector3(0, 0, 0));
        GL.Vertex(new Vector3(1, 1, 0));

        GL.Vertex(new Vector3(1, 1, 0));
        GL.Vertex(new Vector3(1, 2, 0));

        GL.Vertex(new Vector3(1, 2, 0));
        GL.Vertex(new Vector3(2, 2, 0));

        GL.Vertex(new Vector3(2, 2, 0));
        GL.Vertex(new Vector3(3, 3, 0));

        GL.Vertex(new Vector3(3, 3, 0));
        GL.Vertex(new Vector3(0, 3, 0));

        GL.Vertex(new Vector3(0, 3, 0));
        GL.Vertex(new Vector3(0, 0, 0));
        */

        //STAR
        /*
        GL.Vertex(new Vector3(0, 3, 0));
        GL.Vertex(new Vector3(1.05f, 2, 0));

        GL.Vertex(new Vector3(1.05f, 2, 0));
        GL.Vertex(new Vector3(0.5f, 0, 0));

        GL.Vertex(new Vector3(0.5f, 0, 0));
        GL.Vertex(new Vector3(2, 1.05f, 0));

        GL.Vertex(new Vector3(2, 1.05f, 0));
        GL.Vertex(new Vector3(3.5f, 0, 0));

        GL.Vertex(new Vector3(3.5f, 0, 0));
        GL.Vertex(new Vector3(2.95f, 2, 0));

        GL.Vertex(new Vector3(2.95f, 2, 0));
        GL.Vertex(new Vector3(4, 3, 0));

        GL.Vertex(new Vector3(4, 3, 0));
        GL.Vertex(new Vector3(2.8f, 3, 0));

        GL.Vertex(new Vector3(2.8f, 3, 0));
        GL.Vertex(new Vector3(2, 5, 0));

        GL.Vertex(new Vector3(2, 5, 0));
        GL.Vertex(new Vector3(1.2f, 3, 0));

        GL.Vertex(new Vector3(1.2f, 3, 0));
        GL.Vertex(new Vector3(0, 3, 0));
        */

        //SQUARE WITH TWO ARROWS IN BOTH SIDES
        /*
        GL.Vertex(new Vector3(0, 2, 0));
        GL.Vertex(new Vector3(0, 0, 0));

        GL.Vertex(new Vector3(0, 0, 0));
        GL.Vertex(new Vector3(5, 0, 0));

        GL.Vertex(new Vector3(5, 0, 0));
        GL.Vertex(new Vector3(5, 2, 0));

        GL.Vertex(new Vector3(5, 2, 0));
        GL.Vertex(new Vector3(6, 2, 0));

        GL.Vertex(new Vector3(6, 2, 0));
        GL.Vertex(new Vector3(6, 1, 0));

        GL.Vertex(new Vector3(6, 1, 0));
        GL.Vertex(new Vector3(7.5f, 2.5f, 0));

        GL.Vertex(new Vector3(7.5f, 2.5f, 0));
        GL.Vertex(new Vector3(6, 4, 0));

        GL.Vertex(new Vector3(6, 4, 0));
        GL.Vertex(new Vector3(6, 3, 0));

        GL.Vertex(new Vector3(6, 3, 0));
        GL.Vertex(new Vector3(5, 3, 0));

        GL.Vertex(new Vector3(5, 3, 0));
        GL.Vertex(new Vector3(5, 5, 0));

        GL.Vertex(new Vector3(5, 5, 0));
        GL.Vertex(new Vector3(0, 5, 0));

        GL.Vertex(new Vector3(0, 5, 0));
        GL.Vertex(new Vector3(0, 3, 0));

        GL.Vertex(new Vector3(0, 3, 0));
        GL.Vertex(new Vector3(-1, 3, 0));

        GL.Vertex(new Vector3(-1, 3, 0));
        GL.Vertex(new Vector3(-1, 4, 0));

        GL.Vertex(new Vector3(-1, 4, 0));
        GL.Vertex(new Vector3(-2.5f, 2.5f, 0));

        GL.Vertex(new Vector3(-2.5f, 2.5f, 0));
        GL.Vertex(new Vector3(-1, 1, 0));

        GL.Vertex(new Vector3(-1, 1, 0));
        GL.Vertex(new Vector3(-1, 2, 0));

        GL.Vertex(new Vector3(-1, 2, 0));
        GL.Vertex(new Vector3(0, 2, 0));
        */

        //END REGION

        //REGION SHAPES (2) WITH NUMBERS INSIDE
        //SQUARE WITH NUMBER 7

        //HEXAGON WITH NUMBER 4

        //STAR WITH NUMBER 1

        //END REGION

        //REGION FORMAS 3
        //END REGION
        GL.End();
        GL.PopMatrix();
}
}