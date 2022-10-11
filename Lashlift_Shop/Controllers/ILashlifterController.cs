namespace Lashlift_Shop.Controllers
{
    public interface ILashlifterController
    {
        void CreateLashlifter();
        void DeleteLashlifter();
        void ReadAllLashlifters();
        void ReadLashliftersWithGirls();
        void ReadRichLashlifters();
        void UpdateLashlifter();
    }
}