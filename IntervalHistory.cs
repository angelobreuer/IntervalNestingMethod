namespace IntervalNestingMethod
{
    public sealed class IntervalHistory
    {
        public double A1 { get; private set; }

        public double A2 { get; private set; }

        public double A3 { get; private set; }

        public double B1 { get; private set; }

        public double B2 { get; private set; }

        public double B3 { get; private set; }

        public void Push(double a, double b)
        {
            A1 = A2;
            A2 = A3;
            A3 = a;

            B1 = B2;
            B2 = B3;
            B3 = b;
        }

        public override string ToString() => $"[\nA1: {A1},\nA2: {A2},\nA3: {A3},\nB3: {B3},\nB2: {B2},\nB1: {B1}\n]";
    }
}
