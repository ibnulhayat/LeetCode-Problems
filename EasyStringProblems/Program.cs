using System;

namespace EasyStringProblems
{
    class Program
    {
        static void Main(string[] args)
        {
          
            /* 
            if you want to see output Length Of Last Word
            commnet out below two lines(13,14)
            Problem no = 58
            status: done 
             */
            // LengthOfLastWord loflw = new LengthOfLastWord();
            // Console.WriteLine("Length : " +loflw.lengthOfLastWord(input()));

            /* 
            if you want to see output Add Binary
            commnet out below two lines
            Problem no = 67
            status: done 
            */
            /* input string */
            //string stringOne = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
            //string stringTwo = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";
            /* output: 110111101100010011000101110110100000011101000101011001000011011000001100011110011010010011000000000 */
            // AddBinary addbinary = new AddBinary();
            // Console.WriteLine("Add Binary: " + addbinary.addBinary("1010", "1011"));


            /* 
            if you want to see output ValidPalindrome
            commnet out below two lines
            Problem no = 125
            status: done 
            */
            //IsPalindrome Palindrome = new IsPalindrome();
            //Console.WriteLine("Is Palindrome : " + Palindrome.isPalindrome(input()));
            

            /* 
            if you want to see output ReverseString
            commnet out below two lines
            Problem no = 344
            status: done 
            */
            // char[] ch = {'h','e','l','l','o'};
            // ReverseString reverseString = new ReverseString();
            // reverseString.reverseString(ch);

            /* 
            if you want to see output Reverse Vowels String
            commnet out below two lines
            Problem no = 345
            status: done
            */
            // ReverseVowelsString reverseVowels = new ReverseVowelsString();
            // Console.WriteLine("ReverseVowels : " + reverseVowels.reverseVowels(input()));
            

            /* 
            if you want to see output RansomNote
            commnet out below two lines
            Problem no = 383
            status: done 
            */
            //RansomNote ransom = new RansomNote();
            //Console.WriteLine("RansomNote : " + ransom.CanConstruct(input(),input()));

            /* 
            if you want to see output First Uniq Chararacter
            commnet out below two lines
            Problem no = 387
            status: done 
            */
            // FirstUniqCharacter uniqCharacter = new FirstUniqCharacter();
            // Console.WriteLine("Uniq Character : " + uniqCharacter.firstUniqChar(input()));

             
            /* 
            if you want to see output Add Strings
            commnet out below two lines
            Problem no = 415
            status: done 
            */
            // AddStrings addStrings = new AddStrings();
            // Console.WriteLine("Add String : " + addStrings.addStrings(input(), input()));

            /* 
            if you want to see output Number of Segments
            commnet out below two lines
            Problem no = 434
            status: done
            */
            // NumberofSegments numberofSegments = new NumberofSegments();
            // Console.WriteLine("Number of Segments : " + numberofSegments.countSegments(input()));
        

            /* 
            if you want to see output Reverse String II
            commnet out below two lines
            Problem no = 520
            status: done
            */
            // DetectCapital detectcapital = new DetectCapital();
            // Console.WriteLine("detectcapital : " + detectcapital.DetectCapitalUse(input()));
            

            /* 
            if you want to see output ValidPalindromeII
            commnet out below two lines
            Problem no = 680
            status: done 
            */
            //ValidPalindrome validP = new ValidPalindrome();
            //Console.WriteLine("Valid Palindrome : " + validP.validPalindrome2(input()));

            /* 
            if you want to see output MakeGood
            commnet out below two lines
            Problem no = 1544
            status: done 
            */
            //MakeGood makegood = new MakeGood();
            //Console.WriteLine("MakeGood : " + makegood.makeGood2(input()));

            /* 
            if you want to see output Repeated Substring Pattern
            commnet out below two lines
            Problem no = 459
            status: done 
            */
            // SubstringPattern substringPattern = new SubstringPattern();
            // Console.WriteLine("Substring Pattern : " + substringPattern.RepeatedSubstringPattern(input()));

            
             /* 
            if you want to see output Longest Uncommon Subsequence I
            commnet out below two lines
            Problem no = 521
            status: done 
            */
            // LongestUncommonSub longestUncommon = new LongestUncommonSub();
            // Console.WriteLine("ReverseStringII : " + longestUncommon.FindLUSlength(input(),input()));
        
            /* 
            if you want to see output Student Attendance Record
            commnet out below two lines
            Problem no = 551
            status: done 
            */
            // StudentAttendanceRecord studentAttendance = new StudentAttendanceRecord();
            // Console.WriteLine("Student Attendance : " + studentAttendance.CheckRecord(input()));
        

            /* 
            if you want to see output Reverse Words String III
            commnet out below two lines
            Problem no = 557
            status: done 
            */
            // ReverseWordsStringIII reverseStringIII = new ReverseWordsStringIII();
            // Console.WriteLine("ReverseStringII : " + reverseStringIII.ReverseWords(input()));
        
            /* 
            if you want to see output Reverse String II
            commnet out below two lines
            Problem no = 541
            status: done
            */
            // ReverseStringII reverseStringII = new ReverseStringII();
            // Console.WriteLine("ReverseStringII : " + reverseStringII.reverseStr(input(),4));
        

            /* 
            if you want to see output Count Binary Substrings
            commnet out below two lines
            Problem no = 696
            status: not submit now/ on testing 
            */
            CountBinarySubstrings countBinary = new CountBinarySubstrings();
            Console.WriteLine("Count Binary : " + countBinary.countBinarySubstrings(input()));
        
            

            

        }

        public static string input()
        {
            Console.WriteLine("Input string value:");
            string value = Console.ReadLine();
            return value;
        }
        
        public static void output(string message, string value)
        {
            Console.WriteLine(message + " : " + value);
        }
    }
}
