namespace CollectionHierarchy
{
    using System.Collections.Generic;
    public class AddRemoveCollection : IAddCollection, IAddRemoveCollection
    {
        private readonly List<string> data;
        public AddRemoveCollection(int size)
        {
            data = new(size);
        }
        public int Add(string item)
        {
            data.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            string last = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return last;
        }
    }
}
