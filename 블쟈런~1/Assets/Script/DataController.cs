using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {

	private static DataController instance;
	public int m_gold;	//골드



	public static DataController GetInstance ()
	{
		if (instance == null)
		{
			instance = FindObjectOfType<DataController> ();

			if (instance == null) 
			{
				GameObject container = new GameObject ("DataController");
				instance = container.AddComponent<DataController> ();
			}
		}
		return instance;
	}
	//게임 초기화 될 때
	void Awake()
	{
		DontDestroyOnLoad (this);

		//m_gold = PlayerPrefs.GetInt("Gold","0");
	}

	// Use this for initialization
	void Start () {
		//InvokeRepeating ("UpdateLastPlayDate", 0f, 5f);

		//SetloadingFinish (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddGold(int newgold)
	{
		SetGold (m_gold + newgold);	
	}

	public void SubGold(int newgold)
	{
		SetGold (m_gold - newgold);
	}

	public void SetGold(int newgold)
	{
		m_gold = newgold;
		PlayerPrefs.SetString ("Gold", m_gold.ToString ());
	}

	public int GetGold()
	{
		return m_gold;
	}
	/*
	// 게임 데이터를 불러오는 함수
	public object LoadGameData(string dataPath)
	{
		string filePath = Application.persistentDataPath + dataPath;

		if (File.Exists(filePath))
		{
			return DataDeserialize(File.ReadAllBytes(filePath));
		}

		return null;
	}


	// 데이터를 역직렬화하는 함수
	public object DataDeserialize(byte[] buffer)
	{
		BinaryFormatter binFormatter = new BinaryFormatter();
		MemoryStream mStream = new MemoryStream();

		mStream.Write(buffer, 0, buffer.Length);
		mStream.Position = 0;

		return binFormatter.Deserialize(mStream);
	}

	// 게임 데이터를 저장하는 함수
	public void SaveGameData(object data, string dataPath)
	{
		byte[] stream = DataSerialize(data);
		File.WriteAllBytes(Application.persistentDataPath + dataPath, stream);
	}

	// 데이터를 직렬화하는 함수
	public byte[] DataSerialize(object data)
	{
		BinaryFormatter binFormmater = new BinaryFormatter();
		MemoryStream mStream = new MemoryStream();

		binFormmater.Serialize(mStream, data);

		return mStream.ToArray();
	}

	DateTime GetLastPlayDate()
	{
		if (!PlayerPrefs.HasKey("Time"))
		{
			return DateTime.Now;
		}

		string timeBinaryInString = PlayerPrefs.GetString("Time");
		long timeBinaryInLong = Convert.ToInt64(timeBinaryInString);

		return DateTime.FromBinary(timeBinaryInLong);
	}

	void UpdateLastPlayDate()
	{
		PlayerPrefs.SetString("Time", DateTime.Now.ToBinary().ToString());
	}

	private void OnApplicationQuit()
	{
		UpdateLastPlayDate();
	}

	public int TimeAfterLastPlay
	{
		get
		{
			DateTime currentTime = DateTime.Now;
			DateTime lastTime = GetLastPlayDate();

			int subTime = (int)currentTime.Subtract(lastTime).TotalSeconds;
			return subTime;
		}
	}

	public bool GetloadingFinish()
	{
		return loadingFinish;
	}

	public void SetloadingFinish(bool finish)
	{
		loadingFinish = finish;
	}
	*/
}
