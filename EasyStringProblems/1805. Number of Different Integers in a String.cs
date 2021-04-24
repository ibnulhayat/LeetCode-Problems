using System;
using System.Text;

namespace EasyStringProblems
{
	
	class NumDifferentIntegers{

		public int NumDifferentIntegers(string word) {
			
			HashSet<string> hashSet = new HashSet<string>();
			int i = 0;
			while(i < word.Length){
				string number = "";
				while(i<word.Length && word[i] >= '0' && word[i] <= '9'){
					number += word[i];
					i++;
				}
				if(number != ""){
					number = number.TrimStart('0');
					hashSet.Add(number);
				}     
				i++;
			}
			
			return hashSet.Count;
		}
		

	}
}