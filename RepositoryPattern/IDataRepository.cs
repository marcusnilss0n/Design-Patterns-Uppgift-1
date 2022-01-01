namespace Design_Patterns_Assignment.RepositoryPattern
{
    public interface IDataRepository
    {
        public string GetAllData(string inputString);

        public void SaveData(string data);
    }
}