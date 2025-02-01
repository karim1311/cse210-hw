using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        // Video
        // Responsibilities
        // Track the title, author, and length in seconds
        // Also has responsibility to store a list of comments, and should have a method to return the number
        // of comments. A comment should be defined by the Comment class which has the responsibility for tracking
        // both the name of the person who made the comment and the text of the comment.
        // What are candidates for classes?
        // Video and Comment
        // 3.- What are the responsibilities of each class?
        // For the Video class, its responsibility is to store the video information
        // Title, Author and length in seconds and has a list of Comments, and should return number of comments
        // For the Comment class its responsibility is tracking the name of the person who commented and the text of the comment
        // display the comment with author and text

        // Create a list of video objects
        List<Video> videosList = new List<Video>();

        Video video1 = new Video("Jumpsuit","Twenty One Pilots",298);

        video1.AddComment("cfox6456","Nearly a year already, I remember watching the video for the first time and being full of excitement for Trench like it was yesterday.");
        video1.AddComment("joshuastewart5714","Let’s be honest all of TØPs songs don’t feel as old as they really are");
        video1.AddComment("Luluhzinha27","I can't wait for the new album, my anxiety is hitting me hard, I need you soon!");





        Video video2 = new Video("Strawberry Fields Forever","The Beatles",263);

        video2.AddComment("dc37wwe2kmods","Fun Fact: The final song is actually 2 takes combined. From the first chorus to the first verse, John sang it normally. In the second chorus and onwards however, John sang the song on a faster tempo and higher key (different take). John liked both versions so much that he decided to use them both and told the engineers to do whatever they can to fuse the two different takes. This task however is very complicated since recordings on those times were done on tape unlike digitally today. So the engineers figured out to slow the second take to match the first take. In doing so it also changes the pitch of the second take and matched the first one. That is why on the second chorus onwards, John's voice sounded a bit different. Cheers! EDIT: The transition from the first take to the second one is in the second chorus at the 'cause I'm going to line. It's on 1:00");
        video2.AddComment("DinnySkip","A masterpiece. Revisiting The Beatles every now and again and being reminded how much they were the greatest band to ever exist.");
        video2.AddComment("Luluhzinha27","Living is easy with eyes closed - Misunderstanding all you see.\nIt's getting hard to be someone, but it all works out - It doesn't matter much to me\nThose lines are just beautiful on so many levels.");



        Video video3 = new Video("Uncle Albert / Admiral Halsey (Medley)","PAUL McCARTNEY",295);

        video3.AddComment("angelomisterioso","This song is pure genius. So much going on and everything thought up by Paul. Many of his solo songs could have been better, but this one is truly amazing. Another note : I love the effort Paul made with the vocal harmonies in Ram and Wild Life. 3 voice harmonies were such a big part of The Beatles, yet Paul was the only Beatle who put a lot of effort into it in his early solo work. Paul, Denny and Linda sounded really great , at least to my ears.");
        video3.AddComment("major7thsmcgee973","To me, this is the most McCartney-ish McCartney song that's ever been McCartneyed. It's quirky, musical, progressive, dorky and genius.");
        video3.AddComment("richardsiciliano7117","Even John liked this one.");
        video3.AddComment("davidtodora6173","I was in 1st grade when this song came out. I had to hustle to pay for the 45 RPM record. It was .99 cents. I forgot to say, this song has never aged. It is truly a musical masterpiece!");



        // Add videos to the videosList
        videosList.Add(video1);
        videosList.Add(video2);
        videosList.Add(video3);

        foreach(Video video in videosList)
        {
            Console.WriteLine(video.GetDisplayText());
        }

        
    }
}