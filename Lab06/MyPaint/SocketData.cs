using System;
using System.Drawing;

namespace MyPaint
{
    [Serializable]
    class SocketData
    {
        private Color penColor;
        private int width;
        private Point oldPos;
        private Point currentPos;

        public Color PenColor { get => penColor; set => penColor = value; }
        public int Width { get => width; set => width = value; }
        public Point OldPos { get => oldPos; set => oldPos = value; }
        public Point CurrentPos { get => currentPos; set => currentPos = value; }

        public SocketData(Color penColor, int width, Point oldPos, Point currentPos)
        {
            this.PenColor = penColor;
            this.Width = width;
            this.OldPos = oldPos;
            this.CurrentPos = currentPos;
        }
    }
}
