﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AAStudio
{
    public partial class DrawingArea : UserControl
    {
        #region "Private members"
        private ArtSprite _sprite;

        private bool _showGrid;
        private int _gridSize;

        private DrawingTools _currentTool = DrawingTools.None;

        private Brush brushGridDark1 = new SolidBrush(Color.FromArgb(50, 50, 50));
        private Brush brushGridLight1 = new SolidBrush(Color.FromArgb(100, 100, 100));
        private Brush brushGridDark2 = new SolidBrush(Color.FromArgb(75, 75, 75));
        private Brush brushGridLight2 = new SolidBrush(Color.FromArgb(150, 150, 150));
        private Brush brushNoGrid = new SolidBrush(Color.FromArgb(0, 0, 0));
        private Brush brushPixel = new SolidBrush(Color.FromArgb(255, 255, 255));
        private Brush brushTemp = new SolidBrush(Color.Pink);

        private int _topX, _topY, _scale, _x0, _y0, _x1, _y1;
        bool _pressedLeft, _pressedRight, _pressed;

        private Stack<BitArray> _undo = new Stack<BitArray>();
        private Stack<BitArray> _redo = new Stack<BitArray>();

        #endregion

        #region "Constructors"
        public DrawingArea()
        {
            InitializeComponent();
        }
        #endregion

        #region "Events"
        public event MouseMovedHandler OnMouseMoved;
        public event NotifyHandler OnNotify;
        #endregion

        #region "Custom event handlers"
        private void PictureChangedHandler(object sender, OnPictureChangeEventArgs e)
        {
            Refresh();
        }
        #endregion

        #region "Control event handlers"
        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            int x, y;
            int minX, maxX, minY, maxY;
            List<Point> points;

            if (DesignMode)
                return;

            minX = Math.Min(_x0, _x1);
            maxX = Math.Max(_x0, _x1);
            minY = Math.Min(_y0, _y1);
            maxY = Math.Max(_y0, _y1);

            if (OnNotify != null)
                OnNotify(this, new OnNotifyEventArgs("DrawingArea", Properties.Resources.MSG_DRAWING_REFRESH));

            e.Graphics.Clear(Color.FromKnownColor(KnownColor.AppWorkspace));

            if (_sprite == null)
                return;

            // ===============================================================
            // === Draw the background
            // ===============================================================
            // Determine the scale factor for a 128x64 sprite
            x = Width / 128;
            y = Height / 64;
            _scale = Math.Min(x, y);
            // Center the sprite depending on its real size
            _topX = (Width - _sprite.Width * _scale) / 2;
            _topY = (Height - _sprite.Height * _scale) / 2;

            if (_showGrid == true)
                for (x = 0; x < _sprite.Width; x++)
                    for (y = 0; y < _sprite.Height; y++)
                        if (_sprite.GetPixel(x, y) == true)
                            e.Graphics.FillRectangle(brushPixel, _topX + x * _scale, _topY + y * _scale, _scale, _scale);
                        else
                            e.Graphics.FillRectangle(
                                (((x / _gridSize + y / _gridSize) % 2 == 0) ? (((x + y) % 2 == 0) ? brushGridDark1 : brushGridLight1) : (((x + y) % 2 == 0) ? brushGridDark2 : brushGridLight2)),
                                _topX + x * _scale,
                                _topY + y * _scale,
                                _scale,
                                _scale);
            else
            {
                e.Graphics.FillRectangle(brushNoGrid, _topX, _topY, _sprite.Width * _scale, _sprite.Height * _scale);

                for (x = 0; x < _sprite.Width; x++)
                    for (y = 0; y < _sprite.Height; y++)
                        if (_sprite.GetPixel(x, y) == true)
                            e.Graphics.FillRectangle(brushPixel, _topX + x * _scale, _topY + y * _scale, _scale, _scale);
            }

            if (_pressed)
                switch (_currentTool)
                {
                    case DrawingTools.DrawLine:
                        points = drawLine(_x0, _y0, _x1, _y1);

                        foreach (Point point in points)
                        {
                            e.Graphics.FillRectangle(
                                brushTemp,
                                _topX + point.X * _scale, _topY + point.Y * _scale, _scale, _scale);
                        }
                        break;
                    case DrawingTools.DrawRect:
                        points = drawRect(minX, minY, maxX, maxY);
                        foreach (Point point in points)
                        {
                            e.Graphics.FillRectangle(
                                brushTemp,
                                _topX + point.X * _scale, _topY + point.Y * _scale, _scale, _scale);
                        }
                        break;
                    case DrawingTools.DrawFilledRect:
                        e.Graphics.FillRectangle(
                            brushTemp,
                            _topX + minX * _scale,
                            _topY + minY * _scale,
                            ((maxX - minX) + 1) * _scale,
                            ((maxY - minY) + 1) * _scale);
                        break;
                }
        }

        private void DrawingArea_Load(object sender, EventArgs e)
        {
            _gridSize = Properties.Settings.Default.GridSize;
        }

        private void DrawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            if ((_sprite != null) &&
                (e.X >= _topX) &&
                (e.X <= _topX + _sprite.Width * _scale) &&
                (e.Y >= _topY) &&
                (e.Y <= _topY + _sprite.Height * _scale))
            {
                _pressedLeft = (e.Button == MouseButtons.Left);
                _pressedRight = (e.Button == MouseButtons.Right);
                _pressed = _pressedLeft | _pressedRight;

                // Set x, y coordinates
                _x0 = (e.X - _topX) / _scale;
                _y0 = (e.Y - _topY) / _scale;

                DrawingArea_MouseMove(sender, e); // Force move
            }
        }

        private void DrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            List<Point> points;
            int minX, maxX, minY, maxY;

            if (_currentTool != DrawingTools.None)
            {
                _undo.Push((BitArray)_sprite.Data.Clone());
                _redo.Clear();

                minX = Math.Min(_x0, _x1);
                maxX = Math.Max(_x0, _x1);
                minY = Math.Min(_y0, _y1);
                maxY = Math.Max(_y0, _y1);

                switch (_currentTool)
                {
                    case DrawingTools.DrawLine:
                        points = drawLine(_x0, _y0, _x1, _y1);
                        foreach (Point point in points)
                            _sprite.SetPixel(point.X, point.Y, _pressedLeft, false);
                        _sprite.ForceRefresh();
                        break;
                    case DrawingTools.DrawRect:
                        //                        points = drawRect(_x0, _y0, _x1, _y1);
                        points = drawRect(minX, minY, maxX, maxY);
                        foreach (Point point in points)
                            _sprite.SetPixel(point.X, point.Y, _pressedLeft, false);
                        _sprite.ForceRefresh();
                        break;
                    case DrawingTools.DrawFilledRect:
                        for (int x = minX; x <= maxX; x++)
                            for (int y = minY; y <= maxY; y++)
                                _sprite.SetPixel(x, y, _pressedLeft, false);
                        break;
                }
            }

            _pressedLeft = false;
            _pressedRight = false;
            _pressed = false;

            if (_sprite != null)
                _sprite.ForceRefresh();
        }

        private void DrawingArea_MouseMove(object sender, MouseEventArgs e)
        {

            if ((_sprite != null) &&
                (e.X >= _topX) &&
                (e.X <= _topX + _sprite.Width * _scale) &&
                (e.Y >= _topY) &&
                (e.Y <= _topY + _sprite.Height * _scale))
            {
                switch (_currentTool)
                {
                    case DrawingTools.DoSelect:
                    case DrawingTools.DrawPixel:
                    case DrawingTools.DrawLine:
                    case DrawingTools.DrawRect:
                    case DrawingTools.DrawFilledRect:
                        Cursor = Cursors.Cross;
                        break;
                    case DrawingTools.DoMove:
                        Cursor = Cursors.SizeAll;
                        break;
                    default:
                        Cursor = Cursors.Default;
                        break;
                }

                if (_pressed)
                {
                    _x1 = (e.X - _topX) / _scale;
                    _y1 = (e.Y - _topY) / _scale;

                    if (_pressed)
                        switch (_currentTool)
                        {
                            case DrawingTools.DrawPixel:
                                _sprite.SetPixel(_x1, _y1, _pressedLeft);
                                break;
                        }
                    Refresh();
                }
                else
                {
                    _x0 = (e.X - _topX) / _scale;
                    _y0 = (e.Y - _topY) / _scale;
                    _x1 = (e.X - _topX) / _scale;
                    _y1 = (e.Y - _topY) / _scale;
                }


                OnMouseMoved(this, new OnMouseMoveEventArgs(_pressed, _x0, _y0, _x1, _y1));
            }
            else
            {
                if (_pressed == false)
                {
                    // Set x, y coordinates
                    _x0 = -1;
                    _y0 = -1;
                    _x1 = -1;
                    _y1 = -1;
                }
                OnMouseMoved(this, new OnMouseMoveEventArgs(_pressed, _x0, _y0, _x1, _y1));
            }
        }
        #endregion

        #region "Methods"
        private List<Point> drawLine(int x1, int y1, int x2, int y2)
        {
            List<Point> rc;
            float xA, xB, yA, yB, m, p;
            int minX, maxX, minY, maxY;

            rc = new List<Point>();

            if (x1 <= x2)
            {
                xA = (float)x1;
                yA = (float)y1;
                xB = (float)x2;
                yB = (float)y2;
            }
            else
            {
                xA = (float)x2;
                yA = (float)y2;
                xB = (float)x1;
                yB = (float)y1;
            }

            // Compute the equation of the line 2 points A(xA, yA) and B(xB, yB)
            // Y = mX + p where
            //      m = (yB - yA) / (xB - xA)
            //      p = yA - m * xA (or yB - m * xB)
            if ((xB - xA) == 0)
            {
                minY = Math.Min(y1, y2);
                maxY = Math.Max(y1, y2);
                for (int y = minY; y <= maxY; y++)
                    rc.Add(new Point(x1, y));
            }
            else
            {
                m = (yB - yA) / (xB - xA);
                p = yA - m * xA;

                //System.Diagnostics.Debug.WriteLine(String.Format("A({0}, {1}), B({2}, {3}) -> Y = ({4})X + ({5})",
                //    xA, yA, xB, yB, m, p));

                minX = Math.Min(x1, x2);
                maxX = Math.Max(x1, x2);
                for (int x = minX; x <= maxX; x++)
                    rc.Add(new Point(x, (int)(m * x + p)));
            }
            return rc;
        }

        private List<Point> drawRect(int x1, int y1, int x2, int y2)
        {
            List<Point> rc;

            rc = new List<Point>();

            for (int x = x1; x <= x2; x++)
            {
                rc.Add(new Point(x, y1));
                rc.Add(new Point(x, y2));
            }

            for (int y = y1; y <= y2; y++)
            {
                rc.Add(new Point(x1, y));
                rc.Add(new Point(x2, y));
            }

            return rc;
        }

        public void Undo()
        {
            if (_undo.Count != 0)
            {
                // Save the current state in the Redo queue
                _redo.Push((BitArray)_sprite.Data.Clone());

                // Pop the last state
                _sprite.Restore(_undo.Pop());

                Refresh();
            }
        }

        public void Redo()
        {
            if (_redo.Count != 0)
            {
                // Save the current state in the Undo queue
                _undo.Push((BitArray)_sprite.Data.Clone());

                // Restore the state
                _sprite.Restore(_redo.Pop());

                Refresh();
            }
        }
        #endregion

        #region "Properties"
        public ArtSprite Sprite
        {
            get
            {
                return _sprite;
            }

            set
            {
                if (DesignMode)
                    return;
                if (_sprite != value)
                {
                    if (_sprite != null)
                        _sprite.OnPictureChanged -= PictureChangedHandler;

                    _sprite = value;
                    _undo.Clear();
                    _redo.Clear();

                    if (_sprite != null)
                        _sprite.OnPictureChanged += PictureChangedHandler;

                    Refresh();
                }
            }
        }

        public bool ShowGrid
        {
            get
            {
                return _showGrid;
            }

            set
            {
                if (_showGrid != value)
                {
                    _showGrid = value;
                    Refresh();
                }
            }
        }

        public DrawingTools CurrentTool
        {
            get
            {
                return _currentTool;
            }

            set
            {
                if (_currentTool != value)
                {
                    _currentTool = value;
                }
            }
        }
        #endregion

    }
}
