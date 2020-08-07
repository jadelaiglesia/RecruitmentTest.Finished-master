namespace GunvorRecruitment.Repository
{
    public interface IRepository
    {
        Node GetNodeAndImmediateChildren(string nodeName);
    }
}
