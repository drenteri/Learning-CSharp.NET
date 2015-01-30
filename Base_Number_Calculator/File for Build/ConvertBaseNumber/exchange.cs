using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertBaseNumber
{
    class exchange
    {
        private const int MAX_DIGIT_ARRAY_TH = 6;//สะหรับภาษาไทยแบ่งกันที่หลักล้าน
        private const int MAX_DIGIT_ARRAY = 4;//สำหรับภาษาอังกฤษแบ่ที่หลักพัน
        private string[] _smallNumbers = new string[] {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        private string[] _tens = new string[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private string[] _scaleNumbers = new string[] { "", "Thousand", "Million", "Billion" };
        
        //สำหรับแปลงเป็นภาษาอังกฤษ
        public string NumberToWords(int number)
        {
            // หากเป็น 0 ให้ค่าแรกไปเลย
            if (number == 0)
                return _smallNumbers[0];
            
            int[] digitGroups = new int[MAX_DIGIT_ARRAY];
            
            // ทำให้เป็นพวกทังหมดก่อนครับ
            int positive = Math.Abs(number);
            for (int i = 0; i < MAX_DIGIT_ARRAY; i++)
            {
                digitGroups[i] = positive % 1000;
                positive /= 1000;
            }
            string[] groupText = new string[MAX_DIGIT_ARRAY];
            for (int i = 0; i < MAX_DIGIT_ARRAY; i++)
                groupText[i] = ThreeDigitGroupToWords(digitGroups[i]);
        
            string combined = groupText[0];
            bool appendAnd;
            appendAnd = (digitGroups[0] > 0) && (digitGroups[0] < 100);
        
            for (int i = 1; i < MAX_DIGIT_ARRAY; i++)
            {
                if (digitGroups[i] != 0)
                {
                    string prefix = groupText[i] + " " + _scaleNumbers[i];
                    if (combined.Length != 0)
                        prefix += appendAnd ? " and " : " ";

                    appendAnd = false;
                    combined = prefix + combined;
                }
            }
            if (number < 0)
                combined = "Negative " + combined;

            return combined;
        }

        private string ThreeDigitGroupToWords(int threeDigits)
        {
            string groupText = "";
            int hundreds = threeDigits / 100;
            int tensUnits = threeDigits % 100;
            if (hundreds != 0)
            {
                groupText += _smallNumbers[hundreds] + " Hundred";
                if (tensUnits != 0)
                    groupText += " and ";
            }
            int tens = tensUnits / 10;
            int units = tensUnits % 10;
            if (tens >= 2)
            {
                groupText += _tens[tens];
                if (units != 0)
                    groupText += " " + _smallNumbers[units];
            }
            else if (tensUnits != 0)
                groupText += _smallNumbers[tensUnits];
            return groupText;
        }
    }
}
