using System;

class Program
{
    static void Main()
    {
        double numberPictures = int.Parse(Console.ReadLine());
        double filterTime = int.Parse(Console.ReadLine());//time need to filter the pictures
        double filterFactor = int.Parse(Console.ReadLine());//good pictures can be uploded in persentage
        double timeForUpload = int.Parse(Console.ReadLine());//time needet each picture to be uploaded

        int goodPictures = (int)Math.Ceiling(numberPictures * filterFactor / 100);
        double timeInsecondsForFilter = filterTime * numberPictures;
        double timeToUploadGoodPictures = goodPictures * timeForUpload;
        double totalTimeSeconds = timeInsecondsForFilter + timeToUploadGoodPictures;


        TimeSpan t = TimeSpan.FromSeconds(Convert.ToDouble(totalTimeSeconds));
        Console.WriteLine(t.ToString(@"d\:hh\:mm\:ss"));
    }
}

