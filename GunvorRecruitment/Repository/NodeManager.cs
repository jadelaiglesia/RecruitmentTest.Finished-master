namespace GunvorRecruitment.Repository
{
    public class NodeManager
    {
        private readonly IRepository _nodeRepository;

        public NodeManager(IRepository nodeRepository)
        {
            _nodeRepository = nodeRepository;
        }

        public Node GetNodeAndImmediateChildren(string name)
        {
            return _nodeRepository.GetNodeAndImmediateChildren(name);
        }
    }
}
