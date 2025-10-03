namespace LibraryApp
{
    public class Reader
    {
        private string name;
        private int id;

        public Reader(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string GetName() => name;
        public int GetId() => id;
    }
}

