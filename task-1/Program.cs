string[] arr = new string[] { "html", "css", "js" };
Console.WriteLine("Yazini daxil edin: eyer sizin sehv cavab: 5 olacaqsa o zaman oyunu uduzdunuz => amma doqru cavabinizin sayi 8 olarsa o zaman siz qalib geldiniz. ");

bool continueLoop = true;
int score = 5;
int wrongAnswers = 0;
int correctAnswers = 0;

while (continueLoop)
{
    string input = Console.ReadLine();
    if (arr.Contains(input))
    {
        Thread.Sleep(500);
        score++;
        correctAnswers++;
        Console.WriteLine($"{input} adlı data tapıldı: Cari xal {score}");
        Console.WriteLine($"Sehv cavabların sayı: {wrongAnswers} => doqru cavablarin sayi {correctAnswers}");
        if (correctAnswers >= 8)
        {
            Console.WriteLine($"Qalib geldiniz. {correctAnswers} doqru  => {wrongAnswers} yanlış cavabiniz oldu.");
            continueLoop = false;
        }
    }
    else
    {
        Thread.Sleep(500);
        wrongAnswers++;
        Console.WriteLine($"Melumat tapılmadı: Cari xal {score}");
        Console.WriteLine($"Sehv cavabların sayı: {wrongAnswers} => doqru cavablarin sayi {correctAnswers}");

        if (wrongAnswers >= 5)
        {
            Console.WriteLine($"Uduzdunuz. {wrongAnswers} yanlış => {correctAnswers} doqru cavabiniz oldu.");
            continueLoop = false;
        }
    }
}