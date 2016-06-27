namespace WhichShouldYouUse.Benchmarks.Enums.ObjectEnumVsRegular.ObjectEnum
{
    public class StreetTypeObject : StreetType
    {
        public static readonly StreetType Street = new StreetTypeObject(1);
        public static readonly StreetType TownSquare = new StreetTypeObject(2);
        public static readonly StreetType Avenue = new StreetTypeObject(3);
        public static readonly StreetType Roundabout = new StreetTypeObject(4);
        public static readonly StreetType Settlement = new StreetTypeObject(5);
        public static readonly StreetType Square = new StreetTypeObject(6);

        protected StreetTypeObject(int value) : base(value)
        {
        }
    }
}