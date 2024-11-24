namespace XayDungClassAnimal
{
    public class Cat : Animal
    {
        private string name {  get; set; }
        public Cat(float weight, float height, string name):base(weight, height)
        {
            this.name = name;
        }
        protected override void Show()
        {
            Console.WriteLine("" + name);
        }
    }
}
