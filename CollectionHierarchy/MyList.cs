namespace CollectionHierarchy
{
    using System.Collections.Generic;
    public class MyList : IAddCollection, IAddRemoveCollection, IMyList
    {
        private readonly List<string> data;
        public MyList(int size)
        {
            data = new(size);
        }
        public int Used => data.Count;

        public int Add(string item)
        {
            data.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            string first = data[0];
            data.RemoveAt(0);
            return first;
        }
    }
}
