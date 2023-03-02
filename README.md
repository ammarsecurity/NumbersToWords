# NumbersToWords

[![NuGet Version](https://img.shields.io/nuget/v/NTWConverter.svg)](https://www.nuget.org/packages/NTWConverter)
[![NuGet Downloads](https://img.shields.io/nuget/dt/NTWConverter.svg)](https://www.nuget.org/packages/NTWConverter)

This is a simple C# class that converts numbers to words in different languages. Currently, it supports English, French, and Arabic.

## Usage
Instantiate an instance of the NumbersToWords class, and then call its Convert method with the number to convert and the language code as parameters. The method will 
return a string that represents the number in words.


```csharp
NTWConverter nt = new NTWConverter();
string enWords = nt.Convert(123456, "en");  // one hundred and twenty-three thousand four hundred and fifty-six
string arWords = nt.Convert(123456, "ar");  // مائة وثلاثة وعشرون ألفًا وأربعمائة وستة وخمسون
string frWords = nt.Convert(123456, "fr");  // cent vingt-trois mille quatre cent cinquante-six
```

## Supported Languages

## The following languages are currently supported:

1. English ("en")
2. French ("fr")
3. Arabic ("ar")

## Contributing
If you find any issues or have suggestions for improvement, please feel free to open an issue or submit a pull request.

## Developer Information
This class was developed by Ammar Rashad in 2023. If you need any support or have any questions, you can reach out to him at +9647830200030 or through his LinkedIn profile: https://www.linkedin.com/in/ammar-alasafer-b2933415a/
