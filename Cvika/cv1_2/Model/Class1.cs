﻿using System.Text;

namespace Model
{
	public class Class1
	{
		public string Greeting(string name)
		{
			if (name.Length == 0)
				return "Ahoj ";

			string[] names = name.Split(' ');
			for (int i = 0; i < names.Length; i++)
			{
				names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1);
			}

			StringBuilder sb = new StringBuilder();
			foreach (string item in names)
				sb.Append("Ahoj " + item + "\n");

			return sb.ToString();
		}
	}
}
