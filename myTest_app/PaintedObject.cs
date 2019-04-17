using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace myTest_app
{
    class PaintedObject : ICloneable
    {
        private GraphicsPath path;
        private string composition;
        private Color color;
        private float rotation;
        private float width;
        private float height;
        private Point pointStart;


        public GraphicsPath Path
        {
            get { return path; }
            set { path = value; }
        }
        private Pen pen;

        public Pen @Pen
        {
            get { return pen; }
            set { pen = value; }
        }
        public PaintedObject(Pen pen, GraphicsPath path)
        {
            this.path = path;
            this.pen = pen;
           // path.

        }

        public string Composition
        {
            get { return composition; }
            set { composition = value; }
        }
        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public float Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }
        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        public Point Location
        {
            get { return pointStart; }
            set { pointStart = value; }
        }
       // #region ICloneable Members

        public object Clone()
        {
            return new PaintedObject(this.Pen, this.Path.Clone() as GraphicsPath);
        }

       // #endregion
    }
}
