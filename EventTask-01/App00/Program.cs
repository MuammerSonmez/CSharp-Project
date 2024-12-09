namespace App00
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Yazar author1 = new Yazar("Orhan Pamuk");
            Yazar author2 = new Yazar("Elif Şafak");

            Takipci follower1 = new Takipci("Muammer");
            Takipci follower2 = new Takipci("Sudenaz");


            author1.BookPublished += follower1.Notify; 
            author1.BookPublished += follower2.Notify; 
            author2.BookPublished += follower2.Notify;

            follower1.Follow(author1);
            follower2.Follow(author2);

            author1.PublishBook("Masumiyet Müzesi");
            author2.PublishBook("Aşk");
        }
    }
}
