using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DB_Load : MonoBehaviour {
	public struct User
	{
		string User_id;
		string User_password;
		string User_name;
		int User_Up_st_lv;
		int User_Up_sp_lv;
		List<int> Character_num;
		public void UserInfo(object User_id,
			object User_password,
			object User_name,
			object User_Up_st_lv,
			object User_Up_sp_lv,
			List<int> Character_num)
		{
			this.User_id = User_id.ToString();
			this.User_password = User_password.ToString();
			this.User_name = User_name.ToString();
			this.User_Up_st_lv = int.Parse(User_Up_st_lv.ToString());
			this.User_Up_sp_lv = int.Parse(User_Up_sp_lv.ToString());
			this.Character_num = Character_num;
			return ;
		}
	};
	public struct Upgrade
	{
		string Up_name;
		int Up_index;
		int Up_price;
		public  void UpInfo(
			object Up_name,
			object Up_index,
			object Up_price)
		{
			this.Up_index = int.Parse(Up_index.ToString());
			this.Up_name = Up_name.ToString();
			this.Up_price = int.Parse(Up_price.ToString());
			return;
		}
	};
	public struct Character
	{
		string char_name;
		int char_grade;
		int char_price;
		int char_number;
		int char_stamina;
		int char_speed;
		public void charInfo(
			object char_name,
			object char_grade,
			object char_price,
			object char_number,
			object char_stamina,
			object char_speed)
		{
			this.char_name = char_name.ToString();
			this.char_grade = int.Parse(char_grade.ToString());
			this.char_price = int.Parse(char_price.ToString());
			this.char_number = int.Parse(char_number.ToString());
			this.char_stamina = int.Parse(char_stamina.ToString());
			this.char_speed = int.Parse(char_speed.ToString());
			return;
		}
	};
	List<User> UserList = new List<User>();
	List<Upgrade> UpList = new List<Upgrade>();
	List<Character> ChList = new List<Character>();
	// Use this for initialization
	void Start () {
		

		List<Dictionary<string,object>> data = CSVReader.Read("User");
		List<int> tempList = new List<int>();
		User user = new User ();
		
		for (var i = 0; i < data.Count; i++) 
		{
			
			for(var j = 0; j < 6; j++)
			{
				tempList.Add(int.Parse(data[i]["Charater_num_"+j.ToString()].ToString()));
			}
			user.UserInfo (data [i] ["User_id"], data [i] ["User_ps"], data [i] ["User_name"],
				data [i] ["User_up_st_lv"],data [i] ["User_up_sp_lv"], tempList);
			UserList.Add (user);
		}

		List<Dictionary<string,object>> Updata = CSVReader.Read ("Upgrade");
		Upgrade Up = new Upgrade ();
		for (var i = 0; i < data.Count; i++) 
		{
			
			Up.UpInfo (data [i] ["Up_name"], data [i] ["Up_index"], data [i] ["Up_price"]);
			UpList.Add (Up);
		}
		List<Dictionary<string,object>> Chdata = CSVReader.Read ("Character");
		Character CharSt = new Character();
		for (var i = 0; i < Chdata.Count; i++) 
		{
			CharSt.charInfo (Chdata [i] ["char_name"], Chdata [i] ["char_grade"], Chdata [i] ["char_price"], 
				Chdata[i]["char_number"],Chdata[i]["char_stamina"],Chdata[i]["char_speed"]);
			ChList.Add (CharSt);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	List<User> Get_UserList(){
		return UserList;
	}

	List<Upgrade> Get_UpList(){
		return UpList;
	}
	List<Character> Get_ChList(){
		return ChList;
	}

	void setUserList()
	{
	}
}
