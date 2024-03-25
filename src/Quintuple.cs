public class Quintuple<T1, T2, T3> 
{
    public T1 T1Value { get; set; }
    public T2 T2Value { get; set; }
    public T3 T3Value { get; set; }


    public Quintuple(T1 t1, T2 t2, T3 t3)
    {
        T1Value = t1;
        T2Value = t2;
        T3Value = t3;
    }
}