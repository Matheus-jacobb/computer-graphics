using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GLDraw_Curve : MonoBehaviour
{
    public Material mat;
    public float radius = 2f;
    public Vector3 center = new Vector3(0, 0, 0);

    //use this variable in unity, to choose the draw(1~7)
    public int choice = 0;

    private void OnPostRender()
    {

        GL.PushMatrix();

        mat.SetPass(0);

        switch (choice)
        {
            case 1:
                //CIRCLE
                drawCircle(radius, new Vector3(0, 0));
            break;

            case 2:
                //CYLINDER
                drawCylinder(radius, new Vector3(radius, radius));
            break;

            case 3:
                //BLOCK
                drawCircle(5, new Vector3(0, 0));

                drawSemicircle(3, new Vector3(0, 0), (5 * Mathf.PI / 6), (5 * Mathf.PI / 3));
                drawSemicircle(3, new Vector3(0, 0), (11 * Mathf.PI / 6), (2 * Mathf.PI) + (2 * Mathf.PI / 3));

                GL.Begin(GL.LINES);
                GL.Vertex(new Vector3(Mathf.Cos(5 * Mathf.PI / 6) * 3 + center.x, Mathf.Sin(5 * Mathf.PI / 6) * 3 + center.y, 0));
                GL.Vertex(new Vector3(Mathf.Cos(5 * Mathf.PI / 3) * 3 + center.x, Mathf.Sin(5 * Mathf.PI / 3) * 3 + center.y, 0));

                GL.Vertex(new Vector3(Mathf.Cos(11 * Mathf.PI / 6) * 3 + center.x, Mathf.Sin(11 * Mathf.PI / 6) * 3 + center.y, 0));
                GL.Vertex(new Vector3(Mathf.Cos((2 * Mathf.PI) + (2 * Mathf.PI / 3)) * 3 + center.x, Mathf.Sin((2 * Mathf.PI) + (2 * Mathf.PI / 3)) * 3 + center.y, 0));
                GL.End();
            break;

            case 4:
                //SMILE FACE
                drawCircle(5, center);
                drawCircle(0.5f, new Vector3(2.5f, 2));
                drawCircle(0.5f, new Vector3(-2.5f, 2));

                GL.Begin(GL.LINES);

                for (float t = 0.0f; t < (Mathf.PI); t += 0.01f)
                {
                    Vector3 ci = (new Vector3(Mathf.Cos(t) * -3 + center.x, Mathf.Sin(t) * -1.5f - 1, center.z));
                    GL.Vertex3(ci.x, ci.y, ci.z);
                }
                GL.End();
            break;

            case 5:
                //PIZZA 4 PIECES
                drawCircle(5, center);

                drawLine(Mathf.Cos(Mathf.PI / 2) * 5 + center.x, Mathf.Sin(Mathf.PI / 2) * 5 + center.y, Mathf.Cos(3 * Mathf.PI / 2) * 5 + center.x, Mathf.Sin(3 * Mathf.PI / 2) * 5 + center.y);
                drawLine(Mathf.Cos(Mathf.PI) * 5 + center.x, Mathf.Sin(Mathf.PI) * 5 + center.y, Mathf.Cos(0) * 5 + center.x, Mathf.Sin(0) * 5 + center.y);
            break;

            case 6:
                //SUN
                drawCircle(2, center);

                drawLine(0, 4, -0.5f, 2.5f);
                drawLine(-0.5f, 2.5f, 0.5f, 2.5f);
                drawLine(0, 4, 0.5f, 2.5f);

                drawLine(4, 0, Mathf.Cos(15) * -3f, Mathf.Sin(15));
                drawLine(Mathf.Cos(15) * -3, Mathf.Sin(15), Mathf.Cos(345) * 2.7f, Mathf.Sin(345));
                drawLine(4, 0, Mathf.Cos(345) * 2.7f, Mathf.Sin(345));

                drawLine(-4, 0, Mathf.Cos(15) * 3f, Mathf.Sin(15));
                drawLine(Mathf.Cos(15) * 3, Mathf.Sin(15), Mathf.Cos(345) * -2.7f, Mathf.Sin(345));
                drawLine(-4, 0, Mathf.Cos(345) * -2.7f, Mathf.Sin(345));

                drawLine(0, -4, -0.5f, -2.5f);
                drawLine(-0.5f, -2.5f, 0.5f, -2.5f);
                drawLine(0, -4, 0.5f, -2.5f);

                drawLine(Mathf.Cos(Mathf.PI / 4) * 4, Mathf.Sin(Mathf.PI / 4) * 4, Mathf.Cos(Mathf.PI / 3) * 2.5f, Mathf.Sin(Mathf.PI / 3) * 2.5f);
                drawLine(Mathf.Cos(Mathf.PI / 3) * 2.5f, Mathf.Sin(Mathf.PI / 3) * 2.5f, Mathf.Cos(Mathf.PI / 6) * 2.5f, Mathf.Sin(Mathf.PI / 6) * 2.5f);
                drawLine(Mathf.Cos(Mathf.PI / 4) * 4, Mathf.Sin(Mathf.PI / 4) * 4, Mathf.Cos(Mathf.PI / 6) * 2.5f, Mathf.Sin(Mathf.PI / 6) * 2.5f);

                drawLine(Mathf.Cos(3 * Mathf.PI / 4) * 4, Mathf.Sin(3 * Mathf.PI / 4) * 4, Mathf.Cos(5 * Mathf.PI / 6) * 2.5f, Mathf.Sin(5 * Mathf.PI / 6) * 2.5f);
                drawLine(Mathf.Cos(5 * Mathf.PI / 6) * 2.5f, Mathf.Sin(5 * Mathf.PI / 6) * 2.5f, Mathf.Cos(2 * Mathf.PI / 3) * 2.5f, Mathf.Sin(2 * Mathf.PI / 3) * 2.5f);
                drawLine(Mathf.Cos(3 * Mathf.PI / 4) * 4, Mathf.Sin(3 * Mathf.PI / 4) * 4, Mathf.Cos(2 * Mathf.PI / 3) * 2.5f, Mathf.Sin(2 * Mathf.PI / 3) * 2.5f);

                drawLine(Mathf.Cos(5 * Mathf.PI / 4) * 4, Mathf.Sin(5 * Mathf.PI / 4) * 4, Mathf.Cos(4 * Mathf.PI / 3) * 2.5f, Mathf.Sin(4 * Mathf.PI / 3) * 2.5f);
                drawLine(Mathf.Cos(4 * Mathf.PI / 3) * 2.5f, Mathf.Sin(4 * Mathf.PI / 3) * 2.5f, Mathf.Cos(7 * Mathf.PI / 6) * 2.5f, Mathf.Sin(7 * Mathf.PI / 6) * 2.5f);
                drawLine(Mathf.Cos(7 * Mathf.PI / 6) * 2.5f, Mathf.Sin(7 * Mathf.PI / 6) * 2.5f, Mathf.Cos(5 * Mathf.PI / 4) * 4, Mathf.Sin(5 * Mathf.PI / 4) * 4);

                drawLine(Mathf.Cos(7 * Mathf.PI / 4) * 4, Mathf.Sin(7 * Mathf.PI / 4) * 4, Mathf.Cos(11 * Mathf.PI / 6) * 2.5f, Mathf.Sin(11 * Mathf.PI / 6) * 2.5f);
                drawLine(Mathf.Cos(11 * Mathf.PI / 6) * 2.5f, Mathf.Sin(11 * Mathf.PI / 6) * 2.5f, Mathf.Cos(5 * Mathf.PI / 3) * 2.5f, Mathf.Sin(5 * Mathf.PI / 3) * 2.5f);
                drawLine(Mathf.Cos(5 * Mathf.PI / 3) * 2.5f, Mathf.Sin(5 * Mathf.PI / 3) * 2.5f, Mathf.Cos(7 * Mathf.PI / 4) * 4, Mathf.Sin(7 * Mathf.PI / 4) * 4);
            break;

            case 7:
                //RECTANGLE WITH CURVED EDGE
                drawLine(-3, 2, 3, 2);
                drawSemicircle(0.5f, new Vector3(-3, 1.5f), Mathf.PI / 2, Mathf.PI);
                drawLine(-3.5f, 1.5f, -3.5f, -2);
                drawLine(-3.5f, -2, 2.5f, -2);
                drawSemicircle(0.5f, new Vector3(2.5f, -1.5f), 3 * Mathf.PI / 2, 2 * Mathf.PI);
                drawLine(3, -1.5f, 3, 2);
            break;
                GL.PopMatrix();
        }
    }


        //region Funcoes
        private void drawCircle(float radius, Vector3 center)
        {

            GL.Begin(GL.LINES);

            for (float t = 0.0f; t < (Mathf.PI * 2); t += 0.01f)
            {
                Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * radius + center.y, center.z));
                GL.Vertex3(ci.x, ci.y, ci.z);
            }
            GL.End();
        }

        private void drawCylinder(float radius, Vector3 center)
        {

            GL.Begin(GL.LINES);
            radius = radius / 2;
            drawEllipse(radius, center);
            GL.End();

            GL.Begin(GL.LINES);
            GL.Vertex(new Vector3(Mathf.Cos(0) * radius + center.x, 0));
            GL.Vertex(new Vector3(Mathf.Cos(0) * radius + center.x, radius * 2));

            GL.Vertex(new Vector3(Mathf.Cos(0) * -radius + center.x, 0));
            GL.Vertex(new Vector3(Mathf.Cos(0) * -radius + center.x, radius * 2));

            center.y = 0;

            for (float t = 0.0f; t < Mathf.PI; t += 0.01f)
            {
                Vector3 ci = (new Vector3(Mathf.Cos(t) * -radius + center.x, Mathf.Sin(t) * (-radius / 2) + center.y, center.z));
                GL.Vertex3(ci.x, ci.y, ci.z);
            }
            GL.End();
        }

        private void drawEllipse(float radius, Vector3 center)
        {
            for (float t = 0.0f; t < (Mathf.PI * 2); t += 0.01f)
            {
                Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * (radius / 2) + center.y, center.z));
                GL.Vertex3(ci.x, ci.y, ci.z);
            }
        }

        private void drawSemicircle(float radius, Vector3 center, float begin, float end)
        {

            GL.Begin(GL.LINES);

            for (float t = begin; t < end; t += 0.01f)
            {
                Vector3 ci = (new Vector3(Mathf.Cos(t) * radius + center.x, Mathf.Sin(t) * radius + center.y, center.z));
                GL.Vertex3(ci.x, ci.y, ci.z);
            }
            GL.End();
        }

    
        private void drawLine(float startX, float startY, float endX, float endY)
        {

            GL.Begin(GL.LINES);

            GL.Vertex(new Vector3(startX, startY, 0));
            GL.Vertex(new Vector3(endX, endY, 0));

            GL.End();
        }

        //endregion

    }