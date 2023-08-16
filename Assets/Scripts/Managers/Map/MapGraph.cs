using QuickGraph;

namespace Managers.Map
{
    public class MapNode
    {
        public MapNode(string name, float x, float y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }
    
        public string name;
        public float x;
        public float y;
    }

    public class MapGraph
    {
        public static AdjacencyGraph<MapNode,Edge<MapNode>> Generate()
        {
            AdjacencyGraph<MapNode, Edge<MapNode>> map = new AdjacencyGraph<MapNode, Edge<MapNode>>();
            var monster1 = new MapNode("monster 1", -455, 0f);
            var monster2 = new MapNode("monster 2", 0, 0);
            var monster3 = new MapNode("monster 3", 455, 0);
        
        
            map.AddVertex(monster1);
            map.AddVertex(monster2);
            map.AddVertex(monster3);
        
            Edge<MapNode> monster12 = new Edge<MapNode>(monster1, monster2);
            Edge<MapNode> monster13 = new Edge<MapNode>(monster1, monster3);

            map.AddEdge(monster12);
            map.AddEdge(monster13);
        
            return map;
        }
    }
}