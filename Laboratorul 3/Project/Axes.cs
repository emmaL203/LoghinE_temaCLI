using System;
using System.Collections.Generic;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Graphics;



namespace Project
{
    public class Axes
    {

        private bool _visibility;
        private float _axeSize;
        private Color _xColor;
        private Color _yColor;
        private Color _zColor;

        public Axes()
        {
            _axeSize = 200;

            _xColor = Color.CornflowerBlue;
            _yColor = Color.ForestGreen;
            _zColor = Color.IndianRed;

            _visibility = true;
        }

        public bool GetVisibility()
        {
            return _visibility;
        }

        public void Show()
        {
            _visibility = true;
        }

        public void Hide()
        {
            _visibility = false;
        }


        //laboratorul 3
        public void Draw()
        {

            if (!_visibility)
            {
                return;
            }

            
            GL.LineWidth(25);

            GL.Begin(PrimitiveType.Lines);

            // X
            GL.Color3(_xColor);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(_axeSize, 0, 0);

            // Y
            GL.Color3(_yColor);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, _axeSize, 0);

            // Z
            GL.Color3(_zColor);
            GL.Vertex3(0, 0, 0);
            GL.Vertex3(0, 0, _axeSize);

            GL.End();
        }
    }
}
