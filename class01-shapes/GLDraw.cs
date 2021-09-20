using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLDraw : MonoBehaviour
{
    public Material mat;
    //use this variable in unity, to choose the draw(1~14)
    public int choice = 0;


    private void OnPostRender()
    {
        GL.PushMatrix();
        mat.SetPass(0);
        GL.Begin(GL.LINES);

        switch (choice)
        {
            /**
             * REGION SHAPES 1
             */

            //SQUARE
            case 1:
                GL.Vertex(new Vector3(0, 0, 0));
                GL.Vertex(new Vector3(5, 0, 0));

                GL.Vertex(new Vector3(5, 0, 0));
                GL.Vertex(new Vector3(5, 5, 0));

                GL.Vertex(new Vector3(5, 5, 0));
                GL.Vertex(new Vector3(0, 5, 0));

                GL.Vertex(new Vector3(0, 5, 0));
                GL.Vertex(new Vector3(0, 0, 0));
            break;


            //TRIANGLE
            case 2:
                GL.Vertex(new Vector3(0, 0, 0));
                GL.Vertex(new Vector3(5, 0, 0));

                GL.Vertex(new Vector3(5, 0, 0));
                GL.Vertex(new Vector3((float)2.50, 5, 0));

                GL.Vertex(new Vector3((float)2.5, 5, 0));
                GL.Vertex(new Vector3(0, 0, 0));
            break;

            //HEXAGON
            case 3:
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
            break;


            //SQUARE WITH LINES
            case 4:
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
            break;

            // X
            case 5:
                
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
            break;


            // ARROW
            case 6:
                
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
            break;


            //TOP-LEFT SQUARE
            case 7:
                
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
            break;


            //STAR
            case 8:
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

            break;
                

                //SQUARE WITH TWO ARROWS
            case 9:

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

            break;

            /**
             * END REGION
             */

            /**
             * REGION SHAPES (2) WITH NUMBERS INSIDE
            */

            //SQUARE WITH NUMBER 7
            case 10:
                GL.Vertex(new Vector3(0, 0, 0));
                GL.Vertex(new Vector3(5, 0, 0));

                GL.Vertex(new Vector3(5, 0, 0));
                GL.Vertex(new Vector3(5, 5, 0));

                GL.Vertex(new Vector3(5, 5, 0));
                GL.Vertex(new Vector3(0, 5, 0));

                GL.Vertex(new Vector3(0, 5, 0));
                GL.Vertex(new Vector3(0, 0, 0));

                GL.Vertex(new Vector3(1.5f, 4, 0));
                GL.Vertex(new Vector3(3.5f, 4, 0));

                GL.Vertex(new Vector3(3.5f, 4, 0));
                GL.Vertex(new Vector3(1.5f, 1, 0));

            break;


            //HEXAGON WITH NUMBER 4
            case 11:
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

                GL.Vertex(new Vector3(0, 2, 0));
                GL.Vertex(new Vector3(2, 2, 0));

                GL.Vertex(new Vector3(1.25f, 1, 0));
                GL.Vertex(new Vector3(1.25f, 3, 0));

                GL.Vertex(new Vector3(1.25f, 3, 0));
                GL.Vertex(new Vector3(0, 2, 0));

            break;


            //STAR WITH NUMBER 1
            case 12:
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

                GL.Vertex(new Vector3(2f, 1.5f, 0));
                GL.Vertex(new Vector3(2f, 2.5f, 0));

                GL.Vertex(new Vector3(2f, 2.5f, 0));
                GL.Vertex(new Vector3(1.75f, 2.25f, 0));

            break;

            /**
             * END REGION
             */

            /**
             * REGION SHAPES 3
             */

            //SQUARE WITH BORDERS
            case 13:
                GL.Vertex(new Vector3(0, 0, 0));
                GL.Vertex(new Vector3(5, 0, 0));

                GL.Vertex(new Vector3(5, 0, 0));
                GL.Vertex(new Vector3(5, 5, 0));

                GL.Vertex(new Vector3(5, 5, 0));
                GL.Vertex(new Vector3(0, 5, 0));

                GL.Vertex(new Vector3(0, 5, 0));
                GL.Vertex(new Vector3(0, 0, 0));

                GL.Vertex(new Vector3(-1, -1, 0));
                GL.Vertex(new Vector3(6, -1, 0));

                GL.Vertex(new Vector3(6, -1, 0));
                GL.Vertex(new Vector3(6, 6, 0));

                GL.Vertex(new Vector3(6, 6, 0));
                GL.Vertex(new Vector3(-1, 6, 0));

                GL.Vertex(new Vector3(-1, 6, 0));
                GL.Vertex(new Vector3(-1, -1, 0));

                GL.Vertex(new Vector3(0, 0, 0));
                GL.Vertex(new Vector3(-1, -1, 0));

                GL.Vertex(new Vector3(5, 0, 0));
                GL.Vertex(new Vector3(6, -1, 0));

                GL.Vertex(new Vector3(5, 5, 0));
                GL.Vertex(new Vector3(6, 6, 0));

                GL.Vertex(new Vector3(0, 5, 0));
                GL.Vertex(new Vector3(-1, 6, 0));

            break;

            //HOUSE
            case 14:
                GL.Vertex(new Vector3(0, 0, 0));
                GL.Vertex(new Vector3(5, 0, 0));

                GL.Vertex(new Vector3(5, 0, 0));
                GL.Vertex(new Vector3(5, 5, 0));

                GL.Vertex(new Vector3(5, 5, 0));
                GL.Vertex(new Vector3(0, 5, 0));

                GL.Vertex(new Vector3(0, 5, 0));
                GL.Vertex(new Vector3(0, 0, 0));

                GL.Vertex(new Vector3(1.5f, 0.5f, 0));
                GL.Vertex(new Vector3(3.5f, 0.5f, 0));

                GL.Vertex(new Vector3(3.5f, 0.5f, 0));
                GL.Vertex(new Vector3(3.5f, 2.5f, 0));

                GL.Vertex(new Vector3(3.5f, 2.5f, 0));
                GL.Vertex(new Vector3(1.5f, 2.5f, 0));

                GL.Vertex(new Vector3(1.5f, 2.5f, 0));
                GL.Vertex(new Vector3(1.5f, 0.5f, 0));

                GL.Vertex(new Vector3(2.25f, 0.5f, 0));
                GL.Vertex(new Vector3(2.25f, 1.25f, 0));

                GL.Vertex(new Vector3(2.25f, 1.25f, 0));
                GL.Vertex(new Vector3(2.75f, 1.25f, 0));

                GL.Vertex(new Vector3(2.75f, 1.25f, 0));
                GL.Vertex(new Vector3(2.75f, 0.5f, 0));

                GL.Vertex(new Vector3(1, 2.5f, 0));
                GL.Vertex(new Vector3(4, 2.5f, 0));

                GL.Vertex(new Vector3(4, 2.5f, 0));
                GL.Vertex(new Vector3(2.5f, 4, 0));

                GL.Vertex(new Vector3(2.5f, 4, 0));
                GL.Vertex(new Vector3(1, 2.5f, 0));

                GL.Vertex(new Vector3(3, 3.5f, 0));
                GL.Vertex(new Vector3(3, 4, 0));

                GL.Vertex(new Vector3(3, 4, 0));
                GL.Vertex(new Vector3(3.25f, 4, 0));

                GL.Vertex(new Vector3(3.25f, 4, 0));
                GL.Vertex(new Vector3(3.25f, 3.25f, 0));

            break;

                /**
                 * END REGION
                 */
        }
        GL.End();
        GL.PopMatrix();
}
}