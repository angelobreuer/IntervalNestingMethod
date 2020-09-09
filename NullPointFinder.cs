namespace IntervalNestingMethod
{
    using System;

    public sealed class NullPointFinder
    {
        private readonly Func<double, double> _func;

        public NullPointFinder(Func<double, double> func, double span = 10000D)
        {
            _func = func ?? throw new ArgumentNullException(nameof(func));

            Maximum = Math.Abs(span);
            Minimum = -Maximum;
        }

        public double Maximum { get; private set; }

        public double Minimum { get; private set; }

        public double OffsetY { get; private set; }

        public double Tolerance => Math.Abs(Minimum - Maximum);

        public bool NextSample(out double value)
        {
            value = (Minimum + Maximum) / 2.0D;
            OffsetY = _func(value);

            if (_func(Minimum) * OffsetY < 0.0D)
            {
                Maximum = value;
            }
            else
            {
                Minimum = value;
            }

            return OffsetY == 0.0D;
        }
    }
}
