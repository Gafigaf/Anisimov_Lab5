namespace Lab_5_task1
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }
        public int Capacity { get; set; }

        public abstract void Move();
    }
}