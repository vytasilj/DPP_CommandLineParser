namespace CommandLineParser.Options
{
    /// <summary>
    /// Boolean option without parameters
    /// </summary>
    public class BoolOption : AbstractOption<bool>
    {
        public BoolOption(string id) : base(id)
        {
        }

        protected override bool CheckValue(bool value)
        {
            return true;
        }
    }
}