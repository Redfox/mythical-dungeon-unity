using UnityEngine;

namespace Managers.Map
{
    public class MapManager : MonoBehaviour
    {
        [SerializeField] public GameObject monster;
        [SerializeField] public GameObject canvas;
    
        void Start()
        {
            var lol = MapGraph.Generate();
        
            foreach (var vertice in lol.Vertices)
            {
                GameObject mapObject = Instantiate(monster, new Vector2(vertice.x, vertice.y), Quaternion.identity);
                mapObject.GetComponent<MapPhase>().phaseName = vertice.name;
                mapObject.transform.SetParent(canvas.transform, false);
            
                foreach (var edge in lol.OutEdges(vertice))
                {
                    // Debug.Log(edge.Source.name + " -> " + edge.Target.name);
                }
            }
        }
    }
}
