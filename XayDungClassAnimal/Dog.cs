namespace XayDungClassAnimal
{
    public class Dog : Animal
    {
        private string name;
        private string color;
        public Dog(float weigth, float height,string name, string color) : base(weigth, height)
        {
            this .name = name;
            this .color = color;
        }

        protected override void Show()
        {
            Console.WriteLine(name + " " + color);
            name.ToString();
        }
    }
}
