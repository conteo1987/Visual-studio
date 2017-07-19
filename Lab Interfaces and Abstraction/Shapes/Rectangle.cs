using System;

public class Rectangle : IDrawable
{


    private int height;
    private int width;

    public int Height
    {
        get { return height; }
        protected set { height = value; }
    }

    public int Width
    {
        get { return width; }
        protected set { width = value; }
    }

    public Rectangle(int height, int width)
    {
        this.Height = height;
        this.Width = width;
    }



    public void Draw()
    {
        DrawLine(this.Width, '*', '*');
        for (int i = 1; i < this.Height - 1; ++i)
            DrawLine(this.Width, '*', ' ');
        DrawLine(this.Width, '*', '*');
    }
    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i < width - 1; ++i)
            Console.Write(mid);
        Console.WriteLine(end);

    }
}
