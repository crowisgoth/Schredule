using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace College
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Schredule schredule = new Schredule();
            schredule.saveInFile();
            schredule.readFile();
            Console.ReadLine();
            //Расписание, кабинеты, имена преподавателей,
            //Список учеников, список своих занятий,количество рабочих часов 
        }
        
    }
    class Schredule
    {
        static string path = @"D:\C#_Projects\College\College\Data\Schredule.json";
        FileInfo fs = new FileInfo(path);
        
        
        private Dictionary<string, string> schredule = new Dictionary<string, string>() {
            { "key","value" },
            { "key1", "value" },
            { "key2", "value" }, 
            { "key3", "value" }, 
            { "key4", "value" } 
        };
        void change(Dictionary<string, string> updatedSchredule)
        {
            
            schredule = updatedSchredule;
            
        }
        Dictionary<string, string> get()
        {
            return schredule;
        }

       public void saveInFile()
        {

            using (fs.Create()) ;
            string json = JsonConvert.SerializeObject(schredule, Formatting.Indented);
            File.AppendAllText(path, json);
            
            
            
           

        }
        public void readFile()
        {
            

            string json = File.ReadAllText(path);
            
            schredule = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            Console.WriteLine(schredule["key"]);

        }
    }
  
}
