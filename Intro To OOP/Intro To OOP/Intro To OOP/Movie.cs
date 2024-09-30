public class Movie
{
    public string MovieName { get; set; }
    public int LenghtOfMovie { get; set; }
    public string DateOfRelease { get; set; }
    public int NoOfStreams { get; set; }    
    public string MovieCategory { get; set; }

    public Movie(string name, int lenght, string release, int noOfStreams, string category)
    {
        MovieName = name;
        LenghtOfMovie = lenght;
        DateOfRelease = release;
        NoOfStreams = noOfStreams;  
        MovieCategory = category;

    }

    public Movie(string name, int lenght, string release, int noOfStreams)
    {
        MovieName = name;
        LenghtOfMovie = lenght;
        DateOfRelease = release;
        NoOfStreams = noOfStreams;

    }
}

