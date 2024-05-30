using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{

    static string[] allCharacters = {"Warrior", "Jester", "Bear", "Inventor", "Robot", "Thief", "Witch"};

    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/" + player.name;
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer(Player player)
    {
        string path = Application.persistentDataPath + "/" + player.name;
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

    public static void ClearSave()
    {
        foreach(string character in allCharacters)
        {
            string path = Application.persistentDataPath + "/" + character;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        
    }
}
