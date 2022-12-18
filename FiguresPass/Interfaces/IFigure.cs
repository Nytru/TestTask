namespace FiguresPass;

public interface IFigure
{
    public float GetArea();

    public static float GetArea(IFigure figure)
    {
        return figure.GetArea();
    }
}
