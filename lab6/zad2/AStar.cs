
namespace ASD.Graph
{

/// <summary>
/// Rozszerzenie interfejsu <see cref="IGraph"/> o algorytm A*
/// </summary>
public static class AStarLabGraphExtender
    {

    /// <summary>
    /// Wyznacza najkrótszą ścieżkę do wskazanego wierzchołka algorytmem A*
    /// </summary>
    /// <param name="g">Badany graf</param>
    /// <param name="s">Wierzchołek źródłowy</param>
    /// <param name="t">Wierzchołek docelowy</param>
    /// <param name="p">Znaleziona ścieżka (parametr wyjściowy)</param>
    /// <param name="h">Oszacowanie odległości wierzchołków (funkcja)</param>
    /// <returns>Długość ścieżki (jeśli nie istnieje to null)</returns>
    /// <remarks>
    /// Domyślna wartość parametru <i>h</i> (<b>null</b>) oznacza, że zostanie przyjęte oszacowanie zerowe.
    /// Algorytm A* sprowadza się wówczas do algorytmu Dijkstry.<br/>
    /// <br/>
    /// Metoda nie bada spełnienia założeń algorytmu A* - jeśli nie one są spełnione może zwrócić błędny wynik (nieoptymalną ścieżkę).<br/>
    /// Informacja, czy szukana ścieżka istnieje, zawsze jest zwracana poprawnie.
    /// Jeśli ścieżka nie istnieje (wynik <b>null</b>), to parametr <i>p</i> również jest równy <b>null</b>.
    /// </remarks>
    public static int? AStar(this IGraph g, int s, int t, out Edge[] p, System.Collections.Generic.Dictionary<int,string> description, System.Func<int,int,int> h=null)
        {
        var open = new PriorityQueue<int,int>((x,y) => x<y,Graph.Access);
        var close = new System.Collections.Generic.HashSet<int>();  // dodać referencję system.dll
        var dist = new HashTable<int,int>(Graph.Access);
        var last = new HashTable<int,Edge>(Graph.Access);
        if ( h==null )
            h = (x,y)=>0 ;

        p=null;
        //
        //  TO DO 
        //
        return null;
        }
 
    }  // class AStarGraphExtender

}  // namespace ASD.Graph
