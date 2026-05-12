# MedStation - system zarzadania dla szpitali

Projekt **MedStation** jest aplikacją desktopową w systemie Avalonia c#
Projekt ma spełniać trzy funkcje: 

1. **Dla adminstratorów** Pozwalający na dodawanie usuwanie i aktualizowanie danych pracowników.

2. **Dla pracowników** Pozwala sprawdzic lekarzowi historie leczenia jego pacjentów to czy wykorzystali swoje recepty lub czy maja umówioną wizyte.Pracownik jest w stanie równierz zobaczyc swój grafik na dany miesiąc.

3. **Dla pacjętów** Ładny i estetyczny, panel do sprawdzania przyszłych wizyt, pozwala również sprawdzic historie leczenia oraz wykorzystac recepty.

---

## Technologie i narzędzia
* **Język:** C#
* **Interfejs:** AXAML + Data Binding (MVVM)
* **Baza Danych:** supabase

---

## Wymagania Projektowe
1. **Panel admina**
     * Lista z wszystkimi pracownikami `imie, nazwisko, specjalizacja` (możliwość zmiany listy na wyswietlanie na pacjętów).
     * po wybraniu danej osoby wyswietlają sie dodatkowe informacje np. ilość pacjentów którą prowadzi, ilość wypisanych recept.
     * Panel wyswietlajacy pracownika umożliwa:
         - Dodanie nowego pracownika(przenosi do nowego okna w ktoórym wpisujemy dane).
         - Edytowanie danych pracownika(tylko po wybraniu, przenosi do tego samego panelu co dodawanie).
         - Usuwanie pracownika(po usunieciu w liscie z pacjętami dodaje sie adnotacja `brak lekarza!!` admistrator może albo przenieść go do innego lekarza o potrzebnej specjalizacji albo wysłać informacje o zwolnieniu usunięcie go z listy "przeniesinie go do innego szpitala".

2.**Panel Pracownika**
  * Lista z wszystkimi pacjętami `imie, nazwisko`
  * Po wybraniu pacjęta pojawia się wiecej informacji np. historia leczenia, data ostatniej, wizyty przyszła wizyta.
  * Pozwala zobaczyc czy pacjęt zrealizował ostatnia recepte. 
  * Graficzne ukazanie grafiku kalendarz z przyszłymi wizytami pacjętów.
  * Możliwość zakonczenia leczenia.
    
3.**Panel Pacjęta** 
  * Pełna historai leczenia u wszystkich lekarzy.
  * Wyświetla wszystkie zaplanowane wiytyt.
  * wyswietla nizrealizowane recepty, pozwala je zrealizowac co przenosi je do histori recept.

---



    
     
   
