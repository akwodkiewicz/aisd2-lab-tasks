using System;
using System.Collections.Generic;
using System.Linq;
using Point = ASD.Geometry.Point;
using Segment = ASD.Geometry.Segment;
namespace ASD
{
    class Lab12
    {

        /// <summary>
        /// Znajduje otoczkę wypukłą dla punktów.
        /// Można zastosować dowolny algorytm liczenia otoczki omówiony na wykłądzie
        /// </summary>
        /// <param name="points">Tablica punktów</param>
        /// <returns>Tablica kolejnych punktów należących do otoczki</returns>
        public static Point[] ConvexHull(Point[] p)
        {
            return new Point[0];
        }

        /// <summary>
        /// Znajduje maksymalna odległość między punktami w tablicy points.
        /// (2pkt, w tym otoczka)
        /// </summary>
        /// <remarks>
        /// Odległość należy znaleźć wykorzystując otoczkę wypukłą.
        /// Tzn. Najpierw dla points znaleźć otoczkę, a potem wyszukiwać pary wierzchołków sposród tych znajdujących się na otoczce.
        /// </remarks>
        /// <param name="points">zbiór punktów</param>
        /// <param name="result">Tablica 2 punktów zawierające punkty najbardziej odległe</param>
        /// <returns>Wartość maksymalnej odległości w zbiorze</returns>
        public static double MaxDiameter(Point[] points, out Point[] result)
        {
            result = new Point[2];
            return 0.0;
        }

        /// <summary>
        /// Dla podanych współrzędnych ołtarza i murów metoda zwraca informację czy istnieje półprosta o początku 
        /// w ołtarzu nie przecinająca żadnego muru.
        /// (2pkt)
        /// </summary>
        /// <remarks>
        /// Nie należy liczyć bezpośrednio żadnych kątów (funkcje trygonometryczne liczą się powoli)
        /// Można zastosować następujący algorytm
        ///
        ///    A) przygotowanie danych
        ///    Na podstawie tablicy murów (odcinków) utworzyć tablicę punktów (końców odcinków).
        ///    Utworzyć też Dictionary indeksowane punktami i wypełnione wartościami +1 dla "wcześniejszego końca odcinka" i -1 dla "późniejszego końca odcinka".
        ///    "Wcześniejszy koniec odcinka" to koniec, dla którego prosta przechodząca przez ten koniec tworzy mniejszy kąt z osia OX
        ///    niż analogiczna prosta przechodząca przez drugi koniec (ten drugi koniec to "póżniejszy koniec"). Oczywiście nie liczymy bezpośrednio żadnych kątów !!!.
        ///    Policzyć ile murów (odcinków) przecina się z półprostą (długim odcinkiem) zaczepioną w ołtarzu i równoległą do osi OX
        ///
        ///    B) posortować tablicę punktów (końców odcinków) według kąta jaki tworzą odcinki o początku w ołtarzu i końcu w danym punkcie z osią OX
        ///       (skorzystać z biblioteki geom.cs)
        ///
        ///    C) obliczenia
        ///    przetwarzać punkty w kolejności wynikającej z posortowania w czesci B
        ///    dla każdego z punktów zmniejszać bądź zwiekszać licznik przecięć (odbiczony w części A) zależnie od tego czy punkt jest wcześniejszym czy późniejszym końcem odcinka
        ///    (korzystać z przygotowanego Dictionary). Zastanowić się co oznacza wartość licznika równa 0.
        ///
        ///    Uwaga: Nie przejmować się przypadkami szczególnymi (np. ołtarz i końce dwóch murów leżące na jednej prostej) w testach ich nie będzie.
        /// </remarks>
        /// <param name="altar"> Współrzędne ołtarza</param>
        /// <param name="walls">zbiór murów (odcinków)</param>
        /// <returns>true jeśli nie istnieje prosta nieprzecinająca muru, false jeśli taka prosta istnieje</returns>
        public static bool ChineeseAltars(Point altar, Segment[] walls)
            {
            return false;
            }

    }
}
