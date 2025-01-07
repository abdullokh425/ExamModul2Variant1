using ExamModul2.DataAccess.Entities;

namespace ExamModul2.Repositories;

public interface IMusicRepository
{
    public Guid GetMusicById(Guid musicId);
    public void UpdateMusic(Music music);
    public void DeleteMusic(Music music);
    public List<Music> GetMusics();
}