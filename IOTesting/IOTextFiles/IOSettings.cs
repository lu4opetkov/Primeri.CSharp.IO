using System;

namespace IOTextFiles
{
	public class IOSettings
	{
		private STable _stable;
		public IOSettings (STable stable)
		{
			_stable = stable;
		}
		public bool save()
		{
			try{
				string _temp = "";
				_temp = string.Join("\r\n", _stable.stable);
				System.IO.File.WriteAllText("d://aula//text.txt", _temp);
 				//Запис на текстов файл

				return true;

				}catch{
				}

		return false;

		}
	}
}

