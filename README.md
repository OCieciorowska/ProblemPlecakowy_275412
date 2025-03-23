# ProblemPlecakowy_275412
Opis projektu:

Projekt Problem Plecakowy to  implementacja rozwiązania dla problemu plecakowego (Knapsack Problem). Program generuje losowe przedmioty o określonych wagach i wartościach, a następnie wybiera optymalne przedmioty do umieszczenia w plecaku o podanej pojemności, tak aby było to najbardziej opłacalne, w stosunku wartości do wagi. Także posiada testy sprawdzające poprawne działanie programu. 

Struktura projektu:

Projekt składa się z następujących plików:

ProgramPL.cs – Główny plik programu, obsługuje interakcję z użytkownikiem i steruje procesem rozwiązania problemu.

Problem.cs – Klasa odpowiedzialna za generowanie instancji problemu i znajdowanie rozwiązania.

Przedmiot.cs – Klasa reprezentująca pojedynczy przedmiot, zawierająca jego indeks, wagę i wartość.

Result.cs – Klasa przechowująca wynik rozwiązania problemu, czyli listę wybranych przedmiotów, ich łączną wartość oraz wagę.

ProjektPlecakowy.csproj – Pliki konfiguracyjny projektu .NET.

ProjektPlecakowy.sln – Plik rozwiązania Visual Studio.

Test1.cs – Plik zawierający testy jednostkowe dla klasy Problem.

MSTestSettings.cs – Plik konfiguracyjny testów jednostkowych.

Działanie programu

Użytkownik wprowadza seed dla generatora liczb losowych (zapewnia powtarzalność wyników). Następnie Użytkownik podaje liczbę przedmiotów, które zostaną wygenerowane oraz określa pojemność plecaka.
Program generuje losową listę przedmiotów, a algorytm wybiera optymalne przedmioty do plecaka według stosunku wartości do wagi. Wynik jest wyświetlany w konsoli – lista wybranych przedmiotów, ich suma wartości oraz waga.

Algorytm rozwiązania

Program używa algorytmu zachłannego, który działa w następujący sposób:

Sortuje przedmioty malejąco według stosunku wartości do wagi. Dodaje przedmioty do plecaka, dopóki nie przekroczy jego pojemności i zwraca listę wybranych przedmiotów oraz łączną wagę i wartość rozwiązania.

Przykład użycia

Wprowadz seed: 42
Wprowadz liczbe przedmiotow: 5
Wprowadz pojemnosc plecaka: 10

Lista przedmiotów:
[#1] Waga: 3, Wartość: 7
[#2] Waga: 5, Wartość: 8
[#3] Waga: 2, Wartość: 4
[#4] Waga: 6, Wartość: 10
[#5] Waga: 4, Wartość: 5

Wybrane przedmioty: 4, 1, 3
Łączna wartość: 21, Łączna waga: 10

Testy jednostkowe

Projekt zawiera testy jednostkowe napisane w MSTest, które sprawdzają poprawność działania algorytmu. Testy znajdują się w pliku Test1.cs i obejmują :

Test 1- Czy zwrócono co najmniej jeden element, gdy któryś pasuje?
Tworzymy nowy obiekt problem, który generuje 5 przedmiotów losowo - seed 42. Wywołujemy solve z 10 aby znaleźć najlepszy zestaw przedmiotów w plecaku o pojemności 10. sprawdzamy czy lista z wybranymi rzeczami nie jest pusta. Jeśli count==0, test nie przejdzie

Test 2- Czy zwrócono pusta listę jeśli żaden przedmiot nie pasuje?
Sprawdzamy przypadek gdy plecak nie mieści żadnych przedmiotów. Porównujemy count z 0. jeśli są jakieś przedmioty test nie przejdzie.

Test 3-Czy wynik jest poprawny dla konkretnej instancji
Tworzymy problem z tylko 1 przedmiotem. Sprawdzamy dla pojemności 10 i wartość powinna być większą od 0 bo przynajmniej jeden przedmiot powinien zmieścić się do plecaka

Test 4- Czy oryginalna lista przedmiotów nie została zmodyfikowana
Sprawdzamy czy metoda solve nie zmienia oryginalnej listy przedmiotów. Kopjujemy listę Przedmioty przed uruchomieniem Solve. Uruchamiamy metodę aby sprawdzić czy zmienia oryginalne dane. Porównujemy. Test nie przejdzie jeśli metoda zmodyfikowała dane.

Test 5- Czy metoda poprawnie obsługuje pusta listę 
Tworzymy problem bez żadnych przedmiotów. Uruchamiamy sole z pojemnością 10 i oczekujemy ze wynikowa lista będzie pusta

Test 6- Sprawdzamy czy generowane przedmioty maja poprawne wartości
Tworzymy nowy obiekt problem który generuje 10 przedmiotów i dajemy seed 42.  pętla forach przechodzi przez wszystkie przedmioty, elementy listy Problem.Items. Sprawdzamy czy waga przedmiotu jest większą od 0 i czy wartość jest większą od 0. 




Autor

Twórca projektu: Aleksandra Cieciorowska 275412
