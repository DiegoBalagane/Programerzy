using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programerzy
{
	class Question
	{
		public string task;
		public string rightAnswer;
		public string wrongAnswer1;
		public string wrongAnswer2;
		public string wrongAnswer3;
		public Question() { }
		public Question(string task_, string rightAnswer_, string wrongAnswer1_, string wrongAnswer2_, string wrongAnswer3_)
		{
			this.task = task_;
			this.rightAnswer = rightAnswer_;
			this.wrongAnswer1 = wrongAnswer1_;
			this.wrongAnswer2 = wrongAnswer2_;
			this.wrongAnswer3 = wrongAnswer3_;
		}
		public bool checkAnswer(string selectedOption)
		{
			if (this.rightAnswer == selectedOption)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
