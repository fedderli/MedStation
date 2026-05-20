# MedStation - system zarzadania dla szpitali

Projekt **MedStation** jest aplikacją desktopową w systemie Avalonia c#
Projekt ma spełniać trzy funkcje: 

1. **Dla adminstratorów** Pozwalający na dodawanie usuwanie i aktualizowanie danych pracowników.

2. **Dla pracowników** Pozwala sprawdzic lekarzowi historie leczenia jego pacjentów to czy wykorzystali swoje recepty lub czy maja umówioną wizyte. Pracownik jest w stanie również zobaczyc swój grafik na dany miesiąc.

3. **Dla pacjentów** Ładny i estetyczny, panel do sprawdzania przyszłych wizyt, pozwala również sprawdzic historie leczenia oraz wykorzystac recepty.

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
  * Lista z wszystkimi pacjentami `imie, nazwisko`
  * Po wybraniu pacjenta pojawia się wiecej informacji np. historia leczenia, data ostatniej wizyty, przyszła wizyta.
  * Pozwala zobaczyc czy pacjent zrealizował ostatnia recepte. 
  * Graficzne ukazanie grafiku kalendarz z przyszłymi wizytami pacjentów.
  * Możliwość zakonczenia leczenia.
    
3.**Panel Pacjenta** 
  * Pełna historai leczenia u wszystkich lekarzy.
  * Wyświetla wszystkie zaplanowane wiytyt.
  * wyswietla nizrealizowane recepty, pozwala je zrealizowac co przenosi je do histori recept.

---
## Baza danych

### 1. Kolekcja: `Pracownicy`
| Pole | Typ | Opis | Przykład |
| :--- | :--- | :--- | :--- |
| `Id` | **String** | Id Pracownika. | `"LE_7234012"` |
| `Imie` | **String** | Imie Pracownika. | `"Gregory"` |
| `Nazwisko` | **String** | Nazwisko Pracownika. | `"House"` |
| `Specjalizacje` | **Array** | Lista specjalizacji Lekarza. | `["Nefrolog", "Diagnosta"]` |
| `Zarobek` | **Int** | Płaca pracownika w złotówkach. | `10000` |
| `Pacjeci` | **Array** | Lista aktualncyh pacjętów. | `["Rebecca Adler", "Amber Volakis"]` |

### 2. Kolekcja: `Pacjenci`
| Pole | Typ | Opis | Przykład |
| :--- | :--- | :--- | :--- |
| `Id` | **String** | Id Pacjęta. | `"PA_3451234"` |
| `Imie` | **String** | Imie Pacjęta. | `"Kamil"` |
| `Nazwisko` | **String** | Nazwisko Pacjęta. | `"Wiśniewski"` |
| `Recepty` | **Array** | Lista Recept. | `["RE_43242", "RE_12839"]` |
| `Wizyty` | **Array** | Lista Wizyt. | `["WZ_34612", "WZ_34612"]` |


### 3. Kolekcja: `Wizyty`
| Pole | Typ | Opis | Przykład |
| :--- | :--- | :--- | :--- |
| `Id` | **String** | Id Wizyty. | `"WZ_34612"` |
| `Id_Lekarza` | **String** | Id Pracownika. | `"LE_7234012"` |
| `Id_Pacjenta` | **String** | Id Pacjenta. | `"PA_3451234"` |
| `Data_Wizyty` | **String** | Data wizyty. | `21.07.2026` |
| `Powód_Wizyty` | **String** | Powód wizyty. | `"Ból prawgo uda"` |
| `Czy_Zrealizowano` | **Bool** | Czy zrealizowano Wizyte. | `False` |

### 4. Kolekcja: `Recepty`
| Pole | Typ | Opis | Przykład |
| :--- | :--- | :--- | :--- |
| `Id` | **String** | Id Wizyty. | `"RE_43242"` |
| `Id_Lekarza` | **Int** | Id Pracownika. | `"LE_7234012"` |
| `Id_Pacjenta` | **Int** | Id Pacjenta. | `"PA_3451234"` |
| `Data_Wydania` | **String** | Data wydania recepty. | `"21.07.2026"` |
| `Data_Wygasniecia` | **String** |  Data wygasnięcia recepty. | `"28.07.2026"` |
| `Lek` | **String** |  Nazwa przepisanego leku | `"Vicodin"` |
| `Dawkowanie` | **String** |  Nazwa przepisanego leku | `"1 tabletka do posiłku rano i wieczorem"` |
| `Czy_Zrealizowano` | **Bool** | Czy zrealizowano recepte. | `True` |



    
     
   
