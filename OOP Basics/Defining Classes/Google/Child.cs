namespace Google
{
    public class Child
    {
        private string name;
        private string birthday;

        public Child(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public string BirthDay
        {
            get { return this.birthday; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public override string ToString()
        {
            if (this.name != null)
            {
                return $"{this.name} {this.birthday}";
            }
            else
            {
                return $"";
            }
        }
    }
}
