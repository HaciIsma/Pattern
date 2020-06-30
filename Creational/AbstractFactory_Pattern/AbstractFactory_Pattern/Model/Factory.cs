namespace AbstractFactory_Pattern.Model
{
    public class Factory
    {
        public BenzineVerchile BenzineVerchile { get; } = new BenzineVerchile();
        public ElectricVerchile ElectricVerchile { get; } = new ElectricVerchile();
    }
}
