namespace TheStonefox.Test.Zinpipa
{
    using TheStonefox.Test.Mabimbey;

    public class Zinpipifier
    {
        public virtual string Zinpipify()
        {
            Mabimbificator m = new Mabimbificator();
            return "A " + m.Mabimbificate();
        }
    }
}