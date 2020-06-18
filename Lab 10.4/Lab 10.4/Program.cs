using System;

namespace Lab_10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing Artist Class
            Artist prince = new Artist("Prince");
            prince.AddToPlaylist("Purple Rain");
            prince.AddToPlaylist("Little Red Corvette");
            prince.AddToPlaylist("Kiss");
            prince.AddToPlaylist("When Doves Cry");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(prince);

            // Testing AudioBook Class
            AudioBook howto = new AudioBook("How to Win Friends & Influence People", "Dale Carnegie");
            player.PlayMedia(howto);

            // Testing MovieSoundTrack Class
            MovieSoundTrack starWars = new MovieSoundTrack("Star Wars");
            starWars.SelectTrack("Opening Credits Theme");
            player.PlayMedia(starWars);
        }
    }
}
