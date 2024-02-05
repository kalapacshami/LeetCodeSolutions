using System;
using System.Linq;

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
            int[] nums = { 2,3,4,3,2,1};
            int[] nums2 = { 1,2,3,4,5,0,0,0 };
            //DuplicateZeros(nums);
            //foreach (int i in nums) { Console.WriteLine(    i); }

            //Merge(nums,3,nums2,5);

            TitleToNumber("ZY");




        }

        public int ClimbStairs(int n) //3 
        {
            
        }

        //public static bool IsIsomorphic(string s, string t) // egg , add
        //{

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for(int j = 0; j < t.Length; j++)
        //        {

        //        }
        //    }
        //}


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
            if (x < 0)
            {
                throw new ArgumentException("Big no no negativ number");
            }

            double guess = x / 2;

            for (int i = 0; i < 1000; i++) 
            {
                guess = 0.5 * (guess + x / guess);
            }

            return Convert.ToInt32(Math.Floor(guess));


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







    }
}
