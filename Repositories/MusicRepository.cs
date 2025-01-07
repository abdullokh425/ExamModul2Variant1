using ExamModul2.DataAccess.Entities;
using System.Text.Json;
using ExamModul2.Services.DTOs;

namespace ExamModul2.Repositories;

public class MusicRepository : IMusicRepository
{
    private readonly string _path;
    private List<Music> _musics;

    public MusicRepository()
    {
        _path = "DataAccess/Data/Music.json";
        _musics = new List<Music>();

        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }

        _musics = GetMusics();
    }

    public List<Music> GetMusics()
    {
        var getMusics = JsonSerializer.Deserialize<List<Music>>(File.ReadAllText(_path));
        return getMusics;
    }

    public void UpdateMusic(Music music)
    {
        var updateMusic = GetMusicById(music.Id);
        if (updateMusic is null)
        {
            throw new NullReferenceException();
        }
        
        var index = _musics.IndexOf(updateMusic);
        _musics[index] = music;
        SaveData();
    }



    public void DeleteMusic(Music music)
    {
        _musics.Remove(music);
        SaveData();
    }

    public Guid GetMusicById(Guid musicId)
    {
        var musics = _musics;

        foreach (var music in musics)
        {
            if (music.Id == musicId)
            {
                return musicId;
            }
        }

        return musicId;
    }
    

    private void SaveData()
    {
        var musicJson = JsonSerializer.Serialize(_musics);
        File.WriteAllText(_path, musicJson);
    }
}