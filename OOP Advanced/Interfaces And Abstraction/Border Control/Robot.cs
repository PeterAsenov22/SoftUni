namespace Border_Control
{
    public class Robot:IEnterable
    {
        public string Model { get; private set; }

        public string ID { get; private set; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.ID = id;
        }
    }
}
