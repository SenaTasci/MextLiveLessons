// See https://aka.ms/new-console-template for more information
using Spovify.Domain;
using Spovify.Domain.Modals;
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

var artist = new Person()
{
    Id = Guid.NewGuid(),
    Name = "Adele",
    Surname = "Adkins",
    Nick = "Adele"
};

var producer = new Person()
{
    Id = Guid.NewGuid(),
    Name = "Greg",
    Surname = "Kurstin",
    Nick = "Greg"
};

var song = new Song
{
    Id = Guid.NewGuid(),
    Name = "Set Fire to the Rain",
    Artist = artist,
    Producer = producer,
    Lyricist = artist
};


var songService = new SongService();

songService.AddSong(song);

var songsfromtext = songService.GetSongs();

foreach (var songfromtext in songsfromtext)
{ 
    Console.WriteLine($"{songfromtext.Name} - {songfromtext.Artist.Name}");
}

  Console.WriteLine();





