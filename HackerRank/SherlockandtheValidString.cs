using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class SherlockandtheValidString
    {
        class Result
        {

            /*
             * Complete the 'isValid' function below.
             *
             * The function is expected to return a STRING.
             * The function accepts STRING s as parameter.
             */

            public static string isValid(string s)
            {
                List<char> character = new List<char>();
                List<int> characterNum = new List<int>();
                bool changed = false;
                int comNum = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    if (character.Contains(s[i]))
                    {
                        characterNum[character.IndexOf(s[i])]++;
                    }
                    else
                    {
                        character.Add(s[i]);
                        characterNum.Add(0);
                        characterNum[character.IndexOf(s[i])]++;
                    }

                }

                characterNum.Sort();

                comNum = characterNum[characterNum.Count / 2];

                for (int i = 0; i < characterNum.Count; i++)
                {


                    if (comNum != characterNum[i] && !changed)
                    {
                        characterNum[i]--;
                        changed = true;

                    }



                    if (characterNum[i] == 0)
                        characterNum.RemoveAt(i);


                }

                for (int i = 0; i < characterNum.Count - 1; i++)
                {
                    if (characterNum[i] != characterNum[i + 1])
                    {
                        return "NO";
                    }

                }
                return "YES";
            }

        }

        public class Solution
        {
            public static void Run()
            {


                // string s = "ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd"; //YES
                //string s = "aabbccddeefghi";
                //string s = "abcdefghhgfedecba"; //YES
                // string s = "aabbc"; //YES  
                //string s = "ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd"; //YES
                //string s = "aabbcd"; //No
                //string s = "aaaabbcc"; //No
                string s = "abcdefghhgfedecba"; //YES

                string result = Result.isValid(s);

                Console.WriteLine(result);

            }
        }
    }
}
