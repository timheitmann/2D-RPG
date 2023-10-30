using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPersistanceManager : MonoBehaviour {

    [Header("File Storage Config")]
    [SerializeField] private string fileName;
    private GameData gameData;
    private List<IDataPersistance> dataPersistanceObjects;
    private FileDataHandler dataHandler;

    public static DataPersistanceManager instance { get; private set; }

    private void Awake() {
        if (instance != null) {
            Debug.LogError("Found more than one DataPersistanceManager instance:");
        }
        instance = this;
    }

    private void Start() {
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, this.fileName);
        this.dataPersistanceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>().ToList();
        LoadGame();
    }

    public void NewGame() {
        this.gameData = new GameData();
    }

    public void LoadGame() {
        // Load the game data using the data handler
        this.gameData = this.dataHandler.Load();

        // pass the data to other scripts to load their data
        foreach (IDataPersistance dataPersistanceObject in this.dataPersistanceObjects) {
            dataPersistanceObject.LoadData(this.gameData);
        }
    }

    public void SaveGame() {
        // pass the data to other scripts to save their data
        foreach (IDataPersistance dataPersistanceObject in this.dataPersistanceObjects) {
            dataPersistanceObject.SaveData(ref this.gameData);
        }

        // Save the game data using the data handler
        this.dataHandler.Save(this.gameData);
    }

    private List<IDataPersistance> FindAllDatPersistanceObjects() {
        IEnumerable<IDataPersistance> dataPersistanceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistance>();
        return new List<IDataPersistance>(dataPersistanceObjects);
    }

}

