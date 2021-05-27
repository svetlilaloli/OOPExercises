namespace CollectionHierarchy
{
    using System.Collections.Generic;
    public class AddCollection : IAddCollection
    {
        private readonly List<string> data;
        public AddCollection(int size)
        {
            data = new(size);
        }
        public int Add(string item)
        {
            data.Add(item);
            return data.Count - 1;
        }
    }
}
