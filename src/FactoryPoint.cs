public class FactoryPoint
{
    int _numberOfPoints;
    public FactoryPoint(int numberOfPoints)
    {
        _numberOfPoints = numberOfPoints;
    }

    public IEnumerable<Point> CreatePoints()
    {
        var rand = new Random();
        for (int i = 0; i < _numberOfPoints; i++)
        {
            yield return new Point(rand.Next(), rand.Next());
        }
    }

}