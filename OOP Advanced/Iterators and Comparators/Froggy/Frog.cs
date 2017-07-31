namespace Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Frog :IEnumerable<int>
    {
        private IList<int> stones;

        public Frog(IList<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            var oddStones = new List<int>();
            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.stones[i];
                }
                else
                {
                    oddStones.Add(this.stones[i]);
                }
            }

            for (int i = oddStones.Count - 1; i >= 0; i--)
            {
                yield return oddStones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
