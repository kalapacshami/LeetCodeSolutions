﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "LVIII";
            //Console.WriteLine(RomanToInt(s)); 

            //IsPalindrome(1001);

            //int[] nums = new int[] { 12, 345, 2, 6, 7896 }; // Input: nums = [1,1,0,1,1,1]
            ////int result=FindMaxConsecutiveOnes(nums);
            ////Console.WriteLine(result);

            //int result = FindNumbers(nums);

            //Console.WriteLine(result);

            //// nums = [-4,-1,0,3,10]
            //int[] nums = { -4, -1, 0, 3, 10 };
            //SortedSquares(nums);
            //foreach (int i in nums) { Console.WriteLine(i); }

            //bool power = IsPowerOfTwo(3);
            //Console.WriteLine(power);
            int[] nums = { 17, 18, 5, 4, 6, 1 };
            int[] nums2 = { 1,2,3,4,5,0,0,0 };
            //DuplicateZeros(nums);
            //foreach (int i in nums) { Console.WriteLine(    i); }

            //Merge(nums,3,nums2,5);

            //TitleToNumber("ZY");

            //int[] result = ReplaceElements(nums);




            //string test = "(){}}{";
            //Console.WriteLine(IsValid(test));

            Console.WriteLine(HammingWeight(00000000000000000000000000001011));

















        }

        public static int LengthOfLastWord(string s)
        {
            
            
            string lastWord = s.TrimEnd();
            lastWord = lastWord.Split(' ').Last();
            return lastWord.Length;



        }

        public static int HammingWeight(uint n)
        {
            CultureInfo provider = new CultureInfo("fr-FR");
            string format = "D5";
            string str = n.ToString(format, provider);
            
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 1)
                {
                    counter += 1;
                }
            }

            return counter;

        }



        //public int SearchInsert(int[] nums, int target) //VISSZATERNI RA LOGARITMIKUS KERESES O(Log n)- be kéri
        //{
        //    int halfindex = nums.Length / 2;
        //    if (nums[halfindex] == target)
        //    {
        //        return halfindex;
        //    }
        //    else if (nums[halfindex] > target) // bal
        //    {

        //        for (int i = 0; i <= halfindex; i++)
        //        {
        //            if (nums[i] == )
        //            {

        //            }
        //        }
        //    }
        //    else if(nums[halfindex] < target) // jobb
        //    {

        //    }
        //    else // nincs benne 
        //    {

        //    }

        //}

        public int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle);
            }
            else
            {
                return -1;
            }
        }


        //Input: nums = [0,1,0,3,12] Output: [1,3,12,0,0]
        public void MoveZeroes(int[] nums)
        {
            int nonZeroIndex = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {

                    int temp = nums[i];
                    nums[i] = nums[nonZeroIndex];
                    nums[nonZeroIndex] = temp;

                    nonZeroIndex++;



                }

            }
        }

        public int[] SortArrayByParity(int[] nums) // nums = [3,1,2,4,5,3,4,5,6,7,7,8]
        {


            int evenIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    
                    int temp = nums[i];
                    nums[i] = nums[evenIndex];
                    nums[evenIndex] = temp;

                    evenIndex++;
                }
            }

            return nums;





        }

        //public int FirstUniqChar(string s) // Input: s = "loveleetcode"
        //{
        //    for (int i = 1; i < s.Length; i++)
        //    {
        //        char ch = s[i-1];

        //    }

        //}

        public bool ContainsDuplicate(int[] nums)
        {
            for (int i = 0;i < nums.Length; i++)
            {
                for (int j = nums.Length-1; j> i ; j--)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
            
        }

        public bool CanWinNim(int n)
        {
            int counter = 0;
            if (n == 1 || n == 2 || n == 3)
            {
                return true;
            }
            else
            {
                do
                {
                    n -= 3;
                    counter++;

                } while (n > 3);

                if (counter % 2 == 0)
                {
                    return true;
                }
                else { return false; }



            }
            //return false;





        }

        public int AddDigits(int num)
        {
            while (num >= 10)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }
            return num;
        }


        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;
                int sum = val1 + val2 + carry;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return dummy.next;



        }













        //public int ClimbStairs(int n) //3 
        //{

        //}

        //public static bool IsIsomorphic(string s, string t) // egg , add
        //{

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for(int j = 0; j < t.Length; j++)
        //        {

        //        }
        //    }
        //}


        public static int[] ReplaceElements(int[] arr) // Input: arr = [17,18,5,4,6,1] Output: [18,6,6,6,1,-1]
        {


            //int last = arr.Length - 1;

            //int max = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    max = arr[i+1];
            //    for (int j = i+1; j < arr.Length; j++)
            //    {
            //        if (arr[j] > max)
            //        {
            //            arr[i] = arr[j];
            //        }
            //    }


            //}
            //arr[last] = -1;
            //return arr;

            int n = arr.Length;
            int maxRight = -1;

            for (int i = n - 1; i >= 0; i--)
            {
                int currentElement = arr[i];
                arr[i] = maxRight; 
                maxRight = Math.Max(maxRight, currentElement);
            }

            return arr;


        }





        public static int TitleToNumber(string columnTitle)
        {
            
            int result = 0;

            foreach (char c in columnTitle)
            {
                int digitValue = c - 'A' + 1;
                result = result * 26 + digitValue;
            }

            return result;
        }

        public bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == 2* arr[j] || arr[j] == 2 * arr[i])
                    {
                        return true;
                    }
                }


            }
            return false;


        }
        public static bool ValidMountainArray2(int[] arr)
        {
            int n = arr.Length;

            
            if (n < 3)
            {
                return false;
            }

            
            int peakIndex = 0;
            while (peakIndex < n - 1 && arr[peakIndex] < arr[peakIndex + 1])
            {
                peakIndex++;
            }

            
            if (peakIndex == 0 || peakIndex == n - 1)
            {
                return false;
            }

            
            for (int i = 0; i < peakIndex; i++)
            {
                if (arr[i] >= arr[i + 1])
                {
                    return false;
                }
            }

            
            for (int i = peakIndex; i < n - 1; i++)
            {
                if (arr[i] <= arr[i + 1])
                {
                    return false;
                }
            }

            return true;


        }

        public static bool ValidMountainArray(int[] arr)
        {

            int max =  arr.Max(); // 5
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                {
                    counter++;
                }
            }

            if (counter == 1)
            {
                for (int i = 0; i < max; i++)
                {
                    if (arr[i] < arr[i+1])
                    {
                        for (int j = max; j < arr.Length; j++)
                        {
                            if (arr[j] > arr[j + 1])
                            {
                                return true;
                            }
                            
                        }
                    }
                    else if ( arr[i] > arr[i + 1])
                    {
                        for (int j = max; j < arr.Length-1; j++)
                        {
                            if (arr[j] < arr[j + 1])
                            {
                                return true;
                            }
                            
                        }
                    }
                    else
                    {
                        return false;
                    }



                }
                return false;



            }
            else
            {
                return false;
            }



        }


        public void SortColors(int[] nums) // 0, 1, 2 red,white, blue
        {
            
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int i = m - 1; 
            int j = n - 1; 
            int k = m + n - 1; 

            
            while (i >= 0 && j >= 0)
            {
                
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }

            
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }



        }

        public static int SingleNumber(int[] nums)
        {
            int result = 0;

            foreach (int num in nums)
            {
                result ^= num;
            }

            return result;
        }





        public static bool IsPowerOfTwo(int n)
        {
            int x = 0;

            while (x < 31)
            {
                Math.Pow(2, x);
                if (Math.Pow(2, x) == n)
                {
                    return true;
                }
                x++;
            }         


            return false;
                        
        }
        

        public static int RemoveElement(int[] nums, int val) //nums = [0,1,2,2,3,0,4,2], val = 2 Output: 5, nums = [0,1,4,0,3,_,_,_]
        {
            int k = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    int temp = nums[k];
                    nums[k] = nums[i];
                    nums[i] = temp;

                    k++;
                }

            }


            return k;
        }

        public static int MySqrt(int x)
        {
            if (x == 0 || x == 1)
                return x;

            long left = 1;
            long right = x;

            while (left <= right)
            {
                long mid = left + (right - left) / 2;
                long square = mid * mid;

                if (square == x)
                    return (int)mid;
                else if (square < x)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return (int)right;


        }


        public int MajorityElement(int[] nums)
        {
            double app = nums.Length / 2;
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               
            }

            return 0;
        }






        public static void DuplicateZeros(int[] arr) //[1,0,2,3,0,4,5,0]
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] ==0)
                {
                    for (int j = arr.Length - 1; j > i; j--)
                    {
                        arr[j] = arr[j-1];
                    }
                    i++;
                }

                
                
            }

        }









        public static int PivotIndex(int[] nums) // [1,7,3,6,5,6]
        {
            if (nums == null || nums.Length == 0)
            {

                return -1;
            }

            int totalSum = 0;
            int leftSum = 0;


            foreach (int num in nums)
            {
                totalSum += num;
            }

            for (int i = 0; i < nums.Length; i++)
            {

                if (leftSum == totalSum - leftSum - nums[i])
                {
                    return i;
                }


                leftSum += nums[i];
            }


            return -1;
        }






        //Determine whether the largest element in the array is at least twice as much as every
        //other number in the array.If it is, return the index of
        //the largest element, or return -1 otherwise  nums = [3,6,1,0]

        public static int DominantIndex(int[] nums)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }

            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                {

                }
                else
                {
                    if (nums[i] * 2 <= max)
                    {

                    }
                    else
                    {
                        return -1;
                    }
                }

            }
            return index;
        }

        public int[] PlusOne(int[] digits) // digits = [4,3,2,1]
        {
            if (digits.Length == 1)
            {
                if (digits[0] == 9)
                {
                    return new int[] { 1, 0 };
                }
                digits[0] += 1;
            }
            int last = digits.Length - 1;
            if (digits[last] == 9)
            {
                digits[last - 1] += 1;
                digits[last] = 0;
            }
            else
            {
                digits[last] += 1;
            }
            return digits;


        }

        public int[] FindDiagonalOrder(int[][] mat)
        {
            if (mat == null || mat.Length == 0 || mat[0].Length == 0)
            {
                return new int[0];
            }

            int m = mat.Length; // 3 oszlop
            int n = mat[0].Length; // 3 sor
            int[] result = new int[m * n]; // 3*3 matrix

            int row = 0, col = 0;

            for (int i = 0; i < m * n; i++)
            {
                result[i] = mat[row][col];
                if ((row + col) % 2 == 0)
                {
                    if (col == n - 1)
                    {
                        row++;
                    }
                    else if (row == 0)
                    {
                        col++;
                    }
                    else
                    {
                        row--;
                        col++;
                    }
                }
                else
                {
                    if (row == m - 1)
                    {
                        col++;
                    }
                    else if (col == 0)
                    {
                        row++;
                    }
                    else
                    {
                        row++; col--;
                    }
                }

            }

            return result;

        }



        public static bool IsPalindrome(int x) // DONE-----------------------------------------------------------------------
        {


            if (x < 0)
            {
                return false;
            }
            string digits = x.ToString();
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != digits[digits.Length - 1 - i]) { return false; }
            }
            return true;
        }

        public int[] TwoSum(int[] nums, int target) // [2,7,11,15], target = 9 DONE----------------------------------------
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }

                }


            }
            return new int[] { 0, 0 };

        }


        public int RemoveDuplicates(int[] nums) // DONE --------------------------------------------------------------------------
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int k = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }

        public static int FindMaxConsecutiveOnes(int[] nums) // Input: nums = [1,1,0,1,1,1] Output: 3
        {
            //int k = 0;
            //int index = 0;
            //int next = index + 1;
            //while (index < nums.Length)
            //{
            //    if (nums[index] == 1)
            //    {

            //    }
            //}

            //int k = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{

            //    for (int j = 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] == 1 && nums[j] == nums[i] )
            //        {
            //            k += 2;
            //        }
            //        else if (nums[i] == 1 && nums[j]==1 && j == nums.Length -1 )
            //        {
            //            k++;
            //        }
            //    }
            //}
            //return k;

            int maxConsecutiveOnes = 0;
            int currentConsecutiveOnes = 0;

            foreach (int num in nums)
            {
                if (num == 1)
                {

                    currentConsecutiveOnes++;
                }
                else
                {

                    maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentConsecutiveOnes);
                    currentConsecutiveOnes = 0;
                }
            }


            maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentConsecutiveOnes);

            return maxConsecutiveOnes;








        }

        public static int RomanToInt(string s) // IVX DONE--------------------------------
        {


            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                int currentV = 0;

                switch (current)
                {
                    case 'I': currentV = 1; break;
                    case 'V': currentV = 5; break;
                    case 'X': currentV = 10; break;
                    case 'L': currentV = 50; break;
                    case 'C': currentV = 100; break;
                    case 'D': currentV = 500; break;
                    case 'M': currentV = 1000; break;
                    default: throw new ArgumentException("Invalid input...");
                }

                if (i < s.Length - 1)
                {
                    char next = s[i + 1];
                    int nextV = 0;
                    switch (next)
                    {
                        case 'I': nextV = 1; break;
                        case 'V': nextV = 5; break;
                        case 'X': nextV = 10; break;
                        case 'L': nextV = 50; break;
                        case 'C': nextV = 100; break;
                        case 'D': nextV = 500; break;
                        case 'M': nextV = 1000; break;
                        default: throw new ArgumentException("Invalid Roman numeral");
                    }
                    if (currentV < nextV)
                    {
                        result -= currentV;
                    }
                    else
                    {
                        result += currentV;
                    }
                }
                else
                {
                    result += currentV;
                }

            }
            return result;

        }

        //I - 1
        //V - 5
        //X - 10
        //L - 50
        //C - 100
        //D - 500
        //M - 1000

        //public string LongestCommonPrefix(string[] strs) // Input: strs = ["flower","flow","flight"] Output: "fl"
        //{
        //    for (int i = 0; i < strs.Length; i++)
        //    {
        //        for (int j = 1; j < strs.Length; j++)
        //        {
        //            if (strs[i])
        //            {

        //            }
        //        }
        //    }
        //}
        public static int FindNumbers(int[] nums) // Input: nums = [12,345,2,6,7896] Output: 2
        {
            
            int evenDigitsCount = 0;

            foreach (int num in nums) //vegigmegy az osszses szamon
            {
                int count = 0;
                int tempNum = num; //tempbe elmentjuk ezt a szamot


                while (tempNum != 0)
                {
                    tempNum /= 10;
                    count++;
                }


                if (count % 2 == 0)
                {
                    evenDigitsCount++;
                }
            }

            return evenDigitsCount;

        }
        public static int[] SortedSquares(int[] nums)
        {
            

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
                
            }
            Array.Sort(nums);
            return nums;    
        }

        public static bool IsValid(string s) // "()[]{}"
        {

            
            
            
            
                

                if (s.Contains("("))
            {
                int index = s.IndexOf("(");
                var nextindex = index + 1;
                if (nextindex >= s.Length || index > s.IndexOf(")"))
                {
                    return false;
                }
                if (s[nextindex] == ')')
                {
                    return true;
                }
                return false;
                    
                
            }
            else if (s.Contains("["))
            {
                int index = s.IndexOf("[");
                var nextindex = index + 1;
                if (nextindex >= s.Length || index > s.IndexOf("]"))
                {
                    return false;
                }
                if (s[nextindex] == ']')
                {
                    return true;
                }
                return false;

            }
            else if (s.Contains("{"))
            {
                int index = s.IndexOf("{");
                var nextindex = index + 1;
                if (nextindex >= s.Length || index > s.IndexOf("}"))
                {
                    return false;
                }
                if (s[nextindex] == '}')
                {
                    return true;
                }
                return false;

            }
            else if (s.Length == 1)
            {
                return false;
            }
                
            
            return false;
            
            



        }








    }
}
