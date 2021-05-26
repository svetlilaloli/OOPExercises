namespace BorderControl
{
    public interface IBuyer
    {
        public string Name { get; }
        public int Age { get; }
        public int Food { get; set; }
        public void BuyFood();
    }
}
