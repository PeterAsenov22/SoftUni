namespace Military_Elite
{
    using Military_Elite.Interfaces;

    public class Mission:IMission
    {
        public string CodeName { get; private set; }

        public string State { get; private set; }

        public void CompleteMission()
        {
            this.State = "Finished";
        }

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
