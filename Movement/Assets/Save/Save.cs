using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class Save {

    static string path = Application.persistentDataPath + "/save.fuk"; //what is persistant data path?

    public static void SavePlayerData(PlayerManager player) // serialize
    {
        //refence to binary formatter
        BinaryFormatter formatter = new BinaryFormatter();
        //path to save to
        
        //file stream creat file
        FileStream fs = new FileStream(path, FileMode.Create);

        //dataToSave with player info
        DataToSave data = new DataToSave(player);
        //format and serealize location and data
        formatter.Serialize(fs, data);
        //end
        fs.Close();
    }

    public static DataToSave LoadPlayerData() //desaerialize
    {
        //string path = Application.persistentDataPath + "/save.fuk"; //what is persistant data path?
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(path, FileMode.Open);
            DataToSave data = formatter.Deserialize(fs) as DataToSave;
            fs.Close();
            return data;

        }
        else
        {
            Debug.Log("Could not find data to load");
            return null;
        }

        
    }

}
