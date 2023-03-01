using System.Diagnostics;
namespace NumbersToWords
{

    /// <summary>
    ///  This class is used to convert numbers to words.
    ///  developer : Ammar Rashad
    ///  year : 2023
    ///  for support : 009647830200030
    ///  linkedin : https://www.linkedin.com/in/ammar-alasafer-b2933415a/
    /// </summary>
 
    public class NumbersToWords
        
{
        public string Convert(int number, string lang)

        {
            if (lang == "en")
            {
                return ConvertNumberEnToWords(number);
            }
            else if (lang == "ar")
            {
                return ConvertNumberArToWords(number);
            }
            else if (lang == "fr")
            {
                return ConvertNumberFrToWords(number);
            }
            else
            {
                return "Language not supported";
            }
         
        }



    static  string[] ones = { "", "واحد", "اثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة", "عشرة", "أحد عشر", "اثنا عشر", "ثلاثة عشر", "أربعة عشر", "خمسة عشر", "ستة عشر", "سبعة عشر", "ثمانية عشر", "تسعة عشر" };
    static string[] tens = { "", "", "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون" };
    static string[] hundreds = { "", "مائة", "مائتان", "ثلاثمائة", "أربعمائة", "خمسمائة", "ستمائة", "سبعمائة", "ثمانمائة", "تسعمائة" };

    static string[] enones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    static string[] entens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

    static string[] frones = { "", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf" };
    static string[] frtens = { "", "", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt", "quatre-vingt-dix" };


    public string ConvertNumberArToWords(int number)
    {

        string words = "";
        if (number == 0)
        {
            words = "صفر";
        }
        else if (number < 0)
        {
            words = "سالب " + ConvertNumberArToWords(Math.Abs(number));
        }

        if ((number / 1000000000) > 0)
        {
            words += ConvertNumberArToWords(number / 1000000000) + " مليار ";
            number %= 1000000000;
        }

        if ((number / 1000000) > 0)
        {
            words += ConvertNumberArToWords(number / 1000000) + " مليون ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += ConvertNumberArToWords(number / 1000) + " ألف ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += hundreds[number / 100] + " ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
            {
                words += "و ";
            }

            if (number < 20)
            {
                words += ones[number];
            }
            else
            {
                words += tens[number / 10];

                if ((number % 10) > 0)
                {
                    words += " و" + ones[number % 10];
                }
            }
        }

        return words;
    }
    public string ConvertNumberEnToWords(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 0)
            return "minus " + ConvertNumberEnToWords(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += ConvertNumberEnToWords(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += ConvertNumberEnToWords(number / 1000) + " thousand ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += ConvertNumberEnToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            if (number < 20)
                words += enones[number];
            else
            {
                words += entens[number / 10];
                if ((number % 10) > 0)
                    words += "-" + enones[number % 10];
            }
        }

        return words;
    }
    public string ConvertNumberFrToWords(int number)
    {
        if (number == 0)
            return "zéro";

        if (number < 0)
            return "moins " + ConvertNumberFrToWords(Math.Abs(number));

        string words = "";

        if ((number / 1000000) > 0)
        {
            words += ConvertNumberFrToWords(number / 1000000) + " million ";
            number %= 1000000;
        }

        if ((number / 1000) > 0)
        {
            words += ConvertNumberFrToWords(number / 1000) + " mille ";
            number %= 1000;
        }

        if ((number / 100) > 0)
        {
            words += ConvertNumberFrToWords(number / 100) + " cent ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "et ";

            if (number < 20)
                words += frones[number];
            else if (number < 70)
            {
                if (number % 10 == 1 || number % 10 == 11)
                    words += frtens[number / 10] + "-et-" + frones[number % 10];
                else
                    words += frtens[number / 10] + "-" + frones[number % 10];
            }
            else if (number < 80)
                words += "soixante-" + ConvertNumberFrToWords(number - 60);
            else
            {
                if (number % 10 == 1 || number % 10 == 11)
                    words += "quatre-vingt-" + ConvertNumberFrToWords(number - 80) + "-et-" + frones[number % 10];
                else
                    words += "quatre-vingt-" + ConvertNumberFrToWords(number - 80) + "-" + frones[number % 10];
            }
        }

        return words;
    }



    }
}



