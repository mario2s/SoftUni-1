﻿using System;

public class Box
{
    private double _length;
    private double _width;
    private double _height;

    public double Length
    {
        get => this._length;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }

            this._length = value;
        }
    }

    public double Width
    {
        get => this._width;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }

            this._width = value;
        }
    }

    public double Height
    {
        get => this._height;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }

            this._height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double SurfaceArea()
    {
        return 2 * (this.Length * this.Width + this.Length * this.Height + this.Width * this.Height);
    }

    public double LateralSurfaceArea()
    {
        return 2 * this.Height * (this.Length + this.Width);
    }

    public double Volume()
    {
        return this.Length * this.Width * this.Height;
    }
}