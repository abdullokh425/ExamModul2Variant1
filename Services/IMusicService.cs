using ExamModul2.Services.Extesions;
using ExamModul2.Services.DTOs;

namespace ExamModul2.Services;

public interface IMusicService
{
    List<MusicDto> GetAllMusicByAuthorName(string name);
    int GetMostLikedMusic();
    MusicDto GetMusicByName(string name);
    List<MusicDto> GetAllMusicAboveSize(double minSize);
    List<MusicDto> GetTopMostLikedMusic(int count);
    List<MusicDto> GetMusicByDescibtionKeyword(int count);
    List<MusicDto> GetMusicWithLikesInRange(int minLikes, int maxLikes);
    List<string> GetAllUniqueAuthors();
    double GetTotalMusicSizeByAuthor(string authorName);
}