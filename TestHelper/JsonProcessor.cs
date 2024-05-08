
using DTO;
using Newtonsoft.Json;
using System.Collections;
using TestHelper;



namespace TestUtilHelper
{
    public class JsonProcessor
    {
     
        public static IList LoadProjJson()
        {
             object items = null; 
            String baseDir = ProjectUtil.GetProjectBaseDir();
            using(StreamReader r = new StreamReader(baseDir + "Data-Dir/projdata.json")){
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<IList<AppData>>(json);
                
            }
            return (IList)items;


            //using (StreamReader r = new StreamReader("file.json"))
            //{
            //StreamReader r = new StreamReader("file.json");
            //   string json = r.ReadToEnd();
            //   IList<AppData> items = JsonConvert.DeserializeObject<IList<AppData>>(json);
            //  return items;
            //}

        }

        //public static string LoadUsingTinyJson()
        //{
        //    ////Read it back
        //    //string baseDir = TestUtil.ProjectUtil.GetProjectBaseDir();
        //    //string jsonFile = baseDir + "Data-Dir/projdata.json";
        //    //string fileJson = File.ReadAllText(jsonFile);
        //    //return fileJson;
        //}




        public class getClassType(Type clazz) { 
             
            //object objType = clazz.GetType();
            
            ////object items = null;
            
            //string baseDir = TestUtil.ProjectUtil.GetProjectBaseDir();
            //StreamReader r = new StreamReader(baseDir + "Data-Dir/projdata.json")
            //string json = r.ReadToEnd();
            //var items = JsonConvert.DeserializeObject< typeof(clazz)>(json);

            
        }



    }
}
