using System;

using GunvorRecruitment.Repository;

namespace GunvorRecruitment.Test.Repository
{
    public class FakeRepository : IRepository
    {
        /// <summary>
        /// YOU MUST NOT CHANGE THIS METHOD
        /// </summary>
        public Node GetNodeAndImmediateChildren(string nodeName)
        {
            switch (nodeName)
            {
                case "Node A":
                    // do not modify this
                    var nodeB = new Node { Name = "Node B" };
                    var nodeC = new Node { Name = "Node C" };
                    return new Node { Name = "Node A", ImmediateChildren = new[] { nodeB, nodeC } };
                case "Node B":
                    // do not modify this
                    var nodeD = new Node { Name = "Node D" };
                    var nodeE = new Node { Name = "Node E" };
                    return new Node { Name = "Node B", ImmediateChildren = new[] { nodeD, nodeE } };
                case "Node E":
                    var nodeA = new Node { Name = "Node A" };
                    var nodeF = new Node { Name = "Node F" };
                    return new Node { Name = "Node E", ImmediateChildren = new[] { nodeA, nodeF } };
                default:
                    throw new ApplicationException("Unknown node");
            }
        }
    }
}
