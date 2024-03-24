using tpmodul6_1302223116;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Theo");
        
        /*Untuk uji overflow
        for (int i = 0; i < 123413; i++)
        {
            video.IncreasePlayCount(112390);
            video.IncreasePlayCount(1);
        video.PrintVideoDetails();

    }
}