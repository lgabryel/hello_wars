﻿using System.Drawing;
using System.Windows.Media;
using Common.Models;
using Game.CubeClash.Enums;

namespace Game.CubeClash.ViewModels
{
    public class MissileViewModel : BindableBase
    {
        private int _x;
        private int _range;
        private int _y;
        private SolidColorBrush _color;
        private ImageSource _image;
        private ActionDirections _direction;
        private int _heigth;
        private int _width;
        private int _angle;

        public int Width
        {
            get { return _width; }
            set { SetProperty(ref _width, value); }
        }

        public int Heigth
        {
            get { return _heigth; }
            set { SetProperty(ref _heigth, value); }
        }

        public ImageSource Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }

        public SolidColorBrush Color
        {
            get { return _color; }
            set { SetProperty(ref _color, value); }
        }

        public ActionDirections Direction
        {
            get { return _direction; }
            set { SetProperty(ref _direction, value); }
        }

        public int Range
        {
            get { return _range; }
            set { SetProperty(ref _range, value); }
        }

        public int X
        {
            get { return _x; }
            set { SetProperty(ref _x, value); }
        }

        public int Y
        {
            get { return _y; }
            set { SetProperty(ref _y, value); }
        }

        public int Angle
        {
            get { return _angle; }
            set { SetProperty(ref _angle, value); }
        }
    }
}
