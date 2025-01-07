using System.Security;
using ExamModul2.DataAccess.Entities;
using ExamModul2.Repositories;
using ExamModul2.Services.Extesions;
using ExamModul2.Services.DTOs;

namespace ExamModul2.Services;

public class MusicService : IMusicService
{
    public List<MusicDto> GetAllMusicByAuthorName(string name)
    {
        var musics = new List<MusicDto>();
        var musicsWithAuthor = new List<MusicDto>();

        foreach (var music in musics)
        {
            if (music.AuthorName == name)
            {
                musicsWithAuthor.Add(music);
            }
        }
        
        return musicsWithAuthor;
    }

    public int GetMostLikedMusic()
    {
        var musics = new List<MusicDto>();
        var mostLikedMusic = Int32.MinValue;

        foreach (var music in musics)
        {
            if (music.QuentityLikes > mostLikedMusic)
            {
                mostLikedMusic = music.QuentityLikes;
            }
        }
        
        return mostLikedMusic;
    }

    public MusicDto GetMusicByName(string name)
    {
        var musics = new List<MusicDto>();

        foreach (var music in musics)
        {
            if (music.Name == name)
            {
                return music;
            }
        }
        
        throw new VerificationException("Music does not exist");
    }

    public List<MusicDto> GetAllMusicAboveSize(double minSize)
    {
        var musics = new List<MusicDto>();
        var musicsAboveSize = new List<MusicDto>();

        foreach (var music in musics)
        {
            if (music.MB > minSize)
            {
                musicsAboveSize.Add(music);
            }
        }
        
        return musicsAboveSize;
    }

    // public List<MusicDto> GetTopMostLikedMusic(int count)
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public List<MusicDto> GetMusicByDescibtionKeyword(int count)
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public List<MusicDto> GetMusicWithLikesInRange(int minLikes, int maxLikes)
    // {
    //     throw new NotImplementedException();
    // }
    //
    // public List<string> GetAllUniqueAuthors()
    // {
    //     throw new NotImplementedException();
    // }

    public double GetTotalMusicSizeByAuthor(string authorName)
    {
        var musics = new List<MusicDto>();
        double sum = 0;

        foreach (var music in musics)
        {
            if (music.AuthorName == authorName)
            {
                sum += music.MB;
            }
        }
        
        return sum;
    }

    private Music ConvertToEntity(MusicDto musicDto)
    {
        return new Music
        {
            Id = Guid.NewGuid(),
            Name = musicDto.Name,
            MB = musicDto.MB,
            AuthorName = musicDto.AuthorName,
            Describtion = musicDto.Describtion,
            QuentityLikes = musicDto.QuentityLikes,
        };
    }

    private Music ConvertToDto(MusicDto musicDto)
    {
        return new Music
        {
            Id = Guid.NewGuid(),
            Name = musicDto.Name,
            MB = musicDto.MB,
            AuthorName = musicDto.AuthorName,
            Describtion = musicDto.Describtion,
            QuentityLikes = musicDto.QuentityLikes,
        };
    }

    // private Music MyConverter<T>(T musicDto)
    // {
    //     
    // }
    
    
}