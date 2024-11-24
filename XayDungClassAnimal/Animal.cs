namespace XayDungClassAnimal
{
    public abstract class Animal
    {
        protected float weigth;

        protected float height;

        public Animal(float weigth, float height)
        {
            this.weigth = weigth;
            this.height = height;
        }
        protected abstract void Show();
    }
}
