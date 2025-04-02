using System.IO;
using System.Text.Json;



namespace SpotifyVisualizer
{
    public class Class1
    {
        private DataContext dataContext;
        public Class1()
        {
            dataContext = new DataContext();
        }
        
        public void AddData(string path)
        {
           dataContext.AddFromFile(path);
            
        }
        public string Info() 
        {
            return dataContext.InfoString();
        }

    }
}