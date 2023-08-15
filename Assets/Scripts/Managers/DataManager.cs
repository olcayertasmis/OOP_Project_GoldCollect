using DataSystem;
using SingletonSystem;
using UnityEngine;

public class DataManager : Singleton<DataManager>
{
    [SerializeField] private PlayerData playerData;

    public PlayerData PlayerData => playerData;
}