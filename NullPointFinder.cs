namespace IntervalNestingMethod
{
    using System;

    /// <summary>
    ///     A class used to find null-points.
    /// </summary>
    public sealed class NullPointFinder
    {
        private readonly Func<double, double> _func;

        /// <summary>
        ///     Initializes a new instance of the <see cref="NullPointFinder"/> class.
        /// </summary>
        /// <param name="func">the function used to find the null-points for</param>
        /// <param name="span">the span to find null-points in</param>
        /// <exception cref="ArgumentNullException">
        ///     thrown if the specified <paramref name="func"/> is <see langword="null"/>.
        /// </exception>
        public NullPointFinder(Func<double, double> func, double span = 10000D)
        {
            _func = func ?? throw new ArgumentNullException(nameof(func));

            Maximum = Math.Abs(span);
            Minimum = -Maximum;
        }

        /// <summary>
        ///     Gets the current maximum / right value.
        /// </summary>
        /// <value>the current maximum / right value.</value>
        public double Maximum { get; private set; }

        /// <summary>
        ///     Gets the current minimum / left value.
        /// </summary>
        /// <value>the current minimum / left value.</value>
        public double Minimum { get; private set; }

        /// <summary>
        ///     Gets the current Y-axis offset.
        /// </summary>
        /// <value>the current Y-axis offset.</value>
        public double OffsetY { get; private set; }

        /// <summary>
        ///     Gets the tolerance for the calculation.
        /// </summary>
        /// <value>the tolerance for the calculation.</value>
        public double Tolerance => Math.Abs(Minimum - Maximum);

        /// <summary>
        ///     Gets the next sample.
        /// </summary>
        /// <remarks>
        ///     If <see langword="true"/> was returned invalid values may be returned when trying to
        ///     retrieve samples.
        /// </remarks>
        /// <param name="value">the actual null-point guess</param>
        /// <returns>a value indicating whether the null-point was found.</returns>
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
