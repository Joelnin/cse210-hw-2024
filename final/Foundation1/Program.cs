using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // For Video 1

        string title1 = "Taylor Swift - Love Story (Taylor's Version) [Official Lyric Video]";
        string author1 = "Taylor Swift";
        int lengthSeconds1 = 240;

        // Comment 11 = Comment 1 - Video 1 = Attribute11. And so on.
        string name11 = "@MTV";
        string content11 = "12 YEARS LATER AND THIS IS NOW MY RINGTONE AGAIN";
        Comment comment11 = new Comment(name11, content11);

        string name12 = "@xmermoose";
        string content12 = "Gentle, soft, powerful, strong voice. She's an all in one kind of artist";
        Comment comment12 = new Comment(name12, content12);

        string name13 = "@ithinksiriusknows0204";
        string content13 = "Taylor saved me, lately I had felt so alone and she, with just her songs, fixed my day and my life in general. Even though she doesn't know me, she always has a place in my heart.";
        Comment comment13 = new Comment(name13, content13);

        List<Comment> comments1 = new List<Comment> {
            comment11,
            comment12,
            comment13
        };

        Video video1 = new Video(title1, author1, lengthSeconds1, comments1);

        // For Video 2

        string title2 = "Nathan Evans - Heather On The Hill (Official Video)";
        string author2 = "NathanEvanss";
        int lengthSeconds2 = 139;

        // Comment 21 = Video 2 - Comment1 = Attribute21. And so on.
        string name21 = "@embracegrace4748";
        string content21 = "I just found this song and I've officially put it in my wedding next week.";
        Comment comment21 = new Comment(name21, content21);

        string name22 = "@aradaevyre361";
        string content22 = "Another song for me to play on repeat till everyone around me goes insane. I love that line \"under the Caledonia sky\"";
        Comment comment22 = new Comment(name22, content22);

        string name23 = "@gjcr6116";
        string content23 = "The only problem with this song is that it's too short! We want more please!!";
        Comment comment23 = new Comment(name23, content23);

        string name24 = "@Nightowl298";
        string content24 = "Nathan is in a league of his own wonderful amazing talent wish I can sing as well as he does";
        Comment comment24 = new Comment(name24, content24);

        List<Comment> comments2 = new List<Comment> {
            comment21,
            comment22,
            comment23,
            comment24
        };

        Video video2 = new Video(title2, author2, lengthSeconds2, comments2);

        // For Video 3

        string title3 = "Anne-Marie & James Arthur - Rewrite The Stars [from The Greatest Showman: Reimagined]";
        string author3 = "Anne-Marie";
        int lengthSeconds3 = 227;

        // Comment 31 = Video 3 - Comment1 = Attribute31. And so on.
        string name31 = "@Ruby_Magar";
        string content31 = "This song never gets old. It still gives me goosebumps.";
        Comment comment31 = new Comment(name31, content31);

        string name32 = "@thevibeguide";
        string content32 = "On repeat till the end of 2018 for sure!";
        Comment comment32 = new Comment(name32, content32);

        string name33 = "@user-yr4re2ns7s";
        string content33 = "This song is still amazing!! The way James said/sang Destiny just sounds different but amazing at the same time!! The way Anne just sings is incredible!! You two need to do more songs together you both sound so amazing together.";
        Comment comment33 = new Comment(name33, content33);

        List<Comment> comments3 = new List<Comment> {
            comment31,
            comment32,
            comment33
        };

        Video video3 = new Video(title3, author3, lengthSeconds3, comments3);
        
        List<Video> videos = new List<Video>{
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}