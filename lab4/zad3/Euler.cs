
namespace ASD.Graph
{
using System.Linq;  // potrzebne dla metody First rozszerzającej interfejs IEnumerable

/// <summary>
/// Rozszerzenie interfejsu <see cref="IGraph"/> o wyszukiwanie ścieżki Eulera
/// </summary>
public static class EulerPathGraphExtender
    {

    /// <summary>
    /// Znajduje scieżkę Eulera w grafie
    /// </summary>
    /// <param name="g">Badany graf</param>
    /// <param name="ec">Znaleziona ścieżka (parametr wyjściowy)</param>
    /// <returns>Informacja czy ścieżka Eulera istnieje</returns>
    /// <remarks>
    /// Jeśli w badanym grafie nie istnieje ścieżka Eulera metoda zwraca <b>false</b>, parametr <i>ec</i> ma wówczas wartość <b>null</b>.<br/>
    /// <br/>
    /// Metoda nie modyfikuje badanego grafu.<br/>
    /// <br/>
    /// Metoda implementuje algorytm Fleury'ego.
    /// </remarks>
    public static bool Lab04_Euler(this IGraph g, out Edge[] ec)
        {
        // tylko cykl     - 2 pkt
        // cykl i sciezka - 3 pkt

        /*
        Algorytm Fleury'ego

        utworz pusty stos krawedzi Euler
        utworz pusty stos krawedzi pom
        w = dowolny wierzcholek grafu
        umiesc na stosie pom sztuczna krawedz <w,w>
        dopoki pom jest niepusty powtarzaj
            w = wierzch. koncowy krawedzi ze szczytu stosu pom (bez pobierania krawedzi ze stosu)
            jesli stopien wychodzacy w > 0 
                e = dowolna krawedz wychodzaca z w
                umiesc krawedz e na stosie pom      
                usun krawedz e z grafu
            w przeciwnym przypadku
                pobiez szczytowy element ze stosu pom i umiesc go na stosie Euler
        usun ze stosu Euler sztuczna krawedz (petle) startowa (jest na szczycie)

        wynik: krawedzie tworzace cykl sa na stosie Euler
        
        Uwaga: powyzszy algorytm znajduje cykl Eulera (jesli istnieje),
               aby znalezc sciezke nalezy najpierw wyznaczyc wierzcholek startowy
               (nie mozna wystartowac z dowolnego)
        */

        ec=null;
        return false;
        }

    }  // class EulerGraphExtender

}  // namespace ASD.Graph
