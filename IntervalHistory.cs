namespace IntervalNestingMethod
{
    /// <summary>
    ///     A history used to store two values with a history capacity of 3 values.
    /// </summary>
    public sealed class IntervalHistory
    {
        /// <summary>
        ///     Gets the primary history entry for A.
        /// </summary>
        /// <value>the primary history entry for A.</value>
        public double A1 { get; private set; }

        /// <summary>
        ///     Gets the secondary history entry for A.
        /// </summary>
        /// <value>the secondary history entry for A.</value>
        public double A2 { get; private set; }

        /// <summary>
        ///     Gets the tertiary history entry for A.
        /// </summary>
        /// <value>the tertiary history entry for A.</value>
        public double A3 { get; private set; }

        /// <summary>
        ///     Gets the primary history entry for B.
        /// </summary>
        /// <value>the primary history entry for B.</value>
        public double B1 { get; private set; }

        /// <summary>
        ///     Gets the secondary history entry for B.
        /// </summary>
        /// <value>the secondary history entry for B.</value>
        public double B2 { get; private set; }

        /// <summary>
        ///     Gets the tertiary history entry for B.
        /// </summary>
        /// <value>the tertiary history entry for B.</value>
        public double B3 { get; private set; }

        /// <summary>
        ///     Pushes a new value to the history.
        /// </summary>
        /// <param name="a">the value for A</param>
        /// <param name="b">the value for B</param>
        public void Push(double a, double b)
        {
            A1 = A2;
            A2 = A3;
            A3 = a;

            B1 = B2;
            B2 = B3;
            B3 = b;
        }

        /// <inheritdoc/>
        public override string ToString() => $"[\nA1: {A1},\nA2: {A2},\nA3: {A3},\nB3: {B3},\nB2: {B2},\nB1: {B1}\n]";
    }
}
