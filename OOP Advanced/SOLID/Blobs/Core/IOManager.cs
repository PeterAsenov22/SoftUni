namespace _02.Blobs.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using Factories;
    using Interfaces;

    public class IOManager
    {
        private IList<IBlob> blobs;
        private IWriter writer;

        public IOManager(IWriter writer)
        {
            this.blobs = new List<IBlob>();
            this.writer = writer;
        }

        public void Create(string[] parameters)
        {
            this.BlobsBehave();
            IBlob blob = BlobFactory.CreateNewBlob(parameters);
            this.blobs.Add(blob);
        }

        public void Attack(string[] parameters)
        {
            this.BlobsBehave();
            IBlob attacker = this.blobs.FirstOrDefault(x => x.Name == parameters[0]);
            IBlob target = this.blobs.FirstOrDefault(x => x.Name == parameters[1]);
            attacker.AttackBlob(target);         
        }

        public void Pass(string[] parameters)
        {
        }

        public void Status(string[] parameters)
        {        
            foreach (var blob in this.blobs)
            {
                writer.WriteLine(blob.ToString());
            }
            this.BlobsBehave();
        }

        private void BlobsBehave()
        {
            foreach (var blob in this.blobs)
            {
                blob.Behave();
            }
        }
    }
}
